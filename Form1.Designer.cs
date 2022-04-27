namespace WF_3
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
            this.lblarquivo = new System.Windows.Forms.Label();
            this.lbldelete = new System.Windows.Forms.Label();
            this.txtPastaCriada = new System.Windows.Forms.TextBox();
            this.txtDeletarArquivo = new System.Windows.Forms.TextBox();
            this.lblmovendo = new System.Windows.Forms.Label();
            this.txtArquivoOrigem = new System.Windows.Forms.TextBox();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.lblorigem = new System.Windows.Forms.Label();
            this.lbldestino = new System.Windows.Forms.Label();
            this.btncriar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnmover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.lblpastaorigem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblarquivo
            // 
            this.lblarquivo.AutoSize = true;
            this.lblarquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarquivo.Location = new System.Drawing.Point(74, 58);
            this.lblarquivo.Name = "lblarquivo";
            this.lblarquivo.Size = new System.Drawing.Size(138, 20);
            this.lblarquivo.TabIndex = 0;
            this.lblarquivo.Text = "Criando o Arquivo ";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.Location = new System.Drawing.Point(74, 113);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(153, 20);
            this.lbldelete.TabIndex = 0;
            this.lbldelete.Text = "Deletando o Arquivo";
            // 
            // txtPastaCriada
            // 
            this.txtPastaCriada.Location = new System.Drawing.Point(282, 56);
            this.txtPastaCriada.Name = "txtPastaCriada";
            this.txtPastaCriada.Size = new System.Drawing.Size(320, 20);
            this.txtPastaCriada.TabIndex = 1;
            this.txtPastaCriada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDeletarArquivo
            // 
            this.txtDeletarArquivo.Location = new System.Drawing.Point(282, 115);
            this.txtDeletarArquivo.Name = "txtDeletarArquivo";
            this.txtDeletarArquivo.Size = new System.Drawing.Size(320, 20);
            this.txtDeletarArquivo.TabIndex = 1;
            // 
            // lblmovendo
            // 
            this.lblmovendo.AutoSize = true;
            this.lblmovendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmovendo.Location = new System.Drawing.Point(74, 306);
            this.lblmovendo.Name = "lblmovendo";
            this.lblmovendo.Size = new System.Drawing.Size(144, 20);
            this.lblmovendo.TabIndex = 2;
            this.lblmovendo.Text = "Movendo o Arquivo";
            // 
            // txtArquivoOrigem
            // 
            this.txtArquivoOrigem.Location = new System.Drawing.Point(293, 310);
            this.txtArquivoOrigem.Name = "txtArquivoOrigem";
            this.txtArquivoOrigem.Size = new System.Drawing.Size(328, 20);
            this.txtArquivoOrigem.TabIndex = 3;
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Location = new System.Drawing.Point(293, 360);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(328, 20);
            this.txtPastaDestino.TabIndex = 3;
            // 
            // lblorigem
            // 
            this.lblorigem.AutoSize = true;
            this.lblorigem.Location = new System.Drawing.Point(306, 296);
            this.lblorigem.Name = "lblorigem";
            this.lblorigem.Size = new System.Drawing.Size(40, 13);
            this.lblorigem.TabIndex = 4;
            this.lblorigem.Text = "Origem";
            // 
            // lbldestino
            // 
            this.lbldestino.AutoSize = true;
            this.lbldestino.Location = new System.Drawing.Point(311, 344);
            this.lbldestino.Name = "lbldestino";
            this.lbldestino.Size = new System.Drawing.Size(43, 13);
            this.lbldestino.TabIndex = 5;
            this.lbldestino.Text = "Destino";
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(652, 55);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(113, 33);
            this.btncriar.TabIndex = 6;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(652, 108);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(113, 33);
            this.btndeletar.TabIndex = 6;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnmover
            // 
            this.btnmover.Location = new System.Drawing.Point(652, 324);
            this.btnmover.Name = "btnmover";
            this.btnmover.Size = new System.Drawing.Size(113, 33);
            this.btnmover.TabIndex = 6;
            this.btnmover.Text = "Mover";
            this.btnmover.UseVisualStyleBackColor = true;
            this.btnmover.Click += new System.EventHandler(this.btnmover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Location = new System.Drawing.Point(293, 268);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(323, 20);
            this.txtPastaOrigem.TabIndex = 7;
            // 
            // lblpastaorigem
            // 
            this.lblpastaorigem.AutoSize = true;
            this.lblpastaorigem.Location = new System.Drawing.Point(306, 241);
            this.lblpastaorigem.Name = "lblpastaorigem";
            this.lblpastaorigem.Size = new System.Drawing.Size(70, 13);
            this.lblpastaorigem.TabIndex = 8;
            this.lblpastaorigem.Text = "Pasta Origem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpastaorigem);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnmover);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.lbldestino);
            this.Controls.Add(this.lblorigem);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.txtArquivoOrigem);
            this.Controls.Add(this.lblmovendo);
            this.Controls.Add(this.txtDeletarArquivo);
            this.Controls.Add(this.txtPastaCriada);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.lblarquivo);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblarquivo;
        private System.Windows.Forms.Label lbldelete;
        private System.Windows.Forms.TextBox txtPastaCriada;
        private System.Windows.Forms.TextBox txtDeletarArquivo;
        private System.Windows.Forms.Label lblmovendo;
        private System.Windows.Forms.TextBox txtArquivoOrigem;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Label lblorigem;
        private System.Windows.Forms.Label lbldestino;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnmover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPastaOrigem;
        private System.Windows.Forms.Label lblpastaorigem;
    }
}

