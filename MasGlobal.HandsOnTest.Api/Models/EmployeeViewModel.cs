namespace MasGlobal.HandsOnTest.Api.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleViewModel Role { get; set; }
        public ContractViewModel Contract {get;set;}
    }
}