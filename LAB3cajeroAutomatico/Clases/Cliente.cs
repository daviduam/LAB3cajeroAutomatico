using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3cajeroAutomatico.Clase
{
    class Cliente
    {
        #region Variables

        string v_Nombre;
        string v_Cuenta;
        int v_Pin;
        double v_Saldo;

        #endregion


        #region Metodos

        public Cliente()
        {

            v_Nombre = "";
            v_Cuenta = "";
            v_Pin = 0;
            v_Saldo = 0;

        }

        public Cliente(string p_nom, string p_cuent, int p_pin, double p_sal)
        {

            v_Nombre = p_nom;
            v_Cuenta = p_cuent;
            v_Pin = p_pin;
            v_Saldo = p_sal;

        }

        public void establecerNombre(string p_nom)
        {

            v_Nombre = p_nom;

        }

        public string obtenerNombre()
        {

            return v_Nombre;

        }

        public void establecerCuenta(string p_cuent)
        {

            v_Cuenta = p_cuent;

        }

        public string obtenerCuenta()
        {

            return v_Cuenta;

        }

        public void establecerPin(int p_pin)
        {

            v_Pin = p_pin;

        }

        public int obtenerPin()
        {

            return v_Pin;

        }

        public double obtenerSaldo()
        {

            return v_Saldo;

        }

        public bool disminuirSaldo(double p_monto)
        {

            if (v_Saldo >= p_monto)
            {

                v_Saldo = v_Saldo = p_monto;

                return true;

            }
            else

                return false;



        }

        #endregion

    }
}
