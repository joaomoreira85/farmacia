using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.MultiMais.Dominio.Entidade
{
    public class Produto
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public string categoria { get; set; }
    }
}
