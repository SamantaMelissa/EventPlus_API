﻿using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TiposEventos tipoEvento);
        void Deletar(Guid id);
        List<TiposEventos> Listar();
        TiposEventos BuscarPorId(Guid id);
        void Atualizar(Guid id, TiposEventos tipoEvento);
    }
}
