using System;
using System.Collections.Generic;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class Avatar
    {
        public int AvatarId { get; set; }
        public string AvatarName { get; set; } = null!;
        public byte[] Avatar1 { get; set; } = null!;
    }
}
