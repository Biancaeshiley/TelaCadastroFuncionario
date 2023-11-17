using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaCasdastroFuncionario.Configuracoes;

namespace TelaCasdastroFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Consultar();

            excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
            excluir.FlatAppearance.BorderSize = 0;
            excluir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            excluir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            excluir.BackColor = Color.Transparent;

            cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cadastrar.FlatAppearance.BorderSize = 0;
            cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cadastrar.BackColor = Color.Transparent;

            fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            fechar.FlatAppearance.BorderSize = 0;
            fechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            fechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            fechar.BackColor = Color.Transparent;

        }

        void Inserir(Funcionario fun)
        {
            var nomeFun = "Bianca Eshiley Abreu Torres";
            var datanascFun = "30/07/2007";
            var cpfFun = "040.124.122-05";
            var rgFun = "1235678";
            var telefoneFun = "(69)99393-5418";
            var emailFun = "Eshileybianca4@gmail.com";
            var estadocivilFun = "Solteiro(a)";
            var funcaoFun = "Estágiaria";
            var salarioFun = "500";
            
            try
            {
                ConexoeBD conexoe = new ConexoeBD();

                var comando = conexoe.Comando("INSERT INTO funcionario (nome_fun, cpf_fun) VALUES (@nome, @cpf)");

                comando.Parameters.AddWithValue("@nome", nomeFun);
                comando.Parameters.AddWithValue("@cpf", cpfFun);

                var resultado = comando.ExecuteNonQuery();

                if(resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastro com sucesso");
                }
                LimparTextBoxs();
                Consultar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);            
            }

        }

        void Consultar()
        {
            try
            {
                var ConexoeBD = new ConexoeBD();

                var comando = ConexoeBD.Comando("SELECT * FROM Funcionario");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("nome_fun");
                }

                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparTextBoxs()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
        }

        private bool ExistemTextBoxsVazio()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    var text = control.Text.Replace(",", " ").Replace("-", "").Trim();

                    if(text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


           
            tx_id.Clear();
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_rg.Clear();
            tx_endereco.Clear();
            tx_cidade.Clear();
            tx_estado.Clear();
            tx_dtnas.Clear();
            tx_salario.Clear();
            tx_email.Clear();
            tx_telefone.Clear();
            tx_funcao.Text = "";
            tx_estcivil.Text = "";
            
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            Funcionario f = new Funcionario();
            string id = tx_id.Text;
            f.Nome = tx_nome.Text;
            f.Cpf = tx_cpf.Text;
            f.Endereco = tx_endereco.Text;
            f.Cidade = tx_cidade.Text;
            f.Estado = tx_estado.Text;
            f.Datnascimento = Convert.ToDateTime(tx_dtnas.Text);
            f.Salario = Convert.ToDouble(tx_salario.Text);
            f.Telefone = tx_telefone.Text;
            f.Funcao = tx_funcao.Text;
            f.EstCivil = tx_estcivil.Text;


            if (ExistemTextBoxsVazio())
            {
                MessageBox.Show("Todos os campos são obrigatórios. Favor Preencher os campos corretamente.", "Arenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir(f);
            }
                

            
            /*Validacoes.ValidaCPF(tx_cpf.Text);
            MessageBox.Show(Validacoes.ValidaCPF(tx_cpf.Text).ToString());

            Validacoes.ValidaEmail(tx_email.Text);
            MessageBox.Show(Validacoes.ValidaEmail(tx_email.Text).ToString());*/
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void tx_rg_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tx_rg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tx_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tx_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tx_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tx_telefone_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void tx_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
