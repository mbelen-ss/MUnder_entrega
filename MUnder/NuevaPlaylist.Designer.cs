namespace MUnder
{
    partial class NuevaPlaylist
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
            txtNombrePlaylist = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            btnCrear = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 113);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // txtNombrePlaylist
            // 
            txtNombrePlaylist.Font = new Font("Segoe UI", 12F);
            txtNombrePlaylist.ForeColor = SystemColors.WindowFrame;
            txtNombrePlaylist.Location = new Point(245, 137);
            txtNombrePlaylist.Name = "txtNombrePlaylist";
            txtNombrePlaylist.PlaceholderText = "Nombre de tu playlist";
            txtNombrePlaylist.Size = new Size(319, 29);
            txtNombrePlaylist.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.ForeColor = SystemColors.WindowFrame;
            txtDescripcion.Location = new Point(245, 206);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Describe tu playlist...";
            txtDescripcion.Size = new Size(319, 82);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 179);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 2;
            label2.Text = "Descripción: ";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.SlateBlue;
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(271, 306);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(95, 34);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(422, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(294, 55);
            label3.Name = "label3";
            label3.Size = new Size(206, 37);
            label3.TabIndex = 6;
            label3.Text = "Nueva PlayList";
            label3.Click += label3_Click;
            // 
            // NuevaPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombrePlaylist);
            Controls.Add(label1);
            Name = "NuevaPlaylist";
            Text = "NuevaPlaylist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrePlaylist;
        private TextBox txtDescripcion;
        private Label label2;
        private Button btnCrear;
        private Button btnCancelar;
        private Label label3;
    }
}