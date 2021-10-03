using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class District
    {
        public int Id { get; set; }
        public string Distname { get; set; }
        public string Transtitle { get; set; }
        public string Distaddr1 { get; set; }
        public string Distaddr2 { get; set; }
        public string Distcity { get; set; }
        public string Diststate { get; set; }
        public string Distzip { get; set; }
        public string Distphone { get; set; }
        public byte[] Distlogo { get; set; }
        public byte[] Distlogo2 { get; set; }
        public string Distbillcom { get; set; }
        public string Prefix { get; set; }
        public bool? Printaddr { get; set; }
        public bool? Printlogo { get; set; }
        public bool Printinvsec1 { get; set; }
        public bool Printinvsec2 { get; set; }
        public bool Printinvsec3 { get; set; }
        public bool Printinvsec1Est { get; set; }
        public bool Printinvsec2Est { get; set; }
        public byte Fiscalyr { get; set; }
        public float? Droprethours { get; set; }
        public bool? Overtime { get; set; }
        public float Wklyothours { get; set; }
        public bool? Dailyot { get; set; }
        public float Dailyothours { get; set; }
        public bool? Assignsen { get; set; }
        public bool? Assignhrs { get; set; }
        public string Usercapt1 { get; set; }
        public string Usercapt2 { get; set; }
        public string Usercapt3 { get; set; }
        public string Usercapt4 { get; set; }
        public string Usercapt5 { get; set; }
        public string Userdatecapt1 { get; set; }
        public string Userdatecapt2 { get; set; }
        public string Vusercapt1 { get; set; }
        public string Vusercapt2 { get; set; }
        public string Vusercapt3 { get; set; }
        public string Defaultvtype { get; set; }
        public bool? Logactivity { get; set; }
        public bool Replacecancel { get; set; }
        public bool Makeup { get; set; }
        public string Assigntype { get; set; }
        public bool Schedavg { get; set; }
        public string Schedtiebreak { get; set; }
        public DateTime Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Dateoption { get; set; }
        public bool? TripRecalc { get; set; }
        public bool? SingleRecalc { get; set; }
        public bool Addroutes { get; set; }
        public string RotationOrder { get; set; }
        public string MassOrder { get; set; }
        public byte RoutehrsUse { get; set; }
        public float Conflictrange { get; set; }
        public float RouteConflictRange { get; set; }
        public float SplitConflictRange { get; set; }
        public bool Checktime { get; set; }
        public bool? Autofill { get; set; }
        public bool? AutofillRequests { get; set; }
        public int? Nextmassjobnum { get; set; }
        public bool Allowsplit { get; set; }
        public bool DefaultCalcnumdriver { get; set; }
        public bool Dontaddclosed { get; set; }
        public bool? CalcotDefault { get; set; }
        public bool CheckConflictManual { get; set; }
        public bool StartEndOnly { get; set; }
        public bool TwoTripsSameSched { get; set; }
        public bool NoVehWarn { get; set; }
        public string TripreqComment { get; set; }
        public bool? ViewOtherSchools { get; set; }
        public bool? PassDirections { get; set; }
        public bool? PassMiles { get; set; }
        public short Tract { get; set; }
        public bool WarnNovehAssign { get; set; }
        public bool BilltripDefault { get; set; }
        public short FirstDayOfWeek { get; set; }
        public string Distemail { get; set; }
        public string Distfax { get; set; }
        public bool? TotalTripsByday { get; set; }
        public bool? ShowTripsCal { get; set; }
        public short? TotalTripsLimit { get; set; }
        public string TotalTripsLimitMessage { get; set; }
        public bool? TotalTripsHardwarn { get; set; }
        public bool? TotalTripsWeekenddays { get; set; }
        public bool? TotalTripsNoschooldays { get; set; }
        public bool? TotalTripsBydaySchedule { get; set; }
        public bool? TotalTripsBydayVehtype { get; set; }
        public string TotalTripsScheduleLimitMessage { get; set; }
        public string TotalTripsVehtypeLimitMessage { get; set; }
        public bool? TimeconflictHardwarn { get; set; }
        public bool? FundDd { get; set; }
        public bool? Usecustfund { get; set; }
        public short? DepdtLeadtime { get; set; }
        public bool? DepdtLeadtimeHardwarn { get; set; }
        public float? Hrsrndamt { get; set; }
        public string MapSoftware { get; set; }
        public bool CheckAbsence { get; set; }
        public string DefaultSched { get; set; }
        public bool? Usepayroll { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
