namespace ItemEditor
{
    partial class FormResources
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelItemRank = new System.Windows.Forms.Label();
            this.textBoxItemRank = new System.Windows.Forms.TextBox();
            this.labelPackage = new System.Windows.Forms.Label();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelCashCheck = new System.Windows.Forms.Label();
            this.textBoxCashCheck = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTypeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxStore = new System.Windows.Forms.CheckBox();
            this.checkBoxNPC = new System.Windows.Forms.CheckBox();
            this.checkBoxTrade = new System.Windows.Forms.CheckBox();
            this.checkBoxDrop = new System.Windows.Forms.CheckBox();
            this.tabPageUnknown = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxResources
            // 
            this.listBoxResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.Location = new System.Drawing.Point(0, 0);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(233, 363);
            this.listBoxResources.TabIndex = 0;
            this.listBoxResources.SelectedIndexChanged += new System.EventHandler(this.listBoxResources_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageUnknown);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(233, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(235, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(227, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiết";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelItemRank, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxItemRank, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPackage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPackage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCashCheck, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCashCheck, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelTime, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTime, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTypeNo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGrade, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 331);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelItemRank
            // 
            this.labelItemRank.AutoSize = true;
            this.labelItemRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelItemRank.Location = new System.Drawing.Point(3, 0);
            this.labelItemRank.Name = "labelItemRank";
            this.labelItemRank.Size = new System.Drawing.Size(88, 26);
            this.labelItemRank.TabIndex = 0;
            this.labelItemRank.Text = "Item rank";
            this.labelItemRank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxItemRank
            // 
            this.textBoxItemRank.Location = new System.Drawing.Point(97, 3);
            this.textBoxItemRank.Name = "textBoxItemRank";
            this.textBoxItemRank.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemRank.TabIndex = 1;
            // 
            // labelPackage
            // 
            this.labelPackage.AutoSize = true;
            this.labelPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPackage.Location = new System.Drawing.Point(3, 26);
            this.labelPackage.Name = "labelPackage";
            this.labelPackage.Size = new System.Drawing.Size(88, 26);
            this.labelPackage.TabIndex = 2;
            this.labelPackage.Text = "Package number";
            this.labelPackage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Location = new System.Drawing.Point(97, 29);
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(100, 20);
            this.textBoxPackage.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(3, 52);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(88, 27);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(97, 55);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 5;
            // 
            // labelCashCheck
            // 
            this.labelCashCheck.AutoSize = true;
            this.labelCashCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCashCheck.Location = new System.Drawing.Point(3, 105);
            this.labelCashCheck.Name = "labelCashCheck";
            this.labelCashCheck.Size = new System.Drawing.Size(88, 26);
            this.labelCashCheck.TabIndex = 6;
            this.labelCashCheck.Text = "Cash check";
            this.labelCashCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCashCheck
            // 
            this.textBoxCashCheck.Location = new System.Drawing.Point(97, 108);
            this.textBoxCashCheck.Name = "textBoxCashCheck";
            this.textBoxCashCheck.Size = new System.Drawing.Size(100, 20);
            this.textBoxCashCheck.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Location = new System.Drawing.Point(3, 79);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(88, 26);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(97, 82);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "TypeNo.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTypeNo
            // 
            this.textBoxTypeNo.Location = new System.Drawing.Point(97, 134);
            this.textBoxTypeNo.Name = "textBoxTypeNo";
            this.textBoxTypeNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeNo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Grade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(97, 160);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxStore);
            this.tabPage2.Controls.Add(this.checkBoxNPC);
            this.tabPage2.Controls.Add(this.checkBoxTrade);
            this.tabPage2.Controls.Add(this.checkBoxDrop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(227, 337);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Lựa chọn khác";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxStore
            // 
            this.checkBoxStore.AutoSize = true;
            this.checkBoxStore.Location = new System.Drawing.Point(6, 78);
            this.checkBoxStore.Name = "checkBoxStore";
            this.checkBoxStore.Size = new System.Drawing.Size(71, 17);
            this.checkBoxStore.TabIndex = 3;
            this.checkBoxStore.Text = "Can store";
            this.checkBoxStore.UseVisualStyleBackColor = true;
            // 
            // checkBoxNPC
            // 
            this.checkBoxNPC.AutoSize = true;
            this.checkBoxNPC.Location = new System.Drawing.Point(6, 54);
            this.checkBoxNPC.Name = "checkBoxNPC";
            this.checkBoxNPC.Size = new System.Drawing.Size(100, 17);
            this.checkBoxNPC.TabIndex = 2;
            this.checkBoxNPC.Text = "Can sell to NPC";
            this.checkBoxNPC.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrade
            // 
            this.checkBoxTrade.AutoSize = true;
            this.checkBoxTrade.Location = new System.Drawing.Point(6, 30);
            this.checkBoxTrade.Name = "checkBoxTrade";
            this.checkBoxTrade.Size = new System.Drawing.Size(72, 17);
            this.checkBoxTrade.TabIndex = 1;
            this.checkBoxTrade.Text = "Can trade";
            this.checkBoxTrade.UseVisualStyleBackColor = true;
            // 
            // checkBoxDrop
            // 
            this.checkBoxDrop.AutoSize = true;
            this.checkBoxDrop.Location = new System.Drawing.Point(6, 6);
            this.checkBoxDrop.Name = "checkBoxDrop";
            this.checkBoxDrop.Size = new System.Drawing.Size(69, 17);
            this.checkBoxDrop.TabIndex = 0;
            this.checkBoxDrop.Text = "Can drop";
            this.checkBoxDrop.UseVisualStyleBackColor = true;
            // 
            // tabPageUnknown
            // 
            this.tabPageUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnknown.Name = "tabPageUnknown";
            this.tabPageUnknown.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageUnknown.Size = new System.Drawing.Size(227, 337);
            this.tabPageUnknown.TabIndex = 1;
            this.tabPageUnknown.Text = "Thông tin thêm";
            this.tabPageUnknown.UseVisualStyleBackColor = true;
            // 
            // FormResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 363);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxResources);
            this.Name = "FormResources";
            this.ShowIcon = false;
            this.Text = "Thu thập";
            this.Load += new System.EventHandler(this.FormResources_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormResources_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageUnknown;
        private System.ComponentModel.Design.ByteViewer byteViewer = new System.ComponentModel.Design.ByteViewer();
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelItemRank;
        private System.Windows.Forms.TextBox textBoxItemRank;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxStore;
        private System.Windows.Forms.CheckBox checkBoxNPC;
        private System.Windows.Forms.CheckBox checkBoxTrade;
        private System.Windows.Forms.CheckBox checkBoxDrop;
        private System.Windows.Forms.Label labelPackage;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelCashCheck;
        private System.Windows.Forms.TextBox textBoxCashCheck;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTypeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGrade;
    }
}