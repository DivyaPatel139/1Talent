using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Talent.DTO.View_Model
{
    class EmployeeDetail
    {
        public string EmployeeName { get; set; }
        public int ReportingManagerId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeReason { get; set; }
        public string HrRemark { get; set; }
        public string ReportingPersonRemark { get; set; }
        public bool IsRehiredByRM { get; set; }
        public string Domain { get; set; }
        public string Designation { get; set; }
        public string Technology { get; set; }
        public DateTime ProposedRelievingDate { get; set; }
        public int CcPersonId { get; set; }
        public int OnBordingNoticePeriod { get; set; }
        public int ProposeNoticePeriod { get; set; }
        public int ApprovedNoticePeriod { get; set; }
        public string Status { get; set; }
        public DateTime RaisedOn { get; set; }
        public DateTime ApprovedRelievingDate { get; set; }
        public bool IsRehiredByHR { get; set; }
        public DateTime ExitInterviewDate { get; set; }
    }
}
