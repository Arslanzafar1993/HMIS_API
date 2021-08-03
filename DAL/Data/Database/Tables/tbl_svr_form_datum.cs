using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_svr_form_datum
    {
        public int id { get; set; }
        public long? PatientID { get; set; }
        public int? no_of_monthly_pack_patient_received { get; set; }
        public int? no_of_monthly_pack_patient_used { get; set; }
        public int? no_of_month_pat_treatment_completed { get; set; }
        public bool? gap_btw_treatment { get; set; }
        public bool? is_etr_pcr { get; set; }
        public string etr_pcr_labname { get; set; }
        public string etr_pcr_labname_other { get; set; }
        public bool? is_pat_achieve_etr { get; set; }
        public bool? is_svr_pcr { get; set; }
        public string svr_pcr_labname { get; set; }
        public string svr_pcr_labname_other { get; set; }
        public bool? is_pat_achieve_svr { get; set; }
        public bool? sample_recommended { get; set; }
        public string sample_tag { get; set; }
        public bool? is_new_regime_pat { get; set; }
        public int? created { get; set; }
        public int? hospital_id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
