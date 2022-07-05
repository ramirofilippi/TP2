using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        public MateriaLogic()
        {
            this.MateriaData = new MateriaAdapter();
        }
        private MateriaAdapter _MateriaData;
        public MateriaAdapter MateriaData
        {
            get { return _MateriaData; }
            set { _MateriaData = value; }
        }
        public List<Materia> GetAll()
        {
            List<Materia> materia = MateriaData.GetAll();
            return materia;
        }
        public Materia GetOne(int ID)
        {
            Materia m = MateriaData.GetOne(ID);
            return m;
        }
        public void Save(Materia materia)
        {
            MateriaData.Save(materia);
        }
        public void Delete(int ID)
        {
            MateriaData.Delete(ID);
        }
    }
}
