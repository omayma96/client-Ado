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

namespace AdoClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        SqlConnection cn = new SqlConnection("Data Source = DESKTOP-6DKDTL0; Initial catalog = pclient; Integrated Security = true;");
        DataSet ds = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlDataAdapter adville;
        DataTable dtClient;
        DataView dv;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pclientDataSet2.villes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villesTableAdapter.Fill(this.pclientDataSet2.villes);

            ad = new SqlDataAdapter("Select * From Client", cn);
            ad.Fill(ds, "Client");
            dtClient = ds.Tables["client"];
            dataGridView2.DataSource = dtClient;

            adville = new SqlDataAdapter("Select * From Villes", cn);
            adville.Fill(ds, "villes");
            cbvilleFilter.DataSource = ds.Tables["villes"];
           

            dv = new DataView(dtClient);

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            DataRow r = dtClient.NewRow();
            r[1] = box_Nom.Text;
            r[2] = box_Prenom.Text;
            r[3] = box_Adress.Text;
            r[4] = box_Ville.Text;
            dtClient.Rows.Add(r);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int a = getIndice();
            dtClient.Rows[a][1] = box_Nom.Text;
            dtClient.Rows[a][2] = box_Prenom.Text;
            dtClient.Rows[a][3] = box_Adress.Text;
            dtClient.Rows[a][4] = box_Ville.Text;
         
        }
        int id;

        int getIndice()
        {
            int indice = 0;
            try
            {
               
                for (int i = 0; i < dtClient.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtClient.Rows[i][0]) == id)
                    {
                        indice = i;
                    }
                }
               
            }
            catch (Exception)
            {

            }
            return indice;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                box_Nom.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                box_Prenom.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                box_Adress.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                box_Ville.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch(Exception)
            {

            }

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            int b = getIndice();
            dtClient.Rows[b].Delete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ad);
            ad.Update(ds, "Client");
        }

        private void cbvilleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           

    }

    }
}
