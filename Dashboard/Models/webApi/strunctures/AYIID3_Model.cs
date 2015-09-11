using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.webApi.strunctures
{
    public class AYIID3_Model : global_Model
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

        private List<AYIID3> registros = new List<AYIID3>();
        public List<AYIID3> Registros
        {
            get { return registros; }
            set { registros = value; }
        }        
    }

    public class AYIID3
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

        private fechaComision_Model fechaComision = new fechaComision_Model();
        public fechaComision_Model FechaComision
        {
            get { return fechaComision; }
            set { fechaComision = value; }
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

        private cTDestinoDentrodelSector_Model cTDestinoDentrodelSector = new cTDestinoDentrodelSector_Model();
        public cTDestinoDentrodelSector_Model CTDestinoDentrodelSector
        {
            get { return cTDestinoDentrodelSector; }
            set { cTDestinoDentrodelSector = value; }
        }

        private string lugardelaComisionFueradelSectorEducativo;
        public string LugardelaComisionFueradelSectorEducativo
        {
            get { return lugardelaComisionFueradelSectorEducativo; }
            set { lugardelaComisionFueradelSectorEducativo = value; }
        }

        private string tipodeComision;
        public string TipodeComision
        {
            get { return tipodeComision; }
            set { tipodeComision = value; }
        }

        private string funcionEspecifica;
        public string FuncionEspecifica
        {
            get { return funcionEspecifica; }
            set { funcionEspecifica = value; }
        }

        private string objetodelaComision;
        public string ObjetodelaComision
        {
            get { return objetodelaComision; }
            set { objetodelaComision = value; }
        }

        private string noOficio;
        public string NoOficio
        {
            get { return noOficio; }
            set { noOficio = value; }
        }

    }

    public class fechaComision_Model
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

    public class cTDestinoDentrodelSector_Model {
        private string clave;
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string turno;
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
    }
}