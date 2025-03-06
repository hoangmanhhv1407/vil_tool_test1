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
    public partial class FormElixirs : Form
    {
        public FormElixirs()
        {
            InitializeComponent();
        }

        private void FormElixirs_Load(object sender, EventArgs e)
        {
            tabPageUnknown.Controls.Add(byteViewer);
            byteViewer.Dock = DockStyle.Fill;

            foreach (KeyValuePair<short, ItemElixir> pair in ItemElixir.Elixirs)
                listBoxElixirs.Items.Add(pair.Value);
            listBoxElixirs.DisplayMember = "FullName";
            listBoxElixirs.ValueMember = "ID";

            foreach(var t in Enum.GetValues(typeof(ElixirSecondType)))
            {
                comboBoxSecondType.Items.Add(t);
            }
        }

        private void listBoxElixirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemElixir elixir = listBoxElixirs.SelectedItem as ItemElixir;
            comboBoxSecondType.SelectedIndex = elixir.SecondType;
            comboBoxThirdType.SelectedIndex = elixir.ThirdType;
            textBoxName.Text = elixir.Name;
            byteViewer.SetBytes(elixir.unknownBytes.ToArray());
            textBoxLevel.Text = elixir.Level.ToString();
            labelTxtLv.Text = Level.Get(elixir.Level);
            textBoxMinValue.Text = elixir.MinValue.ToString();
            textBoxMaxValue.Text = elixir.MaxValue.ToString();
            textBoxPrice.Text = elixir.Price.ToString();
            textBoxStep.Text = elixir.Step.ToString();
            textBoxIntox.Text = elixir.Intoxication.ToString();

            btnIcon.Image = ItemParser.SetIcon(elixir);

            //strange stuff here
            textBoxThirdType.Text = elixir.ThirdType.ToString();
            //test map
            if (XsdManager.mapelixirs.Count == 0) XsdManager.GetDataTo(XsdManager.Maps["ElixirName"], "ItemTable_SeedElixir");
            textBoxName.Text = XsdManager.Maps["ElixirName"][(int)(elixir.xsdName)];
            textBoxXsdName.Text = elixir.xsdName.ToString();
            textBoxXsdInfo.Text = elixir.xsdInfo.ToString();
            textBoxGrade.Text = elixir.Grade.ToString();
            textBoxQuality.Text = elixir.Quality.ToString();
            textBoxQuality2.Text = elixir.Quality2.ToString();
            textBoxItemRank.Text = elixir.ItemRank.ToString();
            textBoxModelIndex.Text = elixir.ModelIndex.ToString();
            textBoxIconIndex.Text = elixir.IconIndex.ToString();

            textBoxVisual.Text = elixir.VisualEffect.ToString();
            textBoxClan.Text = elixir.ApplyClan.ToString();
            textBoxContrib1.Text = elixir.ClanPoint1.ToString();
            textBoxContrib2.Text = elixir.ClanPoint2.ToString();
            textBoxSuccess.Text = elixir.SuccessRate.ToString();
            textBoxCooldown.Text = elixir.Cooldown.ToString();

            checkBoxSell.Checked = elixir.CanNPC;
            checkBoxStore.Checked = elixir.BlockStorage;
            checkBoxTrade.Checked = elixir.CanTrade;
        }
    }
}
