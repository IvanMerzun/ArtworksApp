namespace ArtworksApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxCirculation;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddtoXML;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewArtworks;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelCirculation;

        private void InitializeComponent()
        {
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxCirculation = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddtoXML = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewArtworks = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelCirculation = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();


            // 
            // buttonAddtoXML
            // 
            this.buttonAddtoXML.Location = new System.Drawing.Point(240, 570);
            this.buttonAddtoXML.Name = "buttonAddtoXML";
            this.buttonAddtoXML.Size = new System.Drawing.Size(100, 30);
            this.buttonAddtoXML.TabIndex = 11;
            this.buttonAddtoXML.Text = "Add to XML";
            this.buttonAddtoXML.UseVisualStyleBackColor = true;




            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Items.AddRange(new object[] { "Painting", "Book" });
            this.comboBoxType.Location = new System.Drawing.Point(20, 20);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(200, 23);
            this.comboBoxType.TabIndex = 0;

            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(20, 70);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 23);
            this.textBoxTitle.TabIndex = 1;

            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(20, 120);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(200, 23);
            this.textBoxAuthor.TabIndex = 2;

            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(20, 170);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 23);
            this.textBoxPrice.TabIndex = 3;

            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(20, 220);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 23);
            this.textBoxYear.TabIndex = 4;

            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(20, 270);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(200, 23);
            this.textBoxMaterial.TabIndex = 5;
            this.textBoxMaterial.Visible = false;

            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(20, 320);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(200, 23);
            this.textBoxPages.TabIndex = 6;
            this.textBoxPages.Visible = false;

            // 
            // textBoxCirculation
            // 
            this.textBoxCirculation.Location = new System.Drawing.Point(20, 370);
            this.textBoxCirculation.Name = "textBoxCirculation";
            this.textBoxCirculation.Size = new System.Drawing.Size(200, 23);
            this.textBoxCirculation.TabIndex = 7;
            this.textBoxCirculation.Visible = false;

            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 420);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 30);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add Artwork";
            this.buttonAdd.UseVisualStyleBackColor = true;

            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(240, 530);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(500, 23);
            this.textBoxSearch.TabIndex = 10;

            // 
            // dataGridViewArtworks
            // 
            this.dataGridViewArtworks.Location = new System.Drawing.Point(240, 20);
            this.dataGridViewArtworks.Size = new System.Drawing.Size(1300, 500);
            this.dataGridViewArtworks.AllowUserToAddRows = false;
            this.dataGridViewArtworks.AllowUserToDeleteRows = false;
            this.dataGridViewArtworks.ReadOnly = true;
            this.dataGridViewArtworks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArtworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Controls.Add(this.dataGridViewArtworks);

            // Настройка колонок
            this.dataGridViewArtworks.Columns.Add("Title", "Title");
            this.dataGridViewArtworks.Columns.Add("Author", "Author");
            this.dataGridViewArtworks.Columns.Add("Price", "Price ($)");
            this.dataGridViewArtworks.Columns.Add("Year", "Year");
            this.dataGridViewArtworks.Columns.Add("Type", "Type");
            this.dataGridViewArtworks.Columns.Add("Extra", "Extra Info");

            // 
            // Labels
            // 
            this.labelTitle.Location = new System.Drawing.Point(20, 50);
            this.labelTitle.Text = "Title:";
            this.labelAuthor.Location = new System.Drawing.Point(20, 100);
            this.labelAuthor.Text = "Author:";
            this.labelPrice.Location = new System.Drawing.Point(20, 150);
            this.labelPrice.Text = "Price:";
            this.labelYear.Location = new System.Drawing.Point(20, 200);
            this.labelYear.Text = "Year:";
            this.labelMaterial.Location = new System.Drawing.Point(20, 250);
            this.labelMaterial.Text = "Material:";
            this.labelPages.Location = new System.Drawing.Point(20, 300);
            this.labelPages.Text = "Pages:";
            this.labelCirculation.Location = new System.Drawing.Point(20, 350);
            this.labelCirculation.Text = "Circulation:";
            this.labelMaterial.Visible = false;
            this.labelPages.Visible = false;
            this.labelCirculation.Visible = false;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.textBoxCirculation);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelCirculation);
            this.Controls.Add(this.buttonAddtoXML);
            
            this.Name = "MainForm";
            this.Text = "Artworks Manager";
        }

    }
}

