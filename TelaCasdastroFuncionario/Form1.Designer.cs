namespace TelaCasdastroFuncionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tx_id = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_dtnas = new System.Windows.Forms.MaskedTextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_estcivil = new System.Windows.Forms.ComboBox();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.excluir = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.fechar = new System.Windows.Forms.Button();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_id
            // 
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Location = new System.Drawing.Point(48, 55);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(100, 13);
            this.tx_id.TabIndex = 0;
            this.tx_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_id_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tx_nome
            // 
            this.tx_nome.AcceptsReturn = true;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Location = new System.Drawing.Point(48, 100);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(290, 13);
            this.tx_nome.TabIndex = 2;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Location = new System.Drawing.Point(48, 194);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(300, 13);
            this.tx_endereco.TabIndex = 5;
            // 
            // tx_cidade
            // 
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Location = new System.Drawing.Point(48, 240);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(122, 13);
            this.tx_cidade.TabIndex = 6;
            // 
            // tx_estado
            // 
            this.tx_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_estado.Location = new System.Drawing.Point(216, 240);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(127, 13);
            this.tx_estado.TabIndex = 7;
            // 
            // tx_salario
            // 
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Location = new System.Drawing.Point(235, 293);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(108, 13);
            this.tx_salario.TabIndex = 9;
            this.tx_salario.TextChanged += new System.EventHandler(this.tx_salario_TextChanged);
            this.tx_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_salario_KeyPress);
            // 
            // tx_dtnas
            // 
            this.tx_dtnas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_dtnas.Location = new System.Drawing.Point(48, 293);
            this.tx_dtnas.Mask = "00/00/0000";
            this.tx_dtnas.Name = "tx_dtnas";
            this.tx_dtnas.Size = new System.Drawing.Size(122, 13);
            this.tx_dtnas.TabIndex = 10;
            this.tx_dtnas.ValidatingType = typeof(System.DateTime);
            this.tx_dtnas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tx_email
            // 
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Location = new System.Drawing.Point(406, 100);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(303, 13);
            this.tx_email.TabIndex = 11;
            // 
            // tx_estcivil
            // 
            this.tx_estcivil.FormattingEnabled = true;
            this.tx_estcivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Víuvo(a)"});
            this.tx_estcivil.Location = new System.Drawing.Point(406, 237);
            this.tx_estcivil.Name = "tx_estcivil";
            this.tx_estcivil.Size = new System.Drawing.Size(129, 21);
            this.tx_estcivil.TabIndex = 13;
            // 
            // tx_funcao
            // 
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Contador",
            "Analista Financeiro",
            "Perícia Contábil",
            "Consultor",
            "Auditor",
            "Gerente Financeiro",
            "Controller",
            "Consultor trabalhista e previdenciário"});
            this.tx_funcao.Location = new System.Drawing.Point(406, 191);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(129, 21);
            this.tx_funcao.TabIndex = 14;
            this.tx_funcao.SelectedIndexChanged += new System.EventHandler(this.tx_funcao_SelectedIndexChanged);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(391, 283);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 23);
            this.excluir.TabIndex = 15;
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(491, 283);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 16;
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // tx_cpf
            // 
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tx_cpf.Location = new System.Drawing.Point(48, 145);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(122, 13);
            this.tx_cpf.TabIndex = 17;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(724, 1);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(26, 23);
            this.fechar.TabIndex = 18;
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // tx_rg
            // 
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_rg.Location = new System.Drawing.Point(216, 145);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(120, 13);
            this.tx_rg.TabIndex = 19;
            this.tx_rg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tx_rg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_rg_KeyPress_1);
            // 
            // tx_telefone
            // 
            this.tx_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_telefone.Location = new System.Drawing.Point(406, 145);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(129, 13);
            this.tx_telefone.TabIndex = 20;
            this.tx_telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_telefone_MaskInputRejected);
            this.tx_telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_telefone_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(213, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "R$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 13);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_rg_KeyPress_1);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(2, 1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(34, 23);
            this.menu.TabIndex = 22;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TelaCasdastroFuncionario.Properties.Resources.Frame_1__11_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(750, 323);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tx_estcivil);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_dtnas);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.MaskedTextBox tx_dtnas;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.ComboBox tx_estcivil;
        private System.Windows.Forms.ComboBox tx_funcao;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button menu;
    }
}

