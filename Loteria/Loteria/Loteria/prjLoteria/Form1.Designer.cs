namespace prjLoteria
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnCartela = new System.Windows.Forms.Panel();
            this.rbMegasena = new System.Windows.Forms.RadioButton();
            this.rbLotomania = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbLotofacil = new System.Windows.Forms.RadioButton();
            this.btnCartela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnCartela
            // 
            this.pnCartela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.pnCartela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCartela.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCartela.Location = new System.Drawing.Point(0, 70);
            this.pnCartela.Name = "pnCartela";
            this.pnCartela.Size = new System.Drawing.Size(671, 516);
            this.pnCartela.TabIndex = 0;
            // 
            // rbMegasena
            // 
            this.rbMegasena.AutoSize = true;
            this.rbMegasena.Checked = true;
            this.rbMegasena.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMegasena.ForeColor = System.Drawing.Color.White;
            this.rbMegasena.Location = new System.Drawing.Point(9, 12);
            this.rbMegasena.Name = "rbMegasena";
            this.rbMegasena.Size = new System.Drawing.Size(121, 22);
            this.rbMegasena.TabIndex = 1;
            this.rbMegasena.TabStop = true;
            this.rbMegasena.Text = "MEGASENA";
            this.rbMegasena.UseVisualStyleBackColor = true;
            // 
            // rbLotomania
            // 
            this.rbLotomania.AutoSize = true;
            this.rbLotomania.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLotomania.ForeColor = System.Drawing.Color.White;
            this.rbLotomania.Location = new System.Drawing.Point(9, 41);
            this.rbLotomania.Name = "rbLotomania";
            this.rbLotomania.Size = new System.Drawing.Size(125, 22);
            this.rbLotomania.TabIndex = 2;
            this.rbLotomania.Text = "LOTOMANIA";
            this.rbLotomania.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuina.ForeColor = System.Drawing.Color.White;
            this.rbQuina.Location = new System.Drawing.Point(153, 12);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(79, 22);
            this.rbQuina.TabIndex = 3;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbLotofacil
            // 
            this.rbLotofacil.AutoSize = true;
            this.rbLotofacil.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLotofacil.ForeColor = System.Drawing.Color.White;
            this.rbLotofacil.Location = new System.Drawing.Point(153, 41);
            this.rbLotofacil.Name = "rbLotofacil";
            this.rbLotofacil.Size = new System.Drawing.Size(118, 22);
            this.rbLotofacil.TabIndex = 4;
            this.rbLotofacil.Text = "LOTOFACIL";
            this.rbLotofacil.UseVisualStyleBackColor = true;
            // 
            // btnCartela
            // 
            this.btnCartela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnCartela.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartela.ForeColor = System.Drawing.Color.White;
            this.btnCartela.Location = new System.Drawing.Point(462, 12);
            this.btnCartela.Name = "btnCartela";
            this.btnCartela.Size = new System.Drawing.Size(197, 52);
            this.btnCartela.TabIndex = 5;
            this.btnCartela.Text = "GERAR CARTELA";
            this.btnCartela.UseVisualStyleBackColor = false;
            this.btnCartela.Click += new System.EventHandler(this.btnCartela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(671, 586);
            this.Controls.Add(this.btnCartela);
            this.Controls.Add(this.rbLotofacil);
            this.Controls.Add(this.rbQuina);
            this.Controls.Add(this.rbLotomania);
            this.Controls.Add(this.rbMegasena);
            this.Controls.Add(this.pnCartela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERADOR DE CARTELAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCartela;
        private System.Windows.Forms.RadioButton rbMegasena;
        private System.Windows.Forms.RadioButton rbLotomania;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotofacil;
        private System.Windows.Forms.Button btnCartela;
    }
}

