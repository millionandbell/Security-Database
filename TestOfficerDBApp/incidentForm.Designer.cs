namespace TestOfficerDBApp
{
    partial class incidentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.submitBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.officerDBDataSet1 = new TestOfficerDBApp.officerDBDataSet();
            this.officernamebox = new System.Windows.Forms.ComboBox();
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersTableAdapter = new TestOfficerDBApp.officerDBDataSetTableAdapters.officersTableAdapter();
            this.officerDBDataSet11 = new TestOfficerDBApp.officerDBDataSet1();
            this.offendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offendersTableAdapter = new TestOfficerDBApp.officerDBDataSet1TableAdapters.offendersTableAdapter();
            this.officerDBDataSet2 = new TestOfficerDBApp.officerDBDataSet2();
            this.offendersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.offendersTableAdapter1 = new TestOfficerDBApp.officerDBDataSet2TableAdapters.offendersTableAdapter();
            this.officersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new TestOfficerDBApp.officerDBDataSet1TableAdapters.TableAdapterManager();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.offendertext = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.offendernamebox = new System.Windows.Forms.TextBox();
            this.offenderidbox = new System.Windows.Forms.TextBox();
            this.officeridbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Incident Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Offender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Officer Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(15, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(751, 195);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Incident Type";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(691, 13);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 18;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(691, 61);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 19;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // officerDBDataSet1
            // 
            this.officerDBDataSet1.DataSetName = "officerDBDataSet";
            this.officerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officernamebox
            // 
            this.officernamebox.DataSource = this.officersBindingSource;
            this.officernamebox.DisplayMember = "LastName";
            this.officernamebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officernamebox.FormattingEnabled = true;
            this.officernamebox.Location = new System.Drawing.Point(103, 15);
            this.officernamebox.Name = "officernamebox";
            this.officernamebox.Size = new System.Drawing.Size(226, 21);
            this.officernamebox.TabIndex = 20;
            this.officernamebox.ValueMember = "officerID";
            // 
            // officersBindingSource
            // 
            this.officersBindingSource.DataMember = "officers";
            this.officersBindingSource.DataSource = this.officerDBDataSet1BindingSource;
            // 
            // officerDBDataSet1BindingSource
            // 
            this.officerDBDataSet1BindingSource.DataSource = this.officerDBDataSet1;
            this.officerDBDataSet1BindingSource.Position = 0;
            // 
            // officersTableAdapter
            // 
            this.officersTableAdapter.ClearBeforeFill = true;
            // 
            // officerDBDataSet11
            // 
            this.officerDBDataSet11.DataSetName = "officerDBDataSet1";
            this.officerDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offendersBindingSource
            // 
            this.offendersBindingSource.DataMember = "offenders";
            this.offendersBindingSource.DataSource = this.officerDBDataSet11;
            // 
            // offendersTableAdapter
            // 
            this.offendersTableAdapter.ClearBeforeFill = true;
            // 
            // officerDBDataSet2
            // 
            this.officerDBDataSet2.DataSetName = "officerDBDataSet2";
            this.officerDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offendersBindingSource1
            // 
            this.offendersBindingSource1.DataMember = "offenders";
            this.offendersBindingSource1.DataSource = this.officerDBDataSet2;
            // 
            // offendersTableAdapter1
            // 
            this.offendersTableAdapter1.ClearBeforeFill = true;
            // 
            // officersBindingSource1
            // 
            this.officersBindingSource1.DataMember = "officers";
            this.officersBindingSource1.DataSource = this.officerDBDataSet1BindingSource;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.offendersTableAdapter = this.offendersTableAdapter;
            this.tableAdapterManager1.UpdateOrder = TestOfficerDBApp.officerDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.officersBindingSource;
            this.comboBox2.DisplayMember = "LastName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(421, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "LastName";
            // 
            // offendertext
            // 
            this.offendertext.Location = new System.Drawing.Point(103, 66);
            this.offendertext.Name = "offendertext";
            this.offendertext.Size = new System.Drawing.Size(226, 20);
            this.offendertext.TabIndex = 22;
            this.offendertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(312, 82);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Offender";
            // 
            // offendernamebox
            // 
            this.offendernamebox.Location = new System.Drawing.Point(421, 63);
            this.offendernamebox.Name = "offendernamebox";
            this.offendernamebox.Size = new System.Drawing.Size(204, 20);
            this.offendernamebox.TabIndex = 25;
            // 
            // offenderidbox
            // 
            this.offenderidbox.Location = new System.Drawing.Point(421, 108);
            this.offenderidbox.Name = "offenderidbox";
            this.offenderidbox.Size = new System.Drawing.Size(100, 20);
            this.offenderidbox.TabIndex = 26;
            this.offenderidbox.TextChanged += new System.EventHandler(this.offenderidbox_TextChanged);
            // 
            // officeridbox
            // 
            this.officeridbox.Location = new System.Drawing.Point(421, 153);
            this.officeridbox.Name = "officeridbox";
            this.officeridbox.Size = new System.Drawing.Size(100, 20);
            this.officeridbox.TabIndex = 27;
            this.officeridbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // incidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.officeridbox);
            this.Controls.Add(this.offenderidbox);
            this.Controls.Add(this.offendernamebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.offendertext);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.officernamebox);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "incidentForm";
            this.RightToLeftLayout = true;
            this.Text = "Add Incident Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button exitBTN;
        private officerDBDataSet officerDBDataSet1;
        private System.Windows.Forms.ComboBox officernamebox;
        private System.Windows.Forms.BindingSource officerDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource officersBindingSource;
        private officerDBDataSetTableAdapters.officersTableAdapter officersTableAdapter;
        private officerDBDataSet1 officerDBDataSet11;
        private System.Windows.Forms.BindingSource offendersBindingSource;
        private officerDBDataSet1TableAdapters.offendersTableAdapter offendersTableAdapter;
        private officerDBDataSet2 officerDBDataSet2;
        private System.Windows.Forms.BindingSource offendersBindingSource1;
        private officerDBDataSet2TableAdapters.offendersTableAdapter offendersTableAdapter1;
        private System.Windows.Forms.BindingSource officersBindingSource1;
        private officerDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox offendertext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox offendernamebox;
        private System.Windows.Forms.TextBox offenderidbox;
        private System.Windows.Forms.TextBox officeridbox;
    }
}