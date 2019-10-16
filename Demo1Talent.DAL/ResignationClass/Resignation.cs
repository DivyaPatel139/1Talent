using Demo1Talent.DAL.Resignationcontext;
using Demo1Talent.DAL.ResignationInterface;
using Demo1Talent.DTO.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Talent.DAL.ResignationClass
{
    public class Resignation : IResignation
    {
        private readonly ResignationContext _resignationContext;

        public Resignation(ResignationContext resignationContext)
        {

        }
        public bool Apply(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public List<T> GetCcPerson()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeResignation> GetDetails()
        {
           
        }

        public List<EmployeeResignation> GetDetails(int EmployeeId)
        {
            var employeeResignationDetails = (from details in _resignationContext.Resignations
                                              join employee in _resignationContext.Employees
                                              on details.

                                              select new EmployeeResignation
                                              {
                                                  EmployeeId = details.
                                              }).ToList();
            return employeeResignationDetails;
        }
    }
}
