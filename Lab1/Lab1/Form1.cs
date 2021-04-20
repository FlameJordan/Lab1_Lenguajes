using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            

            llenarComboBoxPais(cb_PaisA);
            llenarComboBoxPais(cb_PaisB);
            llenarComboBoxDivisa(cb_Divisa);
            cb_PaisA.SelectedIndex = 0;
            cb_PaisB.SelectedIndex = 1;
            cb_Divisa.SelectedIndex = 0;

           
        }

        public void llenarComboBoxDivisa(ComboBox cb)
        {
            try
            {
                Program.Con.Cmd = new SqlCommand("SELECT NOMBRE FROM [DIVISAS].[DIVISA]", Program.Con.Cnn);
                Program.Con.Dr = Program.Con.Cmd.ExecuteReader();
                while (Program.Con.Dr.Read())
                {
                    cb_Divisa.Items.Add(Program.Con.Dr["NOMBRE"].ToString());

                }
                Program.Con.Dr.Close();

                
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.ToString());

            }

        }


        public void llenarComboBoxPais(ComboBox cb)
        {
            try
            {
                Program.Con.Cmd = new SqlCommand("SELECT NOMBRE FROM [DIVISAS].[PAIS]", Program.Con.Cnn);
                Program.Con.Dr = Program.Con.Cmd.ExecuteReader();
                while (Program.Con.Dr.Read())
                {
                    cb.Items.Add(Program.Con.Dr["NOMBRE"].ToString());

                }
                Program.Con.Dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString());

            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Importe.Text != "")
            {
                string paisA = cb_PaisA.Text;
            string paisB = cb_PaisB.Text;
            double valorAldolarA = 0;
            double valorAldolarB = 0;
            int cod_divisaB = 0;
            int cod_divisaA = 0;
            double intercambio = 0;
            double costo;

            string[] colum = {"CODIGO_DIVISA", "VALORALDOLAR" };

           cod_divisaA = Convert.ToInt32(ConsultaSQL(colum[0].ToString(), "DIVISAS.PAIS"," Where Nombre = "+"'"+paisA+"'"));
           cod_divisaB = Convert.ToInt32(ConsultaSQL(colum[0].ToString(), "DIVISAS.PAIS", " Where Nombre = " + "'" + paisB + "'"));

           valorAldolarA =  Convert.ToDouble(ConsultaSQL(colum[1].ToString(), "DIVISAS.Divisa", " Where CODIGO_DIVISA = " + cod_divisaA));
           valorAldolarB = Convert.ToDouble(ConsultaSQL(colum[1].ToString(), "DIVISAS.Divisa", " Where CODIGO_DIVISA = " + cod_divisaB));
            
                lb_CantidadA.Text = valorAldolarA.ToString();
                lb_CantidadB.Text = valorAldolarB.ToString();

                intercambio = (Convert.ToInt32(tb_Importe.Text) / valorAldolarA) * valorAldolarB;

                lb_TotalConver.Text = intercambio.ToString();

                costo = intercambio * 0.02;

                intercambio = intercambio - costo;

                lb_Total2Apl.Text = intercambio.ToString();
            }
            else
            {
                MessageBox.Show("Importe vacio");

            }
            
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cb_PaisB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_Importe_TextChanged(object sender, EventArgs e)
        {

        }


        public string ConsultaSQL(string columna,string tabla , string condicion)
        {
            string resultado = "";
            string consul = "";
           
                consul = "Select "+columna + " from " + tabla + condicion ;

            try
            {

                Program.Con.Cmd = new SqlCommand(consul, Program.Con.Cnn);

                Program.Con.Dr = Program.Con.Cmd.ExecuteReader();

                while (Program.Con.Dr.Read())
                {
                    resultado = Program.Con.Dr[columna].ToString();
                }

                Program.Con.Dr.Close();


            }catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.ToString());
            }

            return resultado;

        }

        private void lb_CantidadB_Click(object sender, EventArgs e)
        {

        }

        private void cb_Divisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
