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
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("select * from planes", sqlConn);

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan pla = new Plan();
                    pla.ID = (int)drPlanes["id_plan"];
                    pla.Descripcion = (string)drPlanes["desc_plan"];
                    pla.IDEspecialidad = (int)drPlanes["id_especialidad"];
                    planes.Add(pla);
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar los Planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return planes;
        }
        public Plan GetOne(int ID)
        {
            Plan pla = new Plan();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("select * from planes where id_plan = @id", sqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                if (drPlanes.Read())
                {
                    pla.ID = (int)drPlanes["id_plan"];
                    pla.Descripcion = (string)drPlanes["desc_plan"];
                    pla.IDEspecialidad = (int)drPlanes["id_especialidad"];
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar los datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return pla;
        }
        public void Delete(int ID)
        {
            //Usuarios.Remove(this.GetOne(ID));
            try
            {
                this.OpenConnection();
                Console.WriteLine(ID);
                SqlCommand cmdDelete = new SqlCommand("delete from planes where id_plan = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al eliminar el plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE planes SET desc_plan = @desc_plan, id_especialidad = @id_especialidad" +
                    "where id_plan = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al actualizar los datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Plan plan)
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
                    "insert into planes (desc_plan,id_especialidad) values (@desc_plan,@id_especialidad)" +
                    "select @@identity", sqlConn); // Select @@indentity trae el id que le asigno el sql
                //cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //Asi recupero el ID que asigno la base de datos automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al crear el plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

    }
}
