namespace DotnetAPI.Models
{
    public partial class UserSalary
    {
        public int UserId { get; set; }
        public decimal Salary { get; set; }

        // Longer way to avoid unnullable string error:
        // public MyModels()
        // {
        //     if (MyString == null)
        //     {
        //         MyString = "";
        //     }
        // }
    }
}