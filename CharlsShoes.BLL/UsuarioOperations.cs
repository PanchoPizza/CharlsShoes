using CharlsShoes.DAL;
using CharlsShoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlsShoes.BLL
{
   public class UsuarioOperations
    {

        #region Singleton
        private static volatile UsuarioOperations instance = null;

        private static readonly object padlock = new object();

        private CharlsShoesContext context = new CharlsShoesContext();


        private UsuarioOperations() { }

        public static UsuarioOperations Instance()
        {
            if (instance == null)

                lock (padlock)
                    if (instance == null)
                        instance = new UsuarioOperations();
            return instance;

        }


        #endregion


        public int Add(Usuario usuario)
        {
            context.Add(usuario);
            return context.SaveChanges();
        }


        public int Delete(int idUsuario)
        {
            Usuario usuario = context.Usuarios.Where(c => c.idUsuario == idUsuario).FirstOrDefault();
            usuario.activo = false;
            return context.SaveChanges();

        }

        public List<Usuario> GetAll()
        {
            return context.Usuarios.Where(c => c.activo == true).ToList();
        }

        public Usuario GetById(int idUsuario)
        {

            return context.Find<Usuario>(idUsuario);
        }

        public int Update(Usuario usuario)
        {
            context.Update(usuario);
            return context.SaveChanges();
        }

        public Usuario Login(Usuario usuario)
        {

            return context.Usuarios.Where(u => u.usuario == usuario.usuario && u.password == usuario.password).SingleOrDefault();
        }

    }
}
