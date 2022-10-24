using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        public CursoLogic()
        {
            this.CursoData = new CursoAdapter();
        }

        private CursoAdapter _CursoData;

        public CursoAdapter CursoData
        {
            get { return _CursoData; }
            set { _CursoData = value; }
        }

        public List<Curso> GetAll()
        {
            List<Curso> cursos = CursoData.GetAll();
            return cursos;
        }
        public Curso GetOne(int ID)
        {
            Curso curso = CursoData.GetOne(ID);

            return curso;
        }

        public void Save(Curso cur)
        {
            CursoData.Save(cur);
        }

        public void Delete(int ID)
        {
            CursoData.Delete(ID);
        }
    }
}
