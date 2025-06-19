using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sirob_Vaca__Evalacion_Parcial1.Conexion
{
    public class cls_conexion
    {
        public static MySqlConnection Conectar()
        {
            string cadena = "server=localhost;database=db_cursos;uid=root;pwd=root;";
            var conexion = new MySqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
