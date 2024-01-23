using CestaBasica.Entities.Entities;
using System.Collections.Generic;

namespace CestaBasica.Application.Interfaces
{
    public interface ICadastroFuncionario
    {
        List<CadastroFuncionarioEntitie> Get();
        CadastroFuncionarioEntitie Get(int id);
        void insert();
        void update();
        void delete();

    }
}
