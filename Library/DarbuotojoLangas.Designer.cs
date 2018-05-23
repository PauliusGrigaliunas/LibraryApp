namespace Library
{
    partial class DarbuotojoLangas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxAutorius = new System.Windows.Forms.TextBox();
            this.textBoxPavadinimas = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.libraryDataDataSet1 = new Library.LibraryDataDataSet();
            this.knygosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knygosTableAdapter = new Library.LibraryDataDataSetTableAdapters.KnygosTableAdapter();
            this.tableAdapterManager1 = new Library.LibraryDataDataSetTableAdapters.TableAdapterManager();
            this.knygosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knygosDataSet1 = new Library.KnygosDataSet1();
            this.tableTableAdapter = new Library.KnygosDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Library.KnygosDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gražinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pratesti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 639);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Prideti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxAutorius
            // 
            this.textBoxAutorius.Location = new System.Drawing.Point(45, 526);
            this.textBoxAutorius.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAutorius.Name = "textBoxAutorius";
            this.textBoxAutorius.Size = new System.Drawing.Size(279, 22);
            this.textBoxAutorius.TabIndex = 16;
            this.textBoxAutorius.Text = "Autorius";
            // 
            // textBoxPavadinimas
            // 
            this.textBoxPavadinimas.Location = new System.Drawing.Point(45, 582);
            this.textBoxPavadinimas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPavadinimas.Name = "textBoxPavadinimas";
            this.textBoxPavadinimas.Size = new System.Drawing.Size(279, 22);
            this.textBoxPavadinimas.TabIndex = 17;
            this.textBoxPavadinimas.Text = "Pavadinimas";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(425, 15);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Istrinti knyga";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // libraryDataDataSet1
            // 
            this.libraryDataDataSet1.DataSetName = "LibraryDataDataSet";
            this.libraryDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knygosBindingSource
            // 
            this.knygosBindingSource.DataMember = "Knygos";
            this.knygosBindingSource.DataSource = this.libraryDataDataSet1;
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.knygosDataGridView.DataSource = this.knygosBindingSource;
            this.knygosDataGridView.Location = new System.Drawing.Point(0, 50);
            this.knygosDataGridView.Name = "knygosDataGridView";
            this.knygosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.knygosDataGridView.RowTemplate.Height = 24;
            this.knygosDataGridView.Size = new System.Drawing.Size(748, 279);
            this.knygosDataGridView.TabIndex = 18;
            this.knygosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.knygosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Autorius";
            this.dataGridViewTextBoxColumn7.HeaderText = "Autorius";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pavadinimas";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Zmogus";
            this.dataGridViewTextBoxColumn9.HeaderText = "Zmogus";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Gražinimo laikas";
            this.dataGridViewTextBoxColumn10.HeaderText = "Gražinimo laikas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.knygosDataSet1;
            // 
            // knygosDataSet1
            // 
            this.knygosDataSet1.DataSetName = "KnygosDataSet1";
            this.knygosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // DarbuotojoLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 757);
            this.Controls.Add(this.knygosDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.textBoxPavadinimas);
            this.Controls.Add(this.textBoxAutorius);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DarbuotojoLangas";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.DarbuotojoLangas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnygosDataSet1 knygosDataSet1;
        private LibraryDataDataSet libraryDataDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private KnygosDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private KnygosDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxAutorius;
        private System.Windows.Forms.TextBox textBoxPavadinimas;
        private System.Windows.Forms.Button deleteButton;
        private LibraryDataDataSet libraryDataDataSet1;
        private System.Windows.Forms.BindingSource knygosBindingSource;
        private LibraryDataDataSetTableAdapters.KnygosTableAdapter knygosTableAdapter;
        private LibraryDataDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView knygosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}