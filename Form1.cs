using System.Diagnostics.Eventing.Reader;

namespace Monto_Articulos_6_2_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {


            Double? Descuento = null, Monto_Total, Monto_Neto, ITBIS;


            Monto_Total = Double.Parse(txt_Monto_Total.Text);

            ITBIS = Double.Parse(txt_ITBIS.Text);

            if (Monto_Total <1000)
            {
                txt_Monto_Total.Text= ("No aplica para el descuento");
            }

            else if (Monto_Total >= 1000 && Monto_Total <= 5000)
            {

                txt_Monto_Total.Text= ("No aplica para el descuento");
            }

            else if (Monto_Total >= 5001 && Monto_Total <= 10000)
            {
                Descuento = Monto_Total * 0.03;
            }

            else if (Monto_Total >= 10001 && Monto_Total <= 15000)

            {
                Descuento = Monto_Total * 0.05;
            }

            else if (Monto_Total >= 15001 && Monto_Total <= 20000)
            {
                Descuento = Monto_Total * 0.08;
            }

            else
            {
                Descuento = Monto_Total * 0.010;
            }


            txt_Descuento.Text = Descuento.ToString();

            Monto_Neto = (Monto_Total-Descuento) + (Monto_Total*(ITBIS/100));



            txt_Monto_Neto.Text = Monto_Neto.ToString();

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Monto_Neto.Clear();
            txt_Monto_Total.Clear();
            txt_Descuento.Clear();
            txt_ITBIS.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}