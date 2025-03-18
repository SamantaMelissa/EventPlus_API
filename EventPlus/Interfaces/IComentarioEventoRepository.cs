using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IComentarioEventoRepository
    {
        //Adicionar/Criar um novo comentario
        void Cadastrar(ComentarioEvento comentarioEvento);
        //Apagar um comentario
        void Deletar(int idComentario);
        //Listar os comentarios
        List<ComentarioEvento> Listar(Guid id);
        //lista comentários POR usuário
        ComentarioEvento BuscarPorIdUsuario(Guid idUsuario, Guid idEvento);

    }
}
