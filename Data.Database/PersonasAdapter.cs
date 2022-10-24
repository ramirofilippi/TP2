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
    public class PersonasAdapter : Adapter
    {
        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPersonas = new SqlCommand("select * from personas", sqlConn);

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas persona = new Personas();
                    persona.ID = (int)drPersonas["id_persona"];
                    persona.Nombre = (string)drPersonas["nombre"];
                    persona.Apellido = (string)drPersonas["apellido"];
                    persona.Direccion = (string)drPersonas["direccion"];
                    persona.Email = (string)drPersonas["email"];
                    persona.Telefono = (string)drPersonas["telefono"];
                    persona.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    persona.Legajo = (int)drPersonas["legajo"];
                    persona.TipoPersona = (Personas.TiposPersonas)drPersonas["tipo_persona"];

                    personas.Add(persona);
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo recuperar las personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Personas GetOne(int ID)
        {
            Personas persona = new Personas();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("Select * from personas where id_persona = @id", sqlConn);
                cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersona = cmdPersona.ExecuteReader();

                if (drPersona.Read())
                {
                    persona.ID = (int)drPersona["id_persona"];
                    persona.Nombre = (string)drPersona["nombre"];
                    persona.Apellido = (string)drPersona["apellido"];
                    persona.Direccion = (string)drPersona["direccion"];
                    persona.Email = (string)drPersona["email"];
                    persona.Telefono = (string)drPersona["telefono"];
                    persona.FechaNacimiento = (DateTime)drPersona["fecha_nac"];
                    persona.Legajo = (int)drPersona["legajo"];
                    persona.TipoPersona = (Personas.TiposPersonas)drPersona["tipo_persona"];
                    persona.IDPlan = (int)drPersona["id_plan"];
                }
                drPersona.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return persona;
        }

        private void Update(Personas per)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("Update personas set nombre = @nombre, " +
                    "apellido = @apellido, direccion = @direccion, email = @email, telefono = @telefono, " +
                    "fecha_nac = @fecha_nac, legajo = @legajo, tipo_persona = @tipo_persona, id_plan = @id_plan " +
                    "Where id_persona = @id", sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = per.ID;
                cmdUpdate.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmdUpdate.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmdUpdate.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = per.Direccion;
                cmdUpdate.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmdUpdate.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = per.Telefono;
                cmdUpdate.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = per.FechaNacimiento;
                cmdUpdate.Parameters.Add("@legajo", SqlDbType.Int).Value = per.Legajo;
                cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = per.TipoPersona;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = per.IDPlan;

                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo actualidar los datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("Delete from personas where id_persona = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo eliminar los datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        private void Insert (Personas per)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdInsert = new SqlCommand("Insert into personas (nombre, apellido, direccion, " +
                    "email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values " +
                    "(@nombre, @apellido, @direccion, @email, @telefono, @fecha_nac, @legajo, @tipo_persona, " +
                    "@id_plan) select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = per.Nombre;
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = per.Apellido;
                cmdInsert.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = per.Direccion;
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = per.Email;
                cmdInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = per.Telefono;
                cmdInsert.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = per.FechaNacimiento;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.Int).Value = per.Legajo;
                cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = per.TipoPersona;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = per.IDPlan;
                per.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("No se pudo insertar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Personas per)
        {
            if (per.State == BusinessEntity.States.New)
            {
                this.Insert(per);
            }
            else if (per.State == BusinessEntity.States.Deleted)
            {
                this.Delete(per.ID);
            }
            else if (per.State == BusinessEntity.States.Modified)
            {
                this.Update(per);
            }
            per.State = BusinessEntity.States.Unmodified;
        }
    }
}
