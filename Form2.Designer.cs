namespace ArtCrafter.MasterofCollections
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            quitBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            hemBtn = new Button();
            pictureBox1 = new PictureBox();
            txtItemName = new TextBox();
            purchasePriceTextBox = new TextBox();
            salePriceTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            nycategorytxtbox = new TextBox();
            itemName = new Label();
            nycategoriSave = new Button();
            purchaseDateDateTimePicker = new DateTimePicker();
            label1 = new Label();
            descriptionTextBox = new TextBox();
            saleLocationTextBox = new TextBox();
            purchaseLocationTextBox = new TextBox();
            label2 = new Label();
            saleDateDateTimePicker = new DateTimePicker();
            saleDateCheckBox = new CheckBox();
            frontImagePictureBox = new PictureBox();
            backImagePictureBox = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frontImagePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backImagePictureBox).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(quitBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(hemBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 921);
            panel1.TabIndex = 1;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.WhiteSmoke;
            quitBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.ForeColor = Color.DarkGreen;
            quitBtn.Location = new Point(16, 775);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(239, 47);
            quitBtn.TabIndex = 4;
            quitBtn.Text = "Stäng";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.WhiteSmoke;
            updateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.ForeColor = Color.DarkGreen;
            updateBtn.Location = new Point(16, 612);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(239, 47);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Uppdetera";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.WhiteSmoke;
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkGreen;
            addBtn.Location = new Point(16, 440);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(239, 47);
            addBtn.TabIndex = 2;
            addBtn.Text = "Spara";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // hemBtn
            // 
            hemBtn.BackColor = Color.WhiteSmoke;
            hemBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            hemBtn.ForeColor = Color.DarkGreen;
            hemBtn.Location = new Point(16, 266);
            hemBtn.Name = "hemBtn";
            hemBtn.Size = new Size(239, 47);
            hemBtn.TabIndex = 1;
            hemBtn.Text = "Hem";
            hemBtn.UseVisualStyleBackColor = false;
            hemBtn.Click += hemBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(16, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.ForeColor = Color.DarkGreen;
            txtItemName.Location = new Point(401, 398);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Föremål Namn";
            txtItemName.Size = new Size(549, 38);
            txtItemName.TabIndex = 3;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchasePriceTextBox.ForeColor = Color.DarkGreen;
            purchasePriceTextBox.Location = new Point(404, 579);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.PlaceholderText = "Inköpspris";
            purchasePriceTextBox.Size = new Size(549, 38);
            purchasePriceTextBox.TabIndex = 5;
            // 
            // salePriceTextBox
            // 
            salePriceTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            salePriceTextBox.ForeColor = Color.DarkGreen;
            salePriceTextBox.Location = new Point(401, 752);
            salePriceTextBox.Name = "salePriceTextBox";
            salePriceTextBox.PlaceholderText = "Försäljningspris";
            salePriceTextBox.Size = new Size(549, 38);
            salePriceTextBox.TabIndex = 6;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.DarkGreen;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(401, 806);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(549, 39);
            categoryComboBox.TabIndex = 7;
            categoryComboBox.Text = "Kategori";
            // 
            // nycategorytxtbox
            // 
            nycategorytxtbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nycategorytxtbox.ForeColor = Color.DarkGreen;
            nycategorytxtbox.Location = new Point(394, 892);
            nycategorytxtbox.Name = "nycategorytxtbox";
            nycategorytxtbox.PlaceholderText = "Lägg till Ny kategori";
            nycategorytxtbox.Size = new Size(319, 38);
            nycategorytxtbox.TabIndex = 8;
            // 
            // itemName
            // 
            itemName.AutoSize = true;
            itemName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            itemName.ForeColor = Color.DarkGreen;
            itemName.Location = new Point(337, 848);
            itemName.Name = "itemName";
            itemName.Size = new Size(708, 31);
            itemName.TabIndex = 9;
            itemName.Text = "\"Ser du inte den kategori du letar efter? Du kan skapa en ny här.\"";
            // 
            // nycategoriSave
            // 
            nycategoriSave.BackColor = Color.WhiteSmoke;
            nycategoriSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nycategoriSave.ForeColor = Color.DarkGreen;
            nycategoriSave.Location = new Point(741, 891);
            nycategoriSave.Name = "nycategoriSave";
            nycategoriSave.Size = new Size(215, 38);
            nycategoriSave.TabIndex = 10;
            nycategoriSave.Text = "Spara Ny kategori";
            nycategoriSave.UseVisualStyleBackColor = false;
            nycategoriSave.Click += nycategoriSave_Click;
            // 
            // purchaseDateDateTimePicker
            // 
            purchaseDateDateTimePicker.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseDateDateTimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseDateDateTimePicker.Format = DateTimePickerFormat.Short;
            purchaseDateDateTimePicker.Location = new Point(404, 525);
            purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            purchaseDateDateTimePicker.Size = new Size(549, 38);
            purchaseDateDateTimePicker.TabIndex = 11;
            purchaseDateDateTimePicker.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(397, 491);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 12;
            label1.Text = "Inköpsdatum";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.DarkGreen;
            descriptionTextBox.Location = new Point(1131, 47);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Föremål beskrivning";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(580, 886);
            descriptionTextBox.TabIndex = 13;
            // 
            // saleLocationTextBox
            // 
            saleLocationTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saleLocationTextBox.ForeColor = Color.DarkGreen;
            saleLocationTextBox.Location = new Point(401, 633);
            saleLocationTextBox.Name = "saleLocationTextBox";
            saleLocationTextBox.PlaceholderText = "Försäljningsplats";
            saleLocationTextBox.Size = new Size(549, 38);
            saleLocationTextBox.TabIndex = 15;
            // 
            // purchaseLocationTextBox
            // 
            purchaseLocationTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseLocationTextBox.ForeColor = Color.DarkGreen;
            purchaseLocationTextBox.Location = new Point(401, 452);
            purchaseLocationTextBox.Name = "purchaseLocationTextBox";
            purchaseLocationTextBox.PlaceholderText = "Inköpsplats";
            purchaseLocationTextBox.Size = new Size(549, 38);
            purchaseLocationTextBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(400, 674);
            label2.Name = "label2";
            label2.Size = new Size(214, 31);
            label2.TabIndex = 18;
            label2.Text = "Försäljningsdatum";
            // 
            // saleDateDateTimePicker
            // 
            saleDateDateTimePicker.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saleDateDateTimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saleDateDateTimePicker.Format = DateTimePickerFormat.Short;
            saleDateDateTimePicker.Location = new Point(401, 708);
            saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            saleDateDateTimePicker.Size = new Size(549, 38);
            saleDateDateTimePicker.TabIndex = 17;
            saleDateDateTimePicker.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // saleDateCheckBox
            // 
            saleDateCheckBox.AutoSize = true;
            saleDateCheckBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            saleDateCheckBox.Location = new Point(377, 720);
            saleDateCheckBox.Name = "saleDateCheckBox";
            saleDateCheckBox.Size = new Size(18, 17);
            saleDateCheckBox.TabIndex = 19;
            saleDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // frontImagePictureBox
            // 
            frontImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            frontImagePictureBox.Dock = DockStyle.Fill;
            frontImagePictureBox.Location = new Point(3, 3);
            frontImagePictureBox.Name = "frontImagePictureBox";
            frontImagePictureBox.Size = new Size(536, 306);
            frontImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            frontImagePictureBox.TabIndex = 20;
            frontImagePictureBox.TabStop = false;
            frontImagePictureBox.Click += frontImagePictureBox_Click_1;
            // 
            // backImagePictureBox
            // 
            backImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
            backImagePictureBox.Dock = DockStyle.Fill;
            backImagePictureBox.Location = new Point(3, 3);
            backImagePictureBox.Name = "backImagePictureBox";
            backImagePictureBox.Size = new Size(536, 306);
            backImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backImagePictureBox.TabIndex = 21;
            backImagePictureBox.TabStop = false;
            backImagePictureBox.Click += backImagePictureBox_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(400, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(550, 348);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(frontImagePictureBox);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(542, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Framsida";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(backImagePictureBox);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(542, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baksida";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 945);
            Controls.Add(tabControl1);
            Controls.Add(saleDateCheckBox);
            Controls.Add(label2);
            Controls.Add(saleDateDateTimePicker);
            Controls.Add(purchaseLocationTextBox);
            Controls.Add(saleLocationTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(label1);
            Controls.Add(purchaseDateDateTimePicker);
            Controls.Add(nycategoriSave);
            Controls.Add(itemName);
            Controls.Add(nycategorytxtbox);
            Controls.Add(categoryComboBox);
            Controls.Add(salePriceTextBox);
            Controls.Add(purchasePriceTextBox);
            Controls.Add(txtItemName);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)frontImagePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)backImagePictureBox).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button addBtn;
        private Button hemBtn;
        private PictureBox pictureBox1;
        private TextBox txtItemName;
        private TextBox purchasePriceTextBox;
        private TextBox salePriceTextBox;
        private ComboBox categoryComboBox;
        private TextBox nycategorytxtbox;
        private Label itemName;
        private Button nycategoriSave;
        private DateTimePicker purchaseDateDateTimePicker;
        private Label label1;

        private TextBox descriptionTextBox;
        private Button updateBtn;
        private TextBox saleLocationTextBox;
        private TextBox purchaseLocationTextBox;
        private Label label2;
        private DateTimePicker saleDateDateTimePicker;
        private Button quitBtn;
        private CheckBox saleDateCheckBox;
        private PictureBox frontImagePictureBox;
        private PictureBox backImagePictureBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}