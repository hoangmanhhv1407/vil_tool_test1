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
    public partial class FormClothes : Form
    {
        public FormClothes()
        {
            InitializeComponent();

            foreach (KeyValuePair<short, ItemCloth> it in ItemCloth.Clothes)
            {
                listBoxClothes.Items.Add(it.Value);
                listBoxClothes.DisplayMember = "FullName";
                listBoxClothes.ValueMember = "ID";
            }
        }

        private void FormClothes_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            byteViewer.Dock = DockStyle.Fill;
            this.tabPage2.Controls.Add(this.byteViewer);
            
        }

        private void listBoxClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCloth cloth = listBoxClothes.SelectedItem as ItemCloth;
            byteViewer.SetBytes(cloth.unknownBytes.ToArray());
            dataGridView1.DataSource = cloth.Effects;

            textBox1.Text = cloth.Type.ToString();
            textBox2.Text = cloth.SecondType.ToString();
            textBox3.Text = cloth.ModelIndex.ToString();
            textBox4.Text = cloth.clan.ToString();
            textBox5.Text = cloth.sex.ToString();
            textBox6.Text = cloth.ApplyClan.ToString();
            textBox7.Text = cloth.characGrade.ToString();
            textBox8.Text = cloth.IconIndex.ToString();
            textBox9.Text = cloth.precedence.ToString();
            textBox10.Text = cloth.ClanPoint1.ToString();
            textBox11.Text = cloth.ClanPoint2.ToString();
            textBox12.Text = cloth.itemCase.ToString();
            textBox13.Text = cloth.def.ToString();
            textBox14.Text = cloth.durability.ToString();
            textBox15.Text = cloth.itemSet.ToString();
            textBox16.Text = cloth.level.ToString();
            textBox17.Text = cloth.Grade.ToString();
            textBox18.Text = cloth.Price.ToString();
            textBox19.Text = cloth.ItemRank.ToString();
            textBox20.Text = cloth.slots.ToString();
            textBox21.Text = cloth.maxSlots.ToString();
            textBox22.Text = cloth.pockets.ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxClothes.Items.Clear();
            SortedDictionary<short, ItemCloth> map = null;
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        map = ItemCloth.Clothes;
                        break;
                    }
                case 1:
                    {
                        map = ItemCloth.Clothes2;
                        break;
                    }
                case 2:
                    {
                        map = ItemCloth.Clothes3;
                        break;
                    }
                default:
                    {
                        map = ItemCloth.Clothes;
                        break;
                    }
            }

            foreach (KeyValuePair<short, ItemCloth> it in map)
            {
                listBoxClothes.Items.Add(it.Value);
                listBoxClothes.DisplayMember = "FullName";
                listBoxClothes.ValueMember = "ID";
            }
        }

        private void FormClothes_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if (listBoxClothes.SelectedIndex > 0)
                    this.listBoxClothes.SelectedIndex--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (listBoxClothes.SelectedIndex < listBoxClothes.Items.Count - 1)
                    this.listBoxClothes.SelectedIndex++;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
           
            lbLevelDisplay.Text = Level.Get(Convert.ToInt16(textBox16.Text));
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.level = Convert.ToByte(textBox16.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.Type = Convert.ToSByte(textBox1.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.SecondType = Convert.ToSByte(textBox2.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.ModelIndex = Convert.ToInt16(textBox3.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.clan = Convert.ToSByte(textBox4.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.sex = Convert.ToByte(textBox5.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.ApplyClan = Convert.ToSByte(textBox6.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.characGrade = Convert.ToByte(textBox7.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.IconIndex = Convert.ToInt16(textBox8.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.precedence = Convert.ToSByte(textBox9.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.ClanPoint1 = Convert.ToInt32(textBox10.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.ClanPoint2 = Convert.ToInt32(textBox11.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.itemCase = Convert.ToInt16(textBox12.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.def = Convert.ToUInt16(textBox13.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.durability = Convert.ToUInt16(textBox14.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.itemSet = Convert.ToUInt16(textBox15.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.Grade = Convert.ToByte(textBox17.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.Price = Convert.ToUInt32(textBox18.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.ItemRank = Convert.ToUInt16(textBox19.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.slots = Convert.ToByte(textBox20.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.maxSlots = Convert.ToByte(textBox21.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cloth = listBoxClothes.SelectedItem as ItemCloth;
                cloth.pockets = Convert.ToByte(textBox22.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
