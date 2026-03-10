using ApiAutenticacaoUsuario.Data;
using ApiAutenticacaoUsuario.Dto.Usuario;
using ApiAutenticacaoUsuario.Models;
using Microsoft.IdentityModel.Tokens;

namespace ApiAutenticacaoUsuario.Services.Usuario
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            ResponseModel<UsuarioModel> response = new ResponseModel<UsuarioModel>();

            try
            {
                if(!VerificaSeExisteEmailUsuarioRepetido(usuarioCriacaoDto))
                {
                    response.Mensagem = "Email ou Usuário já cadastrado.";
                    response.Status = false;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }

        }
        private bool VerificaSeExisteEmailUsuarioRepetido(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            var usuario = _context.Usuarios.FirstOrDefault(item => item.Email == usuarioCriacaoDto.Email ||
                                                                item.Usuario == usuarioCriacaoDto.Usuario);

            if (usuario != null)
            {
                return false;
            }

            return true;
        }
    }
}
