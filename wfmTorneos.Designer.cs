namespace WfmEstadisticasFutbolPG3
{
    partial class wfmTorneos
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
            groupBox1 = new GroupBox();
            cmbxTorneos = new ComboBox();
            btnBuscarTorneo = new Button();
            btnEliminarTorneo = new Button();
            btnModificarTorneo = new Button();
            txtTemporadaTorneo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombreTorneo = new TextBox();
            btnCrearTorneo = new Button();
            groupBox2 = new GroupBox();
            cmbxMostrarEquipos = new ComboBox();
            btnAgregarEquipoTorneo = new Button();
            btnEliminarEquipoTorneo = new Button();
            label4 = new Label();
            label3 = new Label();
            cmbxMostrarTorneos = new ComboBox();
            groupBox3 = new GroupBox();
            lstbxInformacion = new ListBox();
            cmbxVerEquiposTorneo = new ComboBox();
            btnVerEquipos = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbxTorneos);
            groupBox1.Controls.Add(btnBuscarTorneo);
            groupBox1.Controls.Add(btnEliminarTorneo);
            groupBox1.Controls.Add(btnModificarTorneo);
            groupBox1.Controls.Add(txtTemporadaTorneo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreTorneo);
            groupBox1.Controls.Add(btnCrearTorneo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 306);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Torneo";
            // 
            // cmbxTorneos
            // 
            cmbxTorneos.FormattingEnabled = true;
            cmbxTorneos.Location = new Point(165, 50);
            cmbxTorneos.Name = "cmbxTorneos";
            cmbxTorneos.Size = new Size(266, 28);
            cmbxTorneos.TabIndex = 1;
            // 
            // btnBuscarTorneo
            // 
            btnBuscarTorneo.Location = new Point(25, 50);
            btnBuscarTorneo.Name = "btnBuscarTorneo";
            btnBuscarTorneo.Size = new Size(94, 29);
            btnBuscarTorneo.TabIndex = 7;
            btnBuscarTorneo.Text = "Buscar";
            btnBuscarTorneo.UseVisualStyleBackColor = true;
            btnBuscarTorneo.Click += btnBuscarTorneo_Click;
            // 
            // btnEliminarTorneo
            // 
            btnEliminarTorneo.Location = new Point(325, 227);
            btnEliminarTorneo.Name = "btnEliminarTorneo";
            btnEliminarTorneo.Size = new Size(94, 29);
            btnEliminarTorneo.TabIndex = 6;
            btnEliminarTorneo.Text = "Eliminar";
            btnEliminarTorneo.UseVisualStyleBackColor = true;
            btnEliminarTorneo.Click += btnEliminarTorneo_Click;
            // 
            // btnModificarTorneo
            // 
            btnModificarTorneo.Location = new Point(175, 227);
            btnModificarTorneo.Name = "btnModificarTorneo";
            btnModificarTorneo.Size = new Size(94, 29);
            btnModificarTorneo.TabIndex = 5;
            btnModificarTorneo.Text = "Modificar";
            btnModificarTorneo.UseVisualStyleBackColor = true;
            btnModificarTorneo.Click += btnModificarTorneo_Click;
            // 
            // txtTemporadaTorneo
            // 
            txtTemporadaTorneo.Location = new Point(165, 175);
            txtTemporadaTorneo.Name = "txtTemporadaTorneo";
            txtTemporadaTorneo.Size = new Size(266, 27);
            txtTemporadaTorneo.TabIndex = 3;
            txtTemporadaTorneo.KeyPress += txtTemporadaTorneo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 175);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Temporada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 125);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // txtNombreTorneo
            // 
            txtNombreTorneo.Location = new Point(165, 125);
            txtNombreTorneo.Name = "txtNombreTorneo";
            txtNombreTorneo.Size = new Size(266, 27);
            txtNombreTorneo.TabIndex = 2;
            txtNombreTorneo.KeyPress += txtNombreTorneo_KeyPress;
            // 
            // btnCrearTorneo
            // 
            btnCrearTorneo.Location = new Point(25, 227);
            btnCrearTorneo.Name = "btnCrearTorneo";
            btnCrearTorneo.Size = new Size(94, 29);
            btnCrearTorneo.TabIndex = 4;
            btnCrearTorneo.Text = "Crear";
            btnCrearTorneo.UseVisualStyleBackColor = true;
            btnCrearTorneo.Click += btnCrearTorneo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbxMostrarEquipos);
            groupBox2.Controls.Add(btnAgregarEquipoTorneo);
            groupBox2.Controls.Add(btnEliminarEquipoTorneo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbxMostrarTorneos);
            groupBox2.Location = new Point(540, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(660, 230);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Equipos";
            // 
            // cmbxMostrarEquipos
            // 
            cmbxMostrarEquipos.FormattingEnabled = true;
            cmbxMostrarEquipos.Location = new Point(126, 125);
            cmbxMostrarEquipos.Name = "cmbxMostrarEquipos";
            cmbxMostrarEquipos.Size = new Size(266, 28);
            cmbxMostrarEquipos.TabIndex = 8;
            // 
            // btnAgregarEquipoTorneo
            // 
            btnAgregarEquipoTorneo.Location = new Point(25, 175);
            btnAgregarEquipoTorneo.Name = "btnAgregarEquipoTorneo";
            btnAgregarEquipoTorneo.Size = new Size(94, 29);
            btnAgregarEquipoTorneo.TabIndex = 9;
            btnAgregarEquipoTorneo.Text = "Agregar";
            btnAgregarEquipoTorneo.UseVisualStyleBackColor = true;
            btnAgregarEquipoTorneo.Click += btnAgregarEquipoTorneo_Click;
            // 
            // btnEliminarEquipoTorneo
            // 
            btnEliminarEquipoTorneo.Location = new Point(175, 175);
            btnEliminarEquipoTorneo.Name = "btnEliminarEquipoTorneo";
            btnEliminarEquipoTorneo.Size = new Size(94, 29);
            btnEliminarEquipoTorneo.TabIndex = 10;
            btnEliminarEquipoTorneo.Text = "Eliminar";
            btnEliminarEquipoTorneo.UseVisualStyleBackColor = true;
            btnEliminarEquipoTorneo.Click += btnEliminarEquipoTorneo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 125);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 2;
            label4.Text = "Equipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 75);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Torneo:";
            // 
            // cmbxMostrarTorneos
            // 
            cmbxMostrarTorneos.FormattingEnabled = true;
            cmbxMostrarTorneos.Location = new Point(126, 75);
            cmbxMostrarTorneos.Name = "cmbxMostrarTorneos";
            cmbxMostrarTorneos.Size = new Size(266, 28);
            cmbxMostrarTorneos.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstbxInformacion);
            groupBox3.Controls.Add(cmbxVerEquiposTorneo);
            groupBox3.Controls.Add(btnVerEquipos);
            groupBox3.Location = new Point(37, 341);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1163, 225);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mostrar Equipos por Torneo";
            // 
            // lstbxInformacion
            // 
            lstbxInformacion.FormattingEnabled = true;
            lstbxInformacion.ItemHeight = 20;
            lstbxInformacion.Location = new Point(0, 60);
            lstbxInformacion.Name = "lstbxInformacion";
            lstbxInformacion.Size = new Size(1157, 304);
            lstbxInformacion.TabIndex = 2;
            // 
            // cmbxVerEquiposTorneo
            // 
            cmbxVerEquiposTorneo.FormattingEnabled = true;
            cmbxVerEquiposTorneo.Location = new Point(0, 26);
            cmbxVerEquiposTorneo.Name = "cmbxVerEquiposTorneo";
            cmbxVerEquiposTorneo.Size = new Size(244, 28);
            cmbxVerEquiposTorneo.TabIndex = 11;
            // 
            // btnVerEquipos
            // 
            btnVerEquipos.Location = new Point(300, 26);
            btnVerEquipos.Name = "btnVerEquipos";
            btnVerEquipos.Size = new Size(94, 29);
            btnVerEquipos.TabIndex = 12;
            btnVerEquipos.Text = "Ver:";
            btnVerEquipos.UseVisualStyleBackColor = true;
            btnVerEquipos.Click += btnVerEquipos_Click;
            // 
            // wfmTorneos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 743);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "wfmTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clsTorneos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTemporadaTorneo;
        private Label label2;
        private Label label1;
        private TextBox txtNombreTorneo;
        private Button btnCrearTorneo;
        private GroupBox groupBox2;
        private ComboBox cmbxMostrarTorneos;
        private Button btnEliminarTorneo;
        private Button btnModificarTorneo;
        private Button btnAgregarEquipoTorneo;
        private Button btnEliminarEquipoTorneo;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private ComboBox cmbxMostrarEquipos;
        private Button btnBuscarTorneo;
        private ComboBox cmbxTorneos;
        private ComboBox cmbxVerEquiposTorneo;
        private Button btnVerEquipos;
        private ListBox lstbxInformacion;
    }
}