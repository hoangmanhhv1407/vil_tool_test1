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
    public partial class FormAccessories : Form
    {
        public FormAccessories()
        {
            InitializeComponent();
        }

        private void FormAccessories_Load(object sender, EventArgs e)
        {
            tabPageUnknown.Controls.Add(byteViewer);
            byteViewer.Dock = DockStyle.Fill;

            foreach(KeyValuePair<short, ItemAccessory> pair in ItemAccessory.Accessories)
            {
                listBoxAccessories.Items.Add(pair.Value);
            }
            listBoxAccessories.DisplayMember = "FullName";
            listBoxAccessories.ValueMember = "ID";

            comboBox2ndType.DataSource = Enum.GetValues(typeof(AccessorySecondType));
            //////
            comboBoxFame.DataSource = Enum.GetValues(typeof(FameValues));
            /*foreach(KeyValuePair<int, string> pair in XsdManager.Maps["Fame"])
            {
                comboBoxFame.Items.Add(pair);
            }
            comboBoxFame.DisplayMember = "Value";
            comboBoxFame.ValueMember = "Key";
            //////
            //comboBoxFame.DisplayMember = "Name";
            //comboBoxFame.DataSource = Enum.GetValues(typeof(FameValues));

            //comboBox2ndType.ValueMember = "Value";
            */
        }

        private void listBoxAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemAccessory accessory = listBoxAccessories.SelectedItem as ItemAccessory;
            tbSecondaryType.Text = accessory.SecondType.ToString();
            comboBox2ndType.SelectedItem = (AccessorySecondType)accessory.SecondType;
            tbKarma.Text= accessory.Fame.ToString();
            
            byteViewer.Dock = DockStyle.Fill;
            byteViewer.SetBytes(accessory.unknownBytes.ToArray());

            btnIcon.Image = ItemParser.SetIcon(accessory);

            textBoxName.Text = accessory.Name;
            textBoxCase.Text = accessory.Case.ToString();
            textBoxModelIndex.Text = accessory.ModelIndex.ToString();
            textBoxIconIndex.Text = accessory.IconIndex.ToString();
            textBoxItemRank.Text = accessory.ItemRank.ToString();
            textBoxGroup.Text = accessory.Group.ToString();
            textBoxGrade.Text = accessory.Grade.ToString();

            textBoxLevel.Text = accessory.RequiredLevel.ToString();
            textBoxCon.Text = accessory.RequiredCon.ToString();
            textBoxEss.Text = accessory.RequiredEss.ToString();
            textBoxDex.Text = accessory.RequiredDex.ToString();
            textBoxStr.Text = accessory.RequiredStr.ToString();
            textBoxWis.Text = accessory.RequiredWis.ToString();

            textBoxTime.Text = accessory.Time.ToString();
            textBoxCashCheck.Text = accessory.CashCheck.ToString();
            textBoxPrice.Text = accessory.Price.ToString();
            textBoxItemSet.Text = accessory.ItemSet.ToString();
            textBoxMaxSockets.Text = accessory.MaxSockets.ToString();

            checkBoxDrop.Checked = accessory.BlockDrop;
            checkBoxNPC.Checked = accessory.CanNPC;
            checkBoxStore.Checked = accessory.BlockStorage;
            checkBoxTrade.Checked = accessory.CanTrade;

            dataGridView1.DataSource = accessory.Effects;
        }

        private void textBoxLevel_TextChanged(object sender, EventArgs e)
        {
            labelTxtLv.Text = Level.Get(Convert.ToInt16(textBoxLevel.Text));

            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.requiredLevel = Convert.ToByte(textBoxLevel.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ItemAccessory accessory = listBoxAccessories.SelectedItem as ItemAccessory;
            if (accessory == null) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value.ToString());
                accessory.Effects[e.RowIndex].Desc = XsdManager.EffectsInfo[id];
                accessory.Effects[e.RowIndex].Name = XsdManager.EffectsName[id];
            }
            catch { }
            Update();
        }

        private void FormAccessories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (listBoxAccessories.SelectedIndex > 0)
                    this.listBoxAccessories.SelectedIndex--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (listBoxAccessories.SelectedIndex < listBoxAccessories.Items.Count - 1)
                    this.listBoxAccessories.SelectedIndex++;
            }
        }

        private void textBoxModelIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.ModelIndex= Convert.ToInt16(textBoxModelIndex.Text);
              
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSecondaryType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.SecondType = Convert.ToSByte(tbSecondaryType.Text);
               comboBox2ndType.SelectedItem = (AccessorySecondType)relic.SecondType;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxIconIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.IconIndex = Convert.ToInt16(textBoxIconIndex.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxItemRank_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.ItemRank = Convert.ToUInt16(textBoxItemRank.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.group = Convert.ToInt16(textBoxGroup.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.itemCase = Convert.ToInt16(textBoxCase.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.Grade = Convert.ToByte
                    (textBoxGrade.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.requiredStr = Convert.ToInt16(textBoxStr.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxEss_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.requiredEss = Convert.ToInt16(textBoxEss.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxWis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.requiredWis = Convert.ToInt16(textBoxWis.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.requiredCon = Convert.ToInt16(textBoxCon.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxDex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.requiredDex = Convert.ToInt16(textBoxDex.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbKarma_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.Fame= Convert.ToByte(tbKarma.Text);
               comboBoxFame.SelectedItem = (FameValues)relic.Fame;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.Price = Convert.ToUInt32(textBoxPrice.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCashCheck_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.CashCheck = Convert.ToSByte(textBoxCashCheck.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.Time = Convert.ToInt16(textBoxTime.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxMaxSockets_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.maxSocket = Convert.ToByte(textBoxMaxSockets.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxItemSet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.itemSet = Convert.ToByte(textBoxItemSet.Text);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxDrop_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.BlockDrop = checkBoxDrop.Checked;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxTrade_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.BlockTrade = Convert.ToByte(checkBoxTrade.Checked);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBoxNPC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.BlockNpcSell = checkBoxNPC.Checked;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxStore_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                var relic = listBoxAccessories.SelectedItem as ItemAccessory;
                relic.BlockStorage = checkBoxStore.Checked;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
