using System;
using System.Collections.Generic;
using System.Text;

namespace Kamran.Core.Domain
{
    public partial class Customer : BaseEntity
    {
        public int AccountId{ get; set; }
        public string NameSurName { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public bool IsActive{ get; set; }
        public bool IsDelete { get; set; }
    }
}
