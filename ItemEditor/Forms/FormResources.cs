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
    public partial class FormResources : Form
    {
        public FormResources()
        {
            InitializeComponent();
        }

        private void FormResources_Load(object sender, EventArgs e)
        {
            foreach(ItemResource resource in ItemResource.Resources.Values)
            {
                listBoxResources.Items.Add(resource);
            }
            foreach (var it in Enum.GetValues(typeof(ResourceSecondType))) comboBoxType.Items.Add(it);
            comboBoxType.ValueMember = "value";
            listBoxResources.DisplayMember = "FullName";
            listBoxResources.ValueMember = "ID";
            tabPageUnknown.Controls.Add(byteViewer);
        }

        private void listBoxResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemResource resource = listBoxResources.SelectedItem as ItemResource;
            byteViewer.Dock = DockStyle.Fill;
            byteViewer.SetBytes(resource.unknownBytes.ToArray());

            textBoxItemRank.Text = resource.ItemRank.ToString();
            textBoxPackage.Text = resource.Package.ToString();
            textBoxCashCheck.Text = resource.CashCheck.ToString();
            textBoxTime.Text = resource.Time.ToString();
            textBoxTypeNo.Text = resource.SecondType.ToString();
            textBoxGrade.Text = resource.Grade.ToString();

            comboBoxType.SelectedItem = (ResourceSecondType)resource.SecondType;

            checkBoxDrop.Checked = resource.BlockDrop;
            checkBoxNPC.Checked = resource.CanNPC;
            checkBoxTrade.Checked = resource.CanTrade;
            checkBoxStore.Checked = resource.BlockStorage;
        }

        private void FormResources_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (listBoxResources.SelectedIndex > 0)
                    this.listBoxResources.SelectedIndex--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (listBoxResources.SelectedIndex < listBoxResources.Items.Count - 1)
                    this.listBoxResources.SelectedIndex++;
            }
        }
    }
}
