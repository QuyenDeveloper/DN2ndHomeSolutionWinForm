using System;
using System.Collections.Generic;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public int? AvatarId { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? UserLevel { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
