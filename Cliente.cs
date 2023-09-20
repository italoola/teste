using System.Collections;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; internal set; }
        public Endereco EnderecoDeEntrega { get; set; }
    }
}