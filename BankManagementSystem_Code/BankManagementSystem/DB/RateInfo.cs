//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManagementSystem.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RateInfo
    {
        public RateInfo()
        {
            this.UserAccountInfoes = new HashSet<UserAccountInfo>();
        }
    
        public string DepositId { get; set; }
        public string DepositType { get; set; }
        public Nullable<double> Rate { get; set; }
    
        public virtual ICollection<UserAccountInfo> UserAccountInfoes { get; set; }
    }
}