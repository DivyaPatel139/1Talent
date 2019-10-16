using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1Talent.DTO.Domain_Model
{
    public class Employee
    {        
            [Key]
            public int EmployeeId { get; set; }

            [Required]
            public int EmployeeCode { get; set; }
          
            public int EmployeeRegistredId { get; set; }

            [Required]
            public string FirstName { get; set; }

            public string LastName { get; set; }

            [Required]
            public string Gender { get; set; }

            [Required]
            public string EmailId { get; set; }

            [Required]
            public string PhoneNumber { get; set; }

            [Required]
            public int DomainId { get; set; }

            public int TechnologyID { get; set; }

            public int ManagerId { get; set; }
 
            public int HRId { get; set; }

            [Required]
            public int DesignationId { get; set; }

            [Required]        
            public int NoticePeriod { get; set; }

            [Required]
            public bool IsDomainHead { get; set; }

            [Required]
            public DateTime CreatedDate { get; set; }

            public DateTime LastModifiedDate { get; set; }

            public DateTime DeletedDate { get; set; }

            public ICollection<Resignation> Resignations { get; set; }
       }
    }
