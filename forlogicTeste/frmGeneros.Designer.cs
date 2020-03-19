namespace forlogicTeste
{
    partial class frmGeneros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneros));
            this.btnSairGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSelG = new System.Windows.Forms.ComboBox();
            this.txtTituloG = new System.Windows.Forms.TextBox();
            this.txtDirG = new System.Windows.Forms.TextBox();
            this.txtAnoG = new System.Windows.Forms.TextBox();
            this.txtGenG = new System.Windows.Forms.TextBox();
            this.txtPaisG = new System.Windows.Forms.TextBox();
            this.btnGenPes = new System.Windows.Forms.Button();
            this.btnLimparG = new System.Windows.Forms.Button();
            this.btnEmpG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSairGen
            // 
            this.btnSairGen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSairGen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairGen.Image = global::forlogicTeste.Properties.Resources.close;
            this.btnSairGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairGen.Location = new System.Drawing.Point(361, 267);
            this.btnSairGen.Name = "btnSairGen";
            this.btnSairGen.Size = new System.Drawing.Size(88, 60);
            this.btnSairGen.TabIndex = 4;
            this.btnSairGen.Text = "SAIR";
            this.btnSairGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairGen.UseVisualStyleBackColor = false;
            this.btnSairGen.Click += new System.EventHandler(this.btnSairGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione Gênero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diretor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gênero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pais:";
            // 
            // cbSelG
            // 
            this.cbSelG.FormattingEnabled = true;
            this.cbSelG.Items.AddRange(new object[] {
            "comedia",
            "acao",
            "terror",
            "romance"});
            this.cbSelG.Location = new System.Drawing.Point(163, 37);
            this.cbSelG.Name = "cbSelG";
            this.cbSelG.Size = new System.Drawing.Size(159, 21);
            this.cbSelG.TabIndex = 11;
            this.cbSelG.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTituloG
            // 
            this.txtTituloG.Location = new System.Drawing.Point(106, 91);
            this.txtTituloG.Multiline = true;
            this.txtTituloG.Name = "txtTituloG";
            this.txtTituloG.Size = new System.Drawing.Size(216, 20);
            this.txtTituloG.TabIndex = 12;
            // 
            // txtDirG
            // 
            this.txtDirG.Location = new System.Drawing.Point(106, 148);
            this.txtDirG.Multiline = true;
            this.txtDirG.Name = "txtDirG";
            this.txtDirG.Size = new System.Drawing.Size(216, 20);
            this.txtDirG.TabIndex = 13;
            // 
            // txtAnoG
            // 
            this.txtAnoG.Location = new System.Drawing.Point(106, 201);
            this.txtAnoG.Multiline = true;
            this.txtAnoG.Name = "txtAnoG";
            this.txtAnoG.Size = new System.Drawing.Size(216, 20);
            this.txtAnoG.TabIndex = 14;
            // 
            // txtGenG
            // 
            this.txtGenG.Location = new System.Drawing.Point(106, 253);
            this.txtGenG.Multiline = true;
            this.txtGenG.Name = "txtGenG";
            this.txtGenG.Size = new System.Drawing.Size(216, 20);
            this.txtGenG.TabIndex = 15;
            // 
            // txtPaisG
            // 
            this.txtPaisG.Location = new System.Drawing.Point(106, 307);
            this.txtPaisG.Multiline = true;
            this.txtPaisG.Name = "txtPaisG";
            this.txtPaisG.Size = new System.Drawing.Size(216, 20);
            this.txtPaisG.TabIndex = 16;
            // 
            // btnGenPes
            // 
            this.btnGenPes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGenPes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPes.Image = global::forlogicTeste.Properties.Resources.empCons;
            this.btnGenPes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenPes.Location = new System.Drawing.Point(361, 37);
            this.btnGenPes.Name = "btnGenPes";
            this.btnGenPes.Size = new System.Drawing.Size(88, 60);
            this.btnGenPes.TabIndex = 17;
            this.btnGenPes.Text = "Pesquisar";
            this.btnGenPes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenPes.UseVisualStyleBackColor = false;
            this.btnGenPes.Click += new System.EventHandler(this.btnGenPes_Click);
            // 
            // btnLimparG
            // 
            this.btnLimparG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimparG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparG.Image = global::forlogicTeste.Properties.Resources.ClearUser;
            this.btnLimparG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimparG.Location = new System.Drawing.Point(361, 112);
            this.btnLimparG.Name = "btnLimparG";
            this.btnLimparG.Size = new System.Drawing.Size(88, 60);
            this.btnLimparG.TabIndex = 18;
            this.btnLimparG.Text = "LIMPAR";
            this.btnLimparG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparG.UseVisualStyleBackColor = false;
            this.btnLimparG.Click += new System.EventHandler(this.btnLimparG_Click);
            // 
            // btnEmpG
            // 
            this.btnEmpG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEmpG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpG.Image = global::forlogicTeste.Properties.Resources.empComp;
            this.btnEmpG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpG.Location = new System.Drawing.Point(361, 191);
            this.btnEmpG.Name = "btnEmpG";
            this.btnEmpG.Size = new System.Drawing.Size(88, 60);
            this.btnEmpG.TabIndex = 19;
            this.btnEmpG.Text = "Emprestar";
            this.btnEmpG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpG.UseVisualStyleBackColor = false;
            this.btnEmpG.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 358);
            this.Controls.Add(this.btnEmpG);
            this.Controls.Add(this.btnLimparG);
            this.Controls.Add(this.btnGenPes);
            this.Controls.Add(this.txtPaisG);
            this.Controls.Add(this.txtGenG);
            this.Controls.Add(this.txtAnoG);
            this.Controls.Add(this.txtDirG);
            this.Controls.Add(this.txtTituloG);
            this.Controls.Add(this.cbSelG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSairGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerosFilmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSelG;
        private System.Windows.Forms.TextBox txtTituloG;
        private System.Windows.Forms.TextBox txtDirG;
        private System.Windows.Forms.TextBox txtAnoG;
        private System.Windows.Forms.TextBox txtGenG;
        private System.Windows.Forms.TextBox txtPaisG;
        private System.Windows.Forms.Button btnGenPes;
        private System.Windows.Forms.Button btnLimparG;
        private System.Windows.Forms.Button btnEmpG;
    }
}