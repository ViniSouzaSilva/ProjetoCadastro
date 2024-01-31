using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Server=LP-00021\\SQLEXPRESS01;Database=Cadastro;Trusted_Connection=True;";
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlConnection.Open();
                    SqlDataAdapter command = new SqlDataAdapter("S_ListarUsuario_L", SqlConnection);
                    command.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable DTusuario = new DataTable();
                    command.Fill(DTusuario);
                    dataGridView1.DataSource = DTusuario;
                    SqlConnection.Close();

                }
                catch (Exception Ex)
                {
                    SqlConnection.Close();
                    throw new Exception();
                    
                }


            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {
                    if (TxbNome.Text.Equals("") || TxbRenda.Text.Equals("") || TxbCPF.Text.Equals(""))
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    {
                        var valor = TxbRenda.Text.Replace("R$", "");
                        valor = valor.Replace(".", "").Trim();
                        string ValorApurado = valor.Substring(0, valor.Length - 2);
                        ValorApurado = ValorApurado.Replace(",", "").Trim();

                        int Apurado = Convert.ToInt32(ValorApurado);

                        var CPF = TxbCPF.Text.Replace(".", "");
                        CPF = CPF.Replace("-", "");

                        SqlConnection.Open();
                        SqlCommand command = new SqlCommand("S_InserirUsuario_E", SqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nome", TxbNome.Text);
                        command.Parameters.AddWithValue("@DataNascimento", TxbData.Value);
                        command.Parameters.AddWithValue("@ValorRenda", Apurado);
                        command.Parameters.AddWithValue("@CPF", CPF);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Usuário Inserido!");
                        SqlConnection.Close();
                        PreencherGrid();
                        Clear();
                    }
                }
                catch (Exception Ex)
                {
                    SqlConnection.Close();
                    throw new Exception();
                   
                }



            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)
            {
                TxbNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxbData.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                TxbRenda.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxbCPF.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                BtnAtt.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnDelete.Enabled = true;
                MascaraValor(TxbRenda.Text);
                MascaraCPF(TxbCPF.Text);

            }

        }

        private void TxbCPF_TextChanged(object sender, EventArgs e)
        {
            MascaraCPF(TxbCPF.Text.ToString().Trim());
        }

        public void MascaraCPF(string value)
        {
            string cpf = new string(value.Where(char.IsDigit).ToArray());

            // Aplica a máscara de CPF (xxx.xxx.xxx-xx)
            if (cpf.Length >= 3)
            {
                cpf = cpf.Insert(3, ".");
            }
            if (cpf.Length >= 7)
            {
                cpf = cpf.Insert(7, ".");
            }
            if (cpf.Length >= 11)
            {
                cpf = cpf.Insert(11, "-");
            }

            // Atualiza o texto do TextBox com a máscara
            TxbCPF.Text = cpf;
            TxbCPF.SelectionStart = cpf.Length;
        }

        private void TxbRenda_Leave(object sender, EventArgs e)
        {

            MascaraValor(TxbRenda.ToString().Trim());

        }


        public void MascaraValor(string value)
        {
            // Obtém o texto atual do TextBox removendo caracteres não numéricos
            string textoAtual = new string(value.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(textoAtual))
            {
                // Converte o texto para um valor decimal
                decimal valorDecimal;
                if (decimal.TryParse(textoAtual, out valorDecimal))
                {
                    // Formata o valor como moeda em reais (R$)
                    TxbRenda.Text = valorDecimal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                }
                else
                {
                    // Se não for possível converter para decimal, limpa o TextBox
                    TxbRenda.Clear();
                }
            }

        }

        private void TxbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é uma letra
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Se não for uma letra, cancela a entrada
                e.Handled = true;
            }
        }

        private void TxbRenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é uma letra
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Se não for uma letra, cancela a entrada
                e.Handled = true;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            TxbNome.Text = "";
            TxbData.Value = DateTime.Now;
            TxbCPF.Text = "";
            TxbRenda.Text = "";

            BtnSalvar.Enabled = true;
            BtnAtt.Enabled = false;
            BtnDelete.Enabled = false;

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {


                    SqlConnection.Open();
                    SqlCommand command = new SqlCommand("S_DeletarUsuario_E", SqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", Id);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuário Excluído!");
                    SqlConnection.Close();
                    PreencherGrid();
                }
                catch (Exception Ex)
                {
                    SqlConnection.Close();
                    throw new Exception();
                    
                }
            }
        }

        private void BtnAtt_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var valor = TxbRenda.Text.Replace("R$", "");
                    valor = valor.Replace(".", "").Trim();
                    string ValorApurado = valor.Substring(0, valor.Length - 2);
                    ValorApurado = ValorApurado.Replace(",", "").Trim();

                    int Apurado = Convert.ToInt32(ValorApurado);

                    var CPF = TxbCPF.Text.Replace(".", "");
                    CPF = CPF.Replace("-", "");

                    SqlConnection.Open();
                    SqlCommand command = new SqlCommand("S_AtualizarUsuario_E", SqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", Id);
                    command.Parameters.AddWithValue("@Nome", TxbNome.Text);
                    command.Parameters.AddWithValue("@DataNascimento", TxbData.Value);
                    command.Parameters.AddWithValue("@ValorRenda", Apurado);
                    command.Parameters.AddWithValue("@CPF", CPF);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuário Atualizado!");
                    SqlConnection.Close();
                    PreencherGrid();
                    Clear();
                }
                catch (Exception Ex)
                {
                    SqlConnection.Close();
                    throw new Exception();

                }



            }
        }

        private void TxbRenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {


                    SqlDataAdapter command = new SqlDataAdapter("S_ListarUsuario_L", SqlConnection);
                    command.SelectCommand.CommandType = CommandType.StoredProcedure;

                    command.SelectCommand.Parameters.AddWithValue("@Texto", TxbPesquisa.Text.Trim().ToString());

                    //command.ExecuteNonQuery();

                    DataTable DTusuario = new DataTable();
                    command.Fill(DTusuario);
                    dataGridView1.DataSource = DTusuario;
                    SqlConnection.Close();
                }
                catch (Exception Ex)
                {
                    SqlConnection.Close();
                    throw new Exception();

                }
            }

        }
    }
}
