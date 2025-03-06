using ItemEditor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace ItemEditor
{
    public partial class frmMain : Form
    {
        string Filename = "item_table.bit";
        string nameFile = "NDTEXTDB_US.XSD";
        string patch_index = ".\\Main\\item_table.bit";
        string indexXSD = ".\\Main\\NDTEXTDB_US.XSD";
        string folder = @".\\" + DateAndTime.Now.Date.ToString("yyyyMMdd") + "";
        ItemTableHeader header = new ItemTableHeader();
        public frmMain()
        {
            InitializeComponent();
            if (false == File.Exists(patch_index))
            {
                MessageBox.Show("File '" + Filename + "' không tìm thấy. Bạn có muốn tiêp tục?", "Fail to load item_table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (false == File.Exists(indexXSD))
            {
                MessageBox.Show("File '" + nameFile + "' không tìm thấy", "Fail to load NDTEXTDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                Stream str = File.Open(System.IO.Path.GetFullPath(patch_index), FileMode.Open);
                header.Load(str);
            }
        }
        private void btnWep_Click(object sender, EventArgs e)
        {
            new FormWeapons().Show();
        }
        private void btnCloth_Click(object sender, EventArgs e)
        {
            new FormClothes().Show();
        }
        private void btnElixirs_Click(object sender, EventArgs e)
        {
            new FormElixirs().Show();
        }
        private void btnAccessories_Click(object sender, EventArgs e)
        {
            new FormAccessories().Show();
        }
        private void btnPasses_Click(object sender, EventArgs e)
        {
            new FormPasses().Show();
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            new FormBooks().Show();
        }
        private void btnResources_Click(object sender, EventArgs e)
        {
            new FormResources().Show();
        }
        private void btnFindItem_Click(object sender, EventArgs e)
        {
            try
            {
                ushort itrank = Convert.ToUInt16(textBoxFindItemRank.Text);
                string items = "";
                if (ItemParser.ItemRanks.ContainsKey(itrank))
                {
                    foreach (ItemBase b in ItemParser.ItemRanks[itrank]) items += b.FullName + '\n';
                }
                else items = "Not found";
                MessageBox.Show(items);
            }
            catch { MessageBox.Show("Invalid Input"); }
        }
        private void btnAllRanks_Click(object sender, EventArgs e)
        {
            new FormItemRanks().Show();
        }
        private void btnLifes_Click(object sender, EventArgs e)
        {
            new FormLifes().Show();
        }
        private void btnPotions_Click(object sender, EventArgs e)
        {
            new FormPotion().Show(); 
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "" + Filename + "";
            header.Save(sv.OpenFile());
            backup();
        }
        private void backup()
        {
            if (!File.Exists(Filename))
            {
                MessageBox.Show("File not found: "+ Filename,"File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string backup_path = Filename + ".1";
            for (int i = 2; File.Exists(backup_path); i++)
                backup_path = Filename + "." + i.ToString();
                    
            try
            {
                File.Copy(Filename, backup_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
