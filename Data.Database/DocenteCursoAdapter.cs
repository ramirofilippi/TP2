using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docentes = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocentes = new SqlCommand("Select * from docentes_cursos", sqlConn);
                SqlDataReader drDocentes = cmdDocentes.ExecuteReader();

                while (drDocentes.Read())
                {
                    DocenteCurso docente = new DocenteCurso();

                    docente.ID = (int)drDocentes[""];
                }

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo recuperar el listado de los docentes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentes;
        }
    }
}
