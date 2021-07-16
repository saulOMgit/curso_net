using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoConsola
{
    public class Cuenta
    {
        //Declaramos los campos privados
        private int _NumeroCuenta;
        private string _NombreCliente;
        private double _Saldo;

        //Contructor por defecto
        public Cuenta() 
        {
            
        }
        //Constructor con parametros
        public Cuenta(int NumeroCuenta, string NombreCliente, double Saldo) 
        {
            this._NumeroCuenta = NumeroCuenta;
            this._NombreCliente = NombreCliente;
            this._Saldo = Saldo;
        }

        //getters y setters

        public int PNumeroCuenta 
        {
            get { return _NumeroCuenta; } set { _NumeroCuenta = value; }
        }

        public string PNombreCliente 
        {
            get { return _NombreCliente;}
            set { _NombreCliente = value; }
        }

        public double PSaldo 
        {
            get { return _Saldo; }
            set { _Saldo = value; }
        }


    }
}
