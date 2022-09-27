using System;
using System.Collections.Generic;

#nullable disable

namespace LINQ1._0.Models
{
    public partial class TblSubDepartments
    {
        public int Id { get; set; }
        public string SubDepartmentName { get; set; }
        public int? DepartmentId { get; set; }
    }
}
