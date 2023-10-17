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
            button5 = new Button();
            addBtn = new Button();
            hemBtn = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(hemBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 823);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkGreen;
            button5.Location = new Point(16, 712);
            button5.Name = "button5";
            button5.Size = new Size(239, 47);
            button5.TabIndex = 7;
            button5.Text = "Statistik";
            button5.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.WhiteSmoke;
            addBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.DarkGreen;
            addBtn.Location = new Point(16, 473);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(239, 47);
            addBtn.TabIndex = 2;
            addBtn.Text = "Lägg till föremål";
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Location = new Point(524, 89);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Sök kategori eller föremål";
            textBox1.Size = new Size(863, 47);
            textBox1.TabIndex = 1;
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
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(524, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(863, 78);
            listBox1.TabIndex = 3;
            listBox1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(309, 226);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1397, 609);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 847);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
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
        private Button button5;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}