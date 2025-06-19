using MySql.Data.MySqlClient;
using Sirob_Vaca__Evalacion_Parcial1.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sirob_Vaca__Evalacion_Parcial1.Vistas.FRM_Inscripciones;

namespace Sirob_Vaca__Evalacion_Parcial1.Controllers
{
    public class InscripcionController
    {
        public int InscripcionId { get; private set; }

        public void Inscribir(int estudianteId, int cursoId)
        {
            using (var conn = cls_conexion.Conectar())
            {
                string query = "INSERT INTO inscripciones(estudiante_id, curso_id, fecha_inscripcion) VALUES (@e, @c, NOW())";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@e", estudianteId);
                cmd.Parameters.AddWithValue("@c", cursoId);
                cmd.ExecuteNonQuery();
            }
        }
        public void Eliminar(int id)
        {
            using (var conn = cls_conexion.Conectar())
            {
                string query = "DELETE FROM inscripciones WHERE inscripcion_id = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public List<InscripcionDetalle> ListarDetalleInscripciones()
        {
            var lista = new List<InscripcionDetalle>();
            using (var conn = cls_conexion.Conectar())
            {
                string query = @"SELECT i.inscripcion_id, e.nombre, c.nombre_curso, i.fecha_inscripcion 
                         FROM inscripciones i
                         JOIN estudiantes e ON i.estudiante_id = e.estudiante_id
                         JOIN cursos c ON i.curso_id = c.curso_id";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new InscripcionDetalle
                    {
                        InscripcionId = reader.GetInt32(0),
                        Texto = $"{reader.GetString(1)} - {reader.GetString(2)} - {reader.GetDateTime(3):yyyy-MM-dd}"
                    });
                }
            }
            return lista;
        }

    }
}
