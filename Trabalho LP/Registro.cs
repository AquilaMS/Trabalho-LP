using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP
{
    class Registro
    {
        public string id_cliente;
        public string id_dvd;
        public string quantidade;
        public DateTime retirada;
        public DateTime venda;
        
        public Registro(string _id_cliente, string _id_dvd, string _quantidade, DateTime _retirada ,DateTime _venda)
        {
            id_cliente = _id_cliente;
            id_dvd = _id_dvd;
            quantidade = _quantidade;
            retirada = _retirada;
            venda = _venda;
        }
    }
}
