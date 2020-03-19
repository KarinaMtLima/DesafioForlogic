namespace forlogicTeste
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogUsu = new System.Windows.Forms.TextBox();
            this.txtSenhaLog = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEntar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txtLogUsu
            // 
            this.txtLogUsu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLogUsu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUsu.Location = new System.Drawing.Point(107, 173);
            this.txtLogUsu.Name = "txtLogUsu";
            this.txtLogUsu.Size = new System.Drawing.Size(100, 25);
            this.txtLogUsu.TabIndex = 3;
            // 
            // txtSenhaLog
            // 
            this.txtSenhaLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenhaLog.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLog.Location = new System.Drawing.Point(107, 215);
            this.txtSenhaLog.Name = "txtSenhaLog";
            this.txtSenhaLog.PasswordChar = '*';
            this.txtSenhaLog.Size = new System.Drawing.Size(100, 25);
            this.txtSenhaLog.TabIndex = 4;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Image = global::forlogicTeste.Properties.Resources.add;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(249, 210);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(88, 35);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEntar
            // 
            this.btnEntar.Image = global::forlogicTeste.Properties.Resources.Ok_icon;
            this.btnEntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntar.Location = new System.Drawing.Point(249, 168);
            this.btnEntar.Name = "btnEntar";
            this.btnEntar.Size = new System.Drawing.Size(88, 35);
            this.btnEntar.TabIndex = 5;
            this.btnEntar.Text = "Entrar";
            this.btnEntar.UseVisualStyleBackColor = true;
            this.btnEntar.Click += new System.EventHandler(this.btnEntar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::forlogicTeste.Properties.Resources.fotoVIDEO;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 268);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnEntar);
            this.Controls.Add(this.txtSenhaLog);
            this.Controls.Add(this.txtLogUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogUsu;
        private System.Windows.Forms.TextBox txtSenhaLog;
        private System.Windows.Forms.Button btnEntar;
        private System.Windows.Forms.Button btnCadastro;
    }
}