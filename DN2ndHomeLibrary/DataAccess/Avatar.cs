using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class Avatar
    {
        public int AvatarId { get; set; }
        public string AvatarName { get; set; } = null!;
        public byte[] Avatar1 { get; set; } = null!;
    }
}
