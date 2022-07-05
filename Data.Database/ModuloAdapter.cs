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
    public class ModuloAdapter : Adapter
    {
        public List<Modulo> GetAll()
        {
            List<Modulo> modulos = new List<Modulo>();
            try
            {
                this.OpenConnection();

                SqlCommand cmdModulos = new SqlCommand("select * from modulos", sqlConn);

                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                while (drModulos.Read())
                {
                    Modulo mod = new Modulo();
                    mod.ID = (int)drModulos["id_modulo"];
                    mod.Descripcion = (string)drModulos["desc_modulo"];
                    modulos.Add(mod);
                }
                drModulos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar los modulos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return modulos;
        }
        public Modulo GetOne(int ID)
        {
            Modulo mod = new Modulo();
            try
            {
                this.OpenConnection();

                SqlCommand cmdModulos = new SqlCommand("select * from modulos where id_modulo = @id", sqlConn);
                cmdModulos.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                if (drModulos.Read())
                {
                    mod.ID = (int)drModulos["id_modulo"];
                    mod.Descripcion = (string)drModulos["desc_modulo"];
                }
                drModulos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar los datos del modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mod;
        }
        public void Delete(int ID)
        {
            //Usuarios.Remove(this.GetOne(ID));
            try
            {
                this.OpenConnection();
                Console.WriteLine(ID);
                SqlCommand cmdDelete = new SqlCommand("delete from modulos where id_modulo = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al eliminar Modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Modulo modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulos SET desc_modulo = @desc_modulo " + 
                    "where id_modulo = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al actualizar los datos del modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Modulo modulo)
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
                    "insert into modulos (desc_modulo) values (@desc_modulo)" +
                    "select @@identity", sqlConn); // Select @@indentity trae el id que le asigno el sql
                //cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                modulo.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //Asi recupero el ID que asigno la base de datos automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al crear un modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Modulo modulo)
        {
            if (modulo.State == BusinessEntity.States.Deleted)
            {
                this.Delete(modulo.ID);
            }
            else if (modulo.State == BusinessEntity.States.New)
            {
                this.Insert(modulo);
            }
            else if (modulo.State == BusinessEntity.States.Modified)
            {
                this.Update(modulo);
            }
            modulo.State = BusinessEntity.States.Unmodified;
        }

    }
}
