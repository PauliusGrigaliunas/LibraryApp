using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SkaitytojoLangas : Form
    {
        private DBManager dbman = new DBManager();
        User user = new User();

        public SkaitytojoLangas(User user)
        {
            InitializeComponent();
            this.user = user;
            label1.Text = "Prisijungta kaip: " + user.Username;
            label2.Text = "Skaitytojo ID: " + user.ID;
        }

        private void SkaitytojoLangas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Knygos' table. You can move, or remove it, as needed.
            this.knygosTableAdapter1.Fill(this.libraryDataSet.Knygos);
            // TODO: This line of code loads data into the 'libraryDataDataSet.Knygos' table. You can move, or remove it, as needed.
            //knygosTableAdapter.Fill(libraryDataDataSet.Knygos);

            using (LibraryDataEntities3 dataEntities = new LibraryDataEntities3())
            {

                Knygo[] knygo = (from c in dataEntities.Knygos
                                 from b in dataEntities.Egzempliorius
                                 where c.Isbn == b.Isbn && !b.Skaitytojas.HasValue
                                 select c).Distinct().ToArray();

                knygosDataGridView.DataSource = knygo;

            }


            using (LibraryDataEntities3 dataEntities = new LibraryDataEntities3())
            {

                Knygo[] knygo = (from c in dataEntities.Knygos
                                 from a in dataEntities.Egzempliorius
                                 from b in dataEntities.Vartotojais
                               where c.Isbn == a.Isbn && a.Skaitytojas == b.Id
                               select c).ToArray();

                knygosDataGridView1.DataSource = knygo;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbman.take(knygosDataSet1, knygosDataGridView.CurrentCell.RowIndex, user.ID);
            updateTable();
        }

        private void updateTable()
        {
            knygosTableAdapter.Update(libraryDataDataSet);
           // knygosTableAdapter.FillByZmogus(this.knygosDataSet1.Table);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                knygosTableAdapter.FillByAuthorOrBook(libraryDataDataSet.Knygos, textBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            KurjerioForma Kurjeris = new KurjerioForma();
            Kurjeris.ShowDialog();
            dbman.take(knygosDataSet1, knygosDataGridView.CurrentCell.RowIndex, user.ID);
            updateTable();
        }

        private void knygosDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void knygosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void knygosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
