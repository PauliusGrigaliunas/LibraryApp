namespace Library
{
    partial class SkaitytojoLangas
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
            this.tableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.knygosDataSet1 = new Library.KnygosDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Library.KnygosDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Library.KnygosDataSet1TableAdapters.TableAdapterManager();
            this.knygosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.libraryDataDataSet = new Library.LibraryDataDataSet();
            this.knygosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knygosTableAdapter = new Library.LibraryDataDataSetTableAdapters.KnygosTableAdapter();
            this.tableAdapterManager1 = new Library.LibraryDataDataSetTableAdapters.TableAdapterManager();
            this.knygosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knygosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBindingSource3
            // 
            this.tableBindingSource3.DataMember = "Table";
            this.tableBindingSource3.DataSource = this.knygosDataSet1;
            // 
            // knygosDataSet1
            // 
            this.knygosDataSet1.DataSetName = "KnygosDataSet1";
            this.knygosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rezervuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.knygosDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.KnygosDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // knygosDataSet1BindingSource
            // 
            this.knygosDataSet1BindingSource.DataSource = this.knygosDataSet1;
            this.knygosDataSet1BindingSource.Position = 0;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.knygosDataSet1;
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.knygosDataSet1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Paieška";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Užsakyti į namus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // libraryDataDataSet
            // 
            this.libraryDataDataSet.DataSetName = "LibraryDataDataSet";
            this.libraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knygosBindingSource
            // 
            this.knygosBindingSource.DataMember = "Knygos";
            this.knygosBindingSource.DataSource = this.libraryDataDataSet;
            // 
            // knygosTableAdapter
            // 
            this.knygosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.KnygosTableAdapter = this.knygosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Library.LibraryDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VartotojaiTableAdapter = null;
            // 
            // knygosDataGridView
            // 
            this.knygosDataGridView.AutoGenerateColumns = false;
            this.knygosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knygosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.knygosDataGridView.DataSource = this.knygosBindingSource;
            this.knygosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.knygosDataGridView.Name = "knygosDataGridView";
            this.knygosDataGridView.RowTemplate.Height = 24;
            this.knygosDataGridView.Size = new System.Drawing.Size(556, 395);
            this.knygosDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Autorius";
            this.dataGridViewTextBoxColumn2.HeaderText = "Autorius";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // knygosDataGridView1
            // 
            this.knygosDataGridView1.AutoGenerateColumns = false;
            this.knygosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knygosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.knygosDataGridView1.DataSource = this.knygosBindingSource;
            this.knygosDataGridView1.Location = new System.Drawing.Point(12, 437);
            this.knygosDataGridView1.Name = "knygosDataGridView1";
            this.knygosDataGridView1.RowTemplate.Height = 24;
            this.knygosDataGridView1.Size = new System.Drawing.Size(556, 220);
            this.knygosDataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Autorius";
            this.dataGridViewTextBoxColumn5.HeaderText = "Autorius";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pavadinimas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gražinimo laikas";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gražinimo laikas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // SkaitytojoLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 710);
            this.Controls.Add(this.knygosDataGridView1);
            this.Controls.Add(this.knygosDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SkaitytojoLangas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SkaitytojoLangas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnygosDataSet1 knygosDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private KnygosDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private KnygosDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource knygosDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private System.Windows.Forms.BindingSource tableBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
      
        private System.Windows.Forms.Button button2;
        private LibraryDataDataSet libraryDataDataSet;
        private System.Windows.Forms.BindingSource knygosBindingSource;
        private LibraryDataDataSetTableAdapters.KnygosTableAdapter knygosTableAdapter;
        private LibraryDataDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView knygosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView knygosDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}