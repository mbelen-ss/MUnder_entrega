namespace MUnder
{
    partial class Registro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrarse = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(234, 41);
            label1.Name = "label1";
            label1.Size = new Size(311, 37);
            label1.TabIndex = 0;
            label1.Text = "Registrarse en MUnder";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 96);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 165);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(240, 233);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 3;
            label4.Text = "Contraseña: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(240, 297);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 4;
            label5.Text = "Teléfono: ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(240, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Tu nombre completo";
            txtNombre.Size = new Size(296, 29);
            txtNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = SystemColors.WindowFrame;
            txtEmail.Location = new Point(240, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "tumail@gmail.com";
            txtEmail.Size = new Size(296, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(240, 257);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "******";
            txtContrasena.Size = new Size(296, 29);
            txtContrasena.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.ForeColor = SystemColors.WindowFrame;
            txtTelefono.Location = new Point(240, 321);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "+54 1234-5678";
            txtTelefono.Size = new Size(296, 29);
            txtTelefono.TabIndex = 9;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.SlateBlue;
            btnRegistrarse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(250, 375);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(107, 35);
            btnRegistrarse.TabIndex = 13;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.WhiteSmoke;
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(420, 375);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 35);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(803, 444);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtTelefono);
            Controls.Add(txtContrasena);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtTelefono;
        private Button btnRegistrarse;
        private Button btnVolver;
    }
}