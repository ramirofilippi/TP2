using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        private static List<Materia> _Materias;

        private static List<Materia> Materias
        {
            get { return _Materias; }
            set { _Materias = value; }
        }
        public List<Materia> GetAll()
        {
            return new List<Materia>(Materias);
        }

        public Materia GetOne(int ID)
        {
            return Materias.Find(delegate (Materia m) { return m.ID == ID; });
        }

        public void Delete(int ID)
        {
            Materias.Remove(this.GetOne(ID));
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Materia mat in Materias)
                {
                    if (mat.ID > NextID)
                    {
                        NextID = mat.ID;
                    }
                }
                materia.ID = NextID + 1;
                Materias.Add(materia);
            }
            else if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Materias[Materias.FindIndex(delegate (Materia m) { return m.ID == materia.ID; })] = materia;
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
