using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple19100179
{
    public class DeportistaOlimpicoFamoso: IEquatable<DeportistaOlimpicoFamoso> 
    {
        private int _intClave;

        public int Clave
        {
            get 
            { return _intClave; }
            set { _intClave = value; }
        }
        private double _dblDineroGenerado;

        public double DineroGenerado
        {
            get { return _dblDineroGenerado; }
            set { _dblDineroGenerado = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private char _chrPresea;

        public char Presea
        {
            get { return _chrPresea; }
            set { _chrPresea = value; }
        }
        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }
        private bool _blnActivo;

        public bool Activo
        {
            get { return _blnActivo; }
            set { _blnActivo = value; }
        }
        private string _strImagen;

        public string Imagen
        {
            get { return _strImagen; }
            set { _strImagen = value; }
        }
        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }


        public bool Equals(DeportistaOlimpicoFamoso otroDeportista)
        {
            return Clave == otroDeportista.Clave;
        }
        public DeportistaOlimpicoFamoso()
        {
           
        }
    }
}
