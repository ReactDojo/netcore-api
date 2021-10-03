using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class Emptype
    {
        public string Emptype1 { get; set; }
        public string Etypedesc { get; set; }
        public float Wklyothours { get; set; }
        public float Dailyothours { get; set; }
        public float? Wklydblothours { get; set; }
        public float? Dailydblothours { get; set; }
        public bool? PayDailyOt { get; set; }
        public bool? PayWeeklyOt { get; set; }
        public bool? Monot { get; set; }
        public bool? MonotAllday { get; set; }
        public bool? MondblotAllday { get; set; }
        public bool? MonotTimerng { get; set; }
        public bool? MondblotTimerng { get; set; }
        public DateTime? MonotBegtime { get; set; }
        public DateTime? MonotEndtime { get; set; }
        public DateTime? MondblotBegtime { get; set; }
        public DateTime? MondblotEndtime { get; set; }
        public bool? MonApplyOt { get; set; }
        public bool? Tueot { get; set; }
        public bool? TueotAllday { get; set; }
        public bool? TuedblotAllday { get; set; }
        public bool? TueotTimerng { get; set; }
        public bool? TuedblotTimerng { get; set; }
        public DateTime? TueotBegtime { get; set; }
        public DateTime? TueotEndtime { get; set; }
        public DateTime? TuedblotBegtime { get; set; }
        public DateTime? TuedblotEndtime { get; set; }
        public bool? TueApplyOt { get; set; }
        public bool? Wedot { get; set; }
        public bool? WedotAllday { get; set; }
        public bool? WeddblotAllday { get; set; }
        public bool? WedotTimerng { get; set; }
        public bool? WeddblotTimerng { get; set; }
        public DateTime? WedotBegtime { get; set; }
        public DateTime? WedotEndtime { get; set; }
        public DateTime? WeddblotBegtime { get; set; }
        public DateTime? WeddblotEndtime { get; set; }
        public bool? WedApplyOt { get; set; }
        public bool? Thuot { get; set; }
        public bool? ThuotAllday { get; set; }
        public bool? ThudblotAllday { get; set; }
        public bool? ThuotTimerng { get; set; }
        public bool? ThudblotTimerng { get; set; }
        public DateTime? ThuotBegtime { get; set; }
        public DateTime? ThuotEndtime { get; set; }
        public DateTime? ThudblotBegtime { get; set; }
        public DateTime? ThudblotEndtime { get; set; }
        public bool? ThuApplyOt { get; set; }
        public bool? Friot { get; set; }
        public bool? FriotAllday { get; set; }
        public bool? FridblotAllday { get; set; }
        public bool? FriotTimerng { get; set; }
        public bool? FridblotTimerng { get; set; }
        public DateTime? FriotBegtime { get; set; }
        public DateTime? FriotEndtime { get; set; }
        public DateTime? FridblotBegtime { get; set; }
        public DateTime? FridblotEndtime { get; set; }
        public bool? FriApplyOt { get; set; }
        public bool? Satot { get; set; }
        public bool? SatotAllday { get; set; }
        public bool? SatdblotAllday { get; set; }
        public bool? SatotTimerng { get; set; }
        public bool? SatdblotTimerng { get; set; }
        public DateTime? SatotBegtime { get; set; }
        public DateTime? SatotEndtime { get; set; }
        public DateTime? SatdblotBegtime { get; set; }
        public DateTime? SatdblotEndtime { get; set; }
        public bool? SatApplyOt { get; set; }
        public bool? Sunot { get; set; }
        public bool? SunotAllday { get; set; }
        public bool? SundblotAllday { get; set; }
        public bool? SunotTimerng { get; set; }
        public bool? SundblotTimerng { get; set; }
        public DateTime? SunotBegtime { get; set; }
        public DateTime? SunotEndtime { get; set; }
        public DateTime? SundblotBegtime { get; set; }
        public DateTime? SundblotEndtime { get; set; }
        public bool? SunApplyOt { get; set; }
        public bool Active { get; set; }
        public DateTime? Inactdate { get; set; }
        public string UserEntered { get; set; }
        public string UserChanged { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateChanged { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
