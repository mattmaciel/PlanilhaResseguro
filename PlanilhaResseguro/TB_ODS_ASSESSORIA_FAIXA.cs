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
    
    public partial class TB_ODS_ASSESSORIA_FAIXA
    {
        public string CD_CORRETOR { get; set; }
        public string CD_CLASSIFICACAO { get; set; }
        public string CD_FORMA_APURACAO { get; set; }
        public int ID_FAIXA { get; set; }
        public decimal VL_FAIXA_INICIAL { get; set; }
        public decimal VL_FAIXA_FINAL { get; set; }
        public decimal PC_FAIXA { get; set; }
        public System.DateTime DT_INICIO_VIGENCIA { get; set; }
        public System.DateTime DT_FIM_VIGENCIA { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
    }
}
