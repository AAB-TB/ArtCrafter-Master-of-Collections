namespace ArtCrafter.MasterofCollections
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            quitBtn = new Button();
            hemBtn = new Button();
            pictureBox1 = new PictureBox();
            generaterp = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            tilldatetimepicker = new DateTimePicker();
            label5 = new Label();
            fromdatetimepicker = new DateTimePicker();
            label4 = new Label();
            totalProfitLossTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            totalBuyingCostTextBox = new TextBox();
            totalSellingCostTextBox = new TextBox();
            groupBox3 = new GroupBox();
            locationComboBox = new ComboBox();
            groupBox4 = new GroupBox();
            label7 = new Label();
            tillDateTimePicker2 = new DateTimePicker();
            generateRPbtn = new Button();
            label8 = new Label();
            fromDateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            totalProfitLossBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            totalBuyingCostBox = new TextBox();
            totalSellingCostBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(quitBtn);
            panel1.Controls.Add(hemBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 930);
            panel1.TabIndex = 1;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.WhiteSmoke;
            quitBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.ForeColor = Color.DarkGreen;
            quitBtn.Location = new Point(9, 538);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(239, 47);
            quitBtn.TabIndex = 2;
            quitBtn.Text = "Stäng";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
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
            // generaterp
            // 
            generaterp.BackColor = Color.WhiteSmoke;
            generaterp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            generaterp.ForeColor = Color.DarkGreen;
            generaterp.Location = new Point(457, 23);
            generaterp.Name = "generaterp";
            generaterp.Size = new Size(205, 38);
            generaterp.TabIndex = 2;
            generaterp.Text = "generera rapport";
            generaterp.UseVisualStyleBackColor = false;
            generaterp.Click += generaterp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(totalProfitLossTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(totalBuyingCostTextBox);
            groupBox1.Controls.Add(totalSellingCostTextBox);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(305, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1336, 333);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rapport";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tilldatetimepicker);
            groupBox2.Controls.Add(generaterp);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(fromdatetimepicker);
            groupBox2.Location = new Point(319, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 77);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(228, 29);
            label6.Name = "label6";
            label6.Size = new Size(48, 31);
            label6.TabIndex = 28;
            label6.Text = "Till";
            // 
            // tilldatetimepicker
            // 
            tilldatetimepicker.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tilldatetimepicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tilldatetimepicker.Format = DateTimePickerFormat.Short;
            tilldatetimepicker.Location = new Point(282, 24);
            tilldatetimepicker.Name = "tilldatetimepicker";
            tilldatetimepicker.Size = new Size(153, 38);
            tilldatetimepicker.TabIndex = 26;
            tilldatetimepicker.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(10, 26);
            label5.Name = "label5";
            label5.Size = new Size(61, 31);
            label5.TabIndex = 27;
            label5.Text = "Från";
            // 
            // fromdatetimepicker
            // 
            fromdatetimepicker.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            fromdatetimepicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            fromdatetimepicker.Format = DateTimePickerFormat.Short;
            fromdatetimepicker.Location = new Point(69, 23);
            fromdatetimepicker.Name = "fromdatetimepicker";
            fromdatetimepicker.Size = new Size(153, 38);
            fromdatetimepicker.TabIndex = 25;
            fromdatetimepicker.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(319, 271);
            label4.Name = "label4";
            label4.Size = new Size(207, 31);
            label4.TabIndex = 28;
            label4.Text = "Total vinst/förlust";
            // 
            // totalProfitLossTextBox
            // 
            totalProfitLossTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalProfitLossTextBox.ForeColor = Color.DarkGreen;
            totalProfitLossTextBox.Location = new Point(589, 271);
            totalProfitLossTextBox.Name = "totalProfitLossTextBox";
            totalProfitLossTextBox.PlaceholderText = "Total vinst/förlust.\"";
            totalProfitLossTextBox.Size = new Size(383, 38);
            totalProfitLossTextBox.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(319, 215);
            label3.Name = "label3";
            label3.Size = new Size(264, 31);
            label3.TabIndex = 26;
            label3.Text = "Totala inköpskostnader";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(319, 155);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 25;
            label2.Text = "Total försäljning";
            // 
            // totalBuyingCostTextBox
            // 
            totalBuyingCostTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalBuyingCostTextBox.ForeColor = Color.DarkGreen;
            totalBuyingCostTextBox.Location = new Point(589, 215);
            totalBuyingCostTextBox.Name = "totalBuyingCostTextBox";
            totalBuyingCostTextBox.PlaceholderText = "Totala inköpskostnader";
            totalBuyingCostTextBox.Size = new Size(383, 38);
            totalBuyingCostTextBox.TabIndex = 24;
            // 
            // totalSellingCostTextBox
            // 
            totalSellingCostTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalSellingCostTextBox.ForeColor = Color.DarkGreen;
            totalSellingCostTextBox.Location = new Point(589, 158);
            totalSellingCostTextBox.Name = "totalSellingCostTextBox";
            totalSellingCostTextBox.PlaceholderText = "Total försäljning";
            totalSellingCostTextBox.Size = new Size(383, 38);
            totalSellingCostTextBox.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(locationComboBox);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(totalProfitLossBox);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(totalBuyingCostBox);
            groupBox3.Controls.Add(totalSellingCostBox);
            groupBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.DarkGreen;
            groupBox3.Location = new Point(305, 480);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1336, 359);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rapport";
            // 
            // locationComboBox
            // 
            locationComboBox.ForeColor = Color.DarkGreen;
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Location = new Point(319, 58);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(653, 49);
            locationComboBox.TabIndex = 29;
            locationComboBox.Text = "Enskilda FörsäljningFirma";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(tillDateTimePicker2);
            groupBox4.Controls.Add(generateRPbtn);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(fromDateTimePicker2);
            groupBox4.Location = new Point(319, 94);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(653, 77);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(228, 33);
            label7.Name = "label7";
            label7.Size = new Size(48, 31);
            label7.TabIndex = 28;
            label7.Text = "Till";
            // 
            // tillDateTimePicker2
            // 
            tillDateTimePicker2.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tillDateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tillDateTimePicker2.Format = DateTimePickerFormat.Short;
            tillDateTimePicker2.Location = new Point(282, 26);
            tillDateTimePicker2.Name = "tillDateTimePicker2";
            tillDateTimePicker2.Size = new Size(153, 38);
            tillDateTimePicker2.TabIndex = 26;
            tillDateTimePicker2.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // generateRPbtn
            // 
            generateRPbtn.BackColor = Color.WhiteSmoke;
            generateRPbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            generateRPbtn.ForeColor = Color.DarkGreen;
            generateRPbtn.Location = new Point(457, 23);
            generateRPbtn.Name = "generateRPbtn";
            generateRPbtn.Size = new Size(205, 38);
            generateRPbtn.TabIndex = 2;
            generateRPbtn.Text = "generera rapport";
            generateRPbtn.UseVisualStyleBackColor = false;
            generateRPbtn.Click += generateRPbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(6, 27);
            label8.Name = "label8";
            label8.Size = new Size(61, 31);
            label8.TabIndex = 27;
            label8.Text = "Från";
            // 
            // fromDateTimePicker2
            // 
            fromDateTimePicker2.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            fromDateTimePicker2.CalendarForeColor = Color.DarkGreen;
            fromDateTimePicker2.CalendarTitleForeColor = Color.DarkGreen;
            fromDateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            fromDateTimePicker2.Format = DateTimePickerFormat.Short;
            fromDateTimePicker2.Location = new Point(73, 27);
            fromDateTimePicker2.Name = "fromDateTimePicker2";
            fromDateTimePicker2.Size = new Size(153, 38);
            fromDateTimePicker2.TabIndex = 25;
            fromDateTimePicker2.Value = new DateTime(2023, 10, 17, 14, 34, 1, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(319, 304);
            label9.Name = "label9";
            label9.Size = new Size(207, 31);
            label9.TabIndex = 28;
            label9.Text = "Total vinst/förlust";
            // 
            // totalProfitLossBox
            // 
            totalProfitLossBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalProfitLossBox.ForeColor = Color.DarkGreen;
            totalProfitLossBox.Location = new Point(589, 304);
            totalProfitLossBox.Name = "totalProfitLossBox";
            totalProfitLossBox.PlaceholderText = "Total vinst/förlust.\"";
            totalProfitLossBox.Size = new Size(383, 38);
            totalProfitLossBox.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(319, 248);
            label10.Name = "label10";
            label10.Size = new Size(264, 31);
            label10.TabIndex = 26;
            label10.Text = "Totala inköpskostnader";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(319, 188);
            label11.Name = "label11";
            label11.Size = new Size(190, 31);
            label11.TabIndex = 25;
            label11.Text = "Total försäljning";
            // 
            // totalBuyingCostBox
            // 
            totalBuyingCostBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalBuyingCostBox.ForeColor = Color.DarkGreen;
            totalBuyingCostBox.Location = new Point(589, 248);
            totalBuyingCostBox.Name = "totalBuyingCostBox";
            totalBuyingCostBox.PlaceholderText = "Totala inköpskostnader";
            totalBuyingCostBox.Size = new Size(383, 38);
            totalBuyingCostBox.TabIndex = 24;
            // 
            // totalSellingCostBox
            // 
            totalSellingCostBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalSellingCostBox.ForeColor = Color.DarkGreen;
            totalSellingCostBox.Location = new Point(589, 191);
            totalSellingCostBox.Name = "totalSellingCostBox";
            totalSellingCostBox.PlaceholderText = "Total försäljning";
            totalSellingCostBox.Size = new Size(383, 38);
            totalSellingCostBox.TabIndex = 23;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 945);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button hemBtn;
        private PictureBox pictureBox1;
        private Button generaterp;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox totalProfitLossTextBox;
        private Label label3;
        private Label label2;
        private TextBox totalBuyingCostTextBox;
        private TextBox totalSellingCostTextBox;
        private DateTimePicker fromdatetimepicker;
        private DateTimePicker tilldatetimepicker;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label7;
        private DateTimePicker tillDateTimePicker2;
        private Button generateRPbtn;
        private Label label8;
        private DateTimePicker fromDateTimePicker2;
        private Label label9;
        private TextBox totalProfitLossBox;
        private Label label10;
        private Label label11;
        private TextBox totalBuyingCostBox;
        private TextBox totalSellingCostBox;
        private ComboBox locationComboBox;
        private Button quitBtn;
    }
}