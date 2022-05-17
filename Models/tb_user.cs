using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace ProStart3.Model.Models
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class tb_user
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public int User_id { get; set; }
        /// <summary>
        /// 用户名/账号
        /// </summary>
        [Display(Name = "账号")]
        [Required(ErrorMessage = "账号是必须的")]
        [RegularExpression(@"[A-Za-z0-9._%+-]",
        ErrorMessage = "账号格式不正确！")]
        public string User_userName { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "邮箱格式不正确！")]
        public string User_email { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码是必须的")]
        public string Password { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string User_nickname { get; set; }
        /// <summary>
        /// 用户头像路径
        /// </summary>
        public string User_profilePicture { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        
        public string User_sex { get; set; }
        /// <summary>
        /// 用户等级
        /// </summary>
        public int User_classId { get; set; }
    }
}
