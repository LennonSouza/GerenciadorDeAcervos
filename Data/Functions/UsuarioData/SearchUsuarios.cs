using GerenciadorDeAcervos.Data.Models;

namespace GerenciadorDeAcervos.Data.Functions.UsuarioData
{
    internal class SearchUsuarios
    {
        private readonly AcervoDbContext _context;

        public SearchUsuarios()
        {
            _context = new AcervoDbContext();
        }

        internal List<Usuario> UsuarioToList() 
        {
             return _context.Usuarios.ToList();
        }

        internal Usuario GetUsuario(string usuarioName) 
        {
            return _context.Usuarios.FirstOrDefault(u => u.UsuarioNome == usuarioName);
        }

        internal List<Usuario> GetUsuarioPermission()
        {
            return _context.Usuarios.Where(u => u.NivelPermissao == 0).ToList();
        }
    }
}
