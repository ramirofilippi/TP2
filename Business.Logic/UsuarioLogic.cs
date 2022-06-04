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
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }
        private UsuarioAdapter _UsuarioData;
        public UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }
        public List<Usuario> GetAll()
        {
            List<Usuario> usuario = UsuarioData.GetAll();
            return usuario;
        }
        public Usuario GetOne(int ID)
        {
            Usuario u = UsuarioData.GetOne(ID);
            return u;
        }
        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }
    }
}
