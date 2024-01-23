using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CestaBasica
{
    public partial class CadastroFuncionario : Form
    {
        private TelaInicial _telaInicial;
        private int idRegistroEdicao;
        public CadastroFuncionario(TelaInicial telaInicial)
        {
            InitializeComponent();
            _telaInicial = telaInicial;
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            string stringConnection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CestaBasica;Data Source=DESKTOP-I75R4LO\\MSSQLSERVER2023";
            string nome = NomeTxt.Text;
            string contato = ContatoMTxt.Text;

            
            using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    if (idRegistroEdicao != 0)
                    {
                        string sqlUpdateQuery = "UPDATE Funcionarios SET Nome = @Nome, Contato = @Contato WHERE Id = @Id";
                        SqlCommand updateCommand = new SqlCommand(sqlUpdateQuery, connection);

                        updateCommand.Parameters.AddWithValue("@Id", idRegistroEdicao);
                        updateCommand.Parameters.AddWithValue("@Nome", nome);
                        updateCommand.Parameters.AddWithValue("@Contato", contato);

                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        string sqlQuery = "INSERT INTO Funcionarios(Nome, Contato) VALUES(@Nome, @Contato)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);

                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Contato", contato);

                        command.ExecuteNonQuery();
                    }
                    
                }
                finally
                {
                    connection.Close();
                }
                
            }

            _telaInicial.AtualizarDataGridView();

            Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PreencherCampos(string nome,  string contato, int idRegistro)
        {
            NomeTxt.Text = nome;
            ContatoMTxt.Text = contato;
            idRegistroEdicao = idRegistro;
        }
    }
}
