using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsNomina.Models
{
    public class clavePresupuestal_Model
    {
        private string partidaPresupuestal;
        public string PartidaPresupuestal
        {
            get { return partidaPresupuestal; }
            set { partidaPresupuestal = value; }
        }

        private string codigodePago;
        public string CodigodePago
        {
            get { return codigodePago; }
            set { codigodePago = value; }
        }

        private string clavedeUnidad;
        public string ClavedeUnidad
        {
            get { return clavedeUnidad; }
            set { clavedeUnidad = value; }
        }

        private string clavedeSubUnidad;
        public string ClavedeSubUnidad
        {
            get { return clavedeSubUnidad; }
            set { clavedeSubUnidad = value; }
        }

        private string clavedeCategoria;
        public string ClavedeCategoria
        {
            get { return clavedeCategoria; }
            set { clavedeCategoria = value; }
        }

        private string horasSemanaMes;
        public string HorasSemanaMes
        {
            get { return horasSemanaMes; }
            set { horasSemanaMes = value; }
        }

        private string numerodePlaza;
        public string NumerodePlaza
        {
            get { return numerodePlaza; }
            set { numerodePlaza = value; }
        }

    }
}