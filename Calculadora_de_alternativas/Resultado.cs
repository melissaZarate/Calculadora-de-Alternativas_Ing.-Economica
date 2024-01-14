using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_alternativas
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        public void Btnaceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.lblalternative = lblalternative;
            this.lblnumero = lblnumero;


        }

        private void Lblalternative_Click(object sender, EventArgs e)
        {
            
        }
    }
}
