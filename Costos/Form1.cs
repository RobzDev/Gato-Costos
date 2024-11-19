namespace Costos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenesProduccion_Click(object sender, EventArgs e)
        {
            FormOrdenesProduccion formOrdenes = new FormOrdenesProduccion();
            formOrdenes.ShowDialog();

        }
        private void btnProcesosProduccion_Click(object sender, EventArgs e)
        {

            FormProcesosProduccion formProcesos = new FormProcesosProduccion();
            formProcesos.ShowDialog();
        }

    }
}
