namespace Costos
{
    partial class Form1
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
            btnProcesosProduccion = new Button();
            btnOrdenesProduccion = new Button();
            SuspendLayout();
            // 
            // btnProcesosProduccion
            // 
            btnProcesosProduccion.Location = new Point(429, 294);
            btnProcesosProduccion.Name = "btnProcesosProduccion";
            btnProcesosProduccion.Size = new Size(293, 23);
            btnProcesosProduccion.TabIndex = 3;
            btnProcesosProduccion.Text = "Costos por Procesos de Producción";
            btnProcesosProduccion.UseVisualStyleBackColor = true;
            btnProcesosProduccion.Click += this.btnProcesosProduccion_Click;
            // 
            // btnOrdenesProduccion
            // 
            btnOrdenesProduccion.Location = new Point(37, 294);
            btnOrdenesProduccion.Name = "btnOrdenesProduccion";
            btnOrdenesProduccion.Size = new Size(245, 23);
            btnOrdenesProduccion.TabIndex = 2;
            btnOrdenesProduccion.Text = "Costos por Ordenes de Producción";
            btnOrdenesProduccion.UseVisualStyleBackColor = true;
            btnOrdenesProduccion.Click += btnOrdenesProduccion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcesosProduccion);
            Controls.Add(btnOrdenesProduccion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcesosProduccion;
        private Button btnOrdenesProduccion;
    }
}
