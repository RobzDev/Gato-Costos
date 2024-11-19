namespace Costos
{
    partial class FormOrdenesProduccion
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
            dgvOrdenesProduccion = new DataGridView();
            NumeroOrden = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            ManoObra = new DataGridViewTextBoxColumn();
            CantidadProducida = new DataGridViewTextBoxColumn();
            CostoPorUnidad = new DataGridViewTextBoxColumn();
            CostoTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesProduccion).BeginInit();
            SuspendLayout();
            // 
            // dgvOrdenesProduccion
            // 
            dgvOrdenesProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenesProduccion.Columns.AddRange(new DataGridViewColumn[] { NumeroOrden, Producto, ManoObra, CantidadProducida, CostoPorUnidad, CostoTotal });
            dgvOrdenesProduccion.Location = new Point(81, 36);
            dgvOrdenesProduccion.Name = "dgvOrdenesProduccion";
            dgvOrdenesProduccion.Size = new Size(639, 378);
            dgvOrdenesProduccion.TabIndex = 6;
            // 
            // NumeroOrden
            // 
            NumeroOrden.HeaderText = "Numero de Orden";
            NumeroOrden.Name = "NumeroOrden";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // ManoObra
            // 
            ManoObra.HeaderText = "Mano De Obra";
            ManoObra.Name = "ManoObra";
            // 
            // CantidadProducida
            // 
            CantidadProducida.HeaderText = "Cantidad Producida";
            CantidadProducida.Name = "CantidadProducida";
            // 
            // CostoPorUnidad
            // 
            CostoPorUnidad.HeaderText = "Costo Por Unidad";
            CostoPorUnidad.Name = "CostoPorUnidad";
            // 
            // CostoTotal
            // 
            CostoTotal.HeaderText = "Costo Total";
            CostoTotal.Name = "CostoTotal";
            // 
            // FormOrdenesProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrdenesProduccion);
            Name = "FormOrdenesProduccion";
            Text = "FormOrdenesProduccion";
            Load += FormOrdenesProduccion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenesProduccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrdenesProduccion;
        private DataGridViewTextBoxColumn NumeroOrden;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn ManoObra;
        private DataGridViewTextBoxColumn CantidadProducida;
        private DataGridViewTextBoxColumn CostoPorUnidad;
        private DataGridViewTextBoxColumn CostoTotal;
    }
}