using System;
using System.Collections.Generic;
using System.Text;

namespace ProStart3.Model
{
    /// <summary>
    /// 用户注册时候用的类型
    /// </summary>
    public class UserInsertType
    {
        /// <summary>
        /// 账号 ,用户名
        /// </summary>
        public int username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 网名
        /// </summary>
        public string nickname { get; set; }
    }
}
