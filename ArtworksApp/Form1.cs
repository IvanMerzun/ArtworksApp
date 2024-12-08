using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArtworksApp
{
    public partial class Form1 : Form
    {
        private List<Artwork> artworks = new List<Artwork>();

        public Form1()
        {
            InitializeComponent();
            comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            buttonAdd.Click += ButtonAdd_Click;
            buttonAddtoXML.Click += (sender, e) => AddToXml("artworks.xml");

            // Добавление начальных данных
            artworks.Add(new Painting
            {
                Title = "Starry Night",
                Author = "Van Gogh",
                Price = 1000000m,
                Year = 1889,
                Material = "Canvas"
            });

            artworks.Add(new Book
            {
                Title = "War and Peace",
                Author = "Leo Tolstoy",
                Price = 20.99m,
                Year = 1869,
                Pages = 1225,
                Circulation = 500000
            });

            UpdateArtworkList();
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isPainting = comboBoxType.SelectedItem?.ToString() == "Painting";
            textBoxMaterial.Visible = labelMaterial.Visible = isPainting;

            bool isBook = comboBoxType.SelectedItem?.ToString() == "Book";
            textBoxPages.Visible = labelPages.Visible = isBook;
            textBoxCirculation.Visible = labelCirculation.Visible = isBook;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxYear.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (artworks.Any(a => a.Title == textBoxTitle.Text &&
                                  a.Author == textBoxAuthor.Text &&
                                  a.GetType().Name == comboBoxType.SelectedItem?.ToString()))
            {
                MessageBox.Show("This artwork already exists.");
                return;
            }

            try
            {
                Artwork newArtwork = null;
                if (comboBoxType.SelectedItem?.ToString() == "Painting")
                {
                    newArtwork = new Painting
                    {
                        Title = textBoxTitle.Text,
                        Author = textBoxAuthor.Text,
                        Price = decimal.Parse(textBoxPrice.Text),
                        Year = int.Parse(textBoxYear.Text),
                        Material = textBoxMaterial.Text
                    };
                }
                else if (comboBoxType.SelectedItem?.ToString() == "Book")
                {
                    newArtwork = new Book
                    {
                        Title = textBoxTitle.Text,
                        Author = textBoxAuthor.Text,
                        Price = decimal.Parse(textBoxPrice.Text),
                        Year = int.Parse(textBoxYear.Text),
                        Pages = int.Parse(textBoxPages.Text),
                        Circulation = int.Parse(textBoxCirculation.Text)
                    };
                }

                if (newArtwork != null)
                {
                    artworks.Add(newArtwork);
                    UpdateArtworkList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding artwork: {ex.Message}");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.ToLower();
            var results = artworks
                .Where(a => a.Author.ToLower().Contains(query) || a.Title.ToLower().Contains(query))
                .OrderBy(a => a.Price)
                .ToList();

            dataGridViewArtworks.Rows.Clear(); // Очищаем таблицу

            foreach (var artwork in results)
            {
                if (artwork is Painting painting)
                {
                    dataGridViewArtworks.Rows.Add(painting.Title, painting.Author, painting.Price, painting.Year, "Painting", $"Material: {painting.Material}");
                }
                else if (artwork is Book book)
                {
                    dataGridViewArtworks.Rows.Add(book.Title, book.Author, book.Price, book.Year, "Book", $"Pages: {book.Pages}, Circulation: {book.Circulation}");
                }
            }
        }

        private void UpdateArtworkList()
        {
            dataGridViewArtworks.Rows.Clear(); // Очищаем таблицу

            foreach (var artwork in artworks.OrderBy(a => a.Price))
            {
                // Заполняем строку таблицы
                if (artwork is Painting painting)
                {
                    dataGridViewArtworks.Rows.Add(painting.Title, painting.Author, painting.Price, painting.Year, "Painting", $"Material: {painting.Material}");
                }
                else if (artwork is Book book)
                {
                    dataGridViewArtworks.Rows.Add(book.Title, book.Author, book.Price, book.Year, "Book", $"Pages: {book.Pages}, Circulation: {book.Circulation}");
                }
            }
        }

        private void AddToXml(string filePath)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, filePath); // Автоматически создается в папке приложения

                XElement xml = new XElement("Artworks");

                foreach (DataGridViewRow row in dataGridViewArtworks.Rows)
                {
                    if (row.IsNewRow) continue;

                    string type = row.Cells["Type"].Value?.ToString();
                    if (type == "Painting")
                    {
                        xml.Add(new XElement("Painting",
                            new XElement("Title", row.Cells["Title"].Value?.ToString()),
                            new XElement("Author", row.Cells["Author"].Value?.ToString()),
                            new XElement("Price", row.Cells["Price"].Value?.ToString()),
                            new XElement("Year", row.Cells["Year"].Value?.ToString()),
                            new XElement("Material", row.Cells["Extra"].Value?.ToString().Replace("Material: ", ""))
                        ));
                    }
                    else if (type == "Book")
                    {
                        string[] extraInfo = row.Cells["Extra"].Value?.ToString().Split(',');
                        string pages = extraInfo[0].Replace("Pages: ", "").Trim();
                        string circulation = extraInfo[1].Replace("Circulation: ", "").Trim();

                        xml.Add(new XElement("Book",
                            new XElement("Title", row.Cells["Title"].Value?.ToString()),
                            new XElement("Author", row.Cells["Author"].Value?.ToString()),
                            new XElement("Price", row.Cells["Price"].Value?.ToString()),
                            new XElement("Year", row.Cells["Year"].Value?.ToString()),
                            new XElement("Pages", pages),
                            new XElement("Circulation", circulation)
                        ));
                    }
                }

                xml.Save(path); // Сохраняем файл в папке приложения
                MessageBox.Show($"Data successfully saved to {path}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to XML: {ex.Message}");
            }
        }

    }
}
