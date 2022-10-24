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
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones", sqlConn);

                SqlDataReader drComsiones = cmdComisiones.ExecuteReader();

                while (drComsiones.Read())
                {
                    Comision com = new Comision();
                    com.ID = (int)drComsiones["id_comision"];
                    com.Descripcion = (string)drComsiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComsiones["anio_especialidad"];
                    com.IDPlan = (int)drComsiones["id_plan"];

                    comisiones.Add(com);
                }
                drComsiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar una comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }
        public Comision GetOne(int ID)
        {
            Comision com = new Comision();
            try
            {
                this.OpenConnection();

                SqlCommand cmdComision = new SqlCommand("Select * from comisiones where id_comision = @id", sqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drComision = cmdComision.ExecuteReader();

                if (drComision.Read())
                {
                    com.ID = (int)drComision["id_comision"];
                    com.Descripcion = (string)drComision["desc_comision"];
                    com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    com.IDPlan = (int)drComision["id_plan"];
                }
                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("Delete from comisiones where id_comision = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo eliminar la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        private void Update(Comision com)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("Update comisiones set desc_comision = @desc_comision, "
                + "anio_especialidad = @anio_especialidad, id_plan = @id_plan where id_comision = @id", sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;
                cmdUpdate.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = com.Descripcion;
                cmdUpdate.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = com.AnioEspecialidad;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = com.IDPlan;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo actualizar los datos de la comision",Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        private void Insert(Comision com)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdInsert = new SqlCommand("Insert into comisiones (desc_comision, anio_especialidad, id_plan)" +
                " values(@desc_comision, @anio_especialidad, @id_plan) select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = com.Descripcion;
                cmdInsert.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = com.AnioEspecialidad;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = com.IDPlan;
                com.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo insertar la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
