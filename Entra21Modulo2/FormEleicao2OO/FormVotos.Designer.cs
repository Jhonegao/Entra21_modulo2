namespace FormEleicao2OO
{
    partial class FormVotos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbConfirma = new System.Windows.Forms.CheckBox();
            this.lbNomeVoto = new System.Windows.Forms.Label();
            this.pbVotacaoImagem = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradaNum = new System.Windows.Forms.TextBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgElegiveis = new System.Windows.Forms.DataGridView();
            this.lbNomeCandidatoVotado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVotacaoImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgElegiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizar.Location = new System.Drawing.Point(44, 270);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(127, 123);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar votações";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // cbConfirma
            // 
            this.cbConfirma.AutoSize = true;
            this.cbConfirma.BackColor = System.Drawing.Color.Transparent;
            this.cbConfirma.FlatAppearance.BorderSize = 2;
            this.cbConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbConfirma.Location = new System.Drawing.Point(395, 375);
            this.cbConfirma.Name = "cbConfirma";
            this.cbConfirma.Size = new System.Drawing.Size(74, 17);
            this.cbConfirma.TabIndex = 16;
            this.cbConfirma.Text = "Confirmar?";
            this.cbConfirma.UseVisualStyleBackColor = false;
            this.cbConfirma.Visible = false;
            // 
            // lbNomeVoto
            // 
            this.lbNomeVoto.AutoSize = true;
            this.lbNomeVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeVoto.Location = new System.Drawing.Point(343, 298);
            this.lbNomeVoto.Name = "lbNomeVoto";
            this.lbNomeVoto.Size = new System.Drawing.Size(0, 20);
            this.lbNomeVoto.TabIndex = 15;
            // 
            // pbVotacaoImagem
            // 
            this.pbVotacaoImagem.Location = new System.Drawing.Point(236, 57);
            this.pbVotacaoImagem.Name = "pbVotacaoImagem";
            this.pbVotacaoImagem.Size = new System.Drawing.Size(257, 251);
            this.pbVotacaoImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVotacaoImagem.TabIndex = 14;
            this.pbVotacaoImagem.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Insira o numero do candidato";
            // 
            // txtEntradaNum
            // 
            this.txtEntradaNum.Location = new System.Drawing.Point(314, 338);
            this.txtEntradaNum.Name = "txtEntradaNum";
            this.txtEntradaNum.Size = new System.Drawing.Size(75, 20);
            this.txtEntradaNum.TabIndex = 12;
            this.txtEntradaNum.TextChanged += new System.EventHandler(this.txtEntradaNum_TextChanged);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Silver;
            this.btnVotar.Enabled = false;
            this.btnVotar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Location = new System.Drawing.Point(314, 375);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 11;
            this.btnVotar.Text = "VOTAR";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista dos Elegiveis";
            // 
            // dgElegiveis
            // 
            this.dgElegiveis.AllowUserToDeleteRows = false;
            this.dgElegiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgElegiveis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgElegiveis.Location = new System.Drawing.Point(12, 23);
            this.dgElegiveis.Name = "dgElegiveis";
            this.dgElegiveis.ReadOnly = true;
            this.dgElegiveis.RowHeadersVisible = false;
            this.dgElegiveis.Size = new System.Drawing.Size(199, 242);
            this.dgElegiveis.TabIndex = 9;
            // 
            // lbNomeCandidatoVotado
            // 
            this.lbNomeCandidatoVotado.AutoSize = true;
            this.lbNomeCandidatoVotado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCandidatoVotado.Location = new System.Drawing.Point(238, 31);
            this.lbNomeCandidatoVotado.Name = "lbNomeCandidatoVotado";
            this.lbNomeCandidatoVotado.Size = new System.Drawing.Size(0, 22);
            this.lbNomeCandidatoVotado.TabIndex = 18;
            // 
            // FormVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 436);
            this.Controls.Add(this.lbNomeCandidatoVotado);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cbConfirma);
            this.Controls.Add(this.lbNomeVoto);
            this.Controls.Add(this.pbVotacaoImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntradaNum);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgElegiveis);
            this.Name = "FormVotos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbVotacaoImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgElegiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.CheckBox cbConfirma;
        private System.Windows.Forms.Label lbNomeVoto;
        private System.Windows.Forms.PictureBox pbVotacaoImagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntradaNum;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgElegiveis;
        private System.Windows.Forms.Label lbNomeCandidatoVotado;
    }
}