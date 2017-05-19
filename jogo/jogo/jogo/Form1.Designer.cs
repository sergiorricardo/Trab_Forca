namespace jogo
{
    partial class frmJogo
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
            this.pnJogo = new System.Windows.Forms.Panel();
            this.Mensagem = new System.Windows.Forms.Panel();
            this.dica = new System.Windows.Forms.GroupBox();
            this.lbldica = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btOk = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLetrasDigitadas = new System.Windows.Forms.TextBox();
            this.imgWin = new System.Windows.Forms.PictureBox();
            this.imgGO = new System.Windows.Forms.PictureBox();
            this.lbrestantes = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnJogo.SuspendLayout();
            this.Mensagem.SuspendLayout();
            this.dica.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGO)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.pictureBox1);
            this.pnJogo.Controls.Add(this.dica);
            this.pnJogo.Controls.Add(this.groupBox3);
            this.pnJogo.Controls.Add(this.txtPalavra);
            this.pnJogo.Controls.Add(this.label1);
            this.pnJogo.Location = new System.Drawing.Point(12, 12);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(760, 401);
            this.pnJogo.TabIndex = 2;
            this.pnJogo.Visible = false;
            this.pnJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnJogo_Paint);
            // 
            // Mensagem
            // 
            this.Mensagem.Controls.Add(this.imgWin);
            this.Mensagem.Controls.Add(this.imgGO);
            this.Mensagem.Location = new System.Drawing.Point(2, 0);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(783, 413);
            this.Mensagem.TabIndex = 5;
            this.Mensagem.Visible = false;
            // 
            // dica
            // 
            this.dica.Controls.Add(this.lbldica);
            this.dica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dica.Location = new System.Drawing.Point(18, 107);
            this.dica.Name = "dica";
            this.dica.Size = new System.Drawing.Size(730, 72);
            this.dica.TabIndex = 4;
            this.dica.TabStop = false;
            this.dica.Text = "Dica";
            this.dica.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lbldica
            // 
            this.lbldica.AutoSize = true;
            this.lbldica.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldica.Location = new System.Drawing.Point(14, 27);
            this.lbldica.Name = "lbldica";
            this.lbldica.Size = new System.Drawing.Size(20, 21);
            this.lbldica.TabIndex = 4;
            this.lbldica.Text = "5";
            this.lbldica.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btOk);
            this.groupBox3.Controls.Add(this.txtLetra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 190);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escreva uma letra";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(18, 79);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(442, 36);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "Identificar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(18, 30);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(442, 31);
            this.txtLetra.TabIndex = 0;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra.TextChanged += new System.EventHandler(this.txtLetra_TextChanged);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Enabled = false;
            this.txtPalavra.Location = new System.Drawing.Point(18, 72);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(730, 20);
            this.txtPalavra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifique a palavra secreta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(697, 439);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 439);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLetrasDigitadas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 63);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Letras digitadas";
            // 
            // txtLetrasDigitadas
            // 
            this.txtLetrasDigitadas.Enabled = false;
            this.txtLetrasDigitadas.Location = new System.Drawing.Point(16, 30);
            this.txtLetrasDigitadas.Name = "txtLetrasDigitadas";
            this.txtLetrasDigitadas.Size = new System.Drawing.Size(409, 21);
            this.txtLetrasDigitadas.TabIndex = 0;
            this.txtLetrasDigitadas.TextChanged += new System.EventHandler(this.txtLetrasDigitadas_TextChanged);
            // 
            // imgWin
            // 
            this.imgWin.Image = global::jogo.Properties.Resources.win;
            this.imgWin.Location = new System.Drawing.Point(0, 0);
            this.imgWin.Name = "imgWin";
            this.imgWin.Size = new System.Drawing.Size(785, 413);
            this.imgWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgWin.TabIndex = 1;
            this.imgWin.TabStop = false;
            // 
            // imgGO
            // 
            this.imgGO.Image = global::jogo.Properties.Resources.go1;
            this.imgGO.Location = new System.Drawing.Point(-2, 0);
            this.imgGO.Name = "imgGO";
            this.imgGO.Size = new System.Drawing.Size(785, 413);
            this.imgGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGO.TabIndex = 0;
            this.imgGO.TabStop = false;
            // 
            // lbrestantes
            // 
            this.lbrestantes.AutoSize = true;
            this.lbrestantes.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrestantes.Location = new System.Drawing.Point(110, 48);
            this.lbrestantes.Name = "lbrestantes";
            this.lbrestantes.Size = new System.Drawing.Size(20, 21);
            this.lbrestantes.TabIndex = 3;
            this.lbrestantes.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbrestantes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(175, 541);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tentativas restantes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogo.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(546, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.Mensagem);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnJogo);
            this.Name = "frmJogo";
            this.Text = "Jogo da forca";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.Mensagem.ResumeLayout(false);
            this.dica.ResumeLayout(false);
            this.dica.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGO)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox dica;
        private System.Windows.Forms.Label lbldica;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel Mensagem;
        private System.Windows.Forms.PictureBox imgGO;
        private System.Windows.Forms.PictureBox imgWin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLetrasDigitadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbrestantes;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

