using ApiAutenticacaoUsuario.Dto.Usuario;
using ApiAutenticacaoUsuario.Models;

namespace ApiAutenticacaoUsuario.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto); 

    }
}
