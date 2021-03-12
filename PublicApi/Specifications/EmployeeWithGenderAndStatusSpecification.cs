using PublicApi.Entities;

namespace PublicApi.Specifications
{
    public class EmployeeWithGenderAndStatusSpecification : SpecificationBase<Employee>
    {
        public EmployeeWithGenderAndStatusSpecification(string name) 
        {
            if(name != null)
            {
                Criteria = x => x.FirstName.Contains(name) || x.LastName.Contains(name);
            }
            AddInclude(x => x.EmployeeGender);
            AddInclude(x => x.EmployeeStatus);
        }
    }
}
