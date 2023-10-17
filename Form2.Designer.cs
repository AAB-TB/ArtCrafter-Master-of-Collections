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
            addBtn = new Button();
            hemBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            itemName = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(hemBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 823);
            panel1.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.WhiteSmoke;
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkGreen;
            addBtn.Location = new Point(16, 389);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(239, 47);
            addBtn.TabIndex = 2;
            addBtn.Text = "Spara";
            addBtn.UseVisualStyleBackColor = false;
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
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(1163, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(482, 556);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Location = new Point(336, 70);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Föremål Namn";
            textBox1.Size = new Size(549, 38);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.DarkGreen;
            textBox3.Location = new Point(336, 246);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Inköpspris";
            textBox3.Size = new Size(549, 38);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.DarkGreen;
            textBox4.Location = new Point(336, 336);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Försäljningspris";
            textBox4.Size = new Size(549, 38);
            textBox4.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.DarkGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(336, 420);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(549, 39);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Kategori";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.DarkGreen;
            textBox5.Location = new Point(336, 532);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Lägg till Ny kategori";
            textBox5.Size = new Size(335, 38);
            textBox5.TabIndex = 8;
            // 
            // itemName
            // 
            itemName.AutoSize = true;
            itemName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            itemName.ForeColor = Color.DarkGreen;
            itemName.Location = new Point(336, 485);
            itemName.Name = "itemName";
            itemName.Size = new Size(708, 31);
            itemName.TabIndex = 9;
            itemName.Text = "\"Ser du inte den kategori du letar efter? Du kan skapa en ny här.\"";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(692, 532);
            button1.Name = "button1";
            button1.Size = new Size(193, 38);
            button1.TabIndex = 10;
            button1.Text = "Spara";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(336, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(549, 38);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(336, 135);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 12;
            label1.Text = "Inköpsdatum";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 847);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(itemName);
            Controls.Add(textBox5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button addBtn;
        private Button hemBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Label itemName;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}