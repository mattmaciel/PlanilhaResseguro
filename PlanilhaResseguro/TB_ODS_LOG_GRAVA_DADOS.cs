//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanilhaResseguro
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ODS_LOG_GRAVA_DADOS
    {
        public int ID_LOG_GRAVA_DADOS { get; set; }
        public string NM_BASE { get; set; }
        public string NM_TABELA { get; set; }
        public string NM_PROCEDURE { get; set; }
        public string TP_ERRO { get; set; }
        public Nullable<int> NR_LINHA { get; set; }
        public string DS_LINHA { get; set; }
        public Nullable<int> NR_ERRO { get; set; }
        public string DS_ERRO { get; set; }
        public string IN_LIBERADO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
    }
}
