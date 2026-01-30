using System.ComponentModel.DataAnnotations;

namespace Frontend.Components.Model
{
    public class AppSettings
    {
        public string url { get; set; }
    }
    public class MasterModel
    {
    }

    public class Student
    {
        public int SID { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public int DeptCode { get; set; }
        public string MobileNo { get; set; }
        public string EmailiD { get; set; }


    }
}
