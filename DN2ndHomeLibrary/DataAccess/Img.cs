using System;
using System.Collections.Generic;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class Img
    {
        public int ImgId { get; set; }
        public string ImgName { get; set; } = null!;
        public byte[] Img1 { get; set; } = null!;
        public int PrdId { get; set; }
    }
}
