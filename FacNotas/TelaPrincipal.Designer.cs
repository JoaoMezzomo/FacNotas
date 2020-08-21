namespace FacNotas
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listDisciplinas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNotaFinal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMediaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtA6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMediaT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listDisciplinas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 371);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Location = new System.Drawing.Point(60, 311);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(53, 49);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "x";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.Location = new System.Drawing.Point(3, 311);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(53, 49);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "+";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplinas";
            // 
            // listDisciplinas
            // 
            this.listDisciplinas.FormattingEnabled = true;
            this.listDisciplinas.ItemHeight = 18;
            this.listDisciplinas.Location = new System.Drawing.Point(3, 29);
            this.listDisciplinas.Name = "listDisciplinas";
            this.listDisciplinas.ScrollAlwaysVisible = true;
            this.listDisciplinas.Size = new System.Drawing.Size(194, 274);
            this.listDisciplinas.TabIndex = 1;
            this.listDisciplinas.SelectedIndexChanged += new System.EventHandler(this.listDisciplinas_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 371);
            this.panel2.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 25);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.Location = new System.Drawing.Point(123, 327);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 33);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMensagem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNotaFinal);
            this.groupBox3.Location = new System.Drawing.Point(238, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 286);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nota Final";
            // 
            // txtNotaFinal
            // 
            this.txtNotaFinal.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotaFinal.Location = new System.Drawing.Point(15, 143);
            this.txtNotaFinal.Name = "txtNotaFinal";
            this.txtNotaFinal.ReadOnly = true;
            this.txtNotaFinal.Size = new System.Drawing.Size(80, 25);
            this.txtNotaFinal.TabIndex = 14;
            this.txtNotaFinal.TabStop = false;
            this.txtNotaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotaFinal.TextChanged += new System.EventHandler(this.txtNotaFinal_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMediaP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtA5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtA6);
            this.groupBox2.Location = new System.Drawing.Point(123, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 286);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Média (3,6)";
            // 
            // txtMediaP
            // 
            this.txtMediaP.BackColor = System.Drawing.SystemColors.Window;
            this.txtMediaP.Location = new System.Drawing.Point(15, 193);
            this.txtMediaP.Name = "txtMediaP";
            this.txtMediaP.ReadOnly = true;
            this.txtMediaP.Size = new System.Drawing.Size(80, 25);
            this.txtMediaP.TabIndex = 14;
            this.txtMediaP.TabStop = false;
            this.txtMediaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMediaP.TextChanged += new System.EventHandler(this.txtMediaP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "A5 - Nota";
            // 
            // txtA5
            // 
            this.txtA5.Location = new System.Drawing.Point(15, 93);
            this.txtA5.Name = "txtA5";
            this.txtA5.Size = new System.Drawing.Size(80, 25);
            this.txtA5.TabIndex = 9;
            this.txtA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA5.TextChanged += new System.EventHandler(this.txtA5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "A6 - Nota";
            // 
            // txtA6
            // 
            this.txtA6.Location = new System.Drawing.Point(15, 143);
            this.txtA6.Name = "txtA6";
            this.txtA6.Size = new System.Drawing.Size(80, 25);
            this.txtA6.TabIndex = 10;
            this.txtA6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA6.TextChanged += new System.EventHandler(this.txtA6_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMediaT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtA1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtA3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtA4);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 286);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalhos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Média (2,4)";
            // 
            // txtMediaT
            // 
            this.txtMediaT.BackColor = System.Drawing.SystemColors.Window;
            this.txtMediaT.Location = new System.Drawing.Point(15, 243);
            this.txtMediaT.Name = "txtMediaT";
            this.txtMediaT.ReadOnly = true;
            this.txtMediaT.Size = new System.Drawing.Size(80, 25);
            this.txtMediaT.TabIndex = 8;
            this.txtMediaT.TabStop = false;
            this.txtMediaT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMediaT.TextChanged += new System.EventHandler(this.txtMediaT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "A1 - Nota";
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(15, 43);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(80, 25);
            this.txtA1.TabIndex = 5;
            this.txtA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA1.TextChanged += new System.EventHandler(this.txtA1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "A2 - Nota";
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(15, 93);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(80, 25);
            this.txtA2.TabIndex = 6;
            this.txtA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA2.TextChanged += new System.EventHandler(this.txtA2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "A3 - Nota";
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(15, 143);
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(80, 25);
            this.txtA3.TabIndex = 7;
            this.txtA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA3.TextChanged += new System.EventHandler(this.txtA3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "A4 - Nota";
            // 
            // txtA4
            // 
            this.txtA4.Location = new System.Drawing.Point(15, 193);
            this.txtA4.Name = "txtA4";
            this.txtA4.Size = new System.Drawing.Size(80, 25);
            this.txtA4.TabIndex = 8;
            this.txtA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA4.TextChanged += new System.EventHandler(this.txtA4_TextChanged);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Location = new System.Drawing.Point(3, 170);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ReadOnly = true;
            this.txtMensagem.Size = new System.Drawing.Size(105, 18);
            this.txtMensagem.TabIndex = 15;
            this.txtMensagem.TabStop = false;
            this.txtMensagem.Text = "Mensagem";
            this.txtMensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacNotas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDisciplinas;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMediaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtA6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMediaT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA4;
        private System.Windows.Forms.TextBox txtNotaFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMensagem;
    }
}

