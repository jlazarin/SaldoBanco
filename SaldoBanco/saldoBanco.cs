using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaldoBanco
{
    class saldoBanco
    {
        public int numeroConta;
        public string nomeUsuario;
        public double valorDeposito;
        
        public void AdicionarDeposito(int valordep)
        {
            valorDeposito += valordep;
        }
        public void RemoverValor(int quantidade)
        {
            valorDeposito -= quantidade;
            valorDeposito -= 5.00;
        }

        public override string ToString()
        {
            return "Dados da conta: "
                + " Conta JP " + numeroConta
                + " Titular: " + nomeUsuario.ToString() + " , "
                 + " Saldo: $ "
                + valorDeposito.ToString("F2");
          //  "Conta " + c.numeroConta + ", Titular: " + c.nomeUsuario + ", Saldo: $ " + c.valorDeposito
        }
    }
}
