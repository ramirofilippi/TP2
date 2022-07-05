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
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", sqlConn);

                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                while (drEspecialidades.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    especialidades.Add(esp);
                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar las especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return especialidades;
        }
        public Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades where id_especialidad = @id", sqlConn);
                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                if (drEspecialidades.Read())
                {
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar los datos de la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }
        public void Delete(int ID)
        {
            //Usuarios.Remove(this.GetOne(ID));
            try
            {
                this.OpenConnection();
                Console.WriteLine(ID);
                SqlCommand cmdDelete = new SqlCommand("delete from especialidades where id_especialidad = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al eliminar la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET desc_especialidad = @desc_especialidad " +
                    "where id_especialidad = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al actualizar los datos de la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Especialidad especialidad)
        {
            /*/
            this.OpenConnection();
            SqlCommand cmdBusqueda = new SqlCommand("SELECT MAX(id_usuario) result from usuarios", sqlConn);
            SqlDataReader drBusqueda = cmdBusqueda.ExecuteReader();
            if (drBusqueda.Read())
            {
                int ID = ((int)drBusqueda["result"]) + 1;
                Console.WriteLine("\n\n\nEL VALOR DEL ID SERA: " + ID + "\n\n\n");
            }
            this.CloseConnection();
            
            drBusqueda.Close();
            /*/
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into especialidades (desc_especialidad) values (@desc_especialidad)" +
                    "select @@identity", sqlConn); // Select @@indentity trae el id que le asigno el sql
                //cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //Asi recupero el ID que asigno la base de datos automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al crear la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }

    }
}
