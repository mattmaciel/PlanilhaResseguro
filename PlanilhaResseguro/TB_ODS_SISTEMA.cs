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
    
    public partial class TB_ODS_SISTEMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_ODS_SISTEMA()
        {
            this.TB_ODS_EVENTO = new HashSet<TB_ODS_EVENTO>();
        }
    
        public int ID_SISTEMA { get; set; }
        public string CD_SISTEMA { get; set; }
        public string DS_SISTEMA { get; set; }
        public string CD_ORIGEM { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_EVENTO> TB_ODS_EVENTO { get; set; }
    }
}
