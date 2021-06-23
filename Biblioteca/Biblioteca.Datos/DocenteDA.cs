using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{

    public class DocenteDA
    {
        SqlCommand cmdTabla = new SqlCommand();
        Conexion conexion = new Conexion();

        public Docente getDocente(string user, string pass)
        {
            Docente mDocente = null;

            SqlDataReader dr;

            SqlConnection connection = conexion.m_ObtenerConexion();
            
            cmdTabla = new SqlCommand("Select username,pass From DOCENTE where username=@user and pass=@pass",connection);
            cmdTabla.Parameters.AddWithValue("@user", user);
            cmdTabla.Parameters.AddWithValue("@pass", pass);

            dr = cmdTabla.ExecuteReader();

            while (dr.Read())
            {
                mDocente = new Docente
                {
                    username = Convert.ToString(dr.GetString(0)),
                    pass = Convert.ToString(dr.GetString(1))
                };
            }

            return mDocente;
        }
    }
}


