namespace ItemEditor
{
    partial class FormBooks
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
            this.components = new System.ComponentModel.Container();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSkillID = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSkillGroup = new System.Windows.Forms.TextBox();
            this.textBoxSkillClass = new System.Windows.Forms.TextBox();
            this.textBoxSkillStep = new System.Windows.Forms.TextBox();
            this.textBoxSkillLevel = new System.Windows.Forms.TextBox();
            this.textBoxAbilityID = new System.Windows.Forms.TextBox();
            this.textBoxQuestID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCharacGrade = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.tabPageUnknown = new System.Windows.Forms.TabPage();
            this.itemBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(0, 0);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(174, 353);
            this.listBoxBooks.TabIndex = 0;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageUnknown);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(174, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(362, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiết";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSkillID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSkillGroup, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSkillClass, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSkillStep, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSkillLevel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAbilityID, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuestID, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBoxClan, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCharacGrade, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelClass, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.textBoxClass, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "skillID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSkillID
            // 
            this.textBoxSkillID.Location = new System.Drawing.Point(78, 3);
            this.textBoxSkillID.Name = "textBoxSkillID";
            this.textBoxSkillID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkillID.TabIndex = 2;
            this.textBoxSkillID.TextChanged += new System.EventHandler(this.textBoxSkillID_TextChanged);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(78, 29);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 3;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "skillGroup";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "skillClass";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "skillStep";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "skillLevel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "abilityID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "questID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSkillGroup
            // 
            this.textBoxSkillGroup.Location = new System.Drawing.Point(78, 55);
            this.textBoxSkillGroup.Name = "textBoxSkillGroup";
            this.textBoxSkillGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkillGroup.TabIndex = 10;
            this.textBoxSkillGroup.TextChanged += new System.EventHandler(this.textBoxSkillGroup_TextChanged);
            // 
            // textBoxSkillClass
            // 
            this.textBoxSkillClass.Location = new System.Drawing.Point(78, 81);
            this.textBoxSkillClass.Name = "textBoxSkillClass";
            this.textBoxSkillClass.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkillClass.TabIndex = 11;
            this.textBoxSkillClass.TextChanged += new System.EventHandler(this.textBoxSkillClass_TextChanged);
            // 
            // textBoxSkillStep
            // 
            this.textBoxSkillStep.Location = new System.Drawing.Point(78, 107);
            this.textBoxSkillStep.Name = "textBoxSkillStep";
            this.textBoxSkillStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkillStep.TabIndex = 12;
            this.textBoxSkillStep.TextChanged += new System.EventHandler(this.textBoxSkillStep_TextChanged);
            // 
            // textBoxSkillLevel
            // 
            this.textBoxSkillLevel.Location = new System.Drawing.Point(78, 133);
            this.textBoxSkillLevel.Name = "textBoxSkillLevel";
            this.textBoxSkillLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkillLevel.TabIndex = 13;
            this.textBoxSkillLevel.TextChanged += new System.EventHandler(this.textBoxSkillLevel_TextChanged);
            // 
            // textBoxAbilityID
            // 
            this.textBoxAbilityID.Location = new System.Drawing.Point(78, 159);
            this.textBoxAbilityID.Name = "textBoxAbilityID";
            this.textBoxAbilityID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAbilityID.TabIndex = 14;
            this.textBoxAbilityID.TextChanged += new System.EventHandler(this.textBoxAbilityID_TextChanged);
            // 
            // textBoxQuestID
            // 
            this.textBoxQuestID.Location = new System.Drawing.Point(78, 185);
            this.textBoxQuestID.Name = "textBoxQuestID";
            this.textBoxQuestID.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuestID.TabIndex = 15;
            this.textBoxQuestID.TextChanged += new System.EventHandler(this.textBoxQuestID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "clan";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxClan
            // 
            this.textBoxClan.Location = new System.Drawing.Point(78, 211);
            this.textBoxClan.Name = "textBoxClan";
            this.textBoxClan.Size = new System.Drawing.Size(100, 20);
            this.textBoxClan.TabIndex = 17;
            this.textBoxClan.TextChanged += new System.EventHandler(this.textBoxClan_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "characGrade";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCharacGrade
            // 
            this.textBoxCharacGrade.Location = new System.Drawing.Point(78, 237);
            this.textBoxCharacGrade.Name = "textBoxCharacGrade";
            this.textBoxCharacGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCharacGrade.TabIndex = 19;
            this.textBoxCharacGrade.TextChanged += new System.EventHandler(this.textBoxCharacGrade_TextChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClass.Location = new System.Drawing.Point(3, 260);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(69, 26);
            this.labelClass.TabIndex = 20;
            this.labelClass.Text = "class";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(78, 263);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(100, 20);
            this.textBoxClass.TabIndex = 21;
            this.textBoxClass.TextChanged += new System.EventHandler(this.textBoxClass_TextChanged);
            // 
            // tabPageUnknown
            // 
            this.tabPageUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnknown.Name = "tabPageUnknown";
            this.tabPageUnknown.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageUnknown.Size = new System.Drawing.Size(362, 327);
            this.tabPageUnknown.TabIndex = 1;
            this.tabPageUnknown.Text = "Thông tin thêm";
            this.tabPageUnknown.UseVisualStyleBackColor = true;
            // 
            // itemBookBindingSource
            // 
            this.itemBookBindingSource.DataSource = typeof(ItemEditor.ItemBook);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 353);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBooks";
            this.ShowIcon = false;
            this.Text = "Sửa sách vở";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.ComponentModel.Design.ByteViewer byteViewer = new System.ComponentModel.Design.ByteViewer();
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageUnknown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSkillID;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSkillGroup;
        private System.Windows.Forms.TextBox textBoxSkillClass;
        private System.Windows.Forms.TextBox textBoxSkillStep;
        private System.Windows.Forms.TextBox textBoxSkillLevel;
        private System.Windows.Forms.TextBox textBoxAbilityID;
        private System.Windows.Forms.TextBox textBoxQuestID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCharacGrade;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canStoreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrib1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrib2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemBookBindingSource;
    }
}