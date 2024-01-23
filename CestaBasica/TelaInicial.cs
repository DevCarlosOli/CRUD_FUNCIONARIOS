using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CestaBasica
{
    public partial class TelaInicial : Form
    {
        private SqlDataAdapter _adapter;
        private DataSet _dataSet;

        string stringConnection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CestaBasica;Data Source=DESKTOP-I75R4LO\\MSSQLSERVER2023";

        public TelaInicial()
        {
            InitializeComponent();
            InitializeData();            
        }

        private void InitializeData()
        {
            
            string sqlQuery = "SELECT * FROM Funcionarios";
            using(SqlConnection connection = new SqlConnection(stringConnection))
            {
                _adapter = new SqlDataAdapter(sqlQuery, connection);
                _dataSet = new DataSet();

                _adapter.Fill(_dataSet, "Funcionarios");

                dataGridView1.DataSource = _dataSet.Tables["Funcionarios"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        public void AtualizarDataGridView()
        {
            InitializeData();
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdicionarBtn_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario(this);

            cadastroFuncionario.ShowDialog();
        }

        private void AlterarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indiceLinhas = dataGridView1.SelectedRows[0].Index;
                string nome = dataGridView1.Rows[indiceLinhas].Cells["Nome"].Value.ToString();
                string contato = dataGridView1.Rows[indiceLinhas].Cells["Contato"].Value.ToString();
                int idRegistro = Convert.ToInt32(dataGridView1.Rows[indiceLinhas].Cells["Id"].Value);

                CadastroFuncionario cadastroFuncionario = new CadastroFuncionario(this);

                cadastroFuncionario.PreencherCampos(nome, contato, idRegistro);
                cadastroFuncionario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indiceLinhas = dataGridView1.SelectedRows[0].Index;
                int idRegistro = Convert.ToInt32(dataGridView1.Rows[indiceLinhas].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o registro com ID " + idRegistro + "?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();
                        string query = "DELETE FROM Funcionarios WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", idRegistro);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                CarregarDados();
            }
        }

        private void CarregarDados()
        {

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Funcionarios";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
