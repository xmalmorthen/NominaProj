using Dashboard.Models.dbContext;
using Dashboard.Models.webApi.strunctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Models.webApi
{
    public static class get
    {
        private static dbDataContext db = new dbDataContext();        

        /*
         * Descripción          : Obtener los mensajes nuevos por id de usuario
         * Desarrolló           : Xmal
         * Fecha de desarrollo  : 11/09/15
         * Notas                :
        */ 
        public static IEnumerable<paNewMessagesByIdUserResult> getNewMessagesByIdUser(int id){
            return db.paNewMessagesByIdUser(id).ToList();
        }

        /*
         * Descripción          : Obtiene datos del formato AYIID3
         * Desarrolló           : Xmal
         * Fecha de desarrollo  : 07/09/15
         * Notas                :
        */
        public static AYIID3_Model AYIID3()
        {
            AYIID3_Model model = new AYIID3_Model();

            model.Title = "A Y II D 3";
            model.Trimestre = "4o Trimestre";

            for (int i = 0; i < 5; i++)
            {
                AYIID3 data = new AYIID3();
                data.EntidadFederativa = "Colima";
                data.RFC = "RUAM8111232S9";
                data.CURP = "RUAM811123HCMDGG05";
                data.Nombre = "Miguel Angel Rueda Aguilar";
                data.ClaveIntegrada = "Cve Integrada 0000";
                data.ClavePresupuestal.PartidaPresupuestal = "Partida Presupuestal 0000";
                data.ClavePresupuestal.CodigodePago = "Código de Pago 0000";
                data.ClavePresupuestal.ClavedeUnidad = "Clave de Unidad 0000";
                data.ClavePresupuestal.ClavedeSubUnidad = "Clave de Sub Unidad 0000";
                data.ClavePresupuestal.ClavedeCategoria = "Clave de Categoría 0000";
                data.ClavePresupuestal.HorasSemanaMes = "Horas Semana Mes";
                data.ClavePresupuestal.NumerodePlaza = "Número de Plaza 0000";
                data.FechaComision.Inicio = "Fecha Comision Inicio dd/mm/yyyy";
                data.FechaComision.Conclusion = "Fecha Comision Conclusion dd/mm/yyyy";
                data.PercepcionesPagadasenelPeriododeComisionconPresupuestoFederal = "Percepciones Pagadas Federal 0000";
                data.PercepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente = "Percepciones Pagadas Otras Fuentes 0000";
                data.ClaveCTOrigen = "Clave CT Origen 0000";
                data.CTDestinoDentrodelSector.Clave = "CT Destino Dentro del Sector Clave 0000";
                data.CTDestinoDentrodelSector.Turno = "CT Destino Dentro del Sector Turno 0000";
                data.LugardelaComisionFueradelSectorEducativo = "Lugar de Comision 0000";
                data.TipodeComision = "Tipo de Comisión 0000";
                data.FuncionEspecifica = "Función Específica 0000";
                data.ObjetodelaComision = "Objeto de la Comisión 0000";
                data.NoOficio = "No. Oficio 0000";

                model.Registros.Add(data);
            }

            model.TotalPersonas = model.Registros.Count();
            model.TotalPlazas = model.Registros.Count(x => x.ClavePresupuestal.NumerodePlaza.Length > 0);
            model.TotalPtoFederal = model.Registros.Count(x => x.PercepcionesPagadasenelPeriododeComisionconPresupuestoFederal.Length > 0);
            model.TotalPtoOtrasFuentes = model.Registros.Count(x => x.PercepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente.Length > 0);

            return model;
        }

        /*
         * Descripción          : Obtiene datos del formato AYIID4
         * Desarrolló           : Xmal
         * Fecha de desarrollo  : 07/09/15
         * Notas                :
        */
        public static AYIID4_Model AYIID4()
        {
            AYIID4_Model model = new AYIID4_Model();

            model.Title = "A Y II D 4";
            model.Trimestre = "4o Trimestre";

            for (int i = 0; i < 5; i++)
            {
                AYIID4 data = new AYIID4();
                data.EntidadFederativa = "Colima";
                data.RFC = "RUAM8111232S9";
                data.CURP = "RUAM811123HCMDGG05";
                data.Nombre = "Miguel Angel Rueda Aguilar";
                data.ClaveIntegrada = "Cve Integrada 0000";
                data.ClavePresupuestal.PartidaPresupuestal = "Partida Presupuestal 0000";
                data.ClavePresupuestal.CodigodePago = "Código de Pago 0000";
                data.ClavePresupuestal.ClavedeUnidad = "Clave de Unidad 0000";
                data.ClavePresupuestal.ClavedeSubUnidad = "Clave de Sub Unidad 0000";
                data.ClavePresupuestal.ClavedeCategoria = "Clave de Categoría 0000";
                data.ClavePresupuestal.HorasSemanaMes = "Horas Semana Mes";
                data.ClavePresupuestal.NumerodePlaza = "Número de Plaza 0000";
                data.PeriodoLicencia.Inicio = "Periodo Licencia Inicio dd/mm/yyyy";
                data.PeriodoLicencia.Conclusion = "Periodo Licencia Conclusion dd/mm/yyyy";
                data.PercepcionesPagadasenelPeriododeComisionconPresupuestoFederal = "Percepciones Pagadas Federal 0000";
                data.PercepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente = "Percepciones Pagadas Otras Fuentes 0000";
                data.ClaveCTOrigen = "Clave CT Origen 0000";
                data.Licencia.Clave = "Licencia Clave 0000";
                data.Licencia.Tipo = "Licencia Tipo 0000";
                data.DescripciondelaLicencia = "Descripcion de la Licencia 0000";

                model.Registros.Add(data);
            }

            model.TotalPersonas = model.Registros.Count();
            model.TotalPlazas = model.Registros.Count(x => x.ClavePresupuestal.NumerodePlaza.Length > 0);
            model.TotalPtoFederal = model.Registros.Count(x => x.PercepcionesPagadasenelPeriododeComisionconPresupuestoFederal.Length > 0);
            model.TotalPtoOtrasFuentes = model.Registros.Count(x => x.PercepcionesPagadasenelPeriododeComisionconPresupuestodeOtraFuente.Length > 0);

            return model;
        }
    
    }
}