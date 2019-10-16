using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1Talent.DTO.Domain_Model
{
    public class Resignation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResignationId { get; set; }

        [Required]
        public int HRId { get; set; }

        [Required]
        public int ManagerId { get; set; }

        [Required]
        public DateTime RaisedOnDate { get; set; }

        [Required]
        public DateTime ResignationProposedDate { get; set; }

        [Required]
        public string ResignationReason { get; set; }

        [MinLength(25)]
        [MaxLength(250)]
        public string RevokeRemark { get; set; }

        [Required]
        public string ResignationStatus { get; set; }

        [MinLength(25)]
        [MaxLength(250)]
        public string ManagerRemark { get; set; }

        [MinLength(25)]
        [MaxLength(250)]
        public string HRRemark { get; set; }

        public DateTime ResignationApprovedDate { get; set; }

        public DateTime ExitInterviewDate { get; set; }

        public bool IsRehiredByManager { get; set; }

        public bool IsRehiredByHR { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
