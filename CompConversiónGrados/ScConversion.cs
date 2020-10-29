using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGradosConversión;

namespace CompConversiónGrados {
    public partial class ScConversion : UserControl {
        
        //Variables
        String op;

        public ScConversion() {
            InitializeComponent();
        }


        private void butConversion_Click(object sender, EventArgs e) {

            //Variables
            double gradees = Double.Parse(tbDegrees.Text);

            //Validar que opcion será realizada.
            foreach (RadioButton rb in gbDegrees.Controls) {

                if (rb.Checked) {
                    op = rb.Text;    
                }
            }

            //Operar.
            switch (op) {
                case "Celsius a fahrenheit":
                    tbResult.Text = Conversion.cToF(gradees).ToString();
                    break;
                case "Fahrenheit a celsius":
                    tbResult.Text = Conversion.fToC(gradees).ToString();
                    break;
            }
        }
    }
}
