namespace forlogicTeste
{
    partial class framMenuAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(framMenuAdm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnGeneros = new System.Windows.Forms.Button();
            this.btnEmprest = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::forlogicTeste.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(178, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "SAIR";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::forlogicTeste.Properties.Resources.user2;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(263, 143);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(99, 88);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "USUÁRIOS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneros.Image = global::forlogicTeste.Properties.Resources.movie1;
            this.btnGeneros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeneros.Location = new System.Drawing.Point(72, 143);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(99, 88);
            this.btnGeneros.TabIndex = 2;
            this.btnGeneros.Text = "GÊNEROS";
            this.btnGeneros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneros.UseVisualStyleBackColor = false;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // btnEmprest
            // 
            this.btnEmprest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmprest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprest.Image = global::forlogicTeste.Properties.Resources.emp;
            this.btnEmprest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmprest.Location = new System.Drawing.Point(263, 30);
            this.btnEmprest.Name = "btnEmprest";
            this.btnEmprest.Size = new System.Drawing.Size(99, 88);
            this.btnEmprest.TabIndex = 1;
            this.btnEmprest.Text = "EMPRESTIMOS";
            this.btnEmprest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmprest.UseVisualStyleBackColor = false;
            this.btnEmprest.Click += new System.EventHandler(this.btnEmprest_Click);
            // 
            // btnFilmes
            // 
            this.btnFilmes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilmes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmes.Image = global::forlogicTeste.Properties.Resources.genrooo;
            this.btnFilmes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilmes.Location = new System.Drawing.Point(72, 31);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(99, 88);
            this.btnFilmes.TabIndex = 0;
            this.btnFilmes.Text = "FILMES";
            this.btnFilmes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmes.UseVisualStyleBackColor = false;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // framMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 325);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnGeneros);
            this.Controls.Add(this.btnEmprest);
            this.Controls.Add(this.btnFilmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "framMenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnEmprest;
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClose;
    }
}