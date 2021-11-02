using System.Collections.Generic;

namespace ProjetoDotNet.Interfaces
{
    public interface IRepositório<T>
    {
        List <T> Lista();

         T RetornaPorId(int id);

        void Inserir (T objeto);

        void Excluir (int id);

        void Atualizar (int id, T objeto);

        int ProximoId();


    }
}