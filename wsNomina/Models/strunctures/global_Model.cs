using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsNomina.Models
{
    public class global_Model
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string trimestre;
        public string Trimestre
        {
            get { return trimestre; }
            set { trimestre = value; }
        }

    }
}