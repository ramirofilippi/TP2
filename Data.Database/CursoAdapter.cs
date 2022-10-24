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
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos", sqlConn);

                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];

                    cursos.Add(cur);
                }
                drCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("error al recuperar los cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();

                SqlCommand cmdCurso = new SqlCommand("select * from cursos where id_curso = @id", sqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drCurso = cmdCurso.ExecuteReader();

                if (drCurso.Read())
                {
                    cur.ID = (int)drCurso["id_curso"];
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                    cur.Cupo = (int)drCurso["cupo"];
                }
                drCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar un curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete from cursos where id_curso = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo eliminar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        private void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdUpdate = new SqlCommand("update cursos set " + 
                    "id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, " + 
                    "cupo = @cupo where id_curso = @id_curso", sqlConn);
                cmdUpdate.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.ID;
                cmdUpdate.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmdUpdate.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdUpdate.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdUpdate.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo actualizar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        private void Insert (Curso curso)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdInsert = new SqlCommand("Insert into cursos (id_materia, id_comision, anio_calendario, cupo) " +
                    "values (@id_materia, @id_comision, @anio_calendario, @cupo) select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdInsert.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdInsert.Parameters.Add("anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdInsert.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                curso.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo insertar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso cur)
        {
            if(cur.State == BusinessEntity.States.New)
            {
                this.Insert(cur);
            }
            else if (cur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cur.ID);
            }
            else if (cur.State == BusinessEntity.States.Modified)
            {
                this.Update(cur);
            }
            cur.State = BusinessEntity.States.Unmodified;
        }
    }
}
