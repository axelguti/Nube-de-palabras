namespace Nube_de_palabras
{
    partial class Estudiante
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Se deshace de los recursos (distintos de la memoria) que usa <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="disposing">Es <see langword="true" /> para liberar tanto recursos administrados como no administrados;
        /// es <see langword="false" /> para liberar únicamente recursos no administrados.</param>
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
            this.txtRes1 = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtRes2 = new System.Windows.Forms.TextBox();
            this.txtRes3 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tboxApp = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdea1 = new System.Windows.Forms.Label();
            this.lblIdea2 = new System.Windows.Forms.Label();
            this.lblIdea3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRes1
            // 
            this.txtRes1.Location = new System.Drawing.Point(115, 147);
            this.txtRes1.Name = "txtRes1";
            this.txtRes1.Size = new System.Drawing.Size(276, 20);
            this.txtRes1.TabIndex = 5;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(115, 49);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(0, 16);
            this.lblPregunta.TabIndex = 5;
            this.lblPregunta.UseCompatibleTextRendering = true;
            // 
            // txtRes2
            // 
            this.txtRes2.Location = new System.Drawing.Point(115, 173);
            this.txtRes2.Name = "txtRes2";
            this.txtRes2.Size = new System.Drawing.Size(276, 20);
            this.txtRes2.TabIndex = 6;
            // 
            // txtRes3
            // 
            this.txtRes3.Location = new System.Drawing.Point(115, 199);
            this.txtRes3.Name = "txtRes3";
            this.txtRes3.Size = new System.Drawing.Size(276, 20);
            this.txtRes3.TabIndex = 7;
            this.txtRes3.TextChanged += new System.EventHandler(this.TxtRes3_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(316, 236);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tboxApp
            // 
            this.tboxApp.Location = new System.Drawing.Point(115, 121);
            this.tboxApp.Name = "tboxApp";
            this.tboxApp.Size = new System.Drawing.Size(276, 20);
            this.tboxApp.TabIndex = 9;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(115, 95);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(276, 20);
            this.tboxNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // lblIdea1
            // 
            this.lblIdea1.AutoSize = true;
            this.lblIdea1.Location = new System.Drawing.Point(38, 147);
            this.lblIdea1.Name = "lblIdea1";
            this.lblIdea1.Size = new System.Drawing.Size(37, 13);
            this.lblIdea1.TabIndex = 13;
            this.lblIdea1.Text = "Idea 1";
            // 
            // lblIdea2
            // 
            this.lblIdea2.AutoSize = true;
            this.lblIdea2.Location = new System.Drawing.Point(38, 173);
            this.lblIdea2.Name = "lblIdea2";
            this.lblIdea2.Size = new System.Drawing.Size(37, 13);
            this.lblIdea2.TabIndex = 14;
            this.lblIdea2.Text = "Idea 2";
            // 
            // lblIdea3
            // 
            this.lblIdea3.AutoSize = true;
            this.lblIdea3.Location = new System.Drawing.Point(38, 199);
            this.lblIdea3.Name = "lblIdea3";
            this.lblIdea3.Size = new System.Drawing.Size(37, 13);
            this.lblIdea3.TabIndex = 15;
            this.lblIdea3.Text = "Idea 3";
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 284);
            this.Controls.Add(this.lblIdea3);
            this.Controls.Add(this.lblIdea2);
            this.Controls.Add(this.lblIdea1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxApp);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRes3);
            this.Controls.Add(this.txtRes2);
            this.Controls.Add(this.txtRes1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Estudiante";
            this.Text = "Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.Label lblPregunta;
        public System.Windows.Forms.TextBox txtRes1;
        public System.Windows.Forms.TextBox txtRes2;
        public System.Windows.Forms.TextBox txtRes3;
        public System.Windows.Forms.TextBox tboxApp;
        public System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblIdea1;
        public System.Windows.Forms.Label lblIdea2;
        public System.Windows.Forms.Label lblIdea3;
    }
}