using System;
using System.Collections.Generic;
using System.Text;

namespace DadosVisitas.BLL
{
    interface InterfaceVisitanteDao
    {
        void Salvar(Visitante visitante);
        List<Visitante> Buscar();
    }
}
