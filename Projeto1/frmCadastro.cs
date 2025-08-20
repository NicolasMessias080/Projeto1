using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmCadastro : Form
    {
        //instanciando
        Conexao con = new Conexao();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void dgvCadastro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarDados(); 
        }
        //CRIANDO FUNÇÃO CARREGAR DADOS
        public carregarDados()
        {
            try
            {
                txtNome.Text = dgvCadastro.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Clicar" + erro);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O Campo Nome não pode ficar vazio");
                txtNome.Focus();
            }
            else
            {
                try
                {
                    string sql = "insert into tbProduto(nome)values(@nome)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Cadastrado com Sucesso");
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}
