namespace EmployeeManagementApi.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary key, auto-incremented by database
        public required string FirstName { get; set; } // Required field
        public required string LastName { get; set; }
        public required string Email { get; set; } // Unique in DB
        public DateTime DateOfBirth { get; set; }
        public required string Position { get; set; }
        public decimal Salary { get; set; }
    }
}