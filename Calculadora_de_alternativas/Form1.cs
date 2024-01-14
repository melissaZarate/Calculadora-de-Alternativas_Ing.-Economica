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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 209)
                panel2.Width = 72;
            else
                panel2.Width = 209;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void chec3_CheckedChanged(object sender, EventArgs e)
        {
            if (chec3.Checked == true)
            {

                panel2.Width = 72;
            }
            else
            {
                panel2.Width = 209;

            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Btnviddiferentes_Click(object sender, EventArgs e)
        {
             int valalmacenado = 0; int y = 0;
            double pvalsalv = 0;
            double resultado = 0;
           double panual =0,res=0; 
           double pcostinic = 0;
            double porcentaje = Convert.ToDouble(textporcentaje.Text);
           double costoinicial = Convert.ToDouble(txt1a.Text);
           double cosmantanual = Convert.ToDouble(txt2a.Text);
           double valsalvamento = Convert.ToDouble(txt3a.Text);
            double tasainteres = porcentaje / 100;
            double g = 0, h = 0 ;
            double costoinicial2 = Convert.ToDouble(txt1b.Text);
            double cosmantanual2 = Convert.ToDouble(txt2b.Text);
            double valsalvamento2 = Convert.ToDouble(txt3b.Text);
            double valalmacenado2 = 0;
            double panual2 = 0, resultado2 = 0;
            int y2 = 0;
            double res2 = 0;
            double g2 = 0, h2 = 0;
            double pcostinic2 = 0, pvalsalv2 = 0;
            //sacamos minimo comun multiplo
            int vida_util = Convert.ToInt32(txt4a.Text);
            int  vida_util2 = Convert.ToInt32(txt4b.Text);
            int vdutil = vida_util;
            int vdutil2 = vida_util2;
            int vn1, vn2, mcn = 1, div = 2;
            vida_util = Math.Abs(vida_util);
            vida_util2 = Math.Abs(vida_util2);
            vn1 = vida_util;
            vn2 = vida_util2;
            while(div<=vida_util||div<=vida_util2)
            {
                while((div<=vida_util && vida_util%div ==0)||(div<=vida_util2 && vida_util2 %div==0))
                {
                    mcn = mcn * div;
                    if ((div <= vida_util && vida_util % div == 0))
                        vida_util = vida_util / div;
                    if ((div <= vida_util2 && vida_util2 % div == 0))
                        vida_util2 = vida_util2 / div;

                }
                div = div + 1;

            }
            int maxmn = mcn;
            //alternativaA
           valalmacenado =( mcn/vdutil);
       
             panual=cosmantanual* ((Math.Pow(1 + tasainteres, mcn) - 1) / ((Math.Pow(1 + tasainteres, mcn) * tasainteres)));

            for (int i = 0; i <= valalmacenado; i++)
            {
                mcn = mcn - y;
                if (mcn == 0)
                {
                     resultado = panual + costoinicial + pcostinic - pvalsalv;
                   

                }
                else
                {
                  
                    if (y !=0)
                    {
                        res= (1 / (Math.Pow(1 + tasainteres, mcn)));
                        pcostinic = costoinicial * res;
                        pcostinic = pcostinic + h;
                    
                         g = pvalsalv;
                        h = pcostinic;
                    }
                    pvalsalv = valsalvamento * (1 / (Math.Pow(1 + tasainteres, mcn)));
                    pvalsalv = pvalsalv + g;
                    y = vdutil;
                }
            }

            txtresultado.Text = Convert.ToString(resultado);


            //alternativa B


            
            valalmacenado2 = (maxmn / vdutil2);
           
            panual2 = cosmantanual2 * ((Math.Pow(1 + tasainteres, maxmn) - 1) / ((Math.Pow(1 + tasainteres, maxmn) * tasainteres)));
            //txtresultado2.Text = Convert.ToString(valalmacenado2);

            for (int i = 0; i <= valalmacenado2; i++)
            {
                maxmn = maxmn - y2;
                if (maxmn == 0)
                {
                    resultado2 = panual2 + costoinicial2 + pcostinic2 - pvalsalv2;


                }
                else
                {

                    if (y2 != 0)
                    {
                        res2 = (1 / (Math.Pow(1 + tasainteres, maxmn)));
                        pcostinic2 = costoinicial2 * res2;
                        pcostinic2 = pcostinic2 + h2;

                        g2 = pvalsalv2;
                        h2 = pcostinic2;
                    }
                    pvalsalv2 = valsalvamento2 * (1 / (Math.Pow(1 + tasainteres, maxmn)));
                    pvalsalv2 = pvalsalv2 + g2;
                    y2 = vdutil2;
                }
            }


            txtresultado2.Text = Convert.ToString(resultado2);


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btnvidiguales_Click(object sender, EventArgs e)
        {
            //ingrese el num alter
            //n=5
            
                        int [] alternativa = new int[2];
                        int alt = alternativa.Length;
                          
                          // resultado[2] = Convert.ToDouble(txtresultado3.Text);
                        if (chec3.Checked == true)
                        {

                            alt = alt + 1;
                       
                        }
         
                           double []costoinicial=new double [2];
                           costoinicial[0] = Convert.ToDouble(txt1a.Text);
                           costoinicial[1] = Convert.ToDouble(txt1b.Text);

                           if (chec3.Checked == true)
                           {


                               costoinicial[2] = Convert.ToDouble(txt1c.Text);
                          

                           }


                           double[] costmantanual = new double[2];
                           costmantanual[0] = Convert.ToDouble(txt2a.Text);
                           costmantanual[1] = Convert.ToDouble(txt2b.Text);
                           if (chec3.Checked == true)
                           {

                               costmantanual[2] = Convert.ToDouble(txt2c.Text);
                         
                           }


                           double[] valsalvamento = new double[2];
                           valsalvamento[0] = Convert.ToDouble(txt3a.Text);
                           valsalvamento[1] = Convert.ToDouble(txt3b.Text);
                           if (chec3.Checked == true)
                           {

                               valsalvamento[2] = Convert.ToDouble(txt3b.Text);

                           }


                        
                             double porcentaje = Convert.ToDouble(textporcentaje.Text);
                         double tasainteres = porcentaje / 100;
                         double vida_util = Convert.ToDouble(txt4a.Text);


                         if (chec3.Checked == true)
                         {

                             alt = alt + 1;

                            
                         }
         

                        for (int i = 0; i < alt; i++)
                        {
                            //hallamos presente anual

                            double pranual = 0, prvalorsalv = 0,resul=0;

                            pranual = costmantanual[i] * ((Math.Pow(1 + tasainteres, vida_util) - 1) / ((Math.Pow(1 + tasainteres, vida_util) * tasainteres)));

                            //hallamos el valor presente de salvamento

                            prvalorsalv = valsalvamento[i] * (1 / (Math.Pow(1 + tasainteres, vida_util)));
                            resul = costoinicial[i] + pranual - prvalorsalv;
                            if (i == 0)
                            {
                                txtresultado.Text = Convert.ToString(resul);
                            }
                            if(i==1)
                                {

                                 txtresultado2.Text=Convert.ToString(resul);
                                }
                            else
                            {
                                txtresultado3.Text = Convert.ToString(resul);
                            }
                          // resultado[i]= resul;

                        }
                      //  txtresultado.Text = Convert.ToString(resul);
                        



        }

        private void Btnvaciar_Click(object sender, EventArgs e)
        {
            txt1a.Clear();
            txt1b.Clear();
           
            txt2a.Clear();
            txt2b.Clear();
            txt3a.Clear();
            txt3b.Clear();
            txt4a.Clear();
            txt4b.Clear();
            txt3a.Clear();
            txt3b.Clear();
            txt3c.Clear();
            txtresultado3.Clear();

            txtresultado.Clear();
            txtresultado2.Clear();
            textporcentaje.Clear();

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
         /* DialogResult resultadoo = new DialogResult();
            Form mensaje = new Resultado();
            resultadoo = mensaje.ShowDialog();*/
            Resultado f = new Resultado();
            
            double a = Convert.ToDouble(txtresultado.Text);
            double b= Convert.ToDouble(txtresultado2.Text);
      
            if (a == b)
            {
                 f.lblalternative.Text = "los resultados son iguales";
                 f.lblnumero.Text= Convert.ToString(a);
                 this.Hide();
                this.Show();
                f.ShowDialog();
                

            }
            else
            {
                if (a < b)
                {
                    f.lblalternative.Text = " A ";
                     f.lblnumero.Text = Convert.ToString(a);
                     this.Hide();
                    this.Show();
                    f.ShowDialog();
                }
                //mandar mensaje a es menor

                else {
                      f.lblalternative.Text = " B";
                    f.lblnumero.Text = Convert.ToString(b);
                      this.Hide();
                    this.Show();
                    f.ShowDialog();
                }
                        //mandar mensaje b es menkor


            }
        }

        private void Txt1a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt1b_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
