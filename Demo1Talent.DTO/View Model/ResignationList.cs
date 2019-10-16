using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Talent.DTO.View_Model
{
    class ResignationList
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string Domain { get; set; }
        public string Technology { get; set; }
        public string Designation { get; set; }
        public DateTime RaisedOn { get; set; }
        public DateTime ApprovedRelievingDate { get; set; }
        public string Status { get; set; }
    }
}
