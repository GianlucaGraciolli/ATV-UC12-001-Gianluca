using PjtAtv_UC12_001_Gianluca.Classes;
using System.Data;

namespace PjtAtv_UC12_001_Gianluca
{
    public partial class FormPrincipal : Form
    {

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
            Correntista correntista = new Correntista(txtNome.Text, txtCpf.Text, Convert.ToDateTime(DtpDataNasc.Text), Convert.ToDouble(txtRendaMensal.Text));
            if (correntista.VerificarSeCorrentistaMaior() == false )
            {
                MessageBox.Show("Tu não tienes idade para estar aqui amiguito", "ERRO", MessageBoxButtons.OK,MessageBoxIcon.Information) ;
            }
            else
            {
                MessageBox.Show($"{correntista.IdCorrentista}\n{correntista.Nome}\n{correntista.Cpf}\n{correntista.DataNascimento}\n{correntista.RendaMensal}\n");
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
    }
}