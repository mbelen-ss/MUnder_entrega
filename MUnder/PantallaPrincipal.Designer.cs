namespace MUnder
{
    partial class PantallaPrincipal
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
            btnPerfil = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMusica = new Button();
            btnPlayList = new Button();
            btnSocial = new Button();
            btnMensaje = new Button();
            btnSalir = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 142);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido a MUnder!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 173);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 1;
            label2.Text = "Tu red social de música underground";
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(3, 3);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(75, 23);
            btnPerfil.TabIndex = 0;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnPerfil);
            flowLayoutPanel1.Controls.Add(btnMusica);
            flowLayoutPanel1.Controls.Add(btnPlayList);
            flowLayoutPanel1.Controls.Add(btnSocial);
            flowLayoutPanel1.Controls.Add(btnMensaje);
            flowLayoutPanel1.Controls.Add(btnSalir);
            flowLayoutPanel1.Location = new Point(156, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(487, 35);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnMusica
            // 
            btnMusica.Location = new Point(84, 3);
            btnMusica.Name = "btnMusica";
            btnMusica.Size = new Size(75, 23);
            btnMusica.TabIndex = 1;
            btnMusica.Text = "Música";
            btnMusica.UseVisualStyleBackColor = true;
            // 
            // btnPlayList
            // 
            btnPlayList.Location = new Point(165, 3);
            btnPlayList.Name = "btnPlayList";
            btnPlayList.Size = new Size(75, 23);
            btnPlayList.TabIndex = 2;
            btnPlayList.Text = "PlayList";
            btnPlayList.UseVisualStyleBackColor = true;
            btnPlayList.Click += btnPlayList_Click;
            // 
            // btnSocial
            // 
            btnSocial.Location = new Point(246, 3);
            btnSocial.Name = "btnSocial";
            btnSocial.Size = new Size(75, 23);
            btnSocial.TabIndex = 3;
            btnSocial.Text = "Social";
            btnSocial.UseVisualStyleBackColor = true;
            // 
            // btnMensaje
            // 
            btnMensaje.Location = new Point(327, 3);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(75, 23);
            btnMensaje.TabIndex = 4;
            btnMensaje.Text = "Mensaje";
            btnMensaje.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(408, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseMnemonic = false;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Location = new Point(195, 247);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(404, 71);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 0;
            label3.Text = "Explora música underground";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(366, 30);
            label4.TabIndex = 1;
            label4.Text = "Descubre nuevos artistas, crea playlists y conecta con la comunidad muscal alternativa.";
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnPerfil;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMusica;
        private Button btnPlayList;
        private Button btnSocial;
        private Button btnMensaje;
        private Button btnSalir;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label4;
    }
}