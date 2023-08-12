using PjtAtv_UC12_001_Gianluca.Classes;
using System.Data;

namespace PjtAtv_UC12_001_Gianluca
{
    public partial class FormPrincipal : Form
    {
        Correntista correntista1;
        Correntista correntista2;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            
            try
            {                 
                if (Correntista.Equals == null)
                {
                    
                    correntista1 = new Correntista(txtNome.Text, txtCpf.Text, Convert.ToDateTime(DtpDataNasc.Text), Convert.ToDecimal(txtRendaMensal.Text));
                    MessageBox.Show($"{correntista1.IdCorrentista}\n{correntista1.Nome}\n{correntista1.Cpf}\n{correntista1.DataNascimento}\n{correntista1.RendaMensal}\n{correntista1.RetornarPerfilCliente()}");
                    if (correntista1.VerificarSeCorrentistaMaior() == false)
                    {
                        MessageBox.Show("Não tem idade para criar uma conta!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (correntista1.Nome == string.Empty)
                    {
                        throw new Exception("Nome é necessário ser preenchido!");
                    }
                    else if (correntista1.Cpf.Length != 11)
                    {
                        throw new Exception("O Cpf deve conter 11 Digitos!");
                    }
                    else if (correntista1.RendaMensal <= 0)
                    {
                        throw new Exception("A renda mensal deve ser diferente de zero");
                    }
                    lblWelcome.Text = correntista1.MontarMensagemBoasVindas();
                }
                else
                {
                     correntista2 = new Correntista(txtNome.Text, txtCpf.Text, Convert.ToDateTime(DtpDataNasc.Text), Convert.ToDecimal(txtRendaMensal.Text));
                    MessageBox.Show($"{correntista2.IdCorrentista}\n{correntista2.Nome}\n{correntista2.Cpf}\n{correntista2.DataNascimento}\n{correntista2.RendaMensal}\n{correntista2.RetornarPerfilCliente()}");
                    
                    if (correntista2.VerificarSeCorrentistaMaior() == false)
                    {
                        MessageBox.Show("Não tem idade para criar uma conta!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (correntista2.Nome == string.Empty)
                    {
                        throw new Exception("Nome é necessário ser preenchido!");
                    }
                    else if (correntista2.Cpf.Length != 11)
                    {
                        throw new Exception("O Cpf deve conter 11 Digitos!");
                    }
                    else if (correntista2.RendaMensal <= 0)
                    {
                        throw new Exception("A renda mensal deve ser diferente de zero");
                    }
                    lblWelcome.Text = correntista2.MontarMensagemBoasVindas();
                }
               
            }
            
            catch (FormatException ex)
            {
                MessageBox.Show("A renda mensal deve ser diferente de zero");
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Atenção");
                }
            

                
            


        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCpf.Text, out var cpfDigitado))
            {
                txtCpf.Clear();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNome.Text, out var nomeDigitado))
            {
                txtNome.Clear();
            }
        }

        private void txtRendaMensal_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtRendaMensal.Text, out var rendaDigitada))
            {
                txtRendaMensal.Clear();
            }
        }
    }
}