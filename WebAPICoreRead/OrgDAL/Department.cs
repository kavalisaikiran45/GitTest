using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrgDAL
{
    public class Department
    {

        [Key, System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Description { get; set; }

    }
}
