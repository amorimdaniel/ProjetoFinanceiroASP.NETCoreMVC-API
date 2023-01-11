using ProjetoFinanceiro.Domain.Dtos;
using ProjetoFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinanceiro.Testes
{
    public class DominiosTeste
    {
        public static void TestaCriacaoEntidade()
        {
            Cliente cliente = new Cliente
            {
                ClienteId = 1,
                Nome = "Daniel",
                Cpf = "000111222111"
            };

            Console.WriteLine(cliente);

        }

        public static void testarDto()
        {
            ClienteDto dto = new ClienteDto
            {
                ClienteId = 1,
                Nome = "Thyanna",
                Cpf = "555742515451"
            };
        }
    }
}
