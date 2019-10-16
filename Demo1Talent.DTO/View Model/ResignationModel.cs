using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Talent.DTO.View_Model
{
    class ResignationModel
    {
        public int ResignationId { get; set; }
        public string ResignationStatus { get; set; }
        public string ManagerRemark { get; set; }
        public bool IsRehiredByManager { get; set; }
        public string HrRemark { get; set; }
        public DateTime ResignationAppovalDate { get; set; }
        public bool IsRehiredByHR { get; set; }
        public DateTime ExitInterviewDate { get; set; }
    }
}
