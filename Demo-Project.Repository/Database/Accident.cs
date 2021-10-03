using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Accident
    {
        public int IntAccidentnum { get; set; }
        public string Accidentnum { get; set; }
        public DateTime Accidentdt { get; set; }
        public int? Empnum { get; set; }
        public string Vehicle { get; set; }
        public DateTime? AccidentTime { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public double? Xpos { get; set; }
        public double? Ypos { get; set; }
        public bool? Preventable { get; set; }
        public string Comments { get; set; }
        public string Recommendations { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public string User7 { get; set; }
        public DateTime? Userdt1 { get; set; }
        public DateTime? Userdt2 { get; set; }
        public byte[] Attach1 { get; set; }
        public byte[] Attach2 { get; set; }
        public byte[] Attach3 { get; set; }
        public string Inusefor { get; set; }
        public string Run { get; set; }
        public short? Numpassengers { get; set; }
        public string AccidentType { get; set; }
        public string AccidentInjury { get; set; }
        public string AccidentDamage { get; set; }
        public bool? Fireext { get; set; }
        public bool? Firstaid { get; set; }
        public bool? Citation { get; set; }
        public string Citcomment { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
