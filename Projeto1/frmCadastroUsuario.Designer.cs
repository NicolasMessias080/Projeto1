namespace Projeto1
{
    partial class frmCadastroUsuario
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
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.txtCadUsuario = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.Location = new System.Drawing.Point(290, 42);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(211, 29);
            this.lblTituloUsuario.TabIndex = 0;
            this.lblTituloUsuario.Text = "Cadastro usuario";
            this.lblTituloUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadUsuario.Location = new System.Drawing.Point(221, 114);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(81, 24);
            this.lblCadUsuario.TabIndex = 1;
            this.lblCadUsuario.Text = "Usuario";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.Location = new System.Drawing.Point(221, 177);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(70, 24);
            this.lblCadSenha.TabIndex = 2;
            this.lblCadSenha.Text = "Senha";
            // 
            // txtCadUsuario
            // 
            this.txtCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadUsuario.Location = new System.Drawing.Point(341, 114);
            this.txtCadUsuario.Name = "txtCadUsuario";
            this.txtCadUsuario.Size = new System.Drawing.Size(100, 29);
            this.txtCadUsuario.TabIndex = 3;
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(341, 177);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(100, 29);
            this.txtCadSenha.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(326, 343);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 61);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.txtCadUsuario);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Controls.Add(this.lblTituloUsuario);
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblCadUsuario;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.TextBox txtCadUsuario;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Button btnCadastrar;
    }
}