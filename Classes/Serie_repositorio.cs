using System;
using System.Collections.Generic;
using ProjetoDotNet.Interfaces;


namespace ProjetoDotNet
{
    public class Serie_repositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        
        public void atualizar(int id, Series objeto)
        {
            listaSerie [id] = objeto;
        }

        public void excluir(int id)
        {
            listaSerie [id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }

    public interface IRepositorio<T>
    {
    }
}