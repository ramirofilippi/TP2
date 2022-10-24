using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        public ComisionLogic()
        {
            this.ComisionData = new ComisionAdapter();
        }
        private ComisionAdapter _ComisionData;

        public ComisionAdapter ComisionData
        {
            get { return _ComisionData; }
            set { _ComisionData = value; }
        }

        public List<Comision> GetAll()
        {
            List<Comision> comision = ComisionData.GetAll();
            return comision;
        }

        public Comision GetOne(int ID)
        {
            Comision com = ComisionData.GetOne(ID);
            return com;
        }

        public void Save(Comision com)
        {
            ComisionData.Save(com);
        }

        public void Delete(int ID)
        {
            ComisionData.Delete(ID);
        }
    }
}
