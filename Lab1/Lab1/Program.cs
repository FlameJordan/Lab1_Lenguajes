using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab1
{
 
    static class Program
    {


        private static Conexion con;
        [STAThread]
        static void Main()
        {
            con = new Conexion();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }

        public static Conexion Con
        {
            get { return con; }
            set { con = value; }
        }


    }

    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=163.178.107.10;Initial Catalog=IF4101_B61599_B76271;Persist Security Info=True;User ID=laboratorios;Password=KmZpo.2796");
                cnn.Open();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("No se conecto: " + e.ToString());
            }
        }



        public SqlCommand Cmd
        {
            get { return this.cmd; }
            set { this.cmd = value; }
        }

        public SqlConnection Cnn
        {
            get { return cnn; }
        }

        public SqlDataReader Dr
        {
            get { return this.dr; }
            set { this.dr = value; }
        }

    }



}
