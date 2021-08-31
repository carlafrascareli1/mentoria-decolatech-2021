using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Deposito : Lancamento
    {
        public Deposito(decimal valor, DateTime data, ContaBancaria conta) : base(valor, data, conta)
        {

        }
    }
}
