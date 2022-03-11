using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Circulo_Click(object sender, EventArgs e)
        {
            AreasServiceReference.AreasWebServiceSoapClient ws = new AreasServiceReference.AreasWebServiceSoapClient();
            resulC.Text = ws.AreaCirculo(int.Parse(radio.Text));
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            AreasServiceReference.AreasWebServiceSoapClient ws = new AreasServiceReference.AreasWebServiceSoapClient();
            resulCU.Text = ws.AreaCuadrado(int.Parse(lado.Text));

        }

        private void Triangu_Click(object sender, EventArgs e)
        {
            AreasServiceReference.AreasWebServiceSoapClient ws = new AreasServiceReference.AreasWebServiceSoapClient();
            resulT.Text = ws.AreaTriangulo(int.Parse(bas.Text), int.Parse(altu.Text));
        }
    }
}
