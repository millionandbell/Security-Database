namespace TestOfficerDBApp
{
    partial class allIncidentByname
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allIncidentByname));
            this.txt_searchname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.offendersBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.searchOffender = new TestOfficerDBApp.SearchOffender();
            this.offendersTableAdapter2 = new TestOfficerDBApp.SearchOffenderTableAdapters.offendersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.officerDBDataSet2 = new TestOfficerDBApp.officerDBDataSet2();
            this.officerDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOffender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_searchname
            // 
            this.txt_searchname.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_searchname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_searchname.Location = new System.Drawing.Point(103, 3);
            this.txt_searchname.Name = "txt_searchname";
            this.txt_searchname.Size = new System.Drawing.Size(316, 20);
            this.txt_searchname.TabIndex = 6;
            this.txt_searchname.TextChanged += new System.EventHandler(this.txt_searchname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Offender:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // offendersBindingSource7
            // 
            this.offendersBindingSource7.DataMember = "offenders";
            this.offendersBindingSource7.DataSource = this.searchOffender;
            this.offendersBindingSource7.CurrentChanged += new System.EventHandler(this.offendersBindingSource7_CurrentChanged);
            // 
            // searchOffender
            // 
            this.searchOffender.DataSetName = "SearchOffender";
            this.searchOffender.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offendersTableAdapter2
            // 
            this.offendersTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(994, 470);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // officerDBDataSet2
            // 
            this.officerDBDataSet2.DataSetName = "officerDBDataSet2";
            this.officerDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officerDBDataSet2BindingSource
            // 
            this.officerDBDataSet2BindingSource.DataSource = this.officerDBDataSet2;
            this.officerDBDataSet2BindingSource.Position = 0;
            this.officerDBDataSet2BindingSource.CurrentChanged += new System.EventHandler(this.officerDBDataSet2BindingSource_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(4, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 489);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // allIncidentByname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1009, 534);
            this.Controls.Add(this.txt_searchname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "allIncidentByname";
            this.Text = "Search All Incidents By Name";
            this.Load += new System.EventHandler(this.allIncidentByname_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOffender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource offendersBindingSource7;
        private SearchOffender searchOffender;
        private SearchOffenderTableAdapters.offendersTableAdapter offendersTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private officerDBDataSet2 officerDBDataSet2;
        private System.Windows.Forms.BindingSource officerDBDataSet2BindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}