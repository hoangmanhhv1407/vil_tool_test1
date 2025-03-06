using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEditor
{
	//1213
    public partial class FormLifes : Form
    {
        public FormLifes()
        {
            InitializeComponent();
        }

        private void FormLifes_Load(object sender, EventArgs e)
        {
            foreach(ItemLife life in ItemLife.Lifes.Values)
            {
                listBoxLifes.Items.Add(life);
            }
            listBoxLifes.DisplayMember = "FullName";
            listBoxLifes.ValueMember = "ID";

            tabPageUnknown.Controls.Add(byteViewer);
            byteViewer.Dock = DockStyle.Fill;
        }

        private void listBoxLifes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemLife life = listBoxLifes.SelectedItem as ItemLife;
            byteViewer.SetBytes(life.unknownBytes.ToArray());
        }
    }
}
