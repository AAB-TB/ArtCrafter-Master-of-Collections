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
            tabPage3 = new TabPage();
            signaturePicturebox = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frontImagePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backImagePictureBox).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signaturePicturebox).BeginInit();
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
            panel1.Size = new Size(270, 695);
            panel1.TabIndex = 1;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.WhiteSmoke;
            quitBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.ForeColor = Color.DarkGreen;
            quitBtn.Location = new Point(16, 537);
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
            updateBtn.Location = new Point(16, 446);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(239, 47);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Uppdatera";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.WhiteSmoke;
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkGreen;
            addBtn.Location = new Point(16, 357);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(239, 47);
            addBtn.TabIndex = 2;
            addBtn.Text = "Spara nytt Föremål";
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
            txtItemName.Location = new Point(518, 355);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Föremål Namn";
            txtItemName.Size = new Size(258, 38);
            txtItemName.TabIndex = 3;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchasePriceTextBox.ForeColor = Color.DarkGreen;
            purchasePriceTextBox.Location = new Point(518, 530);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.PlaceholderText = "Inköpspris";
            purchasePriceTextBox.Size = new Size(258, 38);
            purchasePriceTextBox.TabIndex = 5;
            // 
            // salePriceTextBox
            // 
            salePriceTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            salePriceTextBox.ForeColor = Color.DarkGreen;
            salePriceTextBox.Location = new Point(1041, 478);
            salePriceTextBox.Name = "salePriceTextBox";
            salePriceTextBox.PlaceholderText = "Försäljningspris";
            salePriceTextBox.Size = new Size(258, 38);
            salePriceTextBox.TabIndex = 6;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.DarkGreen;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(813, 549);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(258, 39);
            categoryComboBox.TabIndex = 7;
            categoryComboBox.Text = "Kategori";
            // 
            // nycategorytxtbox
            // 
            nycategorytxtbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nycategorytxtbox.ForeColor = Color.DarkGreen;
            nycategorytxtbox.Location = new Point(327, 655);
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
            itemName.Location = new Point(320, 608);
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
            nycategoriSave.Location = new Point(680, 655);
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
            purchaseDateDateTimePicker.Location = new Point(518, 478);
            purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            purchaseDateDateTimePicker.Size = new Size(258, 38);
            purchaseDateDateTimePicker.TabIndex = 11;
            purchaseDateDateTimePicker.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(324, 478);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 12;
            label1.Text = "Inköpsdatum";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.DarkGreen;
            descriptionTextBox.Location = new Point(801, 44);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Föremål beskrivning";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(501, 295);
            descriptionTextBox.TabIndex = 13;
            // 
            // saleLocationTextBox
            // 
            saleLocationTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            saleLocationTextBox.ForeColor = Color.DarkGreen;
            saleLocationTextBox.Location = new Point(1042, 358);
            saleLocationTextBox.Name = "saleLocationTextBox";
            saleLocationTextBox.PlaceholderText = "Försäljningsplats";
            saleLocationTextBox.Size = new Size(258, 38);
            saleLocationTextBox.TabIndex = 15;
            // 
            // purchaseLocationTextBox
            // 
            purchaseLocationTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseLocationTextBox.ForeColor = Color.DarkGreen;
            purchaseLocationTextBox.Location = new Point(518, 416);
            purchaseLocationTextBox.Name = "purchaseLocationTextBox";
            purchaseLocationTextBox.PlaceholderText = "Inköpsplats";
            purchaseLocationTextBox.Size = new Size(258, 38);
            purchaseLocationTextBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(804, 423);
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
            saleDateDateTimePicker.Location = new Point(1041, 423);
            saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            saleDateDateTimePicker.Size = new Size(258, 38);
            saleDateDateTimePicker.TabIndex = 17;
            saleDateDateTimePicker.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // saleDateCheckBox
            // 
            saleDateCheckBox.AutoSize = true;
            saleDateCheckBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            saleDateCheckBox.Location = new Point(1017, 433);
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
            frontImagePictureBox.Size = new Size(346, 285);
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
            backImagePictureBox.Size = new Size(346, 285);
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
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(380, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(360, 327);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(frontImagePictureBox);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(352, 291);
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
            tabPage2.Size = new Size(352, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baksida";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(signaturePicturebox);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(352, 291);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Signature";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // signaturePicturebox
            // 
            signaturePicturebox.BorderStyle = BorderStyle.Fixed3D;
            signaturePicturebox.Dock = DockStyle.Fill;
            signaturePicturebox.Location = new Point(0, 0);
            signaturePicturebox.Name = "signaturePicturebox";
            signaturePicturebox.Size = new Size(352, 291);
            signaturePicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            signaturePicturebox.TabIndex = 0;
            signaturePicturebox.TabStop = false;
            signaturePicturebox.Click += signaturePicturebox_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(320, 358);
            label3.Name = "label3";
            label3.Size = new Size(172, 31);
            label3.TabIndex = 23;
            label3.Text = "Föremål Namn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(801, 6);
            label4.Name = "label4";
            label4.Size = new Size(234, 31);
            label4.TabIndex = 24;
            label4.Text = "Föremål Beskrivning";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(324, 419);
            label5.Name = "label5";
            label5.Size = new Size(138, 31);
            label5.TabIndex = 25;
            label5.Text = "Inköpsplats";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(324, 537);
            label6.Name = "label6";
            label6.Size = new Size(126, 31);
            label6.TabIndex = 26;
            label6.Text = "Inköpspris";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(801, 358);
            label7.Name = "label7";
            label7.Size = new Size(196, 31);
            label7.TabIndex = 27;
            label7.Text = "Försäljningsplats";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(804, 484);
            label8.Name = "label8";
            label8.Size = new Size(184, 31);
            label8.TabIndex = 28;
            label8.Text = "Försäljningspris";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 724);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signaturePicturebox).EndInit();
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TabPage tabPage3;
        private PictureBox signaturePicturebox;
    }
}