namespace WfmEstadisticasFutbolPG3
{
    partial class WfrmEstadisticas
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
            btnTorneos = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPartidos = new Button();
            btnEquipos = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnTorneos
            // 
            btnTorneos.Location = new Point(200, 275);
            btnTorneos.Name = "btnTorneos";
            btnTorneos.Size = new Size(94, 29);
            btnTorneos.TabIndex = 9;
            btnTorneos.Text = "Torneos";
            btnTorneos.UseVisualStyleBackColor = true;
            btnTorneos.Click += btnTorneos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(200, 125);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Jugadores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnTorneos);
            groupBox3.Controls.Add(btnPartidos);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(btnEquipos);
            groupBox3.Location = new Point(37, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(451, 390);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 275);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 41;
            label4.Text = "Ver Torneos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 200);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 40;
            label3.Text = "Ver Partidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 125);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 39;
            label2.Text = "Ver Jugadores:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 38;
            label1.Text = "Ver Equipos:";
            // 
            // btnPartidos
            // 
            btnPartidos.Location = new Point(200, 200);
            btnPartidos.Name = "btnPartidos";
            btnPartidos.Size = new Size(94, 29);
            btnPartidos.TabIndex = 37;
            btnPartidos.Text = "Partidos";
            btnPartidos.UseVisualStyleBackColor = true;
            btnPartidos.Click += btnPartidos_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Location = new Point(200, 50);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(94, 29);
            btnEquipos.TabIndex = 28;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // WfrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 468);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WfrmEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private Button button1;
        private Button btnEquipos;
        private Button btnPartidos;
        private Button btnTorneos;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}