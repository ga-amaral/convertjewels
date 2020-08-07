using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Price.Entities;

namespace Price
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double kbless = double.Parse(txtBlessValue.Text);
            int item = int.Parse(txtItemValue.Text);

            Calc calc = new Calc(kbless, item);

            //Adiciona as linhas separadinhas
            dgPrices.Rows.Add(calc.BlessValue().ToString("F2"), calc.PayPal().ToString("F2"), calc.Tax().ToString("F2"), calc.TotalValue().ToString("F2"));
            
            dgPrices.Update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
