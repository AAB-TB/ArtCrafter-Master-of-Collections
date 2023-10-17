using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtCrafter.MasterofCollections
{
    public partial class ItemUserControl : UserControl
    {
        private Form1 parentForm;
        public CollectionItem CollectionItem { get; set; }
        public ItemUserControl(Form1 parentForm, CollectionItem CollectionItem)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.CollectionItem = CollectionItem;
        }

        public void SetImage(string frontImageFilePath)
        {
            if (!string.IsNullOrEmpty(frontImageFilePath))
            {
                itemImage.ImageLocation = frontImageFilePath;
            }
        }

        public void SetTitle(string name)
        {
            itemName.Text = name;
        }

        private void itemImage_Click(object sender, EventArgs e)
        {
            int id = CollectionItem.ID;
            parentForm.Hide();
            Form3 form3 = new Form3(id);
            form3.Show();

        }

        private void itemName_Click(object sender, EventArgs e)
        {
            int id = CollectionItem.ID;
            parentForm.Hide();
            Form3 form3 = new Form3(id);
            form3.Show();
        }
    }



}
