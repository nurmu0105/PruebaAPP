namespace GUIApp
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
            this.acept = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acept
            // 
            this.acept.Location = new System.Drawing.Point(15, 113);
            this.acept.Name = "acept";
            this.acept.Size = new System.Drawing.Size(75, 23);
            this.acept.TabIndex = 0;
            this.acept.Text = "Aceptar";
            this.acept.UseVisualStyleBackColor = true;
            this.acept.Click += new System.EventHandler(this.Acept_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 34);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(221, 20);
            this.input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce un texto";
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Location = new System.Drawing.Point(12, 68);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(129, 13);
            this.solution.TabIndex = 3;
            this.solution.Text = "Pulsa para revelar el texto";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(158, 113);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 4;
            this.end.Text = "Finalizar";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.End_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 148);
            this.Controls.Add(this.end);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.acept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acept;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label solution;
        private System.Windows.Forms.Button end;
    }
}

