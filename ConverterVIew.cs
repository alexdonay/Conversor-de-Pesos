using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Pesos
{
    public partial class ConverterVIew : Form
    {
        public ConverterVIew()
        {
            InitializeComponent();
        }

        private void ConverterVIew_Load(object sender, EventArgs e)
        {
            List<string> unidades = new List<string>() { "km", "hm", "dam", "m", "dm", "cm", "mm" };
            List<string> unidades1 = new List<string>() { "km", "hm", "dam", "m", "dm", "cm", "mm" };
            cbDestino.DataSource = unidades;
            cbOrigem.DataSource = unidades1;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            String origem = cbOrigem.SelectedItem.ToString();
            String destino = cbDestino.SelectedItem.ToString();
            double vlOrigem;
            double.TryParse(txValorOrigem.Text, out vlOrigem);
            double vlDestino;
            UnitConverter un = new UnitConverter();
            vlOrigem = un.Converte(vlOrigem, origem, destino);
            txValorDestino.Text = vlOrigem.ToString();
        }
    }
}
