using MySql.Data.MySqlClient;
using Sirob_Vaca__Evalacion_Parcial1.Conexion;
using Sirob_Vaca__Evalacion_Parcial1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirob_Vaca__Evalacion_Parcial1.Controllers
{
    public class CursoController
    {
        public void Agregar(string nombre, int creditos)
        {
            using (var conn = cls_conexion.Conectar())
            {
                string query = "INSERT INTO cursos(nombre_curso, creditos) VALUES (@n, @c)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@c", creditos);
                cmd.ExecuteNonQuery();
            }
        }
        public void Eliminar(int id)
        {
            using (var conn = cls_conexion.Conectar())
            {
                string query = "DELETE FROM cursos WHERE curso_id = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public List<CursoModel> Listar()
        {
            var lista = new List<CursoModel>();
            using (var conn = cls_conexion.Conectar())
            {
                string query = "SELECT * FROM cursos";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new CursoModel
                    {
                        CursoId = reader.GetInt32("curso_id"),
                        NombreCurso = reader.GetString("nombre_curso"),
                        Creditos = reader.GetInt32("creditos")
                    });
                }
            }
            return lista;
        }
    }
}
