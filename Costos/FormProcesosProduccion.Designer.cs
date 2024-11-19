namespace Costos
{
    partial class FormProcesosProduccion
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
            dgvProcesosProduccion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProcesosProduccion).BeginInit();
            SuspendLayout();
            // 
            // dgvProcesosProduccion
            // 
            dgvProcesosProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcesosProduccion.Location = new Point(81, 36);
            dgvProcesosProduccion.Name = "dgvProcesosProduccion";
            dgvProcesosProduccion.Size = new Size(639, 378);
            dgvProcesosProduccion.TabIndex = 6;
            dgvProcesosProduccion.CellValueChanged += dgvProcesosProduccion_CellValueChanged;
            // 
            // FormProcesosProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProcesosProduccion);
            Name = "FormProcesosProduccion";
            Text = "FormProcesosProduccion";
            Load += FormProcesosProduccion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProcesosProduccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProcesosProduccion;
    }
}