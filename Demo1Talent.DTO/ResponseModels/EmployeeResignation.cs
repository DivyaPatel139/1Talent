using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Talent.DTO.ResponseModels
{
    public class EmployeeResignation
    {
        public int EmployeeId { get; set; }

        public int ResignationId { get; set; }

        public int ConcernEmployeeID { get; set; }

        public DateTime ResignationProposedDate { get; set; }

        public DateTime ResignaionApprovedDate { get; set; }

        public int NoticePeroid { get; set; }

        public int ProposedNoticePeriod { get; set; }

        public int ApprovedNoticePeriod { get; set; }

        public DateTime RaisedOnDatew { get; set; }

        public string ResignationReason { get; set; }

        public string Status { get; set; }

        public string RevokeReason { get; set; }

        public string ManageRemarks { get; set; }

        public string HRRemarks { get; set; }

        public ICollection<string>  ConcernEmployees { get; set; }
    }
}
