namespace Jsonc
{
    partial class dtg_view
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.tx_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.dgt_view = new System.Windows.Forms.DataGridView();
            this.bt_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(124, 105);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(166, 20);
            this.tx_nome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(393, 105);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(87, 20);
            this.tx_telefone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(124, 181);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(130, 20);
            this.tx_email.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de Nascimento:";
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.White;
            this.bt_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_limpar.Location = new System.Drawing.Point(93, 238);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(78, 31);
            this.bt_limpar.TabIndex = 9;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // tx_nascimento
            // 
            this.tx_nascimento.Location = new System.Drawing.Point(670, 105);
            this.tx_nascimento.Mask = "00/00/0000";
            this.tx_nascimento.Name = "tx_nascimento";
            this.tx_nascimento.Size = new System.Drawing.Size(65, 20);
            this.tx_nascimento.TabIndex = 10;
            this.tx_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF:";
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(635, 178);
            this.tx_cpf.Mask = "000-000-000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 20);
            this.tx_cpf.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Endereço:";
            // 
            // tx_endereco
            // 
            this.tx_endereco.Location = new System.Drawing.Point(356, 179);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(228, 20);
            this.tx_endereco.TabIndex = 14;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.White;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.bt_cadastrar.Location = new System.Drawing.Point(380, 237);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(79, 31);
            this.bt_cadastrar.TabIndex = 15;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgt_view
            // 
            this.dgt_view.BackgroundColor = System.Drawing.Color.White;
            this.dgt_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_view.Location = new System.Drawing.Point(93, 293);
            this.dgt_view.Name = "dgt_view";
            this.dgt_view.Size = new System.Drawing.Size(632, 173);
            this.dgt_view.TabIndex = 16;
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.White;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_excluir.Location = new System.Drawing.Point(650, 238);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 31);
            this.bt_excluir.TabIndex = 17;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dtg_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jsonc.Properties.Resources._360_F_62156749_6euFO5jMyrZaCJ7mCHxnwymCsCgGfHSc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 490);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.dgt_view);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_nascimento);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dtg_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dgt_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.MaskedTextBox tx_nascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.DataGridView dgt_view;
        private System.Windows.Forms.Button bt_excluir;
    }
}