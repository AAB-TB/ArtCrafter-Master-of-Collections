﻿namespace ArtCrafter.MasterofCollections
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            deleteBtn = new Button();
            quitbtn = new Button();
            takeForm2Btn = new Button();
            hemBtn = new Button();
            pictureBox1 = new PictureBox();
            itemDescription = new TextBox();
            itemTitle = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            frontsidePictureBox = new PictureBox();
            tabPage2 = new TabPage();
            backsidePictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            sellDate = new TextBox();
            label3 = new Label();
            sellLocation = new TextBox();
            label6 = new Label();
            label7 = new Label();
            sellPrice = new TextBox();
            groupBox2 = new GroupBox();
            purchaseDate = new TextBox();
            label4 = new Label();
            purchaseLocation = new TextBox();
            label8 = new Label();
            label9 = new Label();
            purchasePrice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frontsidePictureBox).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backsidePictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(quitbtn);
            panel1.Controls.Add(takeForm2Btn);
            panel1.Controls.Add(hemBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 908);
            panel1.TabIndex = 1;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.WhiteSmoke;
            deleteBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.DarkGreen;
            deleteBtn.Location = new Point(16, 552);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(239, 47);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Ta bort föremål";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // quitbtn
            // 
            quitbtn.BackColor = Color.WhiteSmoke;
            quitbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            quitbtn.ForeColor = Color.DarkGreen;
            quitbtn.Location = new Point(16, 717);
            quitbtn.Name = "quitbtn";
            quitbtn.Size = new Size(239, 47);
            quitbtn.TabIndex = 5;
            quitbtn.Text = "Stäng";
            quitbtn.UseVisualStyleBackColor = false;
            quitbtn.Click += quitbtn_Click;
            // 
            // takeForm2Btn
            // 
            takeForm2Btn.BackColor = Color.WhiteSmoke;
            takeForm2Btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            takeForm2Btn.ForeColor = Color.DarkGreen;
            takeForm2Btn.Location = new Point(16, 401);
            takeForm2Btn.Name = "takeForm2Btn";
            takeForm2Btn.Size = new Size(239, 47);
            takeForm2Btn.TabIndex = 3;
            takeForm2Btn.Text = "Redigera föremål";
            takeForm2Btn.UseVisualStyleBackColor = false;
            takeForm2Btn.Click += takeForm2Btn_Click;
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
            // itemDescription
            // 
            itemDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            itemDescription.ForeColor = Color.DarkGreen;
            itemDescription.Location = new Point(379, 586);
            itemDescription.Multiline = true;
            itemDescription.Name = "itemDescription";
            itemDescription.PlaceholderText = "Föremål beskrivning";
            itemDescription.ScrollBars = ScrollBars.Vertical;
            itemDescription.Size = new Size(1272, 334);
            itemDescription.TabIndex = 14;
            // 
            // itemTitle
            // 
            itemTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            itemTitle.ForeColor = Color.DarkGreen;
            itemTitle.Location = new Point(379, 22);
            itemTitle.Name = "itemTitle";
            itemTitle.PlaceholderText = "Föremål Namn";
            itemTitle.Size = new Size(575, 38);
            itemTitle.TabIndex = 15;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(379, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(575, 488);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(frontsidePictureBox);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(567, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Framsida";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // frontsidePictureBox
            // 
            frontsidePictureBox.Dock = DockStyle.Fill;
            frontsidePictureBox.Location = new Point(3, 3);
            frontsidePictureBox.Name = "frontsidePictureBox";
            frontsidePictureBox.Size = new Size(561, 446);
            frontsidePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            frontsidePictureBox.TabIndex = 0;
            frontsidePictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(backsidePictureBox);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(567, 452);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baksida";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // backsidePictureBox
            // 
            backsidePictureBox.Dock = DockStyle.Fill;
            backsidePictureBox.Location = new Point(3, 3);
            backsidePictureBox.Name = "backsidePictureBox";
            backsidePictureBox.Size = new Size(561, 446);
            backsidePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backsidePictureBox.TabIndex = 0;
            backsidePictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sellDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(sellLocation);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(sellPrice);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(1020, 356);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 189);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Försäljnings Historia";
            // 
            // sellDate
            // 
            sellDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellDate.ForeColor = Color.DarkGreen;
            sellDate.Location = new Point(227, 86);
            sellDate.Name = "sellDate";
            sellDate.PlaceholderText = "Inköpningsplats";
            sellDate.Size = new Size(343, 38);
            sellDate.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(13, 39);
            label3.Name = "label3";
            label3.Size = new Size(196, 31);
            label3.TabIndex = 31;
            label3.Text = "Försäljningsplats";
            // 
            // sellLocation
            // 
            sellLocation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellLocation.ForeColor = Color.DarkGreen;
            sellLocation.Location = new Point(227, 36);
            sellLocation.Name = "sellLocation";
            sellLocation.PlaceholderText = "Försäljningsplats";
            sellLocation.Size = new Size(343, 38);
            sellLocation.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(13, 136);
            label6.Name = "label6";
            label6.Size = new Size(184, 31);
            label6.TabIndex = 29;
            label6.Text = "Försäljningspris";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(13, 86);
            label7.Name = "label7";
            label7.Size = new Size(214, 31);
            label7.TabIndex = 28;
            label7.Text = "Försäljningsdatum";
            // 
            // sellPrice
            // 
            sellPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellPrice.ForeColor = Color.DarkGreen;
            sellPrice.Location = new Point(227, 133);
            sellPrice.Name = "sellPrice";
            sellPrice.PlaceholderText = "Försäljningspris";
            sellPrice.Size = new Size(343, 38);
            sellPrice.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(purchaseDate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(purchaseLocation);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(purchasePrice);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.DarkGreen;
            groupBox2.Location = new Point(1020, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 189);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inköpnings Historia";
            // 
            // purchaseDate
            // 
            purchaseDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseDate.ForeColor = Color.DarkGreen;
            purchaseDate.Location = new Point(227, 86);
            purchaseDate.Name = "purchaseDate";
            purchaseDate.PlaceholderText = "Inköpningsplats";
            purchaseDate.Size = new Size(343, 38);
            purchaseDate.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(13, 39);
            label4.Name = "label4";
            label4.Size = new Size(187, 31);
            label4.TabIndex = 31;
            label4.Text = "Inköpningsplats";
            // 
            // purchaseLocation
            // 
            purchaseLocation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseLocation.ForeColor = Color.DarkGreen;
            purchaseLocation.Location = new Point(227, 36);
            purchaseLocation.Name = "purchaseLocation";
            purchaseLocation.PlaceholderText = "Inköpningsplats";
            purchaseLocation.Size = new Size(343, 38);
            purchaseLocation.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(13, 136);
            label8.Name = "label8";
            label8.Size = new Size(175, 31);
            label8.TabIndex = 29;
            label8.Text = "Inköpningspris";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(13, 86);
            label9.Name = "label9";
            label9.Size = new Size(205, 31);
            label9.TabIndex = 28;
            label9.Text = "Inköpningsdatum";
            // 
            // purchasePrice
            // 
            purchasePrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            purchasePrice.ForeColor = Color.DarkGreen;
            purchasePrice.Location = new Point(227, 133);
            purchasePrice.Name = "purchasePrice";
            purchasePrice.PlaceholderText = "Inköpningspris";
            purchasePrice.Size = new Size(343, 38);
            purchasePrice.TabIndex = 26;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 945);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Controls.Add(itemTitle);
            Controls.Add(itemDescription);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)frontsidePictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backsidePictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button takeForm2Btn;
        private Button hemBtn;
        private PictureBox pictureBox1;
        private TextBox itemDescription;
        private TextBox itemTitle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox frontsidePictureBox;
        private PictureBox backsidePictureBox;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox sellLocation;
        private Label label6;
        private Label label7;
        private TextBox sellPrice;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox purchaseLocation;
        private Label label8;
        private Label label9;
        private TextBox purchasePrice;
        private Button quitbtn;
        private TextBox sellDate;
        private TextBox purchaseDate;
        private Button deleteBtn;
    }
}