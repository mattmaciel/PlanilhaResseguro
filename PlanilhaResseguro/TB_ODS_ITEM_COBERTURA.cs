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
    
    public partial class TB_ODS_ITEM_COBERTURA
    {
        public string CD_APOLICE { get; set; }
        public string CD_ENDOSSO { get; set; }
        public int CD_ITEM { get; set; }
        public string CD_COB { get; set; }
        public Nullable<decimal> VL_IS { get; set; }
        public Nullable<decimal> VL_PREM_TARIFARIO { get; set; }
        public Nullable<decimal> PERC_DESCONTO { get; set; }
        public Nullable<decimal> TX_PREMIO { get; set; }
        public Nullable<decimal> VL_DESCONTO { get; set; }
        public Nullable<decimal> VL_PREM_LIQ { get; set; }
        public Nullable<decimal> VL_RESSEGURO { get; set; }
        public Nullable<decimal> VL_COSSEGURO { get; set; }
        public Nullable<decimal> VL_COM_COSS { get; set; }
        public Nullable<decimal> VL_COM_RESS { get; set; }
        public Nullable<decimal> VL_COMISSAO { get; set; }
        public Nullable<decimal> VL_FRANQUIA { get; set; }
        public Nullable<int> CAT_BONUS { get; set; }
        public Nullable<decimal> PERC_BONUS { get; set; }
        public string TP_COBERTURA { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string CD_ORIGEM { get; set; }
        public string TP_ENDOSSO { get; set; }
        public Nullable<double> TX_PCT_BONUS { get; set; }
        public string CD_ACESSORIO { get; set; }
        public Nullable<decimal> VL_PREM_APOLICE { get; set; }
        public Nullable<decimal> VL_PREM_ENDOSSO { get; set; }
        public string IN_STATUS_COB { get; set; }
        public string CD_RAMO { get; set; }
        public Nullable<decimal> VL_CUSTO_AQUISICAO { get; set; }
        public Nullable<decimal> VL_PREMIO_MINIMO { get; set; }
    
        public virtual TB_ODS_ITEM TB_ODS_ITEM { get; set; }
    }
}
