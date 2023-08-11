using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjtAtv_UC12_001_Gianluca.Classes
{
    public class Correntista
    {
        public int IdCorrentista { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public double RendaMensal { get; set; }

        public static int TotalCorrentista { get; set; }

        public Correntista() 
        {
            

        }   

        public Correntista(string nome, string cpf, DateTime dataNascimento, double rendaMensal)
        {
            TotalCorrentista = TotalCorrentista + 1;
            IdCorrentista = TotalCorrentista;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            RendaMensal = rendaMensal;            
        }

        public bool VerificarSeCorrentistaMaior()
        {
            /*TimeSpan diferenca = DateTime.Now - this.DataNascimento;
            int idade = diferenca.Days / 365;
            return idade;*/
            int idade = DateTime.Now.Year - this.DataNascimento.Year;
            if (DateTime.Now.Month < this.DataNascimento.Month || (DateTime.Now.Month < this.DataNascimento.Month && DateTime.Now.Day < this.DataNascimento.Day)) 
            {
                idade--;
            }

            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }   
}
