// File: Models/DepartmentSummaryViewModel.cs

namespace EmployeeManagementSystem.Models
{
    public class DepartmentSummaryViewModel
    {
        public string DepartmentName { get; set; }  // use string, not object
        public int TotalEmployees { get; set; }
        public double? AverageTenure { get; set; }  // use double? for nullable average
    }
}
