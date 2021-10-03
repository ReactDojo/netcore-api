using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class EmailOption
    {
        public int Id { get; set; }
        public string TomSenderEmail { get; set; }
        public bool ReqWebtripChange { get; set; }
        public bool ReqTripAccepted { get; set; }
        public bool ReqTripDenied { get; set; }
        public bool ReqTripEntered { get; set; }
        public bool? ReqAssigned { get; set; }
        public bool ReqCanceled { get; set; }
        public bool ReqBilled { get; set; }
        public bool ReqPaid { get; set; }
        public bool? ReqTripChanged { get; set; }
        public bool AdmWebtripChange { get; set; }
        public bool AdmTripAccepted { get; set; }
        public bool AdmTripDenied { get; set; }
        public bool AdmTripEntered { get; set; }
        public bool? AdmAssigned { get; set; }
        public bool AdmCanceled { get; set; }
        public bool AdmBilled { get; set; }
        public bool AdmPaid { get; set; }
        public bool AppWebtripChange { get; set; }
        public bool AppTripAccepted { get; set; }
        public bool AppTripDenied { get; set; }
        public bool AppTripEntered { get; set; }
        public bool? AppAssigned { get; set; }
        public bool AppCanceled { get; set; }
        public bool AppBilled { get; set; }
        public bool AppPaid { get; set; }
        public bool? EmployeeAssigned { get; set; }
        public bool? EmployeeAssignStatusChanged { get; set; }
        public bool? EmployeeTripCanceled { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
