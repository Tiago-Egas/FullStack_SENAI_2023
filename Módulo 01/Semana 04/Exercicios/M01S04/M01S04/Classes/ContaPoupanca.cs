﻿using M01S04.Classes;
using M01S04.Classes.Enums;

namespace M01S04.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente, decimal saldo) : base(numero, agencia, cliente, saldo)
        {
            if (Cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Clinte não pode ser Pessoa Jurídica!");
            }
        }

        public override void Sacar(decimal valor)
        {
            valor += 0.10M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
}
