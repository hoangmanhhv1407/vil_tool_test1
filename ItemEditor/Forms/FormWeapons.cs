using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using ItemEditor.XStringDatabase;
using System.Resources;

namespace ItemEditor
{
    public partial class FormWeapons : Form
    {
        public FormWeapons()
        {
            InitializeComponent();
            List<ItemWeapon> weaponsList = ItemWeapon.Weapons.Values.ToList();
           
            foreach (KeyValuePair<short,ItemWeapon> it in ItemWeapon.Weapons)
            {
                listBoxWeap.Items.Add(it.Value);
                listBoxWeap.DisplayMember = "FullName";
                listBoxWeap.ValueMember = "ID";
            }
            //MessageBox.Show(header.Datetime.GetDate());
        }

        private void listBoxWeap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBoxLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelTextLevel.Text = Level.Get(Convert.ToInt16(textBoxLevel.Text));
            }
            catch { }
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.level = Convert.ToByte(textBoxLevel.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /*
        private void buttonLoadIcon_Click(object sender, EventArgs e)
        {
            int idx = Convert.ToInt32(this.textBoxIcon.Text);
            int col = --idx % 8;
            int row = idx / 8;
            Button btn = sender as Button;
            btn.Text = "";
            btn.Width = 32;
            btn.Height = 32;
            Rectangle r = new Rectangle(col*32, row*32, 32, 32);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
                btn.Image = CropImage(new Bitmap(ofd.FileName), r);
        } */
        
        private void comboBoxWep_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxWeap.Items.Clear();
            SortedDictionary<short, ItemWeapon> map = null;

            switch(comboBoxWep.SelectedIndex)
            {
                case 0:
                    {
                        map = ItemWeapon.Weapons;
                        break;
                    }
                case 1:
                    {
                        map = ItemWeapon.Weapons2;
                        break;
                    }
                case 2:
                    {
                        map = ItemWeapon.Weapons3;
                        break;
                    }
                default:
                    {
                        map = ItemWeapon.Weapons;
                        break;
                    }
            }

            foreach (KeyValuePair<short, ItemWeapon> it in map)
            {
                listBoxWeap.Items.Add(it.Value);
                listBoxWeap.DisplayMember = "FullName";
                listBoxWeap.ValueMember = "ID";
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (listBoxWeap.SelectedItem != null)
            {
                listBoxWeap.Items.Add(new ItemWeapon(listBoxWeap.SelectedItem as ItemWeapon));
            }
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ItemWeapon weapon = listBoxWeap.SelectedItem as ItemWeapon;
            if (weapon == null) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value.ToString());
                weapon.effects[e.RowIndex].Desc = XsdManager.EffectsInfo[id];
                weapon.effects[e.RowIndex].Name = XsdManager.EffectsName[id];
            }
            catch { }
            Update();
        }

        private void tabBasicInfo_Click(object sender, EventArgs e)
        {

        }

        private void listBoxWeap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.listBoxWeap.SelectedIndex--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.listBoxWeap.SelectedIndex++;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormWeapons_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode == Keys.Up)
            {
                if(listBoxWeap.SelectedIndex>0)
                this.listBoxWeap.SelectedIndex--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if(listBoxWeap.SelectedIndex<listBoxWeap.Items.Count-1)
                this.listBoxWeap.SelectedIndex++;
            }

        }
        ItemWeapon weapon;
        private void listBoxWeap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //clear boxes
            comboBoxAddTo.Items.Clear();
            comboBoxNickname.Items.Clear();

            weapon = listBoxWeap.SelectedItem as ItemWeapon;

            foreach (KeyValuePair<int, string> pair in XsdManager.AddTos)
            {
                comboBoxAddTo.Items.Add(pair);
            }
            comboBoxAddTo.DisplayMember = "Value";
            comboBoxAddTo.ValueMember = "Key";

            foreach (KeyValuePair<int, string> pair in XsdManager.Nicknames)
            {
                comboBoxNickname.Items.Add(pair);
            }
            comboBoxNickname.DisplayMember = "Value";
            comboBoxNickname.ValueMember = "Key";

            comboBoxAddTo.SelectedValue = weapon.xsdAddTo;
            comboBoxNickname.SelectedValue = weapon.xsdNick;

            textBoxXSDindex.Text = weapon.xsdName.ToString();

            //dataGridView2.DataSource = weapon;
            dataGridView1.DataSource = weapon.effects;
            textBoxName.Text = weapon.Name;
            textBoxLevel.Text = weapon.level.ToString();
            textBoxMainStat.Text = weapon.mainStat.ToString();
            textBoxSecondaryStat.Text = weapon.secondaryStat.ToString();
            labelTextLevel.Text = Level.Get(weapon.level);
            textBoxMinDmg.Text = weapon.minDmg.ToString();
            textBoxMaxDmg.Text = weapon.maxDmg.ToString();
            textBoxDurability.Text = (weapon.durabiliy / 100).ToString();
            textBoxBalance.Text = weapon.balance.ToString();
            textBoxAR.Text = weapon.attackRate.ToString();
            textBoxCrit.Text = weapon.critRate.ToString();

            textBoxHardness.Text = weapon.hardness.ToString();
            textBoxTears.Text = "?";
            //textBoxTears.Text = weapon.tears.ToString();

            textBoxPrice.Text = weapon.Price.ToString();

            textBoxSockets.Text = weapon.sockets.ToString();
            textBoxRank.Text = weapon.rank.ToString();
            //textBoxModel.Text = weapon.ModelIndex.ToString();
            textBoxIcon.Text = weapon.IconIndex.ToString();

            textBoxLvlRed.Text = weapon.reduceLevel.ToString();
            textBoxContribClan.Text = weapon.ClanPoint1.ToString();
            textBoxContribOthers.Text = weapon.ClanPoint2.ToString();
            textBoxTime.Text = weapon.Time.ToString();
            textBoxMaxSlots.Text = weapon.maxSlots.ToString();

            textBoxCashCheck.Text = weapon.CashCheck.ToString();
            checkBoxCantNPC.Checked = !weapon.CanNPC;
            checkBoxCantTrade.Checked = !weapon.CanTrade;
            checkBoxCantStorage.Checked = !weapon.BlockStorage;
            checkBoxStatsTrade.Checked = weapon.statTrade;

            buttonLoadIcon.Text = "";
            buttonLoadIcon.ImageAlign = ContentAlignment.MiddleCenter;
            buttonLoadIcon.Width = 32;
            buttonLoadIcon.Height = 32;
            buttonLoadIcon.Image = ItemParser.SetIcon(weapon);
            listBoxEffects.Items.Clear();
            foreach (Effect eff in weapon.effects)
            {
                listBoxEffects.Items.Add(eff);
                listBoxEffects.ValueMember = "ID";
                listBoxEffects.DisplayMember = "Description";
            }

            textBox1.Text = "";
            textBox1.Multiline = true;
            foreach (VectorPos pos in weapon.vecItemPosition)
            {
                textBox1.Text += string.Format("x: {0}\ty: {1}\tz: {2}\r\n", pos.x, pos.y, pos.z);

            }

            byteViewer.SetBytes(weapon.unknownBytes.ToArray());

            WeaponSecondType type = (WeaponSecondType)weapon.SecondType;
            comboBoxWeaponType.SelectedIndex = comboBoxWeaponType.FindStringExact(type.ToString());
            comboBoxWeaponThirdType.Items.Clear();
            Type t = typeof(ThirdTypeWeaponShort);
            switch (type)
            {
                case WeaponSecondType.SHORT:
                    {
                        t = typeof(ThirdTypeWeaponShort);
                        break;
                    }
                case WeaponSecondType.LONG:
                    {
                        t = typeof(ThirdTypeWeaponLong);
                        break;
                    }
                case WeaponSecondType.SOFT:
                    {
                        t = typeof(ThirdTypeWeaponSoft);
                        break;
                    }
                case WeaponSecondType.HIDDEN:
                    {
                        t = typeof(ThirdTypeWeaponHidden);
                        break;
                    }
                case WeaponSecondType.MUSICAL:
                    {
                        t = typeof(ThirdTypeWeaponMusical);
                        break;
                    }
                case WeaponSecondType.SPECIAL:
                    {
                        t = typeof(ThirdTypeWeaponSpecial);
                        break;
                    }
            }
            foreach (var it in Enum.GetValues(t))
                comboBoxWeaponThirdType.Items.Add(it);

            comboBoxWeaponThirdType.SelectedIndex = weapon.thirdType;
        }

        private void FormWeapons_Load(object sender, EventArgs e)
        {

        }

        #region --- Editing Textboxes
        private void textBoxMinDmg_Leave(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.minDmg = Convert.ToInt16(textBoxMinDmg.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxMaxDmg_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.maxDmg = Convert.ToInt16(textBoxMaxDmg.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxDurability_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.durabiliy= Convert.ToUInt16(textBoxDurability.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.ModelIndex = Convert.ToInt16(textBoxModel.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSockets_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.sockets = Convert.ToByte(textBoxSockets.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxMaxSlots_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.maxSlots = Convert.ToByte(textBoxMaxSlots.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxMainStat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.mainStat = Convert.ToInt16(textBoxMainStat.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSecondaryStat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.secondaryStat= Convert.ToInt16(textBoxSecondaryStat.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.balance = Convert.ToSByte(textBoxBalance.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.attackRate = Convert.ToSByte(textBoxAR.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCrit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
              weapon.critRate = Convert.ToInt16(textBoxCrit.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxHardness_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.hardness = Convert.ToSByte(textBoxHardness.Text);
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
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.Price = Convert.ToUInt32(textBoxPrice.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxRank_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.rank = Convert.ToSByte(textBoxRank.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxIcon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.IconIndex= Convert.ToInt16(textBoxIcon.Text);
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
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.Time = Convert.ToInt16(textBoxTime.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxContribClan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.ClanPoint1 = Convert.ToInt32(textBoxContribClan.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxContribOthers_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.ClanPoint2 = Convert.ToInt32(textBoxContribOthers.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxLvlRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.reduceLevel= Convert.ToByte(textBoxLvlRed.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region ---Editing Additional Options
        private void checkBoxCantNPC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.BlockNpcSell = checkBoxCantNPC.Checked;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxCantStorage_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.BlockStorage = checkBoxCantStorage.Checked;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxCantTrade_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.BlockTrade = Convert.ToByte(checkBoxCantTrade.Checked);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxStatsTrade_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var weapon = listBoxWeap.SelectedItem as ItemWeapon;
                weapon.statTrade = checkBoxStatsTrade.Checked;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
