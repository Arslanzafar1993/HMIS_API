using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_baseline
    {
        public int id { get; set; }
        public double? hemoglobin { get; set; }
        public double? ast { get; set; }
        public double? alt { get; set; }
        public double? platelet { get; set; }
        public double? tlc { get; set; }
        public double? apri { get; set; }
        public string hcv_pcr { get; set; }
        public string hbv_pcr { get; set; }
        public decimal? hcv_viral_load { get; set; }
        public decimal? hbv_viral_load { get; set; }
        public string liver { get; set; }
        public string spleen { get; set; }
        public bool? Ascites { get; set; }
        public string genotyping { get; set; }
        public bool? is_skip { get; set; }
        public string prescribe_medicine { get; set; }
        public bool? is_hbv_medicine { get; set; }
        public string hbv_medicine { get; set; }
        public bool? is_hcv_medicine { get; set; }
        public string hcv_medicine { get; set; }
        public bool? counselling { get; set; }
        public bool? vaccination { get; set; }
        public string vaccination_option { get; set; }
        public bool? discharge { get; set; }
        public long? PatientID { get; set; }
        public int? created { get; set; }
        public bool? deferred { get; set; }
        public bool? referral_pkli { get; set; }
        public int? user_id { get; set; }
        public bool is_demote { get; set; }
        public int? follow_up_number { get; set; }
        public int? user_hospital { get; set; }
        public int? updated { get; set; }
        public int? updated_by { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
