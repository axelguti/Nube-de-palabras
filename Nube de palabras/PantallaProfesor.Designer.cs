namespace Nube_de_palabras
{
    partial class PantallaProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaProfesor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.dEntrada = new System.Windows.Forms.NumericUpDown();
            this.btnCompartir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Respuesta5 = new System.Windows.Forms.TextBox();
            this.Respuesta8 = new System.Windows.Forms.TextBox();
            this.Respuesta4 = new System.Windows.Forms.TextBox();
            this.Respuesta6 = new System.Windows.Forms.TextBox();
            this.Respuesta2 = new System.Windows.Forms.TextBox();
            this.Respuesta9 = new System.Windows.Forms.TextBox();
            this.Respuesta3 = new System.Windows.Forms.TextBox();
            this.Respuesta7 = new System.Windows.Forms.TextBox();
            this.Respuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuestas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.dEntrada);
            this.splitContainer1.Panel1.Controls.Add(this.btnCompartir);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.Seleccionar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPregunta);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta5);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta8);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta4);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta6);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta2);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta9);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta3);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta7);
            this.splitContainer1.Panel2.Controls.Add(this.Respuesta1);
            this.splitContainer1.Panel2.Controls.Add(this.txtRespuestas);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Verificar Conexión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dEntrada
            // 
            this.dEntrada.Location = new System.Drawing.Point(25, 214);
            this.dEntrada.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.dEntrada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dEntrada.Name = "dEntrada";
            this.dEntrada.Size = new System.Drawing.Size(120, 20);
            this.dEntrada.TabIndex = 9;
            this.dEntrada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCompartir
            // 
            this.btnCompartir.Location = new System.Drawing.Point(25, 66);
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.Size = new System.Drawing.Size(75, 23);
            this.btnCompartir.TabIndex = 8;
            this.btnCompartir.Text = "Compartir";
            this.btnCompartir.UseVisualStyleBackColor = true;
            this.btnCompartir.Click += new System.EventHandler(this.btnCompartir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Nube_de_palabras.Properties.Resources.descarga;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(82, 370);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSize = true;
            this.Seleccionar.Location = new System.Drawing.Point(25, 287);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(82, 17);
            this.Seleccionar.TabIndex = 5;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Permitir varias respuetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada por participante";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(25, 128);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(216, 20);
            this.txtPregunta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu Pregunta";
            // 
            // Respuesta5
            // 
            this.Respuesta5.Enabled = false;
            this.Respuesta5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.Respuesta5.Location = new System.Drawing.Point(270, 175);
            this.Respuesta5.Name = "Respuesta5";
            this.Respuesta5.Size = new System.Drawing.Size(119, 24);
            this.Respuesta5.TabIndex = 9;
            this.Respuesta5.Visible = false;
            // 
            // Respuesta8
            // 
            this.Respuesta8.Enabled = false;
            this.Respuesta8.Font = new System.Drawing.Font("Microsoft Tai Le", 4F, System.Drawing.FontStyle.Bold);
            this.Respuesta8.Location = new System.Drawing.Point(177, 160);
            this.Respuesta8.Name = "Respuesta8";
            this.Respuesta8.Size = new System.Drawing.Size(105, 14);
            this.Respuesta8.TabIndex = 8;
            this.Respuesta8.Visible = false;
            // 
            // Respuesta4
            // 
            this.Respuesta4.Enabled = false;
            this.Respuesta4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.Respuesta4.Location = new System.Drawing.Point(48, 206);
            this.Respuesta4.Name = "Respuesta4";
            this.Respuesta4.Size = new System.Drawing.Size(143, 28);
            this.Respuesta4.TabIndex = 7;
            this.Respuesta4.Visible = false;
            // 
            // Respuesta6
            // 
            this.Respuesta6.Enabled = false;
            this.Respuesta6.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.Respuesta6.Location = new System.Drawing.Point(316, 246);
            this.Respuesta6.Name = "Respuesta6";
            this.Respuesta6.Size = new System.Drawing.Size(125, 21);
            this.Respuesta6.TabIndex = 6;
            this.Respuesta6.Visible = false;
            // 
            // Respuesta2
            // 
            this.Respuesta2.Enabled = false;
            this.Respuesta2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.25F, System.Drawing.FontStyle.Bold);
            this.Respuesta2.Location = new System.Drawing.Point(167, 246);
            this.Respuesta2.Name = "Respuesta2";
            this.Respuesta2.Size = new System.Drawing.Size(143, 35);
            this.Respuesta2.TabIndex = 5;
            this.Respuesta2.Visible = false;
            // 
            // Respuesta9
            // 
            this.Respuesta9.Enabled = false;
            this.Respuesta9.Font = new System.Drawing.Font("Microsoft Tai Le", 3F, System.Drawing.FontStyle.Bold);
            this.Respuesta9.Location = new System.Drawing.Point(60, 240);
            this.Respuesta9.Name = "Respuesta9";
            this.Respuesta9.Size = new System.Drawing.Size(101, 13);
            this.Respuesta9.TabIndex = 4;
            this.Respuesta9.Visible = false;
            // 
            // Respuesta3
            // 
            this.Respuesta3.Enabled = false;
            this.Respuesta3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.Respuesta3.Location = new System.Drawing.Point(346, 209);
            this.Respuesta3.Name = "Respuesta3";
            this.Respuesta3.Size = new System.Drawing.Size(143, 31);
            this.Respuesta3.TabIndex = 3;
            this.Respuesta3.Visible = false;
            // 
            // Respuesta7
            // 
            this.Respuesta7.Enabled = false;
            this.Respuesta7.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Bold);
            this.Respuesta7.Location = new System.Drawing.Point(138, 180);
            this.Respuesta7.Name = "Respuesta7";
            this.Respuesta7.Size = new System.Drawing.Size(126, 18);
            this.Respuesta7.TabIndex = 2;
            this.Respuesta7.Visible = false;
            // 
            // Respuesta1
            // 
            this.Respuesta1.Enabled = false;
            this.Respuesta1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta1.Location = new System.Drawing.Point(197, 202);
            this.Respuesta1.Name = "Respuesta1";
            this.Respuesta1.Size = new System.Drawing.Size(143, 38);
            this.Respuesta1.TabIndex = 1;
            this.Respuesta1.Visible = false;
            // 
            // txtRespuestas
            // 
            this.txtRespuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRespuestas.Location = new System.Drawing.Point(0, 0);
            this.txtRespuestas.Multiline = true;
            this.txtRespuestas.Name = "txtRespuestas";
            this.txtRespuestas.Size = new System.Drawing.Size(530, 450);
            this.txtRespuestas.TabIndex = 0;
            // 
            // PantallaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PantallaProfesor";
            this.Text = "Interfaz Profesor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox Seleccionar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtRespuestas;
        public System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnCompartir;
        public System.Windows.Forms.TextBox Respuesta5;
        public System.Windows.Forms.TextBox Respuesta8;
        public System.Windows.Forms.TextBox Respuesta4;
        public System.Windows.Forms.TextBox Respuesta6;
        public System.Windows.Forms.TextBox Respuesta2;
        public System.Windows.Forms.TextBox Respuesta9;
        public System.Windows.Forms.TextBox Respuesta3;
        public System.Windows.Forms.TextBox Respuesta7;
        public System.Windows.Forms.TextBox Respuesta1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown dEntrada;
    }
}

