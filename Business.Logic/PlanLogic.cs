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
    public class PlanLogic : BusinessLogic
    {
        public PlanLogic()
        {
            this.PlanData = new PlanAdapter();
        }
        private PlanAdapter _PlanData;
        public PlanAdapter PlanData {
            get { return _PlanData; }
            set { _PlanData = value; }
        }
        public List<Plan> GetAll()
        {
            List<Plan> plan = new List<Plan>();
            try
            {
                plan = PlanData.GetAll();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de planes", Ex);
                throw ExcepcionManejada;
            }
            return plan;

        }
        public Plan GetOne(int ID)
        {
            Plan p = PlanData.GetOne(ID);
            return p;
        }
        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }
        public void Delete(int ID)
        {
            PlanData.Delete(ID);
        }
    }
}
