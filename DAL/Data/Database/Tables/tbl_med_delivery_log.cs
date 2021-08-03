using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Data.Database.Tables
{
    public partial class tbl_med_delivery_log
    {
        public int id { get; set; }
        public int? hospital_id { get; set; }
        public int? user_id { get; set; }
        public int? created { get; set; }
        public long PatientID { get; set; }
        public string prescription_no { get; set; }
        public long? consignment_no { get; set; }
        public DateTime? booking_date { get; set; }
        public string consignee { get; set; }
        public int? delivered_by { get; set; }
        public string received_by { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string delivered_tcs_date { get; set; }
        public int? no_of_dosage { get; set; }
        public bool pending_delivery_alert { get; set; }
        public bool close_case { get; set; }
        public bool is_received_shipment { get; set; }
        public int? received_hospital_id { get; set; }
        public bool is_demote { get; set; }
        public string mo_status { get; set; }
        public int? mo_deliver { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
