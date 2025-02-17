namespace PiedraPapelTijera
{
    partial class PiedraPapelTijera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijera = new Button();
            lblEligeOpcion = new Label();
            label1 = new Label();
            label2 = new Label();
            lblMaquinaEligio = new Label();
            SuspendLayout();
            // 
            // btnPiedra
            // 
            btnPiedra.Location = new Point(48, 69);
            btnPiedra.Name = "btnPiedra";
            btnPiedra.Size = new Size(75, 23);
            btnPiedra.TabIndex = 0;
            btnPiedra.Text = "Piedra";
            btnPiedra.UseVisualStyleBackColor = true;
            btnPiedra.Click += btnPiedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(349, 69);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(75, 23);
            btnPapel.TabIndex = 1;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTijera
            // 
            btnTijera.Location = new Point(640, 69);
            btnTijera.Name = "btnTijera";
            btnTijera.Size = new Size(75, 23);
            btnTijera.TabIndex = 2;
            btnTijera.Text = "Tijera";
            btnTijera.UseVisualStyleBackColor = true;
            btnTijera.Click += btnTijera_Click;
            // 
            // lblEligeOpcion
            // 
            lblEligeOpcion.AutoSize = true;
            lblEligeOpcion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEligeOpcion.Location = new Point(287, 9);
            lblEligeOpcion.Name = "lblEligeOpcion";
            lblEligeOpcion.Size = new Size(192, 32);
            lblEligeOpcion.TabIndex = 3;
            lblEligeOpcion.Text = "Elige una opción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 139);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 139);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 5;
            // 
            // lblMaquinaEligio
            // 
            lblMaquinaEligio.AutoSize = true;
            lblMaquinaEligio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaquinaEligio.Location = new Point(12, 139);
            lblMaquinaEligio.Name = "lblMaquinaEligio";
            lblMaquinaEligio.Size = new Size(208, 32);
            lblMaquinaEligio.TabIndex = 6;
            lblMaquinaEligio.Text = "La maquina eligio:";
            // 
            // PiedraPapelTijera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMaquinaEligio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEligeOpcion);
            Controls.Add(btnTijera);
            Controls.Add(btnPapel);
            Controls.Add(btnPiedra);
            Name = "PiedraPapelTijera";
            Text = "Piedra - Papel - Tijera";
            Load += PiedraPapelTijera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPiedra;
        private Button btnPapel;
        private Button btnTijera;
        private Label lblEligeOpcion;
        private Label label1;
        private Label label2;
        private Label lblMaquinaEligio;
    }
}
