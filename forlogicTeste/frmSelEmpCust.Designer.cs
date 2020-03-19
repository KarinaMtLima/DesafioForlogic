namespace forlogicTeste
{
    partial class frmSelEmpCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelEmpCust));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConsulEmp = new System.Windows.Forms.Button();
            this.btnNovoEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::forlogicTeste.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(132, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "SAIR";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConsulEmp
            // 
            this.btnConsulEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulEmp.Image = global::forlogicTeste.Properties.Resources.empCons;
            this.btnConsulEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulEmp.Location = new System.Drawing.Point(77, 78);
            this.btnConsulEmp.Name = "btnConsulEmp";
            this.btnConsulEmp.Size = new System.Drawing.Size(195, 40);
            this.btnConsulEmp.TabIndex = 7;
            this.btnConsulEmp.Text = "Consultar Emprestimos";
            this.btnConsulEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulEmp.UseVisualStyleBackColor = false;
            this.btnConsulEmp.Click += new System.EventHandler(this.btnConsulEmp_Click);
            // 
            // btnNovoEmp
            // 
            this.btnNovoEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoEmp.Image = global::forlogicTeste.Properties.Resources.empComp;
            this.btnNovoEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoEmp.Location = new System.Drawing.Point(77, 20);
            this.btnNovoEmp.Name = "btnNovoEmp";
            this.btnNovoEmp.Size = new System.Drawing.Size(195, 40);
            this.btnNovoEmp.TabIndex = 6;
            this.btnNovoEmp.Text = "Novo Emprestimo";
            this.btnNovoEmp.UseVisualStyleBackColor = false;
            this.btnNovoEmp.Click += new System.EventHandler(this.btnNovoEmp_Click);
            // 
            // frmSelEmpCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 196);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConsulEmp);
            this.Controls.Add(this.btnNovoEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelEmpCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecionarEmpCust";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConsulEmp;
        private System.Windows.Forms.Button btnNovoEmp;
    }
}