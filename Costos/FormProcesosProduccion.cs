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
    public partial class FormProcesosProduccion : Form
    {
        public FormProcesosProduccion()
        {
            InitializeComponent();
        }

        private void FormProcesosProduccion_Load(object sender, EventArgs e)
        {
            dgvProcesosProduccion.Columns.Add("Proceso", "Proceso");
            dgvProcesosProduccion.Columns.Add("MaterialUtilizado", "Material Utilizado");
            dgvProcesosProduccion.Columns.Add("CantidadUtilizada", "Cantidad Utilizada");
            dgvProcesosProduccion.Columns.Add("CostoPorUnidadMaterial", "Costo por Unidad de Material");
            dgvProcesosProduccion.Columns.Add("CostoTotalMaterial", "Costo Total del Material");
            dgvProcesosProduccion.Columns.Add("HorasManoObra", "Horas de Mano de Obra");
            dgvProcesosProduccion.Columns.Add("CostoPorHoraManoObra", "Costo por Hora de Mano de Obra");
            dgvProcesosProduccion.Columns.Add("CostoTotalManoObra", "Costo Total de Mano de Obra");
            dgvProcesosProduccion.Columns.Add("CostoTotalProceso", "Costo Total del Proceso");

            // Configurar columnas calculadas como no editables
            dgvProcesosProduccion.Columns["CostoTotalMaterial"].ReadOnly = true;
            dgvProcesosProduccion.Columns["CostoTotalManoObra"].ReadOnly = true;
            dgvProcesosProduccion.Columns["CostoTotalProceso"].ReadOnly = true;

        }

        private void dgvProcesosProduccion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que las columnas existen
            if (dgvProcesosProduccion.Columns.Contains("CostoTotalMaterial") &&
                dgvProcesosProduccion.Columns.Contains("CostoTotalManoObra") &&
                dgvProcesosProduccion.Columns.Contains("CostoTotalProceso"))
            {
                DataGridViewRow row = dgvProcesosProduccion.Rows[e.RowIndex];

                // Recalcular Costo Total del Material si es necesario
                if (e.ColumnIndex == dgvProcesosProduccion.Columns["CantidadUtilizada"].Index ||
                    e.ColumnIndex == dgvProcesosProduccion.Columns["CostoPorUnidadMaterial"].Index)
                {
                    if (decimal.TryParse(row.Cells["CantidadUtilizada"].Value?.ToString(), out decimal cantidadMaterial) &&
                        decimal.TryParse(row.Cells["CostoPorUnidadMaterial"].Value?.ToString(), out decimal costoUnidadMaterial))
                    {
                        row.Cells["CostoTotalMaterial"].Value = cantidadMaterial * costoUnidadMaterial;
                    }
                    else
                    {
                        row.Cells["CostoTotalMaterial"].Value = 0;
                    }
                }

                // Recalcular Costo Total de Mano de Obra si es necesario
                if (e.ColumnIndex == dgvProcesosProduccion.Columns["HorasManoObra"].Index ||
                    e.ColumnIndex == dgvProcesosProduccion.Columns["CostoPorHoraManoObra"].Index)
                {
                    if (decimal.TryParse(row.Cells["HorasManoObra"].Value?.ToString(), out decimal horas) &&
                        decimal.TryParse(row.Cells["CostoPorHoraManoObra"].Value?.ToString(), out decimal costoHora))
                    {
                        row.Cells["CostoTotalManoObra"].Value = horas * costoHora;
                    }
                    else
                    {
                        row.Cells["CostoTotalManoObra"].Value = 0;
                    }
                }

                // Calcular el Costo Total del Proceso
                if (decimal.TryParse(row.Cells["CostoTotalMaterial"].Value?.ToString(), out decimal costoTotalMaterial) &&
                    decimal.TryParse(row.Cells["CostoTotalManoObra"].Value?.ToString(), out decimal costoTotalManoObra))
                {
                    row.Cells["CostoTotalProceso"].Value = costoTotalMaterial + costoTotalManoObra;
                }
                else
                {
                    row.Cells["CostoTotalProceso"].Value = 0; // Reiniciar si no hay datos válidos
                }
            }
        }
    }
}
