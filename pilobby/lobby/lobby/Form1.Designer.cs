namespace lobby
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
            this.btnPartidas = new System.Windows.Forms.Button();
            this.lstPartsEncontradas = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListJogadores = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblHelsinque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPartidas
            // 
            this.btnPartidas.Location = new System.Drawing.Point(25, 35);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(120, 23);
            this.btnPartidas.TabIndex = 0;
            this.btnPartidas.Text = "Encontrar Partida";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // lstPartsEncontradas
            // 
            this.lstPartsEncontradas.FormattingEnabled = true;
            this.lstPartsEncontradas.Location = new System.Drawing.Point(25, 90);
            this.lstPartsEncontradas.Name = "lstPartsEncontradas";
            this.lstPartsEncontradas.Size = new System.Drawing.Size(163, 277);
            this.lstPartsEncontradas.TabIndex = 1;
            this.lstPartsEncontradas.SelectedIndexChanged += new System.EventHandler(this.lstPartsEncontradas_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(289, 164);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(149, 147);
            this.lstJogadores.TabIndex = 2;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // btnListJogadores
            // 
            this.btnListJogadores.Location = new System.Drawing.Point(289, 117);
            this.btnListJogadores.Name = "btnListJogadores";
            this.btnListJogadores.Size = new System.Drawing.Size(127, 24);
            this.btnListJogadores.TabIndex = 3;
            this.btnListJogadores.Text = "Jogadores na Partida";
            this.btnListJogadores.UseVisualStyleBackColor = true;
            this.btnListJogadores.Click += new System.EventHandler(this.btnListJogadores_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(707, 440);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(35, 13);
            this.lblVersao.TabIndex = 4;
            this.lblVersao.Text = "label1";
            // 
            // lblHelsinque
            // 
            this.lblHelsinque.AutoSize = true;
            this.lblHelsinque.Location = new System.Drawing.Point(261, 9);
            this.lblHelsinque.Name = "lblHelsinque";
            this.lblHelsinque.Size = new System.Drawing.Size(54, 13);
            this.lblHelsinque.TabIndex = 5;
            this.lblHelsinque.Text = "Helsinque";
            this.lblHelsinque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.Controls.Add(this.lblHelsinque);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnListJogadores);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lstPartsEncontradas);
            this.Controls.Add(this.btnPartidas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.ListBox lstPartsEncontradas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnListJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblHelsinque;
    }
}

