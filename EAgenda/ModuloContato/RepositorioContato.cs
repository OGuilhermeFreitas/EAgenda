using EAgenda.Compartilhado;
using System.Collections.Generic;
using System.Linq;



namespace EAgenda.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public IEnumerable<IGrouping<string, Contato>> SelecionarContatosPorCargo()
        {
            return SelecionarTodos().GroupBy(x => x.Cargo);
        }
    }
}
