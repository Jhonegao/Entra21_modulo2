namespace FormEleicao2OO
{
    partial class TelaInicial
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
            this.lbMaxCandidatos = new System.Windows.Forms.Label();
            this.lbNumMinimo = new System.Windows.Forms.Label();
            this.btnIniciarVotacao = new System.Windows.Forms.Button();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.btnCadastroOK = new System.Windows.Forms.Button();
            this.btnCadastroCancel = new System.Windows.Forms.Button();
            this.btnCadastrarNovo = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarVotacao = new System.Windows.Forms.Button();
            this.txtNumeroCandidato = new System.Windows.Forms.TextBox();
            this.txtNomeCandidato = new System.Windows.Forms.TextBox();
            this.pbFotosCandidatos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaxCandidatos
            // 
            this.lbMaxCandidatos.AutoSize = true;
            this.lbMaxCandidatos.Location = new System.Drawing.Point(237, 272);
            this.lbMaxCandidatos.Name = "lbMaxCandidatos";
            this.lbMaxCandidatos.Size = new System.Drawing.Size(172, 13);
            this.lbMaxCandidatos.TabIndex = 32;
            this.lbMaxCandidatos.Text = "Quantidade atual 0 /10 candidatos";
            // 
            // lbNumMinimo
            // 
            this.lbNumMinimo.AutoSize = true;
            this.lbNumMinimo.Location = new System.Drawing.Point(62, 390);
            this.lbNumMinimo.Name = "lbNumMinimo";
            this.lbNumMinimo.Size = new System.Drawing.Size(347, 13);
            this.lbNumMinimo.TabIndex = 31;
            this.lbNumMinimo.Text = "*Necessário no minimo 2 candidados para iniciar votações ,e máximo 10";
            // 
            // btnIniciarVotacao
            // 
            this.btnIniciarVotacao.Enabled = false;
            this.btnIniciarVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarVotacao.Location = new System.Drawing.Point(313, 288);
            this.btnIniciarVotacao.Name = "btnIniciarVotacao";
            this.btnIniciarVotacao.Size = new System.Drawing.Size(75, 99);
            this.btnIniciarVotacao.TabIndex = 30;
            this.btnIniciarVotacao.Text = "Iniciar votação*";
            this.btnIniciarVotacao.UseVisualStyleBackColor = true;
            this.btnIniciarVotacao.Click += new System.EventHandler(this.btnIniciarVotacao_Click);
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.Location = new System.Drawing.Point(207, 177);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(96, 23);
            this.btnEscolherImagem.TabIndex = 29;
            this.btnEscolherImagem.Text = "Escolher Imagem";
            this.btnEscolherImagem.UseVisualStyleBackColor = true;
            this.btnEscolherImagem.Visible = false;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // btnCadastroOK
            // 
            this.btnCadastroOK.BackColor = System.Drawing.Color.Green;
            this.btnCadastroOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroOK.Location = new System.Drawing.Point(162, 288);
            this.btnCadastroOK.Name = "btnCadastroOK";
            this.btnCadastroOK.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroOK.TabIndex = 28;
            this.btnCadastroOK.Text = "OK";
            this.btnCadastroOK.UseVisualStyleBackColor = false;
            this.btnCadastroOK.Visible = false;
            this.btnCadastroOK.Click += new System.EventHandler(this.btnCadastroOK_Click);
            // 
            // btnCadastroCancel
            // 
            this.btnCadastroCancel.BackColor = System.Drawing.Color.Red;
            this.btnCadastroCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCancel.Location = new System.Drawing.Point(231, 288);
            this.btnCadastroCancel.Name = "btnCadastroCancel";
            this.btnCadastroCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroCancel.TabIndex = 27;
            this.btnCadastroCancel.Text = "CANCEL";
            this.btnCadastroCancel.UseVisualStyleBackColor = false;
            this.btnCadastroCancel.Visible = false;
            this.btnCadastroCancel.Click += new System.EventHandler(this.btnCadastroCancel_Click);
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovo.Location = new System.Drawing.Point(110, 330);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(194, 57);
            this.btnCadastrarNovo.TabIndex = 26;
            this.btnCadastrarNovo.Text = "CADASTRAR NOVO CANDIDATO";
            this.btnCadastrarNovo.UseVisualStyleBackColor = false;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.btnCadastrarNovo_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(31, 103);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(312, 103);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome";
            // 
            // btnAdicionarVotacao
            // 
            this.btnAdicionarVotacao.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionarVotacao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVotacao.Location = new System.Drawing.Point(162, 288);
            this.btnAdicionarVotacao.Name = "btnAdicionarVotacao";
            this.btnAdicionarVotacao.Size = new System.Drawing.Size(142, 22);
            this.btnAdicionarVotacao.TabIndex = 21;
            this.btnAdicionarVotacao.Text = "Colocar na votacao";
            this.btnAdicionarVotacao.UseVisualStyleBackColor = false;
            this.btnAdicionarVotacao.Click += new System.EventHandler(this.btnAdicionarVotacao_Click);
            // 
            // txtNumeroCandidato
            // 
            this.txtNumeroCandidato.Enabled = false;
            this.txtNumeroCandidato.Location = new System.Drawing.Point(110, 290);
            this.txtNumeroCandidato.Name = "txtNumeroCandidato";
            this.txtNumeroCandidato.Size = new System.Drawing.Size(41, 20);
            this.txtNumeroCandidato.TabIndex = 20;
            // 
            // txtNomeCandidato
            // 
            this.txtNomeCandidato.Enabled = false;
            this.txtNomeCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCandidato.Location = new System.Drawing.Point(112, 234);
            this.txtNomeCandidato.Name = "txtNomeCandidato";
            this.txtNomeCandidato.Size = new System.Drawing.Size(194, 23);
            this.txtNomeCandidato.TabIndex = 19;
            // 
            // pbFotosCandidatos
            // 
            this.pbFotosCandidatos.Location = new System.Drawing.Point(112, 12);
            this.pbFotosCandidatos.Name = "pbFotosCandidatos";
            this.pbFotosCandidatos.Size = new System.Drawing.Size(194, 192);
            this.pbFotosCandidatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotosCandidatos.TabIndex = 18;
            this.pbFotosCandidatos.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 437);
            this.Controls.Add(this.lbMaxCandidatos);
            this.Controls.Add(this.lbNumMinimo);
            this.Controls.Add(this.btnIniciarVotacao);
            this.Controls.Add(this.btnEscolherImagem);
            this.Controls.Add(this.btnCadastroOK);
            this.Controls.Add(this.btnCadastroCancel);
            this.Controls.Add(this.btnCadastrarNovo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarVotacao);
            this.Controls.Add(this.txtNumeroCandidato);
            this.Controls.Add(this.txtNomeCandidato);
            this.Controls.Add(this.pbFotosCandidatos);
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaxCandidatos;
        private System.Windows.Forms.Label lbNumMinimo;
        private System.Windows.Forms.Button btnIniciarVotacao;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.Button btnCadastroOK;
        private System.Windows.Forms.Button btnCadastroCancel;
        private System.Windows.Forms.Button btnCadastrarNovo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarVotacao;
        private System.Windows.Forms.TextBox txtNumeroCandidato;
        private System.Windows.Forms.TextBox txtNomeCandidato;
        private System.Windows.Forms.PictureBox pbFotosCandidatos;
    }
}

