using E_CommerceApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceApp.Domain.Entities
{
    public class Employee : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Status Status { get; set; }
        public Roles Roles { get; set; }
        public Guid? MallId { get; set; }
        public Mall? Mall { get; set; }
        public Guid? ManagerId { get; set; }
        public Employee? Manager { get; set; }
        public List<Employee> Employees { get; set; }
        public Employee()
        {
            Employees = new List<Employee>();
        }

    }
}
