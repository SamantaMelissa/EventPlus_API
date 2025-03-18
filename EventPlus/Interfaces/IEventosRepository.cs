using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IEventosRepository
    {
        //Cadastrar um evento
        void Cadastrar(Eventos evento);

        //Atualizar um evento
        void Atualizar(Guid id, Eventos evento);

        //Deletar um evento
        void Deletar(Guid id);

        //Listar os eventos
        List<Eventos> Listar();

        //Buscar os eventos por ID
        Eventos BuscarPorId(Guid id);

        //Listar os eventos por ID
        List<Eventos> ListarPorId(Guid id);

        //Listar Proximos eventos
        List<Eventos> ProximosEventos();
    }
}
