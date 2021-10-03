using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class EmailTemplate
    {
        public string TemplateId { get; set; }
        public string TemplateDesc { get; set; }
        public string EmailTextTop { get; set; }
        public string EmailTextBottom { get; set; }
        public string EmailSubject { get; set; }
        public bool TripnumShow { get; set; }
        public string TripnumCaption { get; set; }
        public bool DestShow { get; set; }
        public string DestCaption { get; set; }
        public bool DestaddShow { get; set; }
        public string DestaddCaption { get; set; }
        public bool CustnumShow { get; set; }
        public string CustnumCaption { get; set; }
        public bool CustnameShow { get; set; }
        public string CustnameCaption { get; set; }
        public bool CustaddShow { get; set; }
        public string CustaddCaption { get; set; }
        public bool BillcustnumShow { get; set; }
        public string BillcustnumCaption { get; set; }
        public bool BillcustnameShow { get; set; }
        public string BillcustnameCaption { get; set; }
        public bool BillcustaddShow { get; set; }
        public string BillcustaddCaption { get; set; }
        public bool DivShow { get; set; }
        public string DivCaption { get; set; }
        public bool DepdateShow { get; set; }
        public string DepdateCaption { get; set; }
        public bool RetdateShow { get; set; }
        public string RetdateCaption { get; set; }
        public bool DeptimeShow { get; set; }
        public string DeptimeCaption { get; set; }
        public bool RettimeShow { get; set; }
        public string RettimeCaption { get; set; }
        public bool FundShow { get; set; }
        public string FundCaption { get; set; }
        public bool FunddescShow { get; set; }
        public string FunddescCaption { get; set; }
        public bool PurposeShow { get; set; }
        public string PurposeCaption { get; set; }
        public bool InttripnumShow { get; set; }
        public string InttripnumCaption { get; set; }
        public bool ContactShow { get; set; }
        public string ContactCaption { get; set; }
        public bool GradeShow { get; set; }
        public string GradeCaption { get; set; }
        public bool PoShow { get; set; }
        public string PoCaption { get; set; }
        public bool MilesShow { get; set; }
        public string MilesCaption { get; set; }
        public bool HoursShow { get; set; }
        public string HoursCaption { get; set; }
        public bool AmountShow { get; set; }
        public string AmountCaption { get; set; }
        public bool TotpassShow { get; set; }
        public string TotpassCaption { get; set; }
        public bool NumstudentsShow { get; set; }
        public string NumstudentsCaption { get; set; }
        public bool NumadultsShow { get; set; }
        public string NumadultsCaption { get; set; }
        public bool NumwheelShow { get; set; }
        public string NumwheelCaption { get; set; }
        public bool TranscommentShow { get; set; }
        public string TranscommentCaption { get; set; }
        public bool TripRequest { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
