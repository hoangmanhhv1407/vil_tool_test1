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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            foreach(ItemBook book in ItemBook.Books.Values)
            {
                listBoxBooks.Items.Add(book);
            }
            listBoxBooks.DisplayMember = "FullName";
            listBoxBooks.ValueMember = "ID";
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemBook book = listBoxBooks.SelectedItem as ItemBook;
            ItemBook[] list = { book };
            //dataGridView1.DataSource = list;
            tabPageUnknown.Controls.Add(byteViewer);
            byteViewer.Dock = DockStyle.Fill;
            byteViewer.SetBytes(book.unknownBytes.ToArray());

            textBoxSkillID.Text = book.SkillID.ToString();
            textBoxSkillLevel.Text = book.SkillLevel.ToString();
            textBoxSkillClass.Text = book.SkillClass.ToString();
            textBoxSkillGroup.Text = book.SkillGroup.ToString();
            textBoxSkillStep.Text = book.SkillStep.ToString();
            textBoxValue.Text = book.Value.ToString();
            textBoxAbilityID.Text = book.AbilityID.ToString();
            textBoxQuestID.Text = book.QuestID.ToString();
            textBoxClan.Text = book.Clan.ToString();
            textBoxClass.Text = book.Class.ToString();
            textBoxCharacGrade.Text = book.CharacterGrade.ToString();
        }

        #region --- Editing 
        private void textBoxSkillID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.skillID = Convert.ToUInt16(textBoxSkillID.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.value = Convert.ToByte(textBoxValue.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSkillGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.skillGroup = Convert.ToByte(textBoxSkillGroup.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSkillClass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.skillClass = Convert.ToByte(textBoxSkillClass.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSkillStep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.skillStep = Convert.ToSByte(textBoxSkillStep.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSkillLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.skillLevel= Convert.ToByte(textBoxSkillLevel.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAbilityID_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.abilityID = Convert.ToUInt16(textBoxAbilityID.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxQuestID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.questID = Convert.ToUInt16(textBoxQuestID.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxClan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.clan = Convert.ToByte(textBoxClan.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCharacGrade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.characGrade = Convert.ToByte(textBoxCharacGrade.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxClass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var book = listBoxBooks.SelectedItem as ItemBook;
                book.classID = Convert.ToByte(textBoxClass.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
