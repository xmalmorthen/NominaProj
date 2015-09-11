using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wsNomina.Models
{
    public class AYIID4_Model : global_Model
    {
        private int totalPersonas;
        public int TotalPersonas
        {
            get { return totalPersonas; }
            set { totalPersonas = value; }
        }

        private int totalPlazas;
        public int TotalPlazas
        {
            get { return totalPlazas; }
            set { totalPlazas = value; }
        }

        private int totalPtoFederal;
        public int TotalPtoFederal
        {
            get { return totalPtoFederal; }
            set { totalPtoFederal = value; }
        }

        private int totalPtoOtrasFuentes;
        public int TotalPtoOtrasFuentes
        {
            get { return totalPtoOtrasFuentes; }
            set { totalPtoOtrasFuentes = value; }
        }

        private List<AYIID4> registros = new List<AYIID4>();
        public List<AYIID4> Registros
        {
            get { return registros; }
            set { registros = value; }
        }        
    }

    public class AYIID4
    {
        private string entidadFederativa;
        public string EntidadFederativa
        {
            get { return entidadFederativa; }
            set { entidadFederativa = value; }
        }

        private string rFC;
        public string RFC
        {
            get { return rFC; }
            set { rFC = value; }
        }
        
        private string cURP;
        public string CURP
        {
            get { return cURP; }
            set { cURP = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string claveIntegrada;
        public string ClaveIntegrada
        {
            get { return claveIntegrada; }
            set { claveIntegrada = value; }
        }

        private clavePresupuestal_Model clavePresupuestal = new clavePresupuestal_Model();
        public clavePresupuestal_Model ClavePresupuestal
        {
            get { return clavePresupuestal; }
            set { clavePresupuestal = value; }
        }

        private periodoLicencia_Model periodoLicencia = new periodoLicencia_Model();
        public periodoLicencia_Model PeriodoLicencia
        {
            get { return periodoLicencia; }
            set { periodoLicencia = value; }
        }

        private string percepcionesPagadasenelPeriododeComisionconPresupuestoFederal;
        public string PercepcionesPagadasenelPeriododeComisionconPresupuestoFederal
        {
            get { return percepcionesPagadasenelPeriododeComisionconPresupuestoFederal; }
            set { percepcionesPagadasenelPeriododeComisionconPresupuestoFederal = value; }
        }

        private string percepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente;
        public string PercepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente
        {
            get { return percepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente; }
            set { percepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente = value; }
        }

        private string claveCTOrigen;
        public string ClaveCTOrigen
        {
            get { return claveCTOrigen; }
            set { claveCTOrigen = value; }
        }

        private licencia_Model licencia = new licencia_Model();
        public licencia_Model Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }

        private string descripciondelaLicencia;
        public string DescripciondelaLicencia
        {
            get { return descripciondelaLicencia; }
            set { descripciondelaLicencia = value; }
        }
    }

    public class periodoLicencia_Model
    {
        private string inicio;
        public string Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        private string conclusion;
        public string Conclusion
        {
            get { return conclusion; }
            set { conclusion = value; }
        }
    }

    public class licencia_Model
    {
        private string clave;
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}