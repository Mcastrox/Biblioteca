using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class DocenteLO
    {
       
        public Docente getDocente(string user, string pass)
        {
            DocenteDA docente = new DocenteDA();
            Docente docentelogin = docente.getDocente(user, pass);
            return docentelogin;
        }
    }
    
}
