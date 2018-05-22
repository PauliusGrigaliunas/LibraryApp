using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class DarbuotojoLangas : Form
    {
        private DBManager dbman = new DBManager();
        User user;

        public DarbuotojoLangas(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DarbuotojoLangas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataDataSet1.Knygos' table. You can move, or remove it, as needed.
            knygosTableAdapter.Fill(this.libraryDataDataSet1.Knygos);


        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                tableBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(knygosDataSet1);
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (knygosDataSet1.Table[knygosDataGridView.CurrentCell.RowIndex][4].Equals(DBNull.Value)) { label1.Text = ""; }
            else
            {
                DateTime grazinimoData = (DateTime)knygosDataSet1.Table[knygosDataGridView.CurrentCell.RowIndex][4];
                label1.Text = "Mokama suma: " + dbman.baudosDydis(grazinimoData).ToString() + " €";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dbman.remove(knygosDataSet1, knygosDataGridView.CurrentCell.RowIndex);
            updateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbman.extend(knygosDataSet1, knygosDataGridView.CurrentCell.RowIndex);
            }catch(Exception exc)
            {
                label1.Text = exc.Message;
            }
             updateTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String autorius = textBoxAutorius.Text;
            String pavadinimas = textBoxPavadinimas.Text;
            dbman.AddBook(autorius, pavadinimas);
            //dbman.add(knygosDataSet1, autorius, pavadinimas);
            //updateTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dbman.delete(knygosDataSet1, 0);
            updateTable();
        }

        private void updateTable()
        {
            tableTableAdapter.Update(knygosDataSet1);
            tableTableAdapter.Fill(knygosDataSet1.Table);
        }

        private void knygosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
