using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costos
{
    public partial class FormOrdenesProduccion : Form
    {
        public FormOrdenesProduccion()
        {
            InitializeComponent();
           
        }

        private void FormOrdenesProduccion_Load(object sender, EventArgs e)
        {

            // Configurar columna CostoTotal como no editable
            dgvOrdenesProduccion.Columns["CostoTotal"].ReadOnly = true;
            //show a message box containing the columns of the datagridview
            
        }


        private void dgvOrdenesProduccion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que las columnas existen antes de acceder a ellas
            if (dgvOrdenesProduccion.Columns.Contains("CantidadProducida") &&
                dgvOrdenesProduccion.Columns.Contains("CostoPorUnidad") &&
                dgvOrdenesProduccion.Columns.Contains("CostoTotal"))
            {
                if (e.ColumnIndex == dgvOrdenesProduccion.Columns["CantidadProducida"].Index ||
                    e.ColumnIndex == dgvOrdenesProduccion.Columns["CostoPorUnidad"].Index)
                {
                    DataGridViewRow row = dgvOrdenesProduccion.Rows[e.RowIndex];
                    if (int.TryParse(row.Cells["CantidadProducida"].Value?.ToString(), out int cantidad) &&
                        decimal.TryParse(row.Cells["CostoPorUnidad"].Value?.ToString(), out decimal costoUnidad))
                    {
                        row.Cells["CostoTotal"].Value = cantidad * costoUnidad;
                    }
                    else
                    {
                        
                        row.Cells["CostoTotal"].Value = 0;
                    }
                }
       }    }
    }
}
