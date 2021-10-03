using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class BigCalSetting
    {
        public int Id { get; set; }
        public short? DateAlign { get; set; }
        public short? DatePos { get; set; }
        public short? TextAlign { get; set; }
        public short? TextPos { get; set; }
        public short? PictureAlign { get; set; }
        public short? PicturePosition { get; set; }
        public bool? SmallIcon { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
