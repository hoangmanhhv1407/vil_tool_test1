using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEditor.Forms
{
    public partial class FormPotion : Form
    {
        public FormPotion()
        {
            InitializeComponent();
            
        }

        private void FormPotion_Load(object sender, EventArgs e)
        {
            byteViewer.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(byteViewer);

            foreach (ItemPotion potion in ItemPotion.Potions.Values)
            {
                listBoxPotions.Items.Add(potion);
            }

            listBoxPotions.DisplayMember = "FullName";
            listBoxPotions.ValueMember = "ID";
        }

        private void listBoxPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemPotion potion = listBoxPotions.SelectedItem as ItemPotion;
            byteViewer.Dock = DockStyle.Fill;
            byteViewer.SetBytes(potion.unknownBytes.ToArray());
        }
    }
}
