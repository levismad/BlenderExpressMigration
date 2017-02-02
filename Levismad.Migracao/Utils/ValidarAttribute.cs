using System;

namespace Levismad.Utils
{

    [AttributeUsage(AttributeTargets.Property)]
    public class ValidarAttribute : Attribute
    {
        public string Nome { get; private set; }
        public int TamanhoMaximo { get; private set; }

        public ValidarAttribute(string nome, int tamanhoMaximo)
        {
            Nome = nome;
            TamanhoMaximo = tamanhoMaximo;
        }
    }
}
