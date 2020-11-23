namespace Nube_de_palabras
{
    partial class Estudiante
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
            this.txtRes1 = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtRes3 = new System.Windows.Forms.TextBox();
            this.txtRes2 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRes1
            // 
            this.txtRes1.Location = new System.Drawing.Point(57, 87);
            this.txtRes1.Name = "txtRes1";
            this.txtRes1.Size = new System.Drawing.Size(276, 20);
            this.txtRes1.TabIndex = 5;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(98, 40);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(0, 16);
            this.lblPregunta.TabIndex = 5;
            this.lblPregunta.UseCompatibleTextRendering = true;
            // 
            // txtRes3
            // 
            this.txtRes3.Location = new System.Drawing.Point(57, 153);
            this.txtRes3.Name = "txtRes3";
            this.txtRes3.Size = new System.Drawing.Size(276, 20);
            this.txtRes3.TabIndex = 6;
            // 
            // txtRes2
            // 
            this.txtRes2.Location = new System.Drawing.Point(57, 118);
            this.txtRes2.Name = "txtRes2";
            this.txtRes2.Size = new System.Drawing.Size(276, 20);
            this.txtRes2.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(159, 194);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 234);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRes2);
            this.Controls.Add(this.txtRes3);
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
        public System.Windows.Forms.TextBox txtRes3;
        public System.Windows.Forms.TextBox txtRes2;
    }
}