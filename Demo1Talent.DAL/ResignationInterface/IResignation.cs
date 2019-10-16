using System;
using System.Collections.Generic;
using System.Text;
using Demo1Talent.DTO.ResponseModels;

namespace Demo1Talent.DAL.ResignationInterface
{
    public interface IResignation
    {
        bool Apply(int EmployeeId);
        bool Revoke(int ResignationId);
        List<EmployeeResignation> GetDetails();
        List<> GetCcPerson();
    }
}
