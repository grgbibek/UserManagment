using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UserManagment.Enums;

namespace UserManagment.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public StatusEnum Status { get; set; }
    }
}
