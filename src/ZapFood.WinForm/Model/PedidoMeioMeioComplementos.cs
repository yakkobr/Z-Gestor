using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapFood.WinForm.Model
{
    public class PedidoMeioMeioComplementos
    {
        public int PedidoMeioMeioComplementosID { get; set; }
        public string NomeDaMetade { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public Guid PedidoGuid { get; set; }

    }
}
