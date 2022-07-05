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
    public class EspecialidadLogic : BusinessLogic
    {
        public EspecialidadLogic()
        {
            this.EspecialidadData = new EspecialidadAdapter();
        }
        private EspecialidadAdapter _EspecialidadData;
        public EspecialidadAdapter EspecialidadData
        {
            get { return _EspecialidadData; }
            set { _EspecialidadData = value; }
        }
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidad = new List<Especialidad>();
            try
            {
                especialidad = EspecialidadData.GetAll();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de especialidades", Ex);
                throw ExcepcionManejada;
            }
            return especialidad;

        }
        public Especialidad GetOne(int ID)
        {
            Especialidad e = EspecialidadData.GetOne(ID);
            return e;
        }
        public void Save(Especialidad especialidad)
        {
            EspecialidadData.Save(especialidad);
        }
        public void Delete(int ID)
        {
            EspecialidadData.Delete(ID);
        }
    }
}
