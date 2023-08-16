using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PjtAtv_UC12_001_Gianluca.Classes
{
    public class Correntista
    {
        public int IdCorrentista { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public decimal RendaMensal { get; set; }

        public static int TotalCorrentista { get; set; }

        public Correntista() 
        {
            

        }   

        public Correntista(string nome, string cpf, DateTime dataNascimento, decimal rendaMensal)
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
        public string RetornarPerfilCliente()
        {
            /*string perfil;
            if (RendaMensal <= 3.000m)
            {
                perfil = "Silver";
            }
            else if (RendaMensal <= 5.000m)
            {
                perfil = "Gold";
            }
            else if (RendaMensal <= 10.000m)
            {
                perfil = "Diamond";
            }
            else
            {
                perfil = "Black";
            }
            return perfil;*/

            if (RendaMensal <= 3.000m)
            {
                return "Conta Silver.";
            }
            else if (RendaMensal <= 5.000m)
            {
                return "Conta Gold!";
            }
            else if (RendaMensal <= 10.000m)
            {
                return  "Conta Diamond";
            }
            else
            {
                return "Conta Black!";
            }                
        }
        public string MontarMensagemBoasVindas()
        {
            
            return $"Olá,{Nome}!\n" +
                $"Seja Bem vindo ao Sifrão!\n" +
                $"Cliente - {RetornarPerfilCliente()}";  
        }
    }   
}
