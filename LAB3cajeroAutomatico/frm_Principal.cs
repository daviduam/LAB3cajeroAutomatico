using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB3cajeroAutomatico.Clase;
//ANDRES MONESTEL
namespace LAB3cajeroAutomatico
{
    public partial class frm_Principal : Form
    {

        Cliente[] clientes = new Cliente[2];

        public frm_Principal()
        {
            InitializeComponent();
            clientes[0] = new Cliente("Joan Gabriel Zuñiga Tencio", "1111-1111-1111-1111", 1111, 150000);

            clientes[1] = new Cliente("Dixiana", "2222-2222-222-2222", 2222, 50000);

        }

       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

            
         }

        /// Pull 
        /// 
        /// 
        /// Push 
        
        /// Esto es un comentario 
        private void button1_Click(object sender, EventArgs e)
        {

        foreach (Cliente cli in clientes)
        {
            if (msk_NumTarjeta.Text.Equals(cli.obtenerCuenta()))
                    && (txb_Pin.Text.Equals(cli.obtenerPin().ToString())))
                   
            {
                Cajero caj = new Cajero(cli);
                caj.Show();
                this.Hide();
            }


        }
    }
}
