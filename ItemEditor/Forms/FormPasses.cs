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
    public partial class FormPasses : Form
    {
        public FormPasses()
        {
            InitializeComponent();
        }

        private void listBoxPasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemPass pass = listBoxPasses.SelectedItem as ItemPass;
            tabPageUnknown.Controls.Add(byteViewer);
            byteViewer.Dock = DockStyle.Fill;
            byteViewer.SetBytes(pass.unknownBytes.ToArray());
            
        }

        private void FormPasses_Load(object sender, EventArgs e)
        {
            foreach(ItemPass pass in ItemPass.Passes.Values)
            {
                listBoxPasses.Items.Add(pass);
            }
            listBoxPasses.DisplayMember = "FullName";
            listBoxPasses.ValueMember = "ID";
        }
    }
}
