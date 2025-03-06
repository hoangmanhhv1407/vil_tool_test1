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
    public partial class FormItemRanks : Form
    {
        public FormItemRanks()
        {
            InitializeComponent();
        }

        private void listBoxRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ushort key = Convert.ToUInt16(listBoxRanks.SelectedItem);
            dataGridView1.DataSource = ItemParser.ItemRanks[key];
        }

        private void FormItemRanks_Load(object sender, EventArgs e)
        {
            foreach(ushort num in ItemParser.ItemRanks.Keys)
            {
                listBoxRanks.Items.Add(num);
            }
        }
    }
}
