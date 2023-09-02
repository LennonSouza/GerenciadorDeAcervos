using GerenciadorDeAcervos.Data.Models;

namespace GerenciadorDeAcervos.Data.Functions.UsuarioData
{
    public class UserData
    {
        private Usuario _usuario;
        private AcervoDbContext _context;

        public UserData(Usuario usuario)
        {
            _usuario = usuario;
            _context = new AcervoDbContext();
        }

        internal void SaveUser()
        {
            _context.Usuarios.Add(_usuario);
            Changes("Usuario salvo.");
        }

        internal void UpdateUser()
        {
            _context.Usuarios.Update(_usuario);
            Changes("Usuario atualizado.");
        }

        internal void DeleteUser()
        {
            _context.Usuarios.Remove(_usuario);
            Changes("Usuario deletado.");
        }

        private void Changes(string msg) 
        {
            _context.SaveChanges();
            MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
