using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IUsuariosRepository
    {
        void Cadastrar(Usuarios usuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}
