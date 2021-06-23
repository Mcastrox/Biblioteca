using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Biblioteca.Entidades;
using Biblioteca.Negocio;


namespace Biblioteca.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login()
        {
            /* SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A5KN1DG;Initial Catalog=Biblioteca;Integrated Security=True");
             conn.Open();
             SqlCommand cm = new SqlCommand("Select username,pass From DOCENTE where username='" + txtCorreo.Text + "' and pass='" + txtContraseña.Text + "'", conn);
             SqlDataReader dr = cm.ExecuteReader();
             if (dr.Read())
             {
                 MessageBox.Show("Bienvenido a Pornhub", "Biblioteca");

             }
             else
             {
                 MessageBox.Show("No tienes membresia", "Biblioteca");
             }*/

            DocenteLO docente = new DocenteLO();

            Docente docenteLogin = docente.getDocente(txtCorreo.Text, txtContraseña.Text);

            if (docenteLogin !=null)
            {
                MessageBox.Show("Bienvenido a Pornhub", "Biblioteca");
            }
            else
            {
                MessageBox.Show("No tiene membresia wachin", "Biblioteca");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
    
