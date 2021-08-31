using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public abstract class Lancamento
    {
        public Lancamento(decimal valor, DateTime data, ContaBancaria conta)
        {
            Data = data;
            Conta = conta ?? throw new ArgumentNullException(nameof(conta));
            Valor = (valor > 0) ? valor : throw new Exception("Valor do lançamento deve ser maior que zero.");
        }

        public decimal Valor { get; init; }
        public DateTime Data { get; init; }
        public ContaBancaria Conta { get; init; }
    }
}
