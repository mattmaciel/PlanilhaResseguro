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
    
    public partial class TB_ODS_RESSEGURO_EMISSAO_MANUAL
    {
        public string CD_ORIGEM { get; set; }
        public string CD_APOLICE { get; set; }
        public string TP_ENDOSSO { get; set; }
        public string CD_ENDOSSO { get; set; }
        public string CD_ENDOSSO_AJ { get; set; }
        public int CD_ITEM { get; set; }
        public string CD_RAMO { get; set; }
        public string CD_COB { get; set; }
        public string CD_RESSEGURADOR { get; set; }
        public System.DateTime DT_EMISSAO_AJ { get; set; }
        public string TP_RESSEGURO { get; set; }
        public double PART_RESSEGURADOR { get; set; }
        public decimal VL_DIF_PREMIO_RESS { get; set; }
        public decimal VL_DIF_COMISSAO_RESS { get; set; }
        public string DS_PLANILHA { get; set; }
        public string CD_CONTABIL { get; set; }
        public string CD_PLANILHA_CEDE { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string CD_CTR_RESSEGURO { get; set; }
        public Nullable<long> ID_EXTRACAO_PREMIO { get; set; }
    
        public virtual TB_ODS_RESSEGURADOR TB_ODS_RESSEGURADOR { get; set; }
    }
}