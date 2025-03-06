namespace ItemEditor
{
    partial class FormItemRanks
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxRanks = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canNPCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canTradeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cashCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyClanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxRanks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(759, 344);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxRanks
            // 
            this.listBoxRanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRanks.FormattingEnabled = true;
            this.listBoxRanks.Location = new System.Drawing.Point(0, 0);
            this.listBoxRanks.Name = "listBoxRanks";
            this.listBoxRanks.Size = new System.Drawing.Size(121, 344);
            this.listBoxRanks.TabIndex = 0;
            this.listBoxRanks.SelectedIndexChanged += new System.EventHandler(this.listBoxRanks_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemRankDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.secondTypeDataGridViewTextBoxColumn,
            this.modelIndexDataGridViewTextBoxColumn,
            this.iconIndexDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn,
            this.quality2DataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.canNPCDataGridViewCheckBoxColumn,
            this.canTradeDataGridViewCheckBoxColumn,
            this.cashCheckDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.applyClanDataGridViewTextBoxColumn,
            this.fameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBaseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemRankDataGridViewTextBoxColumn
            // 
            this.itemRankDataGridViewTextBoxColumn.DataPropertyName = "ItemRank";
            this.itemRankDataGridViewTextBoxColumn.HeaderText = "ItemRank";
            this.itemRankDataGridViewTextBoxColumn.Name = "itemRankDataGridViewTextBoxColumn";
            this.itemRankDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemRankDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondTypeDataGridViewTextBoxColumn
            // 
            this.secondTypeDataGridViewTextBoxColumn.DataPropertyName = "SecondType";
            this.secondTypeDataGridViewTextBoxColumn.HeaderText = "SecondType";
            this.secondTypeDataGridViewTextBoxColumn.Name = "secondTypeDataGridViewTextBoxColumn";
            this.secondTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelIndexDataGridViewTextBoxColumn
            // 
            this.modelIndexDataGridViewTextBoxColumn.DataPropertyName = "ModelIndex";
            this.modelIndexDataGridViewTextBoxColumn.HeaderText = "ModelIndex";
            this.modelIndexDataGridViewTextBoxColumn.Name = "modelIndexDataGridViewTextBoxColumn";
            this.modelIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iconIndexDataGridViewTextBoxColumn
            // 
            this.iconIndexDataGridViewTextBoxColumn.DataPropertyName = "IconIndex";
            this.iconIndexDataGridViewTextBoxColumn.HeaderText = "IconIndex";
            this.iconIndexDataGridViewTextBoxColumn.Name = "iconIndexDataGridViewTextBoxColumn";
            this.iconIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            this.qualityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quality2DataGridViewTextBoxColumn
            // 
            this.quality2DataGridViewTextBoxColumn.DataPropertyName = "Quality2";
            this.quality2DataGridViewTextBoxColumn.HeaderText = "Quality2";
            this.quality2DataGridViewTextBoxColumn.Name = "quality2DataGridViewTextBoxColumn";
            this.quality2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // canNPCDataGridViewCheckBoxColumn
            // 
            this.canNPCDataGridViewCheckBoxColumn.DataPropertyName = "CanNPC";
            this.canNPCDataGridViewCheckBoxColumn.HeaderText = "CanNPC";
            this.canNPCDataGridViewCheckBoxColumn.Name = "canNPCDataGridViewCheckBoxColumn";
            this.canNPCDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // canTradeDataGridViewCheckBoxColumn
            // 
            this.canTradeDataGridViewCheckBoxColumn.DataPropertyName = "CanTrade";
            this.canTradeDataGridViewCheckBoxColumn.HeaderText = "CanTrade";
            this.canTradeDataGridViewCheckBoxColumn.Name = "canTradeDataGridViewCheckBoxColumn";
            this.canTradeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cashCheckDataGridViewTextBoxColumn
            // 
            this.cashCheckDataGridViewTextBoxColumn.DataPropertyName = "CashCheck";
            this.cashCheckDataGridViewTextBoxColumn.HeaderText = "CashCheck";
            this.cashCheckDataGridViewTextBoxColumn.Name = "cashCheckDataGridViewTextBoxColumn";
            this.cashCheckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applyClanDataGridViewTextBoxColumn
            // 
            this.applyClanDataGridViewTextBoxColumn.DataPropertyName = "ApplyClan";
            this.applyClanDataGridViewTextBoxColumn.HeaderText = "ApplyClan";
            this.applyClanDataGridViewTextBoxColumn.Name = "applyClanDataGridViewTextBoxColumn";
            this.applyClanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fameDataGridViewTextBoxColumn
            // 
            this.fameDataGridViewTextBoxColumn.DataPropertyName = "Fame";
            this.fameDataGridViewTextBoxColumn.HeaderText = "Fame";
            this.fameDataGridViewTextBoxColumn.Name = "fameDataGridViewTextBoxColumn";
            this.fameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBaseBindingSource
            // 
            this.itemBaseBindingSource.DataSource = typeof(ItemEditor.ItemBase);
            // 
            // FormItemRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 344);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormItemRanks";
            this.Text = "ItemRanks";
            this.Load += new System.EventHandler(this.FormItemRanks_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxRanks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemBaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iconIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canStoreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canNPCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canTradeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyClanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrib1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrib2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fameDataGridViewTextBoxColumn;
    }
}