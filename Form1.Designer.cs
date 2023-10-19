namespace ArtCrafter.MasterofCollections
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            quitBtn = new Button();
            reportBtn = new Button();
            addBtn = new Button();
            hemBtn = new Button();
            pictureBox1 = new PictureBox();
            searchtextbox = new TextBox();
            label1 = new Label();
            suggestionsListBox = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(quitBtn);
            panel1.Controls.Add(reportBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(hemBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 921);
            panel1.TabIndex = 0;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.WhiteSmoke;
            quitBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.ForeColor = Color.DarkGreen;
            quitBtn.Location = new Point(16, 810);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(239, 47);
            quitBtn.TabIndex = 8;
            quitBtn.Text = "Stäng";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // reportBtn
            // 
            reportBtn.BackColor = Color.WhiteSmoke;
            reportBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            reportBtn.ForeColor = Color.DarkGreen;
            reportBtn.Location = new Point(16, 624);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(239, 47);
            reportBtn.TabIndex = 7;
            reportBtn.Text = "Statistik";
            reportBtn.UseVisualStyleBackColor = false;
            reportBtn.Click += reportBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.WhiteSmoke;
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkGreen;
            addBtn.Location = new Point(16, 425);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(239, 47);
            addBtn.TabIndex = 2;
            addBtn.Text = "Lägg till föremål";
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
            // searchtextbox
            // 
            searchtextbox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchtextbox.ForeColor = Color.DarkGreen;
            searchtextbox.Location = new Point(524, 89);
            searchtextbox.Name = "searchtextbox";
            searchtextbox.PlaceholderText = "Sök kategori eller föremål";
            searchtextbox.Size = new Size(863, 47);
            searchtextbox.TabIndex = 1;
            searchtextbox.TextChanged += searchtextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(704, 34);
            label1.Name = "label1";
            label1.Size = new Size(483, 41);
            label1.TabIndex = 2;
            label1.Text = "Artcraftör: Mästare av Samlingar";
            // 
            // suggestionsListBox
            // 
            suggestionsListBox.BackColor = SystemColors.GradientActiveCaption;
            suggestionsListBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            suggestionsListBox.FormattingEnabled = true;
            suggestionsListBox.ItemHeight = 37;
            suggestionsListBox.Location = new Point(524, 142);
            suggestionsListBox.Name = "suggestionsListBox";
            suggestionsListBox.ScrollAlwaysVisible = true;
            suggestionsListBox.Size = new Size(863, 78);
            suggestionsListBox.TabIndex = 3;
            suggestionsListBox.Visible = false;
            suggestionsListBox.SelectedIndexChanged += suggestionsListBox_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(309, 226);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1397, 707);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1739, 945);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(suggestionsListBox);
            Controls.Add(label1);
            Controls.Add(searchtextbox);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button hemBtn;
        private PictureBox pictureBox1;
        private Button addBtn;
        private Button reportBtn;
        private TextBox searchtextbox;
        private Label label1;
        private ListBox suggestionsListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button quitBtn;
    }
}