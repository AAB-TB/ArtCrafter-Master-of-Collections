﻿namespace ArtCrafter.MasterofCollections
{
    partial class ItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemImage = new PictureBox();
            itemName = new Label();
            ((System.ComponentModel.ISupportInitialize)itemImage).BeginInit();
            SuspendLayout();
            // 
            // itemImage
            // 
            itemImage.BorderStyle = BorderStyle.Fixed3D;
            itemImage.Location = new Point(14, 15);
            itemImage.Name = "itemImage";
            itemImage.Size = new Size(190, 194);
            itemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            itemImage.TabIndex = 0;
            itemImage.TabStop = false;
            itemImage.Click += itemImage_Click;
            // 
            // itemName
            // 
            itemName.AutoSize = true;
            itemName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            itemName.ForeColor = Color.DarkGreen;
            itemName.Location = new Point(14, 222);
            itemName.Name = "itemName";
            itemName.Size = new Size(79, 31);
            itemName.TabIndex = 1;
            itemName.Text = "label1";
            itemName.Click += itemName_Click;
            // 
            // ItemUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(itemName);
            Controls.Add(itemImage);
            Name = "ItemUserControl";
            Size = new Size(218, 261);
            ((System.ComponentModel.ISupportInitialize)itemImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox itemImage;
        private Label itemName;
    }
}
