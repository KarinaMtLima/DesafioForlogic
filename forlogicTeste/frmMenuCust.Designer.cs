namespace forlogicTeste
{
    partial class frmMenuCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCust));
            this.btnClose = new System.Windows.Forms.Button();
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
            this.btnClose.Location = new System.Drawing.Point(116, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "SAIR";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnEmprest
            // 
            this.btnEmprest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmprest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprest.Image = global::forlogicTeste.Properties.Resources.emp;
            this.btnEmprest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmprest.Location = new System.Drawing.Point(187, 28);
            this.btnEmprest.Name = "btnEmprest";
            this.btnEmprest.Size = new System.Drawing.Size(99, 88);
            this.btnEmprest.TabIndex = 3;
            this.btnEmprest.Text = "EMPRESTIMOS";
            this.btnEmprest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmprest.UseVisualStyleBackColor = false;
            this.btnEmprest.Click += new System.EventHandler(this.btnEmprest_Click);
            // 
            // btnFilmes
            // 
            this.btnFilmes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilmes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmes.Image = global::forlogicTeste.Properties.Resources.movie;
            this.btnFilmes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilmes.Location = new System.Drawing.Point(30, 28);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(99, 88);
            this.btnFilmes.TabIndex = 2;
            this.btnFilmes.Text = "FILMES";
            this.btnFilmes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmes.UseVisualStyleBackColor = false;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // frmMenuCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEmprest);
            this.Controls.Add(this.btnFilmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmprest;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnClose;
    }
}