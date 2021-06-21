
namespace Biblioteca.Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.Gb_Login = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.rbtnDocente = new System.Windows.Forms.RadioButton();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.Gb_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(51, 64);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 29);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(51, 137);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(146, 29);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // Gb_Login
            // 
            this.Gb_Login.Controls.Add(this.rdbtnAdmin);
            this.Gb_Login.Controls.Add(this.rbtnDocente);
            this.Gb_Login.Controls.Add(this.btnEntrar);
            this.Gb_Login.Controls.Add(this.txtContraseña);
            this.Gb_Login.Controls.Add(this.txtCorreo);
            this.Gb_Login.Controls.Add(this.lblCorreo);
            this.Gb_Login.Controls.Add(this.lblContraseña);
            this.Gb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Login.Location = new System.Drawing.Point(90, 65);
            this.Gb_Login.Name = "Gb_Login";
            this.Gb_Login.Size = new System.Drawing.Size(630, 308);
            this.Gb_Login.TabIndex = 2;
            this.Gb_Login.TabStop = false;
            this.Gb_Login.Text = "Iniciar Sesión";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(203, 64);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(339, 35);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(203, 137);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(339, 35);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(427, 252);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(115, 39);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // rbtnDocente
            // 
            this.rbtnDocente.AutoSize = true;
            this.rbtnDocente.Location = new System.Drawing.Point(56, 206);
            this.rbtnDocente.Name = "rbtnDocente";
            this.rbtnDocente.Size = new System.Drawing.Size(135, 33);
            this.rbtnDocente.TabIndex = 5;
            this.rbtnDocente.TabStop = true;
            this.rbtnDocente.Text = "Docente";
            this.rbtnDocente.UseVisualStyleBackColor = true;
            this.rbtnDocente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(56, 258);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(200, 33);
            this.rdbtnAdmin.TabIndex = 6;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Administrador";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            this.rdbtnAdmin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gb_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gb_Login.ResumeLayout(false);
            this.Gb_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.GroupBox Gb_Login;
        private System.Windows.Forms.RadioButton rbtnDocente;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
    }
}

