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
    
    public partial class TB_ODS_REVENDA
    {
        public string CD_APOLICE { get; set; }
        public string CD_ENDOSSO { get; set; }
        public string CD_REVENDA { get; set; }
        public string NM_REVENDA { get; set; }
        public string CD_CEP { get; set; }
        public string CD_AGRUPAMENTO { get; set; }
        public string NR_CPF_CNPJ { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string CD_ORIGEM { get; set; }
        public string TP_ENDOSSO { get; set; }
    
        public virtual TB_ODS_AGRUPAMENTO TB_ODS_AGRUPAMENTO { get; set; }
        public virtual TB_ODS_CEP TB_ODS_CEP { get; set; }
        public virtual TB_ODS_EMISSAO TB_ODS_EMISSAO { get; set; }
    }
}