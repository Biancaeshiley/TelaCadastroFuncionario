﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCasdastroFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            menu.BackColor = Color.Transparent;

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
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            string endereco = tx_endereco.Text;
            string cidade = tx_cidade.Text;
            string estado = tx_estado.Text;
            DateTime datnascimento = Convert.ToDateTime(tx_dtnas.Text);
            double salario = Convert.ToDouble(tx_salario.Text);
            string telefone = tx_telefone.Text;
            string funcao = tx_funcao.Text;
            string estcivil = tx_estcivil.Text;


            Validacoes.ValidaCPF(tx_cpf.Text);
            MessageBox.Show(Validacoes.ValidaCPF(tx_cpf.Text).ToString());

            Validacoes.ValidaEmail(tx_email.Text);
            MessageBox.Show(Validacoes.ValidaEmail(tx_email.Text).ToString());


            MessageBox.Show("Funcionário cadastrado com sucesso!!");

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
    }
}
