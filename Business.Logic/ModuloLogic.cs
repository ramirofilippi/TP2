using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
    public class ModuloLogic : BusinessLogic
    {
        public ModuloLogic()
        {
            this.ModuloData = new ModuloAdapter();
        }
        private ModuloAdapter _ModuloData;
        public ModuloAdapter ModuloData
        {
            get { return _ModuloData; }
            set { _ModuloData = value; }
        }
        public List<Modulo> GetAll()
        {
            List<Modulo> modulo = new List<Modulo>();
            try
            {
                modulo = ModuloData.GetAll();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de modulos", Ex);
                throw ExcepcionManejada;
            }
            return modulo;

        }
        public Modulo GetOne(int ID)
        {
            Modulo m = ModuloData.GetOne(ID);
            return m;
        }
        public void Save(Modulo modulo)
        {
            ModuloData.Save(modulo);
        }
        public void Delete(int ID)
        {
            ModuloData.Delete(ID);
        }
    }
}
