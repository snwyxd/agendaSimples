using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace agendaSimples
{
    internal class Contato
    {
        //Variaveis locais da classe Contato
        //Acessiveis apenas pelo classe Contato
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        //Propriedade da classe Contato
        //Acessiveis por qualquer parte do programa
        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }
            set
            {
                primeiroNome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 11) 
                { 
                    telefone = value;
                }
                else
                {
                    telefone = "00-0000-0000";
                }
            }
        }
        
        //construtor da classe
        public Contato()
        {
            primeiroNome = "Vitor";
            sobrenome = "Silva";
            telefone = "11-99774-4675";
        }

        //sobrecarga de metodo
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        //Sobre escreita do metodo ToString()
        public override string ToString()
        {
            //Melhor utilizar String.Empty ao inves de ""
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Segundo);
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0,1), 
                Telefone.Substring(2,3), 
                Telefone.Substring(2,6), 
                Telefone.Substring(7,10));
        }
    }
}
