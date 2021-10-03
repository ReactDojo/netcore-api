using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Demo_Project.Repository.Database
{
    public partial class bustripsEventsContext : DbContext
    {
        public bustripsEventsContext()
        {
        }

        public bustripsEventsContext(DbContextOptions<bustripsEventsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<Accident> Accidents { get; set; }
        public virtual DbSet<AccidentContributor> AccidentContributors { get; set; }
        public virtual DbSet<AccidentDamage> AccidentDamages { get; set; }
        public virtual DbSet<AccidentInjury> AccidentInjuries { get; set; }
        public virtual DbSet<AccidentInusefor> AccidentInusefors { get; set; }
        public virtual DbSet<AccidentType> AccidentTypes { get; set; }
        public virtual DbSet<Ardetail> Ardetails { get; set; }
        public virtual DbSet<Artrantype> Artrantypes { get; set; }
        public virtual DbSet<BigCalSetting> BigCalSettings { get; set; }
        public virtual DbSet<BigCalcalnote> BigCalcalnotes { get; set; }
        public virtual DbSet<Billrate> Billrates { get; set; }
        public virtual DbSet<Cancdriv> Cancdrivs { get; set; }
        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }
        public virtual DbSet<Characteristic> Characteristics { get; set; }
        public virtual DbSet<CheckinArchive> CheckinArchives { get; set; }
        public virtual DbSet<CheckinCurrentshift> CheckinCurrentshifts { get; set; }
        public virtual DbSet<Contributor> Contributors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerDestination> CustomerDestinations { get; set; }
        public virtual DbSet<CustomerFund> CustomerFunds { get; set; }
        public virtual DbSet<CustomerLocation> CustomerLocations { get; set; }
        public virtual DbSet<CustomerTripcat> CustomerTripcats { get; set; }
        public virtual DbSet<Cwzcalendaricon> Cwzcalendaricons { get; set; }
        public virtual DbSet<DayScheduleTotalCalc> DayScheduleTotalCalcs { get; set; }
        public virtual DbSet<DayScheduleTotalLive> DayScheduleTotalLives { get; set; }
        public virtual DbSet<DayTotalCalc> DayTotalCalcs { get; set; }
        public virtual DbSet<DayTotalLive> DayTotalLives { get; set; }
        public virtual DbSet<DayVehicletypeTotalCalc> DayVehicletypeTotalCalcs { get; set; }
        public virtual DbSet<DayVehicletypeTotalLive> DayVehicletypeTotalLives { get; set; }
        public virtual DbSet<Deltrip> Deltrips { get; set; }
        public virtual DbSet<Destcat> Destcats { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<DistrictEmpmgmt> DistrictEmpmgmts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<EmailOption> EmailOptions { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<Empabsence> Empabsences { get; set; }
        public virtual DbSet<EmpabsenceTran> EmpabsenceTrans { get; set; }
        public virtual DbSet<Empchar> Empchars { get; set; }
        public virtual DbSet<Empdepartment> Empdepartments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeeque> Employeeques { get; set; }
        public virtual DbSet<Empnote> Empnotes { get; set; }
        public virtual DbSet<Empphoneaddr> Empphoneaddrs { get; set; }
        public virtual DbSet<Empref> Emprefs { get; set; }
        public virtual DbSet<Emproute> Emproutes { get; set; }
        public virtual DbSet<Empstatus> Empstatuses { get; set; }
        public virtual DbSet<EmptrainTran> EmptrainTrans { get; set; }
        public virtual DbSet<Emptransaction> Emptransactions { get; set; }
        public virtual DbSet<Emptype> Emptypes { get; set; }
        public virtual DbSet<Ethnicity> Ethnicities { get; set; }
        public virtual DbSet<EventLog> EventLogs { get; set; }
        public virtual DbSet<Fund> Funds { get; set; }
        public virtual DbSet<Garage> Garages { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Makeupdriv> Makeupdrivs { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<Remindercategory> Remindercategories { get; set; }
        public virtual DbSet<Schedmast> Schedmasts { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<SwitchboardItem> SwitchboardItems { get; set; }
        public virtual DbSet<System> Systems { get; set; }
        public virtual DbSet<Tmscc> Tmsccs { get; set; }
        public virtual DbSet<Tmscg> Tmscgs { get; set; }
        public virtual DbSet<TmscgPp> TmscgPps { get; set; }
        public virtual DbSet<Tmscp> Tmscps { get; set; }
        public virtual DbSet<Tmscpp> Tmscpps { get; set; }
        public virtual DbSet<Tmscr> Tmscrs { get; set; }
        public virtual DbSet<Tmscu> Tmscus { get; set; }
        public virtual DbSet<TmscuPp> TmscuPps { get; set; }
        public virtual DbSet<Trainingcode> Trainingcodes { get; set; }
        public virtual DbSet<Traininggroup> Traininggroups { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Tripbid> Tripbids { get; set; }
        public virtual DbSet<Tripcat> Tripcats { get; set; }
        public virtual DbSet<Tripchar> Tripchars { get; set; }
        public virtual DbSet<Tripdate> Tripdates { get; set; }
        public virtual DbSet<Tripemployee> Tripemployees { get; set; }
        public virtual DbSet<Tripleg> Triplegs { get; set; }
        public virtual DbSet<TripreqConflicttime> TripreqConflicttimes { get; set; }
        public virtual DbSet<TripreqRequired> TripreqRequireds { get; set; }
        public virtual DbSet<Tripreqchar> Tripreqchars { get; set; }
        public virtual DbSet<Tripreqdate> Tripreqdates { get; set; }
        public virtual DbSet<Tripreqleg> Tripreqlegs { get; set; }
        public virtual DbSet<Tripreqsplit> Tripreqsplits { get; set; }
        public virtual DbSet<Tripreqstatus> Tripreqstatuses { get; set; }
        public virtual DbSet<Tripsplit> Tripsplits { get; set; }
        public virtual DbSet<Tripsreq> Tripsreqs { get; set; }
        public virtual DbSet<TripticketTemplate> TripticketTemplates { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Vehicleque> Vehicleques { get; set; }
        public virtual DbSet<Vehtype> Vehtypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:fieldtrips.database.windows.net,1433;Initial Catalog=bustripsEvents;Persist Security Info=False;User ID=nsayani;Password=Asap2021#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Absence>(entity =>
            {
                entity.HasKey(e => e.Absencecd)
                    .HasName("ABSENCE$PrimaryKey");

                entity.ToTable("ABSENCE");

                entity.Property(e => e.Absencecd)
                    .HasMaxLength(20)
                    .HasColumnName("ABSENCECD");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ActivityCd)
                    .HasMaxLength(10)
                    .HasColumnName("ACTIVITY_CD");

                entity.Property(e => e.Dailyot).HasColumnName("DAILYOT");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Maxhrs).HasColumnName("MAXHRS");

                entity.Property(e => e.RemaininghrsWarning).HasColumnName("REMAININGHRS_WARNING");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Weeklyot).HasColumnName("WEEKLYOT");
            });

            modelBuilder.Entity<Accident>(entity =>
            {
                entity.HasKey(e => e.IntAccidentnum)
                    .HasName("ACCIDENTS$PrimaryKey");

                entity.ToTable("ACCIDENTS");

                entity.Property(e => e.IntAccidentnum).HasColumnName("INT_ACCIDENTNUM");

                entity.Property(e => e.AccidentDamage)
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENT_DAMAGE");

                entity.Property(e => e.AccidentInjury)
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENT_INJURY");

                entity.Property(e => e.AccidentTime)
                    .HasPrecision(0)
                    .HasColumnName("ACCIDENT_TIME");

                entity.Property(e => e.AccidentType)
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENT_TYPE");

                entity.Property(e => e.Accidentdt)
                    .HasPrecision(0)
                    .HasColumnName("ACCIDENTDT");

                entity.Property(e => e.Accidentnum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENTNUM");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(100)
                    .HasColumnName("ADDR1");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDR2");

                entity.Property(e => e.Attach1).HasColumnName("ATTACH1");

                entity.Property(e => e.Attach2).HasColumnName("ATTACH2");

                entity.Property(e => e.Attach3).HasColumnName("ATTACH3");

                entity.Property(e => e.Citation).HasColumnName("CITATION");

                entity.Property(e => e.Citcomment).HasColumnName("CITCOMMENT");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .HasColumnName("CITY");

                entity.Property(e => e.Comments).HasColumnName("COMMENTS");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Fireext).HasColumnName("FIREEXT");

                entity.Property(e => e.Firstaid).HasColumnName("FIRSTAID");

                entity.Property(e => e.Inusefor)
                    .HasMaxLength(20)
                    .HasColumnName("INUSEFOR");

                entity.Property(e => e.Numpassengers).HasColumnName("NUMPASSENGERS");

                entity.Property(e => e.Preventable).HasColumnName("PREVENTABLE");

                entity.Property(e => e.Recommendations).HasColumnName("RECOMMENDATIONS");

                entity.Property(e => e.Run)
                    .HasMaxLength(20)
                    .HasColumnName("RUN");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("STATE");

                entity.Property(e => e.User1)
                    .HasMaxLength(30)
                    .HasColumnName("USER1");

                entity.Property(e => e.User2)
                    .HasMaxLength(30)
                    .HasColumnName("USER2");

                entity.Property(e => e.User3)
                    .HasMaxLength(30)
                    .HasColumnName("USER3");

                entity.Property(e => e.User4)
                    .HasMaxLength(30)
                    .HasColumnName("USER4");

                entity.Property(e => e.User5)
                    .HasMaxLength(30)
                    .HasColumnName("USER5");

                entity.Property(e => e.User6)
                    .HasMaxLength(30)
                    .HasColumnName("USER6");

                entity.Property(e => e.User7)
                    .HasMaxLength(30)
                    .HasColumnName("USER7");

                entity.Property(e => e.Userdt1)
                    .HasPrecision(0)
                    .HasColumnName("USERDT1");

                entity.Property(e => e.Userdt2)
                    .HasPrecision(0)
                    .HasColumnName("USERDT2");

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE");

                entity.Property(e => e.Xpos).HasColumnName("XPOS");

                entity.Property(e => e.Ypos).HasColumnName("YPOS");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<AccidentContributor>(entity =>
            {
                entity.HasKey(e => e.AccContributorId)
                    .HasName("ACCIDENT_CONTRIBUTORS$PrimaryKey");

                entity.ToTable("ACCIDENT_CONTRIBUTORS");

                entity.Property(e => e.AccContributorId).HasColumnName("ACC_CONTRIBUTOR_ID");

                entity.Property(e => e.Contributor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("CONTRIBUTOR");

                entity.Property(e => e.IntAccidentnum).HasColumnName("INT_ACCIDENTNUM");
            });

            modelBuilder.Entity<AccidentDamage>(entity =>
            {
                entity.HasKey(e => e.AccidentDamage1)
                    .HasName("ACCIDENT_DAMAGE$PrimaryKey");

                entity.ToTable("ACCIDENT_DAMAGE");

                entity.Property(e => e.AccidentDamage1)
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENT_DAMAGE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<AccidentInjury>(entity =>
            {
                entity.HasKey(e => e.AccidentInjury1)
                    .HasName("ACCIDENT_INJURY$PrimaryKey");

                entity.ToTable("ACCIDENT_INJURY");

                entity.Property(e => e.AccidentInjury1)
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENT_INJURY");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<AccidentInusefor>(entity =>
            {
                entity.HasKey(e => e.Inusefor)
                    .HasName("ACCIDENT_INUSEFOR$PrimaryKey");

                entity.ToTable("ACCIDENT_INUSEFOR");

                entity.Property(e => e.Inusefor)
                    .HasMaxLength(20)
                    .HasColumnName("INUSEFOR");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<AccidentType>(entity =>
            {
                entity.HasKey(e => e.AccidentType1)
                    .HasName("ACCIDENT_TYPE$PrimaryKey");

                entity.ToTable("ACCIDENT_TYPE");

                entity.Property(e => e.AccidentType1)
                    .HasMaxLength(20)
                    .HasColumnName("ACCIDENT_TYPE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Ardetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ARDETAIL");

                entity.Property(e => e.Checknum)
                    .HasMaxLength(15)
                    .HasColumnName("CHECKNUM");

                entity.Property(e => e.Recid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECID");

                entity.Property(e => e.Tranamt)
                    .HasColumnType("money")
                    .HasColumnName("TRANAMT");

                entity.Property(e => e.Trancode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("TRANCODE");

                entity.Property(e => e.Trancust)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TRANCUST");

                entity.Property(e => e.Trandate)
                    .HasPrecision(0)
                    .HasColumnName("TRANDATE");

                entity.Property(e => e.Tranfund)
                    .HasMaxLength(50)
                    .HasColumnName("TRANFUND");

                entity.Property(e => e.Tranprefix)
                    .HasMaxLength(6)
                    .HasColumnName("TRANPREFIX");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<Artrantype>(entity =>
            {
                entity.HasKey(e => e.Trancode)
                    .HasName("ARTRANTYPE$PrimaryKey");

                entity.ToTable("ARTRANTYPE");

                entity.Property(e => e.Trancode)
                    .HasMaxLength(3)
                    .HasColumnName("TRANCODE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Trandesc)
                    .HasMaxLength(30)
                    .HasColumnName("TRANDESC");

                entity.Property(e => e.Typecat)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("TYPECAT");
            });

            modelBuilder.Entity<BigCalSetting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<BigCalcalnote>(entity =>
            {
                entity.HasKey(e => e.NoteDate)
                    .HasName("BIG_CALCALNOTES$PrimaryKey");

                entity.ToTable("BIG_CALCALNOTES");

                entity.Property(e => e.NoteDate).HasPrecision(0);

                entity.Property(e => e.IconName).HasMaxLength(100);

                entity.Property(e => e.NoteLongText).HasMaxLength(255);

                entity.Property(e => e.NoteSchoolClosed).HasColumnName("Note_SchoolClosed");

                entity.Property(e => e.NoteText).HasMaxLength(20);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Billrate>(entity =>
            {
                entity.HasKey(e => e.Billrate1)
                    .HasName("BILLRATE$PrimaryKey");

                entity.ToTable("BILLRATE");

                entity.Property(e => e.Billrate1)
                    .ValueGeneratedNever()
                    .HasColumnName("BILLRATE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Amount1).HasColumnName("AMOUNT1");

                entity.Property(e => e.Amount2).HasColumnName("AMOUNT2");

                entity.Property(e => e.Amount3).HasColumnName("AMOUNT3");

                entity.Property(e => e.Amount4).HasColumnName("AMOUNT4");

                entity.Property(e => e.Amount5).HasColumnName("AMOUNT5");

                entity.Property(e => e.Amounttxt1)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT1");

                entity.Property(e => e.Amounttxt2)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT2");

                entity.Property(e => e.Amounttxt3)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT3");

                entity.Property(e => e.Amounttxt4)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT4");

                entity.Property(e => e.Amounttxt5)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT5");

                entity.Property(e => e.Billinst)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("BILLINST");

                entity.Property(e => e.Bratedesc)
                    .HasMaxLength(30)
                    .HasColumnName("BRATEDESC");

                entity.Property(e => e.Emprate).HasColumnName("EMPRATE");

                entity.Property(e => e.Hourrate).HasColumnName("HOURRATE");

                entity.Property(e => e.Hourrate2).HasColumnName("HOURRATE2");

                entity.Property(e => e.Hourstep).HasColumnName("HOURSTEP");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Milerate).HasColumnName("MILERATE");

                entity.Property(e => e.Milerate2).HasColumnName("MILERATE2");

                entity.Property(e => e.Milestep).HasColumnName("MILESTEP");

                entity.Property(e => e.Minamount).HasColumnName("MINAMOUNT");

                entity.Property(e => e.Minhours).HasColumnName("MINHOURS");

                entity.Property(e => e.Minmiles).HasColumnName("MINMILES");

                entity.Property(e => e.Otwaitrate).HasColumnName("OTWAITRATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Waitrate).HasColumnName("WAITRATE");
            });

            modelBuilder.Entity<Cancdriv>(entity =>
            {
                entity.HasKey(e => new { e.Empnum, e.Tripnum })
                    .HasName("CANCDRIV$PrimaryKey");

                entity.ToTable("CANCDRIV");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Candate)
                    .HasPrecision(0)
                    .HasColumnName("CANDATE");

                entity.Property(e => e.Repdate)
                    .HasPrecision(0)
                    .HasColumnName("REPDATE");

                entity.Property(e => e.Reptripnum).HasColumnName("REPTRIPNUM");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");
            });

            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangeLog");

                entity.Property(e => e.ChangeDate).HasPrecision(0);

                entity.Property(e => e.ChangeTime).HasPrecision(0);

                entity.Property(e => e.Field).HasMaxLength(50);

                entity.Property(e => e.FieldDesc).HasMaxLength(50);

                entity.Property(e => e.NewValue).HasMaxLength(50);

                entity.Property(e => e.OldValue).HasMaxLength(50);

                entity.Property(e => e.RecordId1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RecordID1");

                entity.Property(e => e.RecordId2)
                    .HasMaxLength(50)
                    .HasColumnName("RecordID2");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Characteristic>(entity =>
            {
                entity.HasKey(e => e.Characteristic1)
                    .HasName("CHARACTERISTICS$PrimaryKey");

                entity.ToTable("CHARACTERISTICS");

                entity.Property(e => e.Characteristic1)
                    .HasMaxLength(20)
                    .HasColumnName("CHARACTERISTIC");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<CheckinArchive>(entity =>
            {
                entity.ToTable("CHECKIN_ARCHIVE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminNote).HasColumnName("ADMIN_NOTE");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.CheckinSource)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKIN_SOURCE");

                entity.Property(e => e.Confirm).HasColumnName("CONFIRM");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(20)
                    .HasColumnName("CREATE_USER");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DistrictMessage).HasColumnName("DISTRICT_MESSAGE");

                entity.Property(e => e.EmpMessage).HasColumnName("EMP_MESSAGE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.In).HasColumnName("IN");

                entity.Property(e => e.MinutesLate).HasColumnName("MINUTES_LATE");

                entity.Property(e => e.Shift)
                    .HasMaxLength(15)
                    .HasColumnName("SHIFT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TimeIn)
                    .HasPrecision(0)
                    .HasColumnName("TIME_IN");

                entity.Property(e => e.TimeScheduled)
                    .HasPrecision(0)
                    .HasColumnName("TIME_SCHEDULED");

                entity.Property(e => e.Trandate)
                    .HasPrecision(0)
                    .HasColumnName("TRANDATE");
            });

            modelBuilder.Entity<CheckinCurrentshift>(entity =>
            {
                entity.ToTable("CHECKIN_CURRENTSHIFT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminNote).HasColumnName("ADMIN_NOTE");

                entity.Property(e => e.CheckinSource)
                    .HasMaxLength(10)
                    .HasColumnName("CHECKIN_SOURCE");

                entity.Property(e => e.Confirm).HasColumnName("CONFIRM");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(20)
                    .HasColumnName("CREATE_USER");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DistrictMessage).HasColumnName("DISTRICT_MESSAGE");

                entity.Property(e => e.EmpMessage).HasColumnName("EMP_MESSAGE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.In).HasColumnName("IN");

                entity.Property(e => e.MinutesLate).HasColumnName("MINUTES_LATE");

                entity.Property(e => e.Shift)
                    .HasMaxLength(15)
                    .HasColumnName("SHIFT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TimeIn)
                    .HasPrecision(0)
                    .HasColumnName("TIME_IN");

                entity.Property(e => e.TimeScheduled)
                    .HasPrecision(0)
                    .HasColumnName("TIME_SCHEDULED");

                entity.Property(e => e.Trandate)
                    .HasPrecision(0)
                    .HasColumnName("TRANDATE");
            });

            modelBuilder.Entity<Contributor>(entity =>
            {
                entity.HasKey(e => e.Contributor1)
                    .HasName("CONTRIBUTOR$PrimaryKey");

                entity.ToTable("CONTRIBUTOR");

                entity.Property(e => e.Contributor1)
                    .HasMaxLength(20)
                    .HasColumnName("CONTRIBUTOR");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Customer1)
                    .HasName("CUSTOMER$PrimaryKey");

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Customer1)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.AdministratorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("ADMINISTRATOR_EMAIL");

                entity.Property(e => e.ApproverEmail)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVER_EMAIL");

                entity.Property(e => e.Baseamt).HasColumnName("BASEAMT");

                entity.Property(e => e.Basehours).HasColumnName("BASEHOURS");

                entity.Property(e => e.Basemiles).HasColumnName("BASEMILES");

                entity.Property(e => e.Budget)
                    .HasColumnType("money")
                    .HasColumnName("BUDGET");

                entity.Property(e => e.Chainid)
                    .HasMaxLength(20)
                    .HasColumnName("CHAINID");

                entity.Property(e => e.CustDefaultFormat)
                    .HasMaxLength(20)
                    .HasColumnName("CUST_DEFAULT_FORMAT");

                entity.Property(e => e.Custadd1)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTADD1");

                entity.Property(e => e.Custadd2)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTADD2");

                entity.Property(e => e.Custbill).HasColumnName("CUSTBILL");

                entity.Property(e => e.Custbillcomm)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTBILLCOMM");

                entity.Property(e => e.Custbillrate).HasColumnName("CUSTBILLRATE");

                entity.Property(e => e.Custcity)
                    .HasMaxLength(15)
                    .HasColumnName("CUSTCITY");

                entity.Property(e => e.Custdiv)
                    .HasMaxLength(15)
                    .HasColumnName("CUSTDIV");

                entity.Property(e => e.Custfax)
                    .HasMaxLength(14)
                    .HasColumnName("CUSTFAX");

                entity.Property(e => e.Custinternalnum)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTINTERNALNUM");

                entity.Property(e => e.Custname)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTNAME");

                entity.Property(e => e.Custphone)
                    .HasMaxLength(14)
                    .HasColumnName("CUSTPHONE");

                entity.Property(e => e.Custspec).HasColumnName("CUSTSPEC");

                entity.Property(e => e.Custstate)
                    .HasMaxLength(2)
                    .HasColumnName("CUSTSTATE");

                entity.Property(e => e.Custzip)
                    .HasMaxLength(10)
                    .HasColumnName("CUSTZIP");

                entity.Property(e => e.DefaultBillcust)
                    .HasMaxLength(30)
                    .HasColumnName("DEFAULT_BILLCUST");

                entity.Property(e => e.Defaultcap)
                    .HasMaxLength(6)
                    .HasColumnName("DEFAULTCAP");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("REQUESTOR_EMAIL");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<CustomerDestination>(entity =>
            {
                entity.HasKey(e => new { e.Custnum, e.Destination })
                    .HasName("CUSTOMER_DESTINATION$PrimaryKey");

                entity.ToTable("CUSTOMER_DESTINATION");

                entity.Property(e => e.Custnum)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTNUM");

                entity.Property(e => e.Destination).HasColumnName("DESTINATION");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Hours).HasColumnName("HOURS");

                entity.Property(e => e.Miles).HasColumnName("MILES");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<CustomerFund>(entity =>
            {
                entity.HasKey(e => new { e.Customer, e.Fund })
                    .HasName("CUSTOMER_FUND$PrimaryKey");

                entity.ToTable("CUSTOMER_FUND");

                entity.Property(e => e.Customer)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .HasColumnName("FUND");
            });

            modelBuilder.Entity<CustomerLocation>(entity =>
            {
                entity.HasKey(e => new { e.Customer, e.Location })
                    .HasName("CUSTOMER_LOCATION$PrimaryKey");

                entity.ToTable("CUSTOMER_LOCATION");

                entity.Property(e => e.Customer)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<CustomerTripcat>(entity =>
            {
                entity.HasKey(e => new { e.Customer, e.Tripcat })
                    .HasName("CUSTOMER_TRIPCAT$PrimaryKey");

                entity.ToTable("CUSTOMER_TRIPCAT");

                entity.Property(e => e.Customer)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Tripcat)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPCAT");

                entity.Property(e => e.Chainid)
                    .HasMaxLength(20)
                    .HasColumnName("CHAINID");
            });

            modelBuilder.Entity<Cwzcalendaricon>(entity =>
            {
                entity.HasKey(e => e.NoteIconName)
                    .HasName("CWZCALENDARICONS$PrimaryKey");

                entity.ToTable("CWZCALENDARICONS");

                entity.Property(e => e.NoteIconName).HasMaxLength(50);

                entity.Property(e => e.Desc)
                    .HasMaxLength(100)
                    .HasColumnName("DESC");

                entity.Property(e => e.Iconseq).HasColumnName("ICONSEQ");

                entity.Property(e => e.NoteIconCategory).HasMaxLength(50);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<DayScheduleTotalCalc>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Schedule })
                    .HasName("DAY_SCHEDULE_TOTAL_CALC$PrimaryKey");

                entity.ToTable("DAY_SCHEDULE_TOTAL_CALC");

                entity.Property(e => e.Date).HasPrecision(0);

                entity.Property(e => e.Schedule).HasMaxLength(6);
            });

            modelBuilder.Entity<DayScheduleTotalLive>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Schedule })
                    .HasName("DAY_SCHEDULE_TOTAL_LIVE$PrimaryKey");

                entity.ToTable("DAY_SCHEDULE_TOTAL_LIVE");

                entity.Property(e => e.Date).HasPrecision(0);

                entity.Property(e => e.Schedule).HasMaxLength(6);
            });

            modelBuilder.Entity<DayTotalCalc>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("DAY_TOTAL_CALC$PrimaryKey");

                entity.ToTable("DAY_TOTAL_CALC");

                entity.Property(e => e.Date).HasPrecision(0);
            });

            modelBuilder.Entity<DayTotalLive>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("DAY_TOTAL_LIVE$PrimaryKey");

                entity.ToTable("DAY_TOTAL_LIVE");

                entity.Property(e => e.Date).HasPrecision(0);
            });

            modelBuilder.Entity<DayVehicletypeTotalCalc>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.VehType })
                    .HasName("DAY_VEHICLETYPE_TOTAL_CALC$PrimaryKey");

                entity.ToTable("DAY_VEHICLETYPE_TOTAL_CALC");

                entity.Property(e => e.Date).HasPrecision(0);

                entity.Property(e => e.VehType).HasMaxLength(3);
            });

            modelBuilder.Entity<DayVehicletypeTotalLive>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.VehType })
                    .HasName("DAY_VEHICLETYPE_TOTAL_LIVE$PrimaryKey");

                entity.ToTable("DAY_VEHICLETYPE_TOTAL_LIVE");

                entity.Property(e => e.Date).HasPrecision(0);

                entity.Property(e => e.VehType).HasMaxLength(3);
            });

            modelBuilder.Entity<Deltrip>(entity =>
            {
                entity.HasKey(e => e.Tripnum)
                    .HasName("DELTRIPS$PrimaryKey");

                entity.ToTable("DELTRIPS");

                entity.Property(e => e.Tripnum)
                    .ValueGeneratedNever()
                    .HasColumnName("TRIPNUM");

                entity.Property(e => e.Addltype)
                    .HasMaxLength(3)
                    .HasColumnName("ADDLTYPE");

                entity.Property(e => e.AdministratorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("ADMINISTRATOR_EMAIL");

                entity.Property(e => e.Amount1).HasColumnName("AMOUNT1");

                entity.Property(e => e.Amount2).HasColumnName("AMOUNT2");

                entity.Property(e => e.Amount3).HasColumnName("AMOUNT3");

                entity.Property(e => e.Amount4).HasColumnName("AMOUNT4");

                entity.Property(e => e.Amount5).HasColumnName("AMOUNT5");

                entity.Property(e => e.Amounttxt1)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT1");

                entity.Property(e => e.Amounttxt2)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT2");

                entity.Property(e => e.Amounttxt3)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT3");

                entity.Property(e => e.Amounttxt4)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT4");

                entity.Property(e => e.Amounttxt5)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT5");

                entity.Property(e => e.ApproverEmail)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVER_EMAIL");

                entity.Property(e => e.Arrivetime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETIME");

                entity.Property(e => e.Assigned).HasColumnName("ASSIGNED");

                entity.Property(e => e.Autoassign).HasColumnName("AUTOASSIGN");

                entity.Property(e => e.Bill).HasColumnName("BILL");

                entity.Property(e => e.Billcust)
                    .HasMaxLength(30)
                    .HasColumnName("BILLCUST");

                entity.Property(e => e.Billdate)
                    .HasPrecision(0)
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billed).HasColumnName("BILLED");

                entity.Property(e => e.Billrate).HasColumnName("BILLRATE");

                entity.Property(e => e.Calcnumdrivers).HasColumnName("CALCNUMDRIVERS");

                entity.Property(e => e.Canceled).HasColumnName("CANCELED");

                entity.Property(e => e.Candate)
                    .HasPrecision(0)
                    .HasColumnName("CANDATE");

                entity.Property(e => e.Capacity)
                    .HasMaxLength(6)
                    .HasColumnName("CAPACITY");

                entity.Property(e => e.Chainid)
                    .HasMaxLength(20)
                    .HasColumnName("CHAINID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(25)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Customer)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Custspec).HasColumnName("CUSTSPEC");

                entity.Property(e => e.DateEntered)
                    .HasPrecision(0)
                    .HasColumnName("DATE_ENTERED");

                entity.Property(e => e.DateLastchanged)
                    .HasPrecision(0)
                    .HasColumnName("DATE_LASTCHANGED");

                entity.Property(e => e.Depdate)
                    .HasPrecision(0)
                    .HasColumnName("DEPDATE");

                entity.Property(e => e.Deptime)
                    .HasPrecision(0)
                    .HasColumnName("DEPTIME");

                entity.Property(e => e.Destadd1)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD1");

                entity.Property(e => e.Destadd2)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD2");

                entity.Property(e => e.Destcat)
                    .HasMaxLength(5)
                    .HasColumnName("DESTCAT");

                entity.Property(e => e.Destcity)
                    .HasMaxLength(15)
                    .HasColumnName("DESTCITY");

                entity.Property(e => e.Destdesc)
                    .HasMaxLength(100)
                    .HasColumnName("DESTDESC");

                entity.Property(e => e.Destination).HasColumnName("DESTINATION");

                entity.Property(e => e.Destspec).HasColumnName("DESTSPEC");

                entity.Property(e => e.Deststate)
                    .HasMaxLength(2)
                    .HasColumnName("DESTSTATE");

                entity.Property(e => e.Destzip)
                    .HasMaxLength(10)
                    .HasColumnName("DESTZIP");

                entity.Property(e => e.Dropret).HasColumnName("DROPRET");

                entity.Property(e => e.Enterdate)
                    .HasPrecision(0)
                    .HasColumnName("ENTERDATE");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(20)
                    .HasColumnName("ENTEREDBY");

                entity.Property(e => e.Estmile).HasColumnName("ESTMILE");

                entity.Property(e => e.Esttime).HasColumnName("ESTTIME");

                entity.Property(e => e.FieldtripNum).HasColumnName("FIELDTRIP_NUM");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .HasColumnName("FUND");

                entity.Property(e => e.Grade)
                    .HasMaxLength(20)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Inttripnum)
                    .HasMaxLength(30)
                    .HasColumnName("INTTRIPNUM");

                entity.Property(e => e.InvoiceComment1).HasColumnName("INVOICE_COMMENT#1");

                entity.Property(e => e.InvoiceFormat)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICE_FORMAT");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Miles).HasColumnName("MILES");

                entity.Property(e => e.Multidest).HasColumnName("MULTIDEST");

                entity.Property(e => e.Numaddl).HasColumnName("NUMADDL");

                entity.Property(e => e.Numadults).HasColumnName("NUMADULTS");

                entity.Property(e => e.Numchar).HasColumnName("NUMCHAR");

                entity.Property(e => e.Numhand).HasColumnName("NUMHAND");

                entity.Property(e => e.Numstudents).HasColumnName("NUMSTUDENTS");

                entity.Property(e => e.Numtype).HasColumnName("NUMTYPE");

                entity.Property(e => e.Numveh).HasColumnName("NUMVEH");

                entity.Property(e => e.Outoftown).HasColumnName("OUTOFTOWN");

                entity.Property(e => e.Po)
                    .HasMaxLength(15)
                    .HasColumnName("PO");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(25)
                    .HasColumnName("PURPOSE");

                entity.Property(e => e.Reqdate)
                    .HasPrecision(0)
                    .HasColumnName("REQDATE");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("REQUESTOR_EMAIL");

                entity.Property(e => e.Retdate)
                    .HasPrecision(0)
                    .HasColumnName("RETDATE");

                entity.Property(e => e.Rettime)
                    .HasPrecision(0)
                    .HasColumnName("RETTIME");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Schedule2)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE2");

                entity.Property(e => e.Schedule3)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE3");

                entity.Property(e => e.Schedule4)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE4");

                entity.Property(e => e.Schedule5)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE5");

                entity.Property(e => e.Shuttle).HasColumnName("SHUTTLE");

                entity.Property(e => e.Split).HasColumnName("SPLIT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusComment).HasColumnName("STATUS_COMMENT");

                entity.Property(e => e.StatusDate)
                    .HasPrecision(0)
                    .HasColumnName("STATUS_DATE");

                entity.Property(e => e.TicketFormat)
                    .HasMaxLength(50)
                    .HasColumnName("TICKET_FORMAT");

                entity.Property(e => e.Tripcat)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPCAT");

                entity.Property(e => e.Tripcom).HasColumnName("TRIPCOM");

                entity.Property(e => e.Tripreqnum).HasColumnName("TRIPREQNUM");

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .HasColumnName("TYPE");

                entity.Property(e => e.User1)
                    .HasMaxLength(30)
                    .HasColumnName("USER1");

                entity.Property(e => e.User2)
                    .HasMaxLength(30)
                    .HasColumnName("USER2");

                entity.Property(e => e.UserEntered)
                    .HasMaxLength(20)
                    .HasColumnName("USER_ENTERED");

                entity.Property(e => e.UserLastchanged)
                    .HasMaxLength(20)
                    .HasColumnName("USER_LASTCHANGED");

                entity.Property(e => e.Userdate1)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE1");

                entity.Property(e => e.Userdate2)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE2");
            });

            modelBuilder.Entity<Destcat>(entity =>
            {
                entity.HasKey(e => e.Destcat1)
                    .HasName("DESTCAT$PrimaryKey");

                entity.ToTable("DESTCAT");

                entity.Property(e => e.Destcat1)
                    .HasMaxLength(5)
                    .HasColumnName("DESTCAT");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Dcatdesc)
                    .HasMaxLength(30)
                    .HasColumnName("DCATDESC");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.Destination1)
                    .HasName("DESTINATION$PrimaryKey");

                entity.ToTable("DESTINATION");

                entity.Property(e => e.Destination1).HasColumnName("DESTINATION");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BillAmount).HasColumnName("BILL_AMOUNT");

                entity.Property(e => e.Destadd1)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD1");

                entity.Property(e => e.Destadd2)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD2");

                entity.Property(e => e.Destcat)
                    .HasMaxLength(5)
                    .HasColumnName("DESTCAT");

                entity.Property(e => e.Destcity)
                    .HasMaxLength(15)
                    .HasColumnName("DESTCITY");

                entity.Property(e => e.Destdesc)
                    .HasMaxLength(100)
                    .HasColumnName("DESTDESC");

                entity.Property(e => e.Destspec).HasColumnName("DESTSPEC");

                entity.Property(e => e.Deststate)
                    .HasMaxLength(2)
                    .HasColumnName("DESTSTATE");

                entity.Property(e => e.Destzip)
                    .HasMaxLength(10)
                    .HasColumnName("DESTZIP");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Miles).HasColumnName("MILES");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("DISTRICT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addroutes).HasColumnName("ADDROUTES");

                entity.Property(e => e.Allowsplit).HasColumnName("ALLOWSPLIT");

                entity.Property(e => e.Assignhrs).HasColumnName("ASSIGNHRS");

                entity.Property(e => e.Assignsen).HasColumnName("ASSIGNSEN");

                entity.Property(e => e.Assigntype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ASSIGNTYPE");

                entity.Property(e => e.Autofill).HasColumnName("AUTOFILL");

                entity.Property(e => e.AutofillRequests).HasColumnName("AUTOFILL_REQUESTS");

                entity.Property(e => e.Begdate)
                    .HasPrecision(0)
                    .HasColumnName("BEGDATE");

                entity.Property(e => e.BilltripDefault).HasColumnName("BILLTRIP_DEFAULT");

                entity.Property(e => e.CalcotDefault).HasColumnName("CALCOT_DEFAULT");

                entity.Property(e => e.CheckAbsence).HasColumnName("CHECK_ABSENCE");

                entity.Property(e => e.CheckConflictManual).HasColumnName("CHECK_CONFLICT_MANUAL");

                entity.Property(e => e.Checktime).HasColumnName("CHECKTIME");

                entity.Property(e => e.Conflictrange).HasColumnName("CONFLICTRANGE");

                entity.Property(e => e.Dailyot).HasColumnName("DAILYOT");

                entity.Property(e => e.Dailyothours).HasColumnName("DAILYOTHOURS");

                entity.Property(e => e.Dateoption)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DATEOPTION");

                entity.Property(e => e.DefaultCalcnumdriver).HasColumnName("DEFAULT_CALCNUMDRIVER");

                entity.Property(e => e.DefaultSched)
                    .HasMaxLength(6)
                    .HasColumnName("DEFAULT_SCHED");

                entity.Property(e => e.Defaultvtype)
                    .HasMaxLength(3)
                    .HasColumnName("DEFAULTVTYPE");

                entity.Property(e => e.DepdtLeadtime).HasColumnName("DEPDT_LEADTIME");

                entity.Property(e => e.DepdtLeadtimeHardwarn).HasColumnName("DEPDT_LEADTIME_HARDWARN");

                entity.Property(e => e.Distaddr1)
                    .HasMaxLength(30)
                    .HasColumnName("DISTADDR1");

                entity.Property(e => e.Distaddr2)
                    .HasMaxLength(30)
                    .HasColumnName("DISTADDR2");

                entity.Property(e => e.Distbillcom)
                    .HasMaxLength(50)
                    .HasColumnName("DISTBILLCOM");

                entity.Property(e => e.Distcity)
                    .HasMaxLength(15)
                    .HasColumnName("DISTCITY");

                entity.Property(e => e.Distemail)
                    .HasMaxLength(100)
                    .HasColumnName("DISTEMAIL");

                entity.Property(e => e.Distfax)
                    .HasMaxLength(14)
                    .HasColumnName("DISTFAX");

                entity.Property(e => e.Distlogo).HasColumnName("DISTLOGO");

                entity.Property(e => e.Distlogo2).HasColumnName("DISTLOGO2");

                entity.Property(e => e.Distname)
                    .HasMaxLength(50)
                    .HasColumnName("DISTNAME");

                entity.Property(e => e.Distphone)
                    .HasMaxLength(14)
                    .HasColumnName("DISTPHONE");

                entity.Property(e => e.Diststate)
                    .HasMaxLength(2)
                    .HasColumnName("DISTSTATE");

                entity.Property(e => e.Distzip)
                    .HasMaxLength(10)
                    .HasColumnName("DISTZIP");

                entity.Property(e => e.Dontaddclosed).HasColumnName("DONTADDCLOSED");

                entity.Property(e => e.Droprethours).HasColumnName("DROPRETHOURS");

                entity.Property(e => e.Enddate)
                    .HasPrecision(0)
                    .HasColumnName("ENDDate");

                entity.Property(e => e.FirstDayOfWeek).HasColumnName("FIRST_DAY_OF_WEEK");

                entity.Property(e => e.Fiscalyr).HasColumnName("FISCALYR");

                entity.Property(e => e.FundDd).HasColumnName("FUND_DD");

                entity.Property(e => e.Hrsrndamt).HasColumnName("HRSRNDAMT");

                entity.Property(e => e.Logactivity).HasColumnName("LOGACTIVITY");

                entity.Property(e => e.Makeup).HasColumnName("MAKEUP");

                entity.Property(e => e.MapSoftware)
                    .HasMaxLength(20)
                    .HasColumnName("MAP_SOFTWARE");

                entity.Property(e => e.MassOrder)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("MASS_ORDER");

                entity.Property(e => e.Nextmassjobnum).HasColumnName("NEXTMASSJOBNUM");

                entity.Property(e => e.NoVehWarn).HasColumnName("NO_VEH_WARN");

                entity.Property(e => e.Overtime).HasColumnName("OVERTIME");

                entity.Property(e => e.PassDirections).HasColumnName("PASS_DIRECTIONS");

                entity.Property(e => e.PassMiles).HasColumnName("PASS_MILES");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Printaddr).HasColumnName("PRINTADDR");

                entity.Property(e => e.Printinvsec1).HasColumnName("PRINTINVSEC1");

                entity.Property(e => e.Printinvsec1Est).HasColumnName("PRINTINVSEC1_EST");

                entity.Property(e => e.Printinvsec2).HasColumnName("PRINTINVSEC2");

                entity.Property(e => e.Printinvsec2Est).HasColumnName("PRINTINVSEC2_EST");

                entity.Property(e => e.Printinvsec3).HasColumnName("PRINTINVSEC3");

                entity.Property(e => e.Printlogo).HasColumnName("PRINTLOGO");

                entity.Property(e => e.Replacecancel).HasColumnName("REPLACECANCEL");

                entity.Property(e => e.RotationOrder)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("ROTATION_ORDER");

                entity.Property(e => e.RouteConflictRange).HasColumnName("ROUTE_CONFLICT_RANGE");

                entity.Property(e => e.RoutehrsUse).HasColumnName("ROUTEHRS_USE");

                entity.Property(e => e.Schedavg).HasColumnName("SCHEDAVG");

                entity.Property(e => e.Schedtiebreak)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SCHEDTIEBREAK");

                entity.Property(e => e.ShowTripsCal).HasColumnName("SHOW_TRIPS_CAL");

                entity.Property(e => e.SingleRecalc).HasColumnName("SINGLE_RECALC");

                entity.Property(e => e.SplitConflictRange).HasColumnName("SPLIT_CONFLICT_RANGE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.StartEndOnly).HasColumnName("START_END_ONLY");

                entity.Property(e => e.TimeconflictHardwarn).HasColumnName("TIMECONFLICT_HARDWARN");

                entity.Property(e => e.TotalTripsByday).HasColumnName("TOTAL_TRIPS_BYDAY");

                entity.Property(e => e.TotalTripsBydaySchedule).HasColumnName("TOTAL_TRIPS_BYDAY_SCHEDULE");

                entity.Property(e => e.TotalTripsBydayVehtype).HasColumnName("TOTAL_TRIPS_BYDAY_VEHTYPE");

                entity.Property(e => e.TotalTripsHardwarn).HasColumnName("TOTAL_TRIPS_HARDWARN");

                entity.Property(e => e.TotalTripsLimit).HasColumnName("TOTAL_TRIPS_LIMIT");

                entity.Property(e => e.TotalTripsLimitMessage).HasColumnName("TOTAL_TRIPS_LIMIT_MESSAGE");

                entity.Property(e => e.TotalTripsNoschooldays).HasColumnName("TOTAL_TRIPS_NOSCHOOLDAYS");

                entity.Property(e => e.TotalTripsScheduleLimitMessage).HasColumnName("TOTAL_TRIPS_SCHEDULE_ LIMIT_MESSAGE");

                entity.Property(e => e.TotalTripsVehtypeLimitMessage).HasColumnName("TOTAL_TRIPS_VEHTYPE_ LIMIT_MESSAGE");

                entity.Property(e => e.TotalTripsWeekenddays).HasColumnName("TOTAL_TRIPS_WEEKENDDAYS");

                entity.Property(e => e.Tract).HasColumnName("TRACT");

                entity.Property(e => e.Transtitle)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSTITLE");

                entity.Property(e => e.TripRecalc).HasColumnName("TRIP_RECALC");

                entity.Property(e => e.TripreqComment).HasColumnName("TRIPREQ_COMMENT");

                entity.Property(e => e.TwoTripsSameSched).HasColumnName("TWO_TRIPS_SAME_SCHED");

                entity.Property(e => e.Usecustfund).HasColumnName("USECUSTFUND");

                entity.Property(e => e.Usepayroll).HasColumnName("USEPAYROLL");

                entity.Property(e => e.Usercapt1)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT1");

                entity.Property(e => e.Usercapt2)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT2");

                entity.Property(e => e.Usercapt3)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT3");

                entity.Property(e => e.Usercapt4)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT4");

                entity.Property(e => e.Usercapt5)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT5");

                entity.Property(e => e.Userdatecapt1)
                    .HasMaxLength(10)
                    .HasColumnName("USERDATECAPT1");

                entity.Property(e => e.Userdatecapt2)
                    .HasMaxLength(10)
                    .HasColumnName("USERDATECAPT2");

                entity.Property(e => e.ViewOtherSchools).HasColumnName("VIEW_OTHER_SCHOOLS");

                entity.Property(e => e.Vusercapt1)
                    .HasMaxLength(10)
                    .HasColumnName("VUSERCAPT1");

                entity.Property(e => e.Vusercapt2)
                    .HasMaxLength(10)
                    .HasColumnName("VUSERCAPT2");

                entity.Property(e => e.Vusercapt3)
                    .HasMaxLength(10)
                    .HasColumnName("VUSERCAPT3");

                entity.Property(e => e.WarnNovehAssign).HasColumnName("WARN_NOVEH_ASSIGN");

                entity.Property(e => e.Wklyothours).HasColumnName("WKLYOTHOURS");
            });

            modelBuilder.Entity<DistrictEmpmgmt>(entity =>
            {
                entity.ToTable("DISTRICT_EMPMGMT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Accusercapt1)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT1");

                entity.Property(e => e.Accusercapt2)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT2");

                entity.Property(e => e.Accusercapt3)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT3");

                entity.Property(e => e.Accusercapt4)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT4");

                entity.Property(e => e.Accusercapt5)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT5");

                entity.Property(e => e.Accusercapt6)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT6");

                entity.Property(e => e.Accusercapt7)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERCAPT7");

                entity.Property(e => e.Accuserdatecapt1)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERDATECAPT1");

                entity.Property(e => e.Accuserdatecapt2)
                    .HasMaxLength(15)
                    .HasColumnName("ACCUSERDATECAPT2");

                entity.Property(e => e.CheckinMessage).HasColumnName("CHECKIN_MESSAGE");

                entity.Property(e => e.CriticalLate).HasColumnName("CRITICAL_LATE");

                entity.Property(e => e.CriticalWarningSound)
                    .HasMaxLength(100)
                    .HasColumnName("CRITICAL_WARNING_SOUND");

                entity.Property(e => e.Lastbatchid).HasColumnName("LASTBATCHID");

                entity.Property(e => e.LateWarningSound)
                    .HasMaxLength(100)
                    .HasColumnName("LATE_WARNING_SOUND");

                entity.Property(e => e.MessageBeginDate)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_BEGIN_DATE");

                entity.Property(e => e.MessageBeginTime)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_BEGIN_TIME");

                entity.Property(e => e.MessageEndDate)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_END_DATE");

                entity.Property(e => e.MessageEndTime)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_END_TIME");

                entity.Property(e => e.PrepTime).HasColumnName("PREP_TIME");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Usercapt10)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT10");

                entity.Property(e => e.Usercapt6)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT6");

                entity.Property(e => e.Usercapt7)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT7");

                entity.Property(e => e.Usercapt8)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT8");

                entity.Property(e => e.Usercapt9)
                    .HasMaxLength(10)
                    .HasColumnName("USERCAPT9");

                entity.Property(e => e.Userdatecapt3)
                    .HasMaxLength(10)
                    .HasColumnName("USERDATECAPT3");

                entity.Property(e => e.Userdatecapt4)
                    .HasMaxLength(10)
                    .HasColumnName("USERDATECAPT4");

                entity.Property(e => e.Userdatecapt5)
                    .HasMaxLength(10)
                    .HasColumnName("USERDATECAPT5");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.Division1)
                    .HasName("DIVISION$PrimaryKey");

                entity.ToTable("DIVISION");

                entity.Property(e => e.Division1)
                    .HasMaxLength(15)
                    .HasColumnName("DIVISION");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Divaddr1)
                    .HasMaxLength(30)
                    .HasColumnName("DIVADDR1");

                entity.Property(e => e.Divaddr2)
                    .HasMaxLength(30)
                    .HasColumnName("DIVADDR2");

                entity.Property(e => e.Divcity)
                    .HasMaxLength(15)
                    .HasColumnName("DIVCITY");

                entity.Property(e => e.Divphone)
                    .HasMaxLength(14)
                    .HasColumnName("DIVPHONE");

                entity.Property(e => e.Divstate)
                    .HasMaxLength(2)
                    .HasColumnName("DIVSTATE");

                entity.Property(e => e.Divzip)
                    .HasMaxLength(10)
                    .HasColumnName("DIVZIP");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<EmailOption>(entity =>
            {
                entity.ToTable("EMAIL_OPTIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdmAssigned).HasColumnName("ADM_ASSIGNED");

                entity.Property(e => e.AdmBilled).HasColumnName("ADM_BILLED");

                entity.Property(e => e.AdmCanceled).HasColumnName("ADM_CANCELED");

                entity.Property(e => e.AdmPaid).HasColumnName("ADM_PAID");

                entity.Property(e => e.AdmTripAccepted).HasColumnName("ADM_TRIP_ACCEPTED");

                entity.Property(e => e.AdmTripDenied).HasColumnName("ADM_TRIP_DENIED");

                entity.Property(e => e.AdmTripEntered).HasColumnName("ADM_TRIP_ENTERED");

                entity.Property(e => e.AdmWebtripChange).HasColumnName("ADM_WEBTRIP_CHANGE");

                entity.Property(e => e.AppAssigned).HasColumnName("APP_ASSIGNED");

                entity.Property(e => e.AppBilled).HasColumnName("APP_BILLED");

                entity.Property(e => e.AppCanceled).HasColumnName("APP_CANCELED");

                entity.Property(e => e.AppPaid).HasColumnName("APP_PAID");

                entity.Property(e => e.AppTripAccepted).HasColumnName("APP_TRIP_ACCEPTED");

                entity.Property(e => e.AppTripDenied).HasColumnName("APP_TRIP_DENIED");

                entity.Property(e => e.AppTripEntered).HasColumnName("APP_TRIP_ENTERED");

                entity.Property(e => e.AppWebtripChange).HasColumnName("APP_WEBTRIP_CHANGE");

                entity.Property(e => e.EmployeeAssignStatusChanged).HasColumnName("EMPLOYEE_ASSIGN_STATUS_CHANGED");

                entity.Property(e => e.EmployeeAssigned).HasColumnName("EMPLOYEE_ASSIGNED");

                entity.Property(e => e.EmployeeTripCanceled).HasColumnName("EMPLOYEE_TRIP_CANCELED");

                entity.Property(e => e.ReqAssigned).HasColumnName("REQ_ASSIGNED");

                entity.Property(e => e.ReqBilled).HasColumnName("REQ_BILLED");

                entity.Property(e => e.ReqCanceled).HasColumnName("REQ_CANCELED");

                entity.Property(e => e.ReqPaid).HasColumnName("REQ_PAID");

                entity.Property(e => e.ReqTripAccepted).HasColumnName("REQ_TRIP_ACCEPTED");

                entity.Property(e => e.ReqTripChanged).HasColumnName("REQ_TRIP_CHANGED");

                entity.Property(e => e.ReqTripDenied).HasColumnName("REQ_TRIP_DENIED");

                entity.Property(e => e.ReqTripEntered).HasColumnName("REQ_TRIP_ENTERED");

                entity.Property(e => e.ReqWebtripChange).HasColumnName("REQ_WEBTRIP_CHANGE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TomSenderEmail)
                    .HasMaxLength(100)
                    .HasColumnName("TOM_SENDER_EMAIL");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("EMAIL_TEMPLATE$PrimaryKey");

                entity.ToTable("EMAIL_TEMPLATE");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(20)
                    .HasColumnName("TEMPLATE_ID");

                entity.Property(e => e.AmountCaption)
                    .HasMaxLength(30)
                    .HasColumnName("AMOUNT_CAPTION");

                entity.Property(e => e.AmountShow).HasColumnName("AMOUNT_SHOW");

                entity.Property(e => e.BillcustaddCaption)
                    .HasMaxLength(30)
                    .HasColumnName("BILLCUSTADD_CAPTION");

                entity.Property(e => e.BillcustaddShow).HasColumnName("BILLCUSTADD_SHOW");

                entity.Property(e => e.BillcustnameCaption)
                    .HasMaxLength(30)
                    .HasColumnName("BILLCUSTNAME_CAPTION");

                entity.Property(e => e.BillcustnameShow).HasColumnName("BILLCUSTNAME_SHOW");

                entity.Property(e => e.BillcustnumCaption)
                    .HasMaxLength(30)
                    .HasColumnName("BILLCUSTNUM_CAPTION");

                entity.Property(e => e.BillcustnumShow).HasColumnName("BILLCUSTNUM_SHOW");

                entity.Property(e => e.ContactCaption)
                    .HasMaxLength(30)
                    .HasColumnName("CONTACT_CAPTION");

                entity.Property(e => e.ContactShow).HasColumnName("CONTACT_SHOW");

                entity.Property(e => e.CustaddCaption)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTADD_CAPTION");

                entity.Property(e => e.CustaddShow).HasColumnName("CUSTADD_SHOW");

                entity.Property(e => e.CustnameCaption)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTNAME_CAPTION");

                entity.Property(e => e.CustnameShow).HasColumnName("CUSTNAME_SHOW");

                entity.Property(e => e.CustnumCaption)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTNUM_CAPTION");

                entity.Property(e => e.CustnumShow).HasColumnName("CUSTNUM_SHOW");

                entity.Property(e => e.DepdateCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DEPDATE_CAPTION");

                entity.Property(e => e.DepdateShow).HasColumnName("DEPDATE_SHOW");

                entity.Property(e => e.DeptimeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DEPTIME_CAPTION");

                entity.Property(e => e.DeptimeShow).HasColumnName("DEPTIME_SHOW");

                entity.Property(e => e.DestCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DEST_CAPTION");

                entity.Property(e => e.DestShow).HasColumnName("DEST_SHOW");

                entity.Property(e => e.DestaddCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD_CAPTION");

                entity.Property(e => e.DestaddShow).HasColumnName("DESTADD_SHOW");

                entity.Property(e => e.DivCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DIV_CAPTION");

                entity.Property(e => e.DivShow).HasColumnName("DIV_SHOW");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL_SUBJECT");

                entity.Property(e => e.EmailTextBottom).HasColumnName("EMAIL_TEXT_BOTTOM");

                entity.Property(e => e.EmailTextTop).HasColumnName("EMAIL_TEXT_TOP");

                entity.Property(e => e.FundCaption)
                    .HasMaxLength(30)
                    .HasColumnName("FUND_CAPTION");

                entity.Property(e => e.FundShow).HasColumnName("FUND_SHOW");

                entity.Property(e => e.FunddescCaption)
                    .HasMaxLength(30)
                    .HasColumnName("FUNDDESC_CAPTION");

                entity.Property(e => e.FunddescShow).HasColumnName("FUNDDESC_SHOW");

                entity.Property(e => e.GradeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("GRADE_CAPTION");

                entity.Property(e => e.GradeShow).HasColumnName("GRADE_SHOW");

                entity.Property(e => e.HoursCaption)
                    .HasMaxLength(30)
                    .HasColumnName("HOURS_CAPTION");

                entity.Property(e => e.HoursShow).HasColumnName("HOURS_SHOW");

                entity.Property(e => e.InttripnumCaption)
                    .HasMaxLength(30)
                    .HasColumnName("INTTRIPNUM_CAPTION");

                entity.Property(e => e.InttripnumShow).HasColumnName("INTTRIPNUM_SHOW");

                entity.Property(e => e.MilesCaption)
                    .HasMaxLength(30)
                    .HasColumnName("MILES_CAPTION");

                entity.Property(e => e.MilesShow).HasColumnName("MILES_SHOW");

                entity.Property(e => e.NumadultsCaption)
                    .HasMaxLength(30)
                    .HasColumnName("NUMADULTS_CAPTION");

                entity.Property(e => e.NumadultsShow).HasColumnName("NUMADULTS_SHOW");

                entity.Property(e => e.NumstudentsCaption)
                    .HasMaxLength(30)
                    .HasColumnName("NUMSTUDENTS_CAPTION");

                entity.Property(e => e.NumstudentsShow).HasColumnName("NUMSTUDENTS_SHOW");

                entity.Property(e => e.NumwheelCaption)
                    .HasMaxLength(30)
                    .HasColumnName("NUMWHEEL_CAPTION");

                entity.Property(e => e.NumwheelShow).HasColumnName("NUMWHEEL_SHOW");

                entity.Property(e => e.PoCaption)
                    .HasMaxLength(30)
                    .HasColumnName("PO_CAPTION");

                entity.Property(e => e.PoShow).HasColumnName("PO_SHOW");

                entity.Property(e => e.PurposeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("PURPOSE_CAPTION");

                entity.Property(e => e.PurposeShow).HasColumnName("PURPOSE_SHOW");

                entity.Property(e => e.RetdateCaption)
                    .HasMaxLength(30)
                    .HasColumnName("RETDATE_CAPTION");

                entity.Property(e => e.RetdateShow).HasColumnName("RETDATE_SHOW");

                entity.Property(e => e.RettimeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("RETTIME_CAPTION");

                entity.Property(e => e.RettimeShow).HasColumnName("RETTIME_SHOW");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TemplateDesc)
                    .HasMaxLength(50)
                    .HasColumnName("TEMPLATE_DESC");

                entity.Property(e => e.TotpassCaption)
                    .HasMaxLength(30)
                    .HasColumnName("TOTPASS_CAPTION");

                entity.Property(e => e.TotpassShow).HasColumnName("TOTPASS_SHOW");

                entity.Property(e => e.TranscommentCaption)
                    .HasMaxLength(30)
                    .HasColumnName("TRANSCOMMENT_CAPTION");

                entity.Property(e => e.TranscommentShow).HasColumnName("TRANSCOMMENT_SHOW");

                entity.Property(e => e.TripRequest).HasColumnName("TRIP_REQUEST");

                entity.Property(e => e.TripnumCaption)
                    .HasMaxLength(30)
                    .HasColumnName("TRIPNUM_CAPTION");

                entity.Property(e => e.TripnumShow).HasColumnName("TRIPNUM_SHOW");
            });

            modelBuilder.Entity<Empabsence>(entity =>
            {
                entity.HasKey(e => new { e.Empnum, e.Absencecd })
                    .HasName("EMPABSENCE$PrimaryKey");

                entity.ToTable("EMPABSENCE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Absencecd)
                    .HasMaxLength(20)
                    .HasColumnName("ABSENCECD");

                entity.Property(e => e.Consumedhrs).HasColumnName("CONSUMEDHRS");

                entity.Property(e => e.Maxhrs).HasColumnName("MAXHRS");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<EmpabsenceTran>(entity =>
            {
                entity.HasKey(e => e.EmpabsenceTransid)
                    .HasName("EMPABSENCE_TRANS$PrimaryKey");

                entity.ToTable("EMPABSENCE_TRANS");

                entity.Property(e => e.EmpabsenceTransid).HasColumnName("EMPABSENCE_TRANSID");

                entity.Property(e => e.Absencecd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ABSENCECD");

                entity.Property(e => e.Absencedate)
                    .HasPrecision(0)
                    .HasColumnName("ABSENCEDATE");

                entity.Property(e => e.Allday).HasColumnName("ALLDAY");

                entity.Property(e => e.ApplyToPayroll).HasColumnName("Apply_To_Payroll");

                entity.Property(e => e.Begtime)
                    .HasPrecision(0)
                    .HasColumnName("BEGTIME");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.CoverageAbs).HasColumnName("COVERAGE_ABS");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Hrs).HasColumnName("HRS");

                entity.Property(e => e.Imported).HasColumnName("IMPORTED");

                entity.Property(e => e.PayTransid).HasColumnName("PAY_TRANSID");

                entity.Property(e => e.PaytransDateentered)
                    .HasPrecision(0)
                    .HasColumnName("PAYTRANS_DATEENTERED");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Empchar>(entity =>
            {
                entity.HasKey(e => new { e.Empnum, e.Characteristic })
                    .HasName("EMPCHAR$PrimaryKey");

                entity.ToTable("EMPCHAR");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Characteristic)
                    .HasMaxLength(20)
                    .HasColumnName("CHARACTERISTIC");
            });

            modelBuilder.Entity<Empdepartment>(entity =>
            {
                entity.HasKey(e => e.Department)
                    .HasName("EMPDEPARTMENTS$PrimaryKey");

                entity.ToTable("EMPDEPARTMENTS");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empnum)
                    .HasName("EMPLOYEE$PrimaryKey");

                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Additphone)
                    .HasMaxLength(14)
                    .HasColumnName("ADDITPHONE");

                entity.Property(e => e.Additphonedesc)
                    .HasMaxLength(50)
                    .HasColumnName("ADDITPHONEDESC");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(30)
                    .HasColumnName("ADDR1");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(30)
                    .HasColumnName("ADDR2");

                entity.Property(e => e.AssignhrsAct).HasColumnName("ASSIGNHRS_ACT");

                entity.Property(e => e.AssignhrsEst).HasColumnName("ASSIGNHRS_EST");

                entity.Property(e => e.Basehrs).HasColumnName("BASEHRS");

                entity.Property(e => e.Bidallowance).HasColumnName("BIDALLOWANCE");

                entity.Property(e => e.Billdailyotrate).HasColumnName("BILLDAILYOTRATE");

                entity.Property(e => e.Billdailyotrate2).HasColumnName("BILLDAILYOTRATE2");

                entity.Property(e => e.Billdailyotrate3).HasColumnName("BILLDAILYOTRATE3");

                entity.Property(e => e.Billdailyotrate4).HasColumnName("BILLDAILYOTRATE4");

                entity.Property(e => e.Billdailyotrate5).HasColumnName("BILLDAILYOTRATE5");

                entity.Property(e => e.Billdailyotrate6).HasColumnName("BILLDAILYOTRATE6");

                entity.Property(e => e.Billdailyotwaitrate).HasColumnName("BILLDAILYOTWAITRATE");

                entity.Property(e => e.Billdailyotwaitrate2).HasColumnName("BILLDAILYOTWAITRATE2");

                entity.Property(e => e.Billdailyotwaitrate3).HasColumnName("BILLDAILYOTWAITRATE3");

                entity.Property(e => e.Billdailyotwaitrate4).HasColumnName("BILLDAILYOTWAITRATE4");

                entity.Property(e => e.Billdailyotwaitrate5).HasColumnName("BILLDAILYOTWAITRATE5");

                entity.Property(e => e.Billdailyotwaitrate6).HasColumnName("BILLDAILYOTWAITRATE6");

                entity.Property(e => e.Billhrlyrate).HasColumnName("BILLHRLYRATE");

                entity.Property(e => e.Billhrlyrate2).HasColumnName("BILLHRLYRATE2");

                entity.Property(e => e.Billhrlyrate3).HasColumnName("BILLHRLYRATE3");

                entity.Property(e => e.Billhrlyrate4).HasColumnName("BILLHRLYRATE4");

                entity.Property(e => e.Billhrlyrate5).HasColumnName("BILLHRLYRATE5");

                entity.Property(e => e.Billhrlyrate6).HasColumnName("BILLHRLYRATE6");

                entity.Property(e => e.Billotrate).HasColumnName("BILLOTRATE");

                entity.Property(e => e.Billotrate2).HasColumnName("BILLOTRATE2");

                entity.Property(e => e.Billotrate3).HasColumnName("BILLOTRATE3");

                entity.Property(e => e.Billotrate4).HasColumnName("BILLOTRATE4");

                entity.Property(e => e.Billotrate5).HasColumnName("BILLOTRATE5");

                entity.Property(e => e.Billotrate6).HasColumnName("BILLOTRATE6");

                entity.Property(e => e.Billotwaitrate).HasColumnName("BILLOTWAITRATE");

                entity.Property(e => e.Billotwaitrate2).HasColumnName("BILLOTWAITRATE2");

                entity.Property(e => e.Billotwaitrate3).HasColumnName("BILLOTWAITRATE3");

                entity.Property(e => e.Billotwaitrate4).HasColumnName("BILLOTWAITRATE4");

                entity.Property(e => e.Billotwaitrate5).HasColumnName("BILLOTWAITRATE5");

                entity.Property(e => e.Billotwaitrate6).HasColumnName("BILLOTWAITRATE6");

                entity.Property(e => e.Billwaithrlyrate).HasColumnName("BILLWAITHRLYRATE");

                entity.Property(e => e.Billwaithrlyrate2).HasColumnName("BILLWAITHRLYRATE2");

                entity.Property(e => e.Billwaithrlyrate3).HasColumnName("BILLWAITHRLYRATE3");

                entity.Property(e => e.Billwaithrlyrate4).HasColumnName("BILLWAITHRLYRATE4");

                entity.Property(e => e.Billwaithrlyrate5).HasColumnName("BILLWAITHRLYRATE5");

                entity.Property(e => e.Billwaithrlyrate6).HasColumnName("BILLWAITHRLYRATE6");

                entity.Property(e => e.Birthday)
                    .HasPrecision(0)
                    .HasColumnName("BIRTHDAY");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(50)
                    .HasColumnName("BIRTHPLACE");

                entity.Property(e => e.Certdate)
                    .HasPrecision(0)
                    .HasColumnName("CERTDATE");

                entity.Property(e => e.Certnum)
                    .HasMaxLength(50)
                    .HasColumnName("CERTNUM");

                entity.Property(e => e.CheckInMessage).HasColumnName("CHECK_IN_MESSAGE");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasColumnName("CITY");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Division)
                    .HasMaxLength(15)
                    .HasColumnName("DIVISION");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EmpnumDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("EMPNUM_DISTRICT");

                entity.Property(e => e.Empstatus)
                    .HasMaxLength(20)
                    .HasColumnName("EMPSTATUS");

                entity.Property(e => e.Empstatusdate)
                    .HasPrecision(0)
                    .HasColumnName("EMPSTATUSDATE");

                entity.Property(e => e.Emptype)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("EMPTYPE");

                entity.Property(e => e.Ethnicity)
                    .HasMaxLength(30)
                    .HasColumnName("ETHNICITY");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(15)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Frihrs).HasColumnName("FRIHRS");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Hiredate)
                    .HasPrecision(0)
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(30)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Licclass)
                    .HasMaxLength(30)
                    .HasColumnName("LICCLASS");

                entity.Property(e => e.Licendorsement)
                    .HasMaxLength(50)
                    .HasColumnName("LICENDORSEMENT");

                entity.Property(e => e.Licexpdate)
                    .HasPrecision(0)
                    .HasColumnName("LICEXPDATE");

                entity.Property(e => e.Licnum)
                    .HasMaxLength(25)
                    .HasColumnName("LICNUM");

                entity.Property(e => e.Licstate)
                    .HasMaxLength(2)
                    .HasColumnName("LICSTATE");

                entity.Property(e => e.Mailaddr1)
                    .HasMaxLength(30)
                    .HasColumnName("MAILADDR1");

                entity.Property(e => e.Mailaddr2)
                    .HasMaxLength(30)
                    .HasColumnName("MAILADDR2");

                entity.Property(e => e.Mailcity)
                    .HasMaxLength(15)
                    .HasColumnName("MAILCITY");

                entity.Property(e => e.Mailstate)
                    .HasMaxLength(2)
                    .HasColumnName("MAILSTATE");

                entity.Property(e => e.Mailzip)
                    .HasMaxLength(10)
                    .HasColumnName("MAILZIP");

                entity.Property(e => e.MessageBeginDate)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_BEGIN_DATE");

                entity.Property(e => e.MessageBeginTime)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_BEGIN_TIME");

                entity.Property(e => e.MessageEndDate)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_END_DATE");

                entity.Property(e => e.MessageEndTime)
                    .HasPrecision(0)
                    .HasColumnName("MESSAGE_END_TIME");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(30)
                    .HasColumnName("MIDDLENAME");

                entity.Property(e => e.Monhrs).HasColumnName("MONHRS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Pin)
                    .HasMaxLength(10)
                    .HasColumnName("PIN");

                entity.Property(e => e.Pschedhrs).HasColumnName("PSCHEDHRS");

                entity.Property(e => e.Ptothrs).HasColumnName("PTOTHRS");

                entity.Property(e => e.RefusedhrsAct).HasColumnName("REFUSEDHRS_ACT");

                entity.Property(e => e.RefusedhrsEst).HasColumnName("REFUSEDHRS_EST");

                entity.Property(e => e.Sathrs).HasColumnName("SATHRS");

                entity.Property(e => e.Schedhrs).HasColumnName("SCHEDHRS");

                entity.Property(e => e.Seniority).HasColumnName("SENIORITY");

                entity.Property(e => e.Socsec)
                    .HasMaxLength(11)
                    .HasColumnName("SOCSEC");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("STATE");

                entity.Property(e => e.Sunhrs).HasColumnName("SUNHRS");

                entity.Property(e => e.Supervisor).HasColumnName("SUPERVISOR");

                entity.Property(e => e.Thuhrs).HasColumnName("THUHRS");

                entity.Property(e => e.Tothrs).HasColumnName("TOTHRS");

                entity.Property(e => e.Totpayhrs).HasColumnName("TOTPAYHRS");

                entity.Property(e => e.Tuehrs).HasColumnName("TUEHRS");

                entity.Property(e => e.User1)
                    .HasMaxLength(30)
                    .HasColumnName("USER1");

                entity.Property(e => e.User10)
                    .HasMaxLength(30)
                    .HasColumnName("USER10");

                entity.Property(e => e.User2)
                    .HasMaxLength(30)
                    .HasColumnName("USER2");

                entity.Property(e => e.User3)
                    .HasMaxLength(30)
                    .HasColumnName("USER3");

                entity.Property(e => e.User4)
                    .HasMaxLength(30)
                    .HasColumnName("USER4");

                entity.Property(e => e.User5)
                    .HasMaxLength(30)
                    .HasColumnName("USER5");

                entity.Property(e => e.User6)
                    .HasMaxLength(30)
                    .HasColumnName("USER6");

                entity.Property(e => e.User7)
                    .HasMaxLength(30)
                    .HasColumnName("USER7");

                entity.Property(e => e.User8)
                    .HasMaxLength(30)
                    .HasColumnName("USER8");

                entity.Property(e => e.User9)
                    .HasMaxLength(30)
                    .HasColumnName("USER9");

                entity.Property(e => e.Userdate1)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE1");

                entity.Property(e => e.Userdate2)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE2");

                entity.Property(e => e.Userdate3)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE3");

                entity.Property(e => e.Userdate4)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE4");

                entity.Property(e => e.Userdate5)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE5");

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE");

                entity.Property(e => e.Wedhrs).HasColumnName("WEDHRS");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .HasColumnName("ZIP");

                entity.Property(e => e.Zonarid)
                    .HasMaxLength(50)
                    .HasColumnName("ZONARID");
            });

            modelBuilder.Entity<Employeeque>(entity =>
            {
                entity.HasKey(e => new { e.Schedule, e.Empnum })
                    .HasName("EMPLOYEEQUE$PrimaryKey");

                entity.ToTable("EMPLOYEEQUE");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.AssignhrsAct).HasColumnName("ASSIGNHRS_ACT");

                entity.Property(e => e.AssignhrsEst).HasColumnName("ASSIGNHRS_EST");

                entity.Property(e => e.Basehrs).HasColumnName("BASEHRS");

                entity.Property(e => e.RefusedhrsAct).HasColumnName("REFUSEDHRS_ACT");

                entity.Property(e => e.RefusedhrsEst).HasColumnName("REFUSEDHRS_EST");

                entity.Property(e => e.Skip).HasColumnName("SKIP");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Empnote>(entity =>
            {
                entity.HasKey(e => new { e.Empnum, e.Noteid })
                    .HasName("EMPNOTES$PrimaryKey");

                entity.ToTable("EMPNOTES");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Noteid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOTEID");

                entity.Property(e => e.Enterdate)
                    .HasPrecision(0)
                    .HasColumnName("ENTERDATE");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(20)
                    .HasColumnName("ENTEREDBY");

                entity.Property(e => e.Notedate)
                    .HasPrecision(0)
                    .HasColumnName("NOTEDATE");

                entity.Property(e => e.Notetime)
                    .HasPrecision(0)
                    .HasColumnName("NOTETIME");

                entity.Property(e => e.Notevalue).HasColumnName("NOTEVALUE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Empphoneaddr>(entity =>
            {
                entity.HasKey(e => e.Phoneaddrid)
                    .HasName("EMPPHONEADDR$PrimaryKey");

                entity.ToTable("EMPPHONEADDR");

                entity.Property(e => e.Phoneaddrid).HasColumnName("PHONEADDRID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(100)
                    .HasColumnName("ADDR1");

                entity.Property(e => e.Addr2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDR2");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasColumnName("CITY");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .HasColumnName("PHONE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("STATE");

                entity.Property(e => e.Statuschgdt)
                    .HasPrecision(0)
                    .HasColumnName("STATUSCHGDT");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<Empref>(entity =>
            {
                entity.HasKey(e => new { e.Empnum, e.Tripnum })
                    .HasName("EMPREF$PrimaryKey");

                entity.ToTable("EMPREF");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Depdate)
                    .HasPrecision(0)
                    .HasColumnName("DEPDATE");

                entity.Property(e => e.Refdate)
                    .HasPrecision(0)
                    .HasColumnName("REFDATE");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");
            });

            modelBuilder.Entity<Emproute>(entity =>
            {
                entity.HasKey(e => e.Routenum)
                    .HasName("EMPROUTE$PrimaryKey");

                entity.ToTable("EMPROUTE");

                entity.Property(e => e.Routenum).HasColumnName("ROUTENUM");

                entity.Property(e => e.Changedate)
                    .HasPrecision(0)
                    .HasColumnName("CHANGEDATE");

                entity.Property(e => e.Createdate)
                    .HasPrecision(0)
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Daynum).HasColumnName("DAYNUM");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Keeproute).HasColumnName("KEEPROUTE");

                entity.Property(e => e.Routeday)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("ROUTEDAY");

                entity.Property(e => e.Routedesc)
                    .HasMaxLength(50)
                    .HasColumnName("ROUTEDESC");

                entity.Property(e => e.Routetime).HasColumnName("ROUTETIME");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Starttime)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Tract).HasColumnName("TRACT");

                entity.Property(e => e.Userchange)
                    .HasMaxLength(20)
                    .HasColumnName("USERCHANGE");

                entity.Property(e => e.Usercreate)
                    .HasMaxLength(20)
                    .HasColumnName("USERCREATE");
            });

            modelBuilder.Entity<Empstatus>(entity =>
            {
                entity.HasKey(e => e.Empstatus1)
                    .HasName("EMPSTATUS$PrimaryKey");

                entity.ToTable("EMPSTATUS");

                entity.Property(e => e.Empstatus1)
                    .HasMaxLength(20)
                    .HasColumnName("EMPSTATUS");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<EmptrainTran>(entity =>
            {
                entity.HasKey(e => e.EmptrainTransid)
                    .HasName("EMPTRAIN_TRANS$PrimaryKey1");

                entity.ToTable("EMPTRAIN_TRANS");

                entity.Property(e => e.EmptrainTransid).HasColumnName("EMPTRAIN_TRANSID");

                entity.Property(e => e.Brakecd)
                    .HasMaxLength(30)
                    .HasColumnName("BRAKECD");

                entity.Property(e => e.Btwcd)
                    .HasMaxLength(30)
                    .HasColumnName("BTWCD");

                entity.Property(e => e.Bus)
                    .HasMaxLength(20)
                    .HasColumnName("BUS");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .HasColumnName("CITY");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .HasColumnName("COUNTY");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Equipcd)
                    .HasMaxLength(30)
                    .HasColumnName("EQUIPCD");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Hrs).HasColumnName("HRS");

                entity.Property(e => e.Hrsapplieddt)
                    .HasPrecision(0)
                    .HasColumnName("HRSAPPLIEDDT");

                entity.Property(e => e.Inservicecd)
                    .HasMaxLength(30)
                    .HasColumnName("INSERVICECD");

                entity.Property(e => e.InstrEmpnum).HasColumnName("INSTR_EMPNUM");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Proficient).HasColumnName("PROFICIENT");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1)
                    .HasColumnName("REASON");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Tcc)
                    .HasMaxLength(30)
                    .HasColumnName("TCC");

                entity.Property(e => e.Trainingcode)
                    .HasMaxLength(30)
                    .HasColumnName("TRAININGCODE");

                entity.Property(e => e.Trainingdt)
                    .HasPrecision(0)
                    .HasColumnName("TRAININGDT");

                entity.Property(e => e.Units)
                    .HasMaxLength(30)
                    .HasColumnName("UNITS");
            });

            modelBuilder.Entity<Emptransaction>(entity =>
            {
                entity.ToTable("EMPTRANSACTIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Achievedhr).HasColumnName("ACHIEVEDHR");

                entity.Property(e => e.Attachment1)
                    .HasMaxLength(255)
                    .HasColumnName("ATTACHMENT1");

                entity.Property(e => e.Attachment2)
                    .HasMaxLength(255)
                    .HasColumnName("ATTACHMENT2");

                entity.Property(e => e.Attachment3)
                    .HasMaxLength(255)
                    .HasColumnName("ATTACHMENT3");

                entity.Property(e => e.Autoschednexttran)
                    .HasPrecision(0)
                    .HasColumnName("AUTOSCHEDNEXTTRAN");

                entity.Property(e => e.Category)
                    .HasMaxLength(30)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Completed).HasColumnName("COMPLETED");

                entity.Property(e => e.Completedt)
                    .HasPrecision(0)
                    .HasColumnName("COMPLETEDT");

                entity.Property(e => e.Duedt)
                    .HasPrecision(0)
                    .HasColumnName("DUEDT");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Rqdhr).HasColumnName("RQDHR");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<Emptype>(entity =>
            {
                entity.HasKey(e => e.Emptype1)
                    .HasName("EMPTYPE$PrimaryKey");

                entity.ToTable("EMPTYPE");

                entity.Property(e => e.Emptype1)
                    .HasMaxLength(5)
                    .HasColumnName("EMPTYPE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Dailydblothours).HasColumnName("DAILYDBLOTHOURS");

                entity.Property(e => e.Dailyothours).HasColumnName("DAILYOTHOURS");

                entity.Property(e => e.DateChanged)
                    .HasPrecision(0)
                    .HasColumnName("DATE_CHANGED");

                entity.Property(e => e.DateEntered)
                    .HasPrecision(0)
                    .HasColumnName("DATE_ENTERED");

                entity.Property(e => e.Etypedesc)
                    .HasMaxLength(30)
                    .HasColumnName("ETYPEDESC");

                entity.Property(e => e.FriApplyOt).HasColumnName("FRI_APPLY_OT");

                entity.Property(e => e.FridblotAllday).HasColumnName("FRIDBLOT_ALLDAY");

                entity.Property(e => e.FridblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("FRIDBLOT_BEGTIME");

                entity.Property(e => e.FridblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("FRIDBLOT_ENDTIME");

                entity.Property(e => e.FridblotTimerng).HasColumnName("FRIDBLOT_TIMERNG");

                entity.Property(e => e.Friot).HasColumnName("FRIOT");

                entity.Property(e => e.FriotAllday).HasColumnName("FRIOT_ALLDAY");

                entity.Property(e => e.FriotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("FRIOT_BEGTIME");

                entity.Property(e => e.FriotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("FRIOT_ENDTIME");

                entity.Property(e => e.FriotTimerng).HasColumnName("FRIOT_TIMERNG");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.MonApplyOt).HasColumnName("MON_APPLY_OT");

                entity.Property(e => e.MondblotAllday).HasColumnName("MONDBLOT_ALLDAY");

                entity.Property(e => e.MondblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("MONDBLOT_BEGTIME");

                entity.Property(e => e.MondblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("MONDBLOT_ENDTIME");

                entity.Property(e => e.MondblotTimerng).HasColumnName("MONDBLOT_TIMERNG");

                entity.Property(e => e.Monot).HasColumnName("MONOT");

                entity.Property(e => e.MonotAllday).HasColumnName("MONOT_ALLDAY");

                entity.Property(e => e.MonotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("MONOT_BEGTIME");

                entity.Property(e => e.MonotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("MONOT_ENDTIME");

                entity.Property(e => e.MonotTimerng).HasColumnName("MONOT_TIMERNG");

                entity.Property(e => e.PayDailyOt).HasColumnName("PAY_DAILY_OT");

                entity.Property(e => e.PayWeeklyOt).HasColumnName("PAY_WEEKLY_OT");

                entity.Property(e => e.SatApplyOt).HasColumnName("SAT_APPLY_OT");

                entity.Property(e => e.SatdblotAllday).HasColumnName("SATDBLOT_ALLDAY");

                entity.Property(e => e.SatdblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("SATDBLOT_BEGTIME");

                entity.Property(e => e.SatdblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("SATDBLOT_ENDTIME");

                entity.Property(e => e.SatdblotTimerng).HasColumnName("SATDBLOT_TIMERNG");

                entity.Property(e => e.Satot).HasColumnName("SATOT");

                entity.Property(e => e.SatotAllday).HasColumnName("SATOT_ALLDAY");

                entity.Property(e => e.SatotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("SATOT_BEGTIME");

                entity.Property(e => e.SatotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("SATOT_ENDTIME");

                entity.Property(e => e.SatotTimerng).HasColumnName("SATOT_TIMERNG");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.SunApplyOt).HasColumnName("SUN_APPLY_OT");

                entity.Property(e => e.SundblotAllday).HasColumnName("SUNDBLOT_ALLDAY");

                entity.Property(e => e.SundblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("SUNDBLOT_BEGTIME");

                entity.Property(e => e.SundblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("SUNDBLOT_ENDTIME");

                entity.Property(e => e.SundblotTimerng).HasColumnName("SUNDBLOT_TIMERNG");

                entity.Property(e => e.Sunot).HasColumnName("SUNOT");

                entity.Property(e => e.SunotAllday).HasColumnName("SUNOT_ALLDAY");

                entity.Property(e => e.SunotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("SUNOT_BEGTIME");

                entity.Property(e => e.SunotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("SUNOT_ENDTIME");

                entity.Property(e => e.SunotTimerng).HasColumnName("SUNOT_TIMERNG");

                entity.Property(e => e.ThuApplyOt).HasColumnName("THU_APPLY_OT");

                entity.Property(e => e.ThudblotAllday).HasColumnName("THUDBLOT_ALLDAY");

                entity.Property(e => e.ThudblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("THUDBLOT_BEGTIME");

                entity.Property(e => e.ThudblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("THUDBLOT_ENDTIME");

                entity.Property(e => e.ThudblotTimerng).HasColumnName("THUDBLOT_TIMERNG");

                entity.Property(e => e.Thuot).HasColumnName("THUOT");

                entity.Property(e => e.ThuotAllday).HasColumnName("THUOT_ALLDAY");

                entity.Property(e => e.ThuotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("THUOT_BEGTIME");

                entity.Property(e => e.ThuotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("THUOT_ENDTIME");

                entity.Property(e => e.ThuotTimerng).HasColumnName("THUOT_TIMERNG");

                entity.Property(e => e.TueApplyOt).HasColumnName("TUE_APPLY_OT");

                entity.Property(e => e.TuedblotAllday).HasColumnName("TUEDBLOT_ALLDAY");

                entity.Property(e => e.TuedblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("TUEDBLOT_BEGTIME");

                entity.Property(e => e.TuedblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("TUEDBLOT_ENDTIME");

                entity.Property(e => e.TuedblotTimerng).HasColumnName("TUEDBLOT_TIMERNG");

                entity.Property(e => e.Tueot).HasColumnName("TUEOT");

                entity.Property(e => e.TueotAllday).HasColumnName("TUEOT_ALLDAY");

                entity.Property(e => e.TueotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("TUEOT_BEGTIME");

                entity.Property(e => e.TueotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("TUEOT_ENDTIME");

                entity.Property(e => e.TueotTimerng).HasColumnName("TUEOT_TIMERNG");

                entity.Property(e => e.UserChanged)
                    .HasMaxLength(20)
                    .HasColumnName("USER_CHANGED");

                entity.Property(e => e.UserEntered)
                    .HasMaxLength(20)
                    .HasColumnName("USER_ENTERED");

                entity.Property(e => e.WedApplyOt).HasColumnName("WED_APPLY_OT");

                entity.Property(e => e.WeddblotAllday).HasColumnName("WEDDBLOT_ALLDAY");

                entity.Property(e => e.WeddblotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("WEDDBLOT_BEGTIME");

                entity.Property(e => e.WeddblotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("WEDDBLOT_ENDTIME");

                entity.Property(e => e.WeddblotTimerng).HasColumnName("WEDDBLOT_TIMERNG");

                entity.Property(e => e.Wedot).HasColumnName("WEDOT");

                entity.Property(e => e.WedotAllday).HasColumnName("WEDOT_ALLDAY");

                entity.Property(e => e.WedotBegtime)
                    .HasPrecision(0)
                    .HasColumnName("WEDOT_BEGTIME");

                entity.Property(e => e.WedotEndtime)
                    .HasPrecision(0)
                    .HasColumnName("WEDOT_ENDTIME");

                entity.Property(e => e.WedotTimerng).HasColumnName("WEDOT_TIMERNG");

                entity.Property(e => e.Wklydblothours).HasColumnName("WKLYDBLOTHOURS");

                entity.Property(e => e.Wklyothours).HasColumnName("WKLYOTHOURS");
            });

            modelBuilder.Entity<Ethnicity>(entity =>
            {
                entity.HasKey(e => e.Ethnicity1)
                    .HasName("ETHNICITY$PrimaryKey");

                entity.ToTable("ETHNICITY");

                entity.Property(e => e.Ethnicity1)
                    .HasMaxLength(20)
                    .HasColumnName("ETHNICITY");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("EVENT_LOG$PrimaryKey");

                entity.ToTable("EVENT_LOG");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.DateTime).HasPrecision(0);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<Fund>(entity =>
            {
                entity.HasKey(e => e.Fund1)
                    .HasName("FUND$PrimaryKey");

                entity.ToTable("FUND");

                entity.Property(e => e.Fund1)
                    .HasMaxLength(50)
                    .HasColumnName("FUND");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Budget).HasColumnName("BUDGET");

                entity.Property(e => e.BudgetAmount)
                    .HasColumnType("money")
                    .HasColumnName("BUDGET_AMOUNT");

                entity.Property(e => e.Funddesc)
                    .HasMaxLength(30)
                    .HasColumnName("FUNDDESC");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Garage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GARAGE");

                entity.Property(e => e.Check1)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK1");

                entity.Property(e => e.Check10)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK10");

                entity.Property(e => e.Check2)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK2");

                entity.Property(e => e.Check3)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK3");

                entity.Property(e => e.Check4)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK4");

                entity.Property(e => e.Check5)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK5");

                entity.Property(e => e.Check6)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK6");

                entity.Property(e => e.Check7)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK7");

                entity.Property(e => e.Check8)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK8");

                entity.Property(e => e.Check9)
                    .HasMaxLength(60)
                    .HasColumnName("CHECK9");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Overall1)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL1");

                entity.Property(e => e.Overall10)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL10");

                entity.Property(e => e.Overall11)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL11");

                entity.Property(e => e.Overall12)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL12");

                entity.Property(e => e.Overall13)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL13");

                entity.Property(e => e.Overall14)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL14");

                entity.Property(e => e.Overall15)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL15");

                entity.Property(e => e.Overall16)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL16");

                entity.Property(e => e.Overall17)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL17");

                entity.Property(e => e.Overall18)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL18");

                entity.Property(e => e.Overall2)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL2");

                entity.Property(e => e.Overall3)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL3");

                entity.Property(e => e.Overall4)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL4");

                entity.Property(e => e.Overall5)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL5");

                entity.Property(e => e.Overall6)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL6");

                entity.Property(e => e.Overall7)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL7");

                entity.Property(e => e.Overall8)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL8");

                entity.Property(e => e.Overall9)
                    .HasMaxLength(60)
                    .HasColumnName("OVERALL9");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.Grade1)
                    .HasName("GRADE$PrimaryKey");

                entity.ToTable("GRADE");

                entity.Property(e => e.Grade1)
                    .HasMaxLength(20)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("INVOICE");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(20)
                    .HasColumnName("INVOICE_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.ChargeLine1Show).HasColumnName("CHARGE_LINE1_SHOW");

                entity.Property(e => e.ChargeLine2Show).HasColumnName("CHARGE_LINE2_SHOW");

                entity.Property(e => e.ChargeLineLabel)
                    .HasMaxLength(20)
                    .HasColumnName("CHARGE_LINE_LABEL");

                entity.Property(e => e.ContactLabel)
                    .HasMaxLength(20)
                    .HasColumnName("CONTACT_LABEL");

                entity.Property(e => e.ContactShow).HasColumnName("CONTACT_SHOW");

                entity.Property(e => e.CustBillCommentShow).HasColumnName("CUST_BILL_COMMENT_SHOW");

                entity.Property(e => e.CustomerBottomLabel)
                    .HasMaxLength(20)
                    .HasColumnName("CUSTOMER_BOTTOM_LABEL");

                entity.Property(e => e.CustomerBottomShow).HasColumnName("CUSTOMER_BOTTOM_SHOW");

                entity.Property(e => e.CustomerLabel)
                    .HasMaxLength(20)
                    .HasColumnName("CUSTOMER_LABEL");

                entity.Property(e => e.CustomerShow).HasColumnName("CUSTOMER_SHOW");

                entity.Property(e => e.DepdateLabel)
                    .HasMaxLength(20)
                    .HasColumnName("DEPDATE_LABEL");

                entity.Property(e => e.DepdateShow).HasColumnName("DEPDATE_SHOW");

                entity.Property(e => e.DestLabel)
                    .HasMaxLength(50)
                    .HasColumnName("DEST_LABEL");

                entity.Property(e => e.DestShow).HasColumnName("DEST_SHOW");

                entity.Property(e => e.DistBillCommentShow).HasColumnName("DIST_BILL_COMMENT_SHOW");

                entity.Property(e => e.DistaddBottomShow).HasColumnName("DISTADD_BOTTOM_SHOW");

                entity.Property(e => e.DistnameBottomShow).HasColumnName("DISTNAME_BOTTOM_SHOW");

                entity.Property(e => e.DistphoneBottomShow).HasColumnName("DISTPHONE_BOTTOM_SHOW");

                entity.Property(e => e.DistphoneLabel)
                    .HasMaxLength(20)
                    .HasColumnName("DISTPHONE_LABEL");

                entity.Property(e => e.EstDateLabel)
                    .HasMaxLength(50)
                    .HasColumnName("EST_DATE_LABEL");

                entity.Property(e => e.EstDateShow).HasColumnName("EST_DATE_SHOW");

                entity.Property(e => e.EstimateLabel)
                    .HasMaxLength(50)
                    .HasColumnName("ESTIMATE_LABEL");

                entity.Property(e => e.EstimateShow).HasColumnName("ESTIMATE_SHOW");

                entity.Property(e => e.FormatComment).HasColumnName("FORMAT_COMMENT");

                entity.Property(e => e.FormatCommentShow).HasColumnName("FORMAT_COMMENT_SHOW");

                entity.Property(e => e.FundLabel)
                    .HasMaxLength(20)
                    .HasColumnName("FUND_LABEL");

                entity.Property(e => e.FundShow).HasColumnName("FUND_SHOW");

                entity.Property(e => e.GradeLabel)
                    .HasMaxLength(20)
                    .HasColumnName("GRADE_LABEL");

                entity.Property(e => e.GradeShow).HasColumnName("GRADE_SHOW");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.InternalLabel)
                    .HasMaxLength(20)
                    .HasColumnName("INTERNAL_LABEL");

                entity.Property(e => e.InternalShow).HasColumnName("INTERNAL_SHOW");

                entity.Property(e => e.InvDateLabel)
                    .HasMaxLength(20)
                    .HasColumnName("INV_DATE_LABEL");

                entity.Property(e => e.InvDateShow).HasColumnName("INV_DATE_SHOW");

                entity.Property(e => e.InvoiceComment1Show).HasColumnName("INVOICE_COMMENT1_SHOW");

                entity.Property(e => e.InvoiceLabel)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICE_LABEL");

                entity.Property(e => e.InvoiceShow).HasColumnName("INVOICE_Show");

                entity.Property(e => e.PhoneLabel)
                    .HasMaxLength(20)
                    .HasColumnName("PHONE_LABEL");

                entity.Property(e => e.PhoneShow).HasColumnName("PHONE_SHOW");

                entity.Property(e => e.PickcustLabel)
                    .HasMaxLength(20)
                    .HasColumnName("PICKCUST_LABEL");

                entity.Property(e => e.PickcustShow).HasColumnName("PICKCUST_SHOW");

                entity.Property(e => e.PoLabel)
                    .HasMaxLength(20)
                    .HasColumnName("PO_LABEL");

                entity.Property(e => e.PoShow).HasColumnName("PO_SHOW");

                entity.Property(e => e.PrefixLabel)
                    .HasMaxLength(50)
                    .HasColumnName("PREFIX_LABEL");

                entity.Property(e => e.PrefixShow).HasColumnName("PREFIX_SHOW");

                entity.Property(e => e.PurposeLabel)
                    .HasMaxLength(20)
                    .HasColumnName("PURPOSE_LABEL");

                entity.Property(e => e.PurposeShow).HasColumnName("PURPOSE_SHOW");

                entity.Property(e => e.ShowAddr).HasColumnName("SHOW_ADDR");

                entity.Property(e => e.ShowInvsec1).HasColumnName("SHOW_INVSEC1");

                entity.Property(e => e.ShowInvsec1Est).HasColumnName("SHOW_INVSEC1_EST");

                entity.Property(e => e.ShowInvsec2).HasColumnName("SHOW_INVSEC2");

                entity.Property(e => e.ShowInvsec2Est).HasColumnName("SHOW_INVSEC2_EST");

                entity.Property(e => e.ShowInvsec3).HasColumnName("SHOW_INVSEC3");

                entity.Property(e => e.ShowInvsec3Est).HasColumnName("SHOW_INVSEC3_EST");

                entity.Property(e => e.ShowInvsec4).HasColumnName("SHOW_INVSEC4");

                entity.Property(e => e.ShowLogo).HasColumnName("SHOW_LOGO");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TearlineLabel)
                    .HasMaxLength(75)
                    .HasColumnName("TEARLINE_LABEL");

                entity.Property(e => e.TearlineShow).HasColumnName("TEARLINE_SHOW");

                entity.Property(e => e.TemplateDesc)
                    .HasMaxLength(50)
                    .HasColumnName("TEMPLATE_DESC");

                entity.Property(e => e.TopinvoiceLabel)
                    .HasMaxLength(20)
                    .HasColumnName("TOPINVOICE_LABEL");

                entity.Property(e => e.TopinvoiceShow).HasColumnName("TOPINVOICE_Show");

                entity.Property(e => e.ToplineShow).HasColumnName("TOPLINE_Show");

                entity.Property(e => e.TotalLabel)
                    .HasMaxLength(20)
                    .HasColumnName("TOTAL_LABEL");

                entity.Property(e => e.TotalShow).HasColumnName("TOTAL_SHOW");

                entity.Property(e => e.TripamountBottomLabel)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPAMOUNT_BOTTOM_LABEL");

                entity.Property(e => e.TripamountBottomShow).HasColumnName("TRIPAMOUNT_BOTTOM_SHOW");

                entity.Property(e => e.TripdateBottomLabel)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPDATE_BOTTOM_LABEL");

                entity.Property(e => e.TripdateBottomShow).HasColumnName("TRIPDATE_BOTTOM_SHOW");

                entity.Property(e => e.TripnumBottomLabel)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPNUM_BOTTOM_LABEL");

                entity.Property(e => e.TripnumBottomShow).HasColumnName("TRIPNUM_BOTTOM_SHOW");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("LOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Activitycode).HasColumnName("ACTIVITYCODE");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Logdate)
                    .HasPrecision(0)
                    .HasColumnName("LOGDATE");

                entity.Property(e => e.Massjobnum).HasColumnName("MASSJOBNUM");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Sourcelist)
                    .HasMaxLength(6)
                    .HasColumnName("SOURCELIST");

                entity.Property(e => e.Sourceroutine)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SOURCEROUTINE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("USER");

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE");
            });

            modelBuilder.Entity<Makeupdriv>(entity =>
            {
                entity.HasKey(e => e.Makupkey)
                    .HasName("MAKEUPDRIV$PrimaryKey");

                entity.ToTable("MAKEUPDRIV");

                entity.Property(e => e.Makupkey).HasColumnName("MAKUPKEY");

                entity.Property(e => e.Candate)
                    .HasPrecision(0)
                    .HasColumnName("CANDATE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Repdate)
                    .HasPrecision(0)
                    .HasColumnName("REPDATE");

                entity.Property(e => e.Reptripnum).HasColumnName("REPTRIPNUM");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Category })
                    .HasName("REMINDER$PrimaryKey");

                entity.ToTable("REMINDER");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Category)
                    .HasMaxLength(30)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Autoschedule)
                    .HasMaxLength(1)
                    .HasColumnName("AUTOSCHEDULE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DueEvery).HasColumnName("DUE_EVERY");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Nexttrandtbasedon)
                    .HasMaxLength(10)
                    .HasColumnName("NEXTTRANDTBASEDON");

                entity.Property(e => e.Nexttrantype)
                    .HasMaxLength(30)
                    .HasColumnName("NEXTTRANTYPE");

                entity.Property(e => e.Rqdhr).HasColumnName("RQDHR");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.WarningPd).HasColumnName("WARNING_PD");
            });

            modelBuilder.Entity<Remindercategory>(entity =>
            {
                entity.HasKey(e => e.Category)
                    .HasName("REMINDERCATEGORY$PrimaryKey");

                entity.ToTable("REMINDERCATEGORY");

                entity.Property(e => e.Category)
                    .HasMaxLength(30)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Schedmast>(entity =>
            {
                entity.HasKey(e => e.Schedule)
                    .HasName("SCHEDMAST$PrimaryKey");

                entity.ToTable("SCHEDMAST");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Nextemp).HasColumnName("NEXTEMP");

                entity.Property(e => e.Scheddesc)
                    .HasMaxLength(30)
                    .HasColumnName("SCHEDDESC");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => e.SettingName)
                    .HasName("SETTINGS$PrimaryKey");

                entity.ToTable("SETTINGS");

                entity.Property(e => e.SettingName).HasMaxLength(15);

                entity.Property(e => e.SettingValue).HasMaxLength(50);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.Shift1)
                    .HasName("SHIFT$PrimaryKey");

                entity.ToTable("SHIFT");

                entity.Property(e => e.Shift1)
                    .HasMaxLength(20)
                    .HasColumnName("SHIFT");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BeginTime)
                    .HasPrecision(0)
                    .HasColumnName("BEGIN_TIME");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EndTime)
                    .HasPrecision(0)
                    .HasColumnName("END_TIME");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<SwitchboardItem>(entity =>
            {
                entity.HasKey(e => new { e.SwitchboardId, e.ItemNumber })
                    .HasName("Switchboard Items$PrimaryKey");

                entity.ToTable("Switchboard Items");

                entity.Property(e => e.SwitchboardId).HasColumnName("SwitchboardID");

                entity.Property(e => e.Argument).HasMaxLength(255);

                entity.Property(e => e.ItemText).HasMaxLength(255);
            });

            modelBuilder.Entity<System>(entity =>
            {
                entity.HasKey(e => e.Recid)
                    .HasName("SYSTEM$PrimaryKey");

                entity.ToTable("SYSTEM");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Lastbackup)
                    .HasPrecision(0)
                    .HasColumnName("LASTBACKUP");

                entity.Property(e => e.Lastcompact)
                    .HasPrecision(0)
                    .HasColumnName("LASTCOMPACT");

                entity.Property(e => e.Lastrepair)
                    .HasPrecision(0)
                    .HasColumnName("LASTREPAIR");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .HasColumnName("VERSION");
            });

            modelBuilder.Entity<Tmscc>(entity =>
            {
                entity.HasKey(e => e.Chainid)
                    .HasName("TMSCC$PrimaryKey");

                entity.ToTable("TMSCC");

                entity.Property(e => e.Chainid)
                    .HasMaxLength(20)
                    .HasColumnName("CHAINID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Chaindesc)
                    .HasMaxLength(50)
                    .HasColumnName("CHAINDESC");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Level1Approver).HasMaxLength(20);

                entity.Property(e => e.Level1Status).HasMaxLength(30);

                entity.Property(e => e.Level2Approver).HasMaxLength(20);

                entity.Property(e => e.Level2Status).HasMaxLength(30);

                entity.Property(e => e.Level3Approver).HasMaxLength(20);

                entity.Property(e => e.Level3Status).HasMaxLength(30);

                entity.Property(e => e.Level4Approver).HasMaxLength(20);

                entity.Property(e => e.Level4Status).HasMaxLength(30);

                entity.Property(e => e.Level5Approver).HasMaxLength(20);

                entity.Property(e => e.Level5Status).HasMaxLength(30);

                entity.Property(e => e.Level6Approver).HasMaxLength(20);

                entity.Property(e => e.Level6Status).HasMaxLength(30);

                entity.Property(e => e.Level7Approver).HasMaxLength(20);

                entity.Property(e => e.Level7Status).HasMaxLength(30);

                entity.Property(e => e.Level8Approver).HasMaxLength(20);

                entity.Property(e => e.Level8Status).HasMaxLength(30);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Tmscg>(entity =>
            {
                entity.HasKey(e => e.Tmgsc1)
                    .HasName("TMSCG$PrimaryKey");

                entity.ToTable("TMSCG");

                entity.Property(e => e.Tmgsc1)
                    .HasMaxLength(20)
                    .HasColumnName("TMGSC1");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Sca).HasColumnName("SCA");

                entity.Property(e => e.Scbkrst).HasColumnName("SCBKRST");

                entity.Property(e => e.Sccal).HasColumnName("SCCAL");

                entity.Property(e => e.Scdrvnt).HasColumnName("SCDRVNT");

                entity.Property(e => e.Scftadchng).HasColumnName("SCFTADCHNG");

                entity.Property(e => e.Scftaddi).HasColumnName("SCFTADDI");

                entity.Property(e => e.Scftaddt).HasColumnName("SCFTADDT");

                entity.Property(e => e.Scftas).HasColumnName("SCFTAS");

                entity.Property(e => e.Scftbl).HasColumnName("SCFTBL");

                entity.Property(e => e.Scftcnc).HasColumnName("SCFTCNC");

                entity.Property(e => e.Scftdl).HasColumnName("SCFTDL");

                entity.Property(e => e.Scftmb).HasColumnName("SCFTMB");

                entity.Property(e => e.Scftpymadj).HasColumnName("SCFTPYMADJ");

                entity.Property(e => e.Scftradd).HasColumnName("SCFTRADD");

                entity.Property(e => e.Scinqemp).HasColumnName("SCINQEMP");

                entity.Property(e => e.Scinqreq).HasColumnName("SCINQREQ");

                entity.Property(e => e.Scma).HasColumnName("SCMA");

                entity.Property(e => e.Scmntc).HasColumnName("SCMNTC");

                entity.Property(e => e.Scmntd).HasColumnName("SCMNTD");

                entity.Property(e => e.Scmnte).HasColumnName("SCMNTE");

                entity.Property(e => e.Scmnto).HasColumnName("SCMNTO");

                entity.Property(e => e.Scmntv).HasColumnName("SCMNTV");

                entity.Property(e => e.Scrptlst).HasColumnName("SCRPTLST");

                entity.Property(e => e.Scrptmgt).HasColumnName("SCRPTMGT");

                entity.Property(e => e.Scrptmst).HasColumnName("SCRPTMST");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Statuschgdt)
                    .HasPrecision(0)
                    .HasColumnName("STATUSCHGDT");

                entity.Property(e => e.Tmgsc3)
                    .HasMaxLength(50)
                    .HasColumnName("TMGSC3");
            });

            modelBuilder.Entity<TmscgPp>(entity =>
            {
                entity.HasKey(e => new { e.Tmgsc1, e.Perm })
                    .HasName("TMSCG_PP$PrimaryKey");

                entity.ToTable("TMSCG_PP");

                entity.Property(e => e.Tmgsc1)
                    .HasMaxLength(20)
                    .HasColumnName("TMGSC1");

                entity.Property(e => e.Perm)
                    .HasMaxLength(20)
                    .HasColumnName("PERM");

                entity.Property(e => e.Authority).HasColumnName("AUTHORITY");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Tmscp>(entity =>
            {
                entity.HasKey(e => e.Product)
                    .HasName("TMSCP$PrimaryKey");

                entity.ToTable("TMSCP");

                entity.Property(e => e.Product)
                    .HasMaxLength(20)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Tmscpp>(entity =>
            {
                entity.HasKey(e => e.Perm)
                    .HasName("TMSCPP$PrimaryKey");

                entity.ToTable("TMSCPP");

                entity.Property(e => e.Perm)
                    .HasMaxLength(20)
                    .HasColumnName("PERM");

                entity.Property(e => e.PermCategory)
                    .HasMaxLength(50)
                    .HasColumnName("PERM_CATEGORY");

                entity.Property(e => e.PermDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PERM_DESC");

                entity.Property(e => e.PermDisplayseq).HasColumnName("PERM_DISPLAYSEQ");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PRODUCT");
            });

            modelBuilder.Entity<Tmscr>(entity =>
            {
                entity.HasKey(e => e.Role)
                    .HasName("TMSCR$PrimaryKey");

                entity.ToTable("TMSCR");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .HasColumnName("ROLE");

                entity.Property(e => e.Roledesc)
                    .HasMaxLength(50)
                    .HasColumnName("ROLEDESC");
            });

            modelBuilder.Entity<Tmscu>(entity =>
            {
                entity.HasKey(e => e.Tmsc1)
                    .HasName("TMSCU$PrimaryKey");

                entity.ToTable("TMSCU");

                entity.Property(e => e.Tmsc1)
                    .HasMaxLength(20)
                    .HasColumnName("TMSC1");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Changepassword).HasColumnName("CHANGEPASSWORD");

                entity.Property(e => e.Customer)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .HasColumnName("ROLE");

                entity.Property(e => e.ScEmailActiontaken).HasColumnName("SC_EMAIL_ACTIONTAKEN");

                entity.Property(e => e.ScEmailNeedsaction).HasColumnName("SC_EMAIL_NEEDSACTION");

                entity.Property(e => e.Sca).HasColumnName("SCA");

                entity.Property(e => e.Scbkrst).HasColumnName("SCBKRST");

                entity.Property(e => e.Sccal).HasColumnName("SCCAL");

                entity.Property(e => e.Scdrvnt).HasColumnName("SCDRVNT");

                entity.Property(e => e.Scftadchng).HasColumnName("SCFTADCHNG");

                entity.Property(e => e.Scftaddi).HasColumnName("SCFTADDI");

                entity.Property(e => e.Scftaddt).HasColumnName("SCFTADDT");

                entity.Property(e => e.Scftas).HasColumnName("SCFTAS");

                entity.Property(e => e.Scftbl).HasColumnName("SCFTBL");

                entity.Property(e => e.Scftcnc).HasColumnName("SCFTCNC");

                entity.Property(e => e.Scftdl).HasColumnName("SCFTDL");

                entity.Property(e => e.Scftmb).HasColumnName("SCFTMB");

                entity.Property(e => e.Scftpymadj).HasColumnName("SCFTPYMADJ");

                entity.Property(e => e.Scftradd).HasColumnName("SCFTRADD");

                entity.Property(e => e.Scinqemp).HasColumnName("SCINQEMP");

                entity.Property(e => e.Scinqreq).HasColumnName("SCINQREQ");

                entity.Property(e => e.Scma).HasColumnName("SCMA");

                entity.Property(e => e.Scmntc).HasColumnName("SCMNTC");

                entity.Property(e => e.Scmntd).HasColumnName("SCMNTD");

                entity.Property(e => e.Scmnte).HasColumnName("SCMNTE");

                entity.Property(e => e.Scmnto).HasColumnName("SCMNTO");

                entity.Property(e => e.Scmntv).HasColumnName("SCMNTV");

                entity.Property(e => e.Scrptlst).HasColumnName("SCRPTLST");

                entity.Property(e => e.Scrptmgt).HasColumnName("SCRPTMGT");

                entity.Property(e => e.Scrptmst).HasColumnName("SCRPTMST");

                entity.Property(e => e.Scwtddft).HasColumnName("SCWTDDFT");

                entity.Property(e => e.Scwtfovd).HasColumnName("SCWTFOVD");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Tmsc2)
                    .HasMaxLength(20)
                    .HasColumnName("TMSC2");

                entity.Property(e => e.Tmsc3)
                    .HasMaxLength(50)
                    .HasColumnName("TMSC3");

                entity.Property(e => e.Tmsc4)
                    .HasMaxLength(20)
                    .HasColumnName("TMSC4");
            });

            modelBuilder.Entity<TmscuPp>(entity =>
            {
                entity.HasKey(e => new { e.Tmsc1, e.Perm })
                    .HasName("TMSCU_PP$PrimaryKey");

                entity.ToTable("TMSCU_PP");

                entity.Property(e => e.Tmsc1)
                    .HasMaxLength(20)
                    .HasColumnName("TMSC1");

                entity.Property(e => e.Perm)
                    .HasMaxLength(20)
                    .HasColumnName("PERM");

                entity.Property(e => e.Authority).HasColumnName("AUTHORITY");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Trainingcode>(entity =>
            {
                entity.HasKey(e => new { e.Trainingcodecat, e.Trainingcode1 })
                    .HasName("TRAININGCODE$PrimaryKey");

                entity.ToTable("TRAININGCODE");

                entity.Property(e => e.Trainingcodecat)
                    .HasMaxLength(20)
                    .HasColumnName("TRAININGCODECAT");

                entity.Property(e => e.Trainingcode1)
                    .HasMaxLength(30)
                    .HasColumnName("TRAININGCODE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Traininggroup>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("TRAININGGROUP$PrimaryKey");

                entity.ToTable("TRAININGGROUP");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Brakecd)
                    .HasMaxLength(30)
                    .HasColumnName("BRAKECD");

                entity.Property(e => e.Btwcd)
                    .HasMaxLength(30)
                    .HasColumnName("BTWCD");

                entity.Property(e => e.Bus)
                    .HasMaxLength(20)
                    .HasColumnName("BUS");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .HasColumnName("CITY");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .HasColumnName("COUNTY");

                entity.Property(e => e.Equipcd)
                    .HasMaxLength(30)
                    .HasColumnName("EQUIPCD");

                entity.Property(e => e.Hrs).HasColumnName("HRS");

                entity.Property(e => e.Hrsapplieddt)
                    .HasPrecision(0)
                    .HasColumnName("HRSAPPLIEDDT");

                entity.Property(e => e.Inservicecd)
                    .HasMaxLength(30)
                    .HasColumnName("INSERVICECD");

                entity.Property(e => e.InstrEmpnum).HasColumnName("INSTR_EMPNUM");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Proficient).HasColumnName("PROFICIENT");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1)
                    .HasColumnName("REASON");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Tcc)
                    .HasMaxLength(30)
                    .HasColumnName("TCC");

                entity.Property(e => e.Trainingcode)
                    .HasMaxLength(30)
                    .HasColumnName("TRAININGCODE");

                entity.Property(e => e.Trainingdt)
                    .HasPrecision(0)
                    .HasColumnName("TRAININGDT");

                entity.Property(e => e.Units)
                    .HasMaxLength(30)
                    .HasColumnName("UNITS");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.HasKey(e => e.Tripnum)
                    .HasName("TRIPS$PrimaryKey");

                entity.ToTable("TRIPS");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Addltype)
                    .HasMaxLength(3)
                    .HasColumnName("ADDLTYPE");

                entity.Property(e => e.AdministratorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("ADMINISTRATOR_EMAIL");

                entity.Property(e => e.Amount1).HasColumnName("AMOUNT1");

                entity.Property(e => e.Amount2).HasColumnName("AMOUNT2");

                entity.Property(e => e.Amount3).HasColumnName("AMOUNT3");

                entity.Property(e => e.Amount4).HasColumnName("AMOUNT4");

                entity.Property(e => e.Amount5).HasColumnName("AMOUNT5");

                entity.Property(e => e.Amounttxt1)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT1");

                entity.Property(e => e.Amounttxt2)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT2");

                entity.Property(e => e.Amounttxt3)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT3");

                entity.Property(e => e.Amounttxt4)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT4");

                entity.Property(e => e.Amounttxt5)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT5");

                entity.Property(e => e.ApproverEmail)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVER_EMAIL");

                entity.Property(e => e.Arrivetime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETIME");

                entity.Property(e => e.Assigned).HasColumnName("ASSIGNED");

                entity.Property(e => e.Autoassign).HasColumnName("AUTOASSIGN");

                entity.Property(e => e.Bill).HasColumnName("BILL");

                entity.Property(e => e.Billcust)
                    .HasMaxLength(30)
                    .HasColumnName("BILLCUST");

                entity.Property(e => e.Billdate)
                    .HasPrecision(0)
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billed).HasColumnName("BILLED");

                entity.Property(e => e.Billrate).HasColumnName("BILLRATE");

                entity.Property(e => e.Calcnumdrivers).HasColumnName("CALCNUMDRIVERS");

                entity.Property(e => e.Canceled).HasColumnName("CANCELED");

                entity.Property(e => e.Candate)
                    .HasPrecision(0)
                    .HasColumnName("CANDATE");

                entity.Property(e => e.Capacity)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("CAPACITY");

                entity.Property(e => e.Contact)
                    .HasMaxLength(25)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Custspec).HasColumnName("CUSTSPEC");

                entity.Property(e => e.DateEntered)
                    .HasPrecision(0)
                    .HasColumnName("DATE_ENTERED");

                entity.Property(e => e.DateLastchanged)
                    .HasPrecision(0)
                    .HasColumnName("DATE_LASTCHANGED");

                entity.Property(e => e.Depdate)
                    .HasPrecision(0)
                    .HasColumnName("DEPDATE");

                entity.Property(e => e.Deptime)
                    .HasPrecision(0)
                    .HasColumnName("DEPTIME");

                entity.Property(e => e.Destination).HasColumnName("DESTINATION");

                entity.Property(e => e.Destspec).HasColumnName("DESTSPEC");

                entity.Property(e => e.Dropret).HasColumnName("DROPRET");

                entity.Property(e => e.Estmile).HasColumnName("ESTMILE");

                entity.Property(e => e.Esttime).HasColumnName("ESTTIME");

                entity.Property(e => e.Fund)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FUND");

                entity.Property(e => e.Grade)
                    .HasMaxLength(20)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Inttripnum)
                    .HasMaxLength(30)
                    .HasColumnName("INTTRIPNUM");

                entity.Property(e => e.InvoiceComment1).HasColumnName("INVOICE_COMMENT#1");

                entity.Property(e => e.InvoiceFormat)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICE_FORMAT");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Multidest).HasColumnName("MULTIDEST");

                entity.Property(e => e.Numaddl).HasColumnName("NUMADDL");

                entity.Property(e => e.Numadults).HasColumnName("NUMADULTS");

                entity.Property(e => e.Numchar).HasColumnName("NUMCHAR");

                entity.Property(e => e.Numhand).HasColumnName("NUMHAND");

                entity.Property(e => e.Numstudents).HasColumnName("NUMSTUDENTS");

                entity.Property(e => e.Numtype).HasColumnName("NUMTYPE");

                entity.Property(e => e.Numveh).HasColumnName("NUMVEH");

                entity.Property(e => e.Outoftown).HasColumnName("OUTOFTOWN");

                entity.Property(e => e.Po)
                    .HasMaxLength(15)
                    .HasColumnName("PO");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(6)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(25)
                    .HasColumnName("PURPOSE");

                entity.Property(e => e.Reqdate)
                    .HasPrecision(0)
                    .HasColumnName("REQDATE");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("REQUESTOR_EMAIL");

                entity.Property(e => e.Retdate)
                    .HasPrecision(0)
                    .HasColumnName("RETDATE");

                entity.Property(e => e.Rettime)
                    .HasPrecision(0)
                    .HasColumnName("RETTIME");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Schedule2)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE2");

                entity.Property(e => e.Schedule3)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE3");

                entity.Property(e => e.Schedule4)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE4");

                entity.Property(e => e.Schedule5)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE5");

                entity.Property(e => e.Shuttle).HasColumnName("SHUTTLE");

                entity.Property(e => e.Split).HasColumnName("SPLIT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TicketFormat)
                    .HasMaxLength(50)
                    .HasColumnName("TICKET_FORMAT");

                entity.Property(e => e.Tripcat)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPCAT");

                entity.Property(e => e.Tripcom).HasColumnName("TRIPCOM");

                entity.Property(e => e.Tripreqnum).HasColumnName("TRIPREQNUM");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("TYPE");

                entity.Property(e => e.User1)
                    .HasMaxLength(30)
                    .HasColumnName("USER1");

                entity.Property(e => e.User2)
                    .HasMaxLength(30)
                    .HasColumnName("USER2");

                entity.Property(e => e.UserEntered)
                    .HasMaxLength(20)
                    .HasColumnName("USER_ENTERED");

                entity.Property(e => e.UserLastchanged)
                    .HasMaxLength(20)
                    .HasColumnName("USER_LASTCHANGED");

                entity.Property(e => e.Userdate1)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE1");

                entity.Property(e => e.Userdate2)
                    .HasPrecision(0)
                    .HasColumnName("USERDATE2");
            });

            modelBuilder.Entity<Tripbid>(entity =>
            {
                entity.HasKey(e => e.Bidnum)
                    .HasName("TRIPBIDS$PrimaryKey");

                entity.ToTable("TRIPBIDS");

                entity.Property(e => e.Bidnum).HasColumnName("BIDNUM");

                entity.Property(e => e.Bidamt).HasColumnName("BIDAMT");

                entity.Property(e => e.Changedate)
                    .HasPrecision(0)
                    .HasColumnName("CHANGEDATE");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Requestdate)
                    .HasPrecision(0)
                    .HasColumnName("REQUESTDATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<Tripcat>(entity =>
            {
                entity.HasKey(e => e.Tripcat1)
                    .HasName("TRIPCAT$PrimaryKey");

                entity.ToTable("TRIPCAT");

                entity.Property(e => e.Tripcat1)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPCAT");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Tripchar>(entity =>
            {
                entity.HasKey(e => new { e.Tripnum, e.Characteristic })
                    .HasName("TRIPCHAR$PrimaryKey");

                entity.ToTable("TRIPCHAR");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Characteristic)
                    .HasMaxLength(20)
                    .HasColumnName("CHARACTERISTIC");
            });

            modelBuilder.Entity<Tripdate>(entity =>
            {
                entity.HasKey(e => new { e.Tripnum, e.Tripdate1 })
                    .HasName("TRIPDATES$PrimaryKey");

                entity.ToTable("TRIPDATES");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Tripdate1)
                    .HasPrecision(0)
                    .HasColumnName("TRIPDATE");

                entity.Property(e => e.Arrivettime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETTIME");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Starttime)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME");
            });

            modelBuilder.Entity<Tripemployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TRIPEMPLOYEES");

                entity.Property(e => e.Addhours).HasColumnName("ADDHOURS");

                entity.Property(e => e.Arriveod).HasColumnName("ARRIVEOD");

                entity.Property(e => e.Arrivetime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETIME");

                entity.Property(e => e.Begod).HasColumnName("BEGOD");

                entity.Property(e => e.Bidnum).HasColumnName("BIDNUM");

                entity.Property(e => e.Calcot).HasColumnName("CALCOT");

                entity.Property(e => e.Custhours).HasColumnName("CUSTHOURS");

                entity.Property(e => e.Custmiles).HasColumnName("CUSTMILES");

                entity.Property(e => e.DontCountHrs).HasColumnName("DONT_COUNT_HRS");

                entity.Property(e => e.Driverexp).HasColumnName("DRIVEREXP");

                entity.Property(e => e.Drivernotes).HasColumnName("DRIVERNOTES");

                entity.Property(e => e.Empnum).HasColumnName("EMPNUM");

                entity.Property(e => e.Endod).HasColumnName("ENDOD");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Hours).HasColumnName("HOURS");

                entity.Property(e => e.Hourspaid).HasColumnName("HOURSPAID");

                entity.Property(e => e.Leaveod).HasColumnName("LEAVEOD");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Legid).HasColumnName("LEGID");

                entity.Property(e => e.Miles).HasColumnName("MILES");

                entity.Property(e => e.Othours).HasColumnName("OTHOURS");

                entity.Property(e => e.Otwaittime).HasColumnName("OTWAITTIME");

                entity.Property(e => e.Postdate)
                    .HasPrecision(0)
                    .HasColumnName("POSTDATE");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Starttime)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Status)
                    .HasMaxLength(13)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Vehicle)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE");

                entity.Property(e => e.Waittime).HasColumnName("WAITTIME");
            });

            modelBuilder.Entity<Tripleg>(entity =>
            {
                entity.HasKey(e => e.Legid)
                    .HasName("TRIPLEG$PrimaryKey");

                entity.ToTable("TRIPLEG");

                entity.Property(e => e.Legid).HasColumnName("LEGID");

                entity.Property(e => e.Arrivetime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETIME");

                entity.Property(e => e.Endadd1)
                    .HasMaxLength(30)
                    .HasColumnName("ENDADD1");

                entity.Property(e => e.Endadd2)
                    .HasMaxLength(30)
                    .HasColumnName("ENDADD2");

                entity.Property(e => e.Endcity)
                    .HasMaxLength(15)
                    .HasColumnName("ENDCITY");

                entity.Property(e => e.Endid)
                    .HasMaxLength(30)
                    .HasColumnName("ENDID");

                entity.Property(e => e.Endname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ENDNAME");

                entity.Property(e => e.Endstate)
                    .HasMaxLength(2)
                    .HasColumnName("ENDSTATE");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Endtype)
                    .HasMaxLength(1)
                    .HasColumnName("ENDTYPE");

                entity.Property(e => e.Endzip)
                    .HasMaxLength(10)
                    .HasColumnName("ENDZIP");

                entity.Property(e => e.Esttime).HasColumnName("ESTTIME");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Startadd1)
                    .HasMaxLength(30)
                    .HasColumnName("STARTADD1");

                entity.Property(e => e.Startadd2)
                    .HasMaxLength(30)
                    .HasColumnName("STARTADD2");

                entity.Property(e => e.Startcity)
                    .HasMaxLength(15)
                    .HasColumnName("STARTCITY");

                entity.Property(e => e.Startid)
                    .HasMaxLength(30)
                    .HasColumnName("STARTID");

                entity.Property(e => e.Startname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("STARTNAME");

                entity.Property(e => e.Startstate)
                    .HasMaxLength(2)
                    .HasColumnName("STARTSTATE");

                entity.Property(e => e.Starttime)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Starttype)
                    .HasMaxLength(1)
                    .HasColumnName("STARTTYPE");

                entity.Property(e => e.Startzip)
                    .HasMaxLength(10)
                    .HasColumnName("STARTZIP");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<TripreqConflicttime>(entity =>
            {
                entity.HasKey(e => e.Routenum)
                    .HasName("TRIPREQ_CONFLICTTIMES$PrimaryKey");

                entity.ToTable("TRIPREQ_CONFLICTTIMES");

                entity.Property(e => e.Routenum).HasColumnName("ROUTENUM");

                entity.Property(e => e.Daynum).HasColumnName("DAYNUM");

                entity.Property(e => e.Endtime1)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME1");

                entity.Property(e => e.Endtime2)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME2");

                entity.Property(e => e.Endtime3)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME3");

                entity.Property(e => e.Routeday)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("ROUTEDAY");

                entity.Property(e => e.Starttime1)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME1");

                entity.Property(e => e.Starttime2)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME2");

                entity.Property(e => e.Starttime3)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME3");
            });

            modelBuilder.Entity<TripreqRequired>(entity =>
            {
                entity.ToTable("TRIPREQ_REQUIRED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArrivetimeReq).HasColumnName("ARRIVETIME_REQ");

                entity.Property(e => e.ContactReq).HasColumnName("CONTACT_REQ");

                entity.Property(e => e.CustomerRequired).HasColumnName("CUSTOMER_REQUIRED");

                entity.Property(e => e.CustspecReq).HasColumnName("CUSTSPEC_REQ");

                entity.Property(e => e.DepdateReq).HasColumnName("DEPDATE_REQ");

                entity.Property(e => e.DeptimeReq).HasColumnName("DEPTIME_REQ");

                entity.Property(e => e.DestinationReq).HasColumnName("DESTINATION_REQ");

                entity.Property(e => e.DestspecReq).HasColumnName("DESTSPEC_REQ");

                entity.Property(e => e.EstmileReq).HasColumnName("ESTMILE_REQ");

                entity.Property(e => e.EsttimeReq).HasColumnName("ESTTIME_REQ");

                entity.Property(e => e.FundRequired).HasColumnName("FUND_REQUIRED");

                entity.Property(e => e.GradeReq).HasColumnName("GRADE_REQ");

                entity.Property(e => e.InttripnumReq).HasColumnName("INTTRIPNUM_REQ");

                entity.Property(e => e.InvoiceCommentReq).HasColumnName("INVOICE_COMMENT_REQ");

                entity.Property(e => e.LeavetimeReq).HasColumnName("LEAVETIME_REQ");

                entity.Property(e => e.NumadultsReq).HasColumnName("NUMADULTS_REQ");

                entity.Property(e => e.NumstudentsReq).HasColumnName("NUMSTUDENTS_REQ");

                entity.Property(e => e.NumwheelReq).HasColumnName("NUMWHEEL_REQ");

                entity.Property(e => e.PoReq).HasColumnName("PO_REQ");

                entity.Property(e => e.PurposeReq).HasColumnName("PURPOSE_REQ");

                entity.Property(e => e.RequestDateRequired).HasColumnName("REQUEST_DATE_REQUIRED");

                entity.Property(e => e.RetdateReq).HasColumnName("RETDATE_REQ");

                entity.Property(e => e.RettimeReq).HasColumnName("RETTIME_REQ");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TripcatReq).HasColumnName("TRIPCAT_REQ");

                entity.Property(e => e.TripcomReq).HasColumnName("TRIPCOM_REQ");
            });

            modelBuilder.Entity<Tripreqchar>(entity =>
            {
                entity.HasKey(e => new { e.Tripnum, e.Characteristic })
                    .HasName("TRIPREQCHAR$PrimaryKey");

                entity.ToTable("TRIPREQCHAR");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Characteristic)
                    .HasMaxLength(20)
                    .HasColumnName("CHARACTERISTIC");
            });

            modelBuilder.Entity<Tripreqdate>(entity =>
            {
                entity.HasKey(e => new { e.Tripnum, e.Tripdate })
                    .HasName("TRIPREQDATES$PrimaryKey");

                entity.ToTable("TRIPREQDATES");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Tripdate)
                    .HasPrecision(0)
                    .HasColumnName("TRIPDATE");

                entity.Property(e => e.Arrivettime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETTIME");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Starttime)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME");
            });

            modelBuilder.Entity<Tripreqleg>(entity =>
            {
                entity.HasKey(e => e.Legid)
                    .HasName("TRIPREQLEG$PrimaryKey");

                entity.ToTable("TRIPREQLEG");

                entity.Property(e => e.Legid).HasColumnName("LEGID");

                entity.Property(e => e.Arrivetime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETIME");

                entity.Property(e => e.Endadd1)
                    .HasMaxLength(30)
                    .HasColumnName("ENDADD1");

                entity.Property(e => e.Endadd2)
                    .HasMaxLength(30)
                    .HasColumnName("ENDADD2");

                entity.Property(e => e.Endcity)
                    .HasMaxLength(15)
                    .HasColumnName("ENDCITY");

                entity.Property(e => e.Endid)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ENDID");

                entity.Property(e => e.Endname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ENDNAME");

                entity.Property(e => e.Endstate)
                    .HasMaxLength(2)
                    .HasColumnName("ENDSTATE");

                entity.Property(e => e.Endtime)
                    .HasPrecision(0)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Endtype)
                    .HasMaxLength(1)
                    .HasColumnName("ENDTYPE");

                entity.Property(e => e.Endzip)
                    .HasMaxLength(10)
                    .HasColumnName("ENDZIP");

                entity.Property(e => e.Esttime).HasColumnName("ESTTIME");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Startadd1)
                    .HasMaxLength(30)
                    .HasColumnName("STARTADD1");

                entity.Property(e => e.Startadd2)
                    .HasMaxLength(30)
                    .HasColumnName("STARTADD2");

                entity.Property(e => e.Startcity)
                    .HasMaxLength(15)
                    .HasColumnName("STARTCITY");

                entity.Property(e => e.Startid)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("STARTID");

                entity.Property(e => e.Startname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("STARTNAME");

                entity.Property(e => e.Startstate)
                    .HasMaxLength(2)
                    .HasColumnName("STARTSTATE");

                entity.Property(e => e.Starttime)
                    .HasPrecision(0)
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Starttype)
                    .HasMaxLength(1)
                    .HasColumnName("STARTTYPE");

                entity.Property(e => e.Startzip)
                    .HasMaxLength(10)
                    .HasColumnName("STARTZIP");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<Tripreqsplit>(entity =>
            {
                entity.HasKey(e => e.Recid)
                    .HasName("TRIPREQSPLIT$PrimaryKey");

                entity.ToTable("TRIPREQSPLIT");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Fund)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FUND");

                entity.Property(e => e.Splitlimitamount).HasColumnName("SPLITLIMITAMOUNT");

                entity.Property(e => e.Splitperc).HasColumnName("SPLITPERC");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<Tripreqstatus>(entity =>
            {
                entity.HasKey(e => e.Status)
                    .HasName("TRIPREQSTATUS$PrimaryKey");

                entity.ToTable("TRIPREQSTATUS");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Description)
                    .HasMaxLength(75)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");
            });

            modelBuilder.Entity<Tripsplit>(entity =>
            {
                entity.HasKey(e => e.Recid)
                    .HasName("TRIPSPLIT$PrimaryKey");

                entity.ToTable("TRIPSPLIT");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Fund)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FUND");

                entity.Property(e => e.Splitlimitamount).HasColumnName("SPLITLIMITAMOUNT");

                entity.Property(e => e.Splitperc).HasColumnName("SPLITPERC");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");
            });

            modelBuilder.Entity<Tripsreq>(entity =>
            {
                entity.HasKey(e => e.Tripnum)
                    .HasName("TRIPSREQ$PrimaryKey");

                entity.ToTable("TRIPSREQ");

                entity.Property(e => e.Tripnum).HasColumnName("TRIPNUM");

                entity.Property(e => e.Addltype)
                    .HasMaxLength(3)
                    .HasColumnName("ADDLTYPE");

                entity.Property(e => e.AdministratorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("ADMINISTRATOR_EMAIL");

                entity.Property(e => e.Amount1).HasColumnName("AMOUNT1");

                entity.Property(e => e.Amount2).HasColumnName("AMOUNT2");

                entity.Property(e => e.Amount3).HasColumnName("AMOUNT3");

                entity.Property(e => e.Amount4).HasColumnName("AMOUNT4");

                entity.Property(e => e.Amount5).HasColumnName("AMOUNT5");

                entity.Property(e => e.Amounttxt1)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT1");

                entity.Property(e => e.Amounttxt2)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT2");

                entity.Property(e => e.Amounttxt3)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT3");

                entity.Property(e => e.Amounttxt4)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT4");

                entity.Property(e => e.Amounttxt5)
                    .HasMaxLength(50)
                    .HasColumnName("AMOUNTTXT5");

                entity.Property(e => e.ApproverEmail)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVER_EMAIL");

                entity.Property(e => e.Arrivetime)
                    .HasPrecision(0)
                    .HasColumnName("ARRIVETIME");

                entity.Property(e => e.Autoassign).HasColumnName("AUTOASSIGN");

                entity.Property(e => e.Billcust)
                    .HasMaxLength(30)
                    .HasColumnName("BILLCUST");

                entity.Property(e => e.Billrate).HasColumnName("BILLRATE");

                entity.Property(e => e.Calcnumdrivers).HasColumnName("CALCNUMDRIVERS");

                entity.Property(e => e.Capacity)
                    .HasMaxLength(6)
                    .HasColumnName("CAPACITY");

                entity.Property(e => e.Chainid)
                    .HasMaxLength(20)
                    .HasColumnName("CHAINID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(25)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.Custspec).HasColumnName("CUSTSPEC");

                entity.Property(e => e.Depdate)
                    .HasPrecision(0)
                    .HasColumnName("DEPDATE");

                entity.Property(e => e.Deptime)
                    .HasPrecision(0)
                    .HasColumnName("DEPTIME");

                entity.Property(e => e.Destadd1)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD1");

                entity.Property(e => e.Destadd2)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD2");

                entity.Property(e => e.Destcat)
                    .HasMaxLength(5)
                    .HasColumnName("DESTCAT");

                entity.Property(e => e.Destcity)
                    .HasMaxLength(15)
                    .HasColumnName("DESTCITY");

                entity.Property(e => e.Destdesc)
                    .HasMaxLength(100)
                    .HasColumnName("DESTDESC");

                entity.Property(e => e.Destination).HasColumnName("DESTINATION");

                entity.Property(e => e.Destspec).HasColumnName("DESTSPEC");

                entity.Property(e => e.Deststate)
                    .HasMaxLength(2)
                    .HasColumnName("DESTSTATE");

                entity.Property(e => e.Destzip)
                    .HasMaxLength(10)
                    .HasColumnName("DESTZIP");

                entity.Property(e => e.Dropret).HasColumnName("DROPRET");

                entity.Property(e => e.Enterdate)
                    .HasPrecision(0)
                    .HasColumnName("ENTERDATE");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(20)
                    .HasColumnName("ENTEREDBY");

                entity.Property(e => e.Estmile).HasColumnName("ESTMILE");

                entity.Property(e => e.Esttime).HasColumnName("ESTTIME");

                entity.Property(e => e.FieldtripNum).HasColumnName("FIELDTRIP_NUM");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .HasColumnName("FUND");

                entity.Property(e => e.Grade)
                    .HasMaxLength(20)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Inttripnum)
                    .HasMaxLength(30)
                    .HasColumnName("INTTRIPNUM");

                entity.Property(e => e.InvoiceComment1).HasColumnName("INVOICE_COMMENT#1");

                entity.Property(e => e.InvoiceFormat)
                    .HasMaxLength(50)
                    .HasColumnName("INVOICE_FORMAT");

                entity.Property(e => e.Leavetime)
                    .HasPrecision(0)
                    .HasColumnName("LEAVETIME");

                entity.Property(e => e.Miles).HasColumnName("MILES");

                entity.Property(e => e.Multidest).HasColumnName("MULTIDEST");

                entity.Property(e => e.Numaddl).HasColumnName("NUMADDL");

                entity.Property(e => e.Numadults).HasColumnName("NUMADULTS");

                entity.Property(e => e.Numchar).HasColumnName("NUMCHAR");

                entity.Property(e => e.Numhand).HasColumnName("NUMHAND");

                entity.Property(e => e.Numstudents).HasColumnName("NUMSTUDENTS");

                entity.Property(e => e.Numtype).HasColumnName("NUMTYPE");

                entity.Property(e => e.Outoftown).HasColumnName("OUTOFTOWN");

                entity.Property(e => e.Po)
                    .HasMaxLength(15)
                    .HasColumnName("PO");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(25)
                    .HasColumnName("PURPOSE");

                entity.Property(e => e.Reqdate)
                    .HasPrecision(0)
                    .HasColumnName("REQDATE");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(100)
                    .HasColumnName("REQUESTOR_EMAIL");

                entity.Property(e => e.Retdate)
                    .HasPrecision(0)
                    .HasColumnName("RETDATE");

                entity.Property(e => e.Rettime)
                    .HasPrecision(0)
                    .HasColumnName("RETTIME");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Schedule2)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE2");

                entity.Property(e => e.Schedule3)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE3");

                entity.Property(e => e.Schedule4)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE4");

                entity.Property(e => e.Schedule5)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE5");

                entity.Property(e => e.Shuttle).HasColumnName("SHUTTLE");

                entity.Property(e => e.Split).HasColumnName("SPLIT");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StatusComment).HasColumnName("STATUS_COMMENT");

                entity.Property(e => e.StatusDate)
                    .HasPrecision(0)
                    .HasColumnName("STATUS_DATE");

                entity.Property(e => e.TicketFormat)
                    .HasMaxLength(50)
                    .HasColumnName("TICKET_FORMAT");

                entity.Property(e => e.Tripcat)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPCAT");

                entity.Property(e => e.Tripcom).HasColumnName("TRIPCOM");

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<TripticketTemplate>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("TRIPTICKET_TEMPLATE$PrimaryKey");

                entity.ToTable("TRIPTICKET_TEMPLATE");

                entity.Property(e => e.TicketId)
                    .HasMaxLength(20)
                    .HasColumnName("TICKET_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.AlldriversCaption)
                    .HasMaxLength(50)
                    .HasColumnName("ALLDRIVERS_CAPTION");

                entity.Property(e => e.AlldriversShow).HasColumnName("ALLDRIVERS_SHOW");

                entity.Property(e => e.ArriveCaption)
                    .HasMaxLength(30)
                    .HasColumnName("ARRIVE_CAPTION");

                entity.Property(e => e.ArriveShow).HasColumnName("ARRIVE_SHOW");

                entity.Property(e => e.CategoryCaption)
                    .HasMaxLength(30)
                    .HasColumnName("CATEGORY_CAPTION");

                entity.Property(e => e.CategoryShow).HasColumnName("CATEGORY_SHOW");

                entity.Property(e => e.ContactCaption)
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT_CAPTION");

                entity.Property(e => e.ContactShow).HasColumnName("CONTACT_SHOW");

                entity.Property(e => e.CustaddCaption)
                    .HasMaxLength(20)
                    .HasColumnName("CUSTADD_CAPTION");

                entity.Property(e => e.CustaddShow).HasColumnName("CUSTADD_SHOW");

                entity.Property(e => e.CustnameCaption)
                    .HasMaxLength(30)
                    .HasColumnName("CUSTNAME_CAPTION");

                entity.Property(e => e.CustnameShow).HasColumnName("CUSTNAME_SHOW");

                entity.Property(e => e.CustspecCaption)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTSPEC_CAPTION");

                entity.Property(e => e.CustspecShow).HasColumnName("CUSTSPEC_SHOW");

                entity.Property(e => e.DepdateLabel)
                    .HasMaxLength(30)
                    .HasColumnName("DEPDATE_LABEL");

                entity.Property(e => e.DepdateShow).HasColumnName("DEPDATE_SHOW");

                entity.Property(e => e.DeptimeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DEPTIME_CAPTION");

                entity.Property(e => e.DeptimeShow).HasColumnName("DEPTIME_SHOW");

                entity.Property(e => e.DestaddCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DESTADD_CAPTION");

                entity.Property(e => e.DestaddShow).HasColumnName("DESTADD_SHOW");

                entity.Property(e => e.DestdescCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DESTDESC_CAPTION");

                entity.Property(e => e.DestdescShow).HasColumnName("DESTDESC_SHOW");

                entity.Property(e => e.DestspecCaption)
                    .HasMaxLength(50)
                    .HasColumnName("DESTSPEC_CAPTION");

                entity.Property(e => e.DestspecShow).HasColumnName("DESTSPEC_SHOW");

                entity.Property(e => e.DisabledCaption)
                    .HasMaxLength(30)
                    .HasColumnName("DISABLED_CAPTION");

                entity.Property(e => e.DisabledShow).HasColumnName("DISABLED_SHOW");

                entity.Property(e => e.DistrictShow).HasColumnName("DISTRICT_SHOW");

                entity.Property(e => e.DriverCaption)
                    .HasMaxLength(50)
                    .HasColumnName("DRIVER_CAPTION");

                entity.Property(e => e.DriverShow).HasColumnName("DRIVER_SHOW");

                entity.Property(e => e.DropretMessage)
                    .HasMaxLength(20)
                    .HasColumnName("DROPRET_MESSAGE");

                entity.Property(e => e.DropretShow).HasColumnName("DROPRET_SHOW");

                entity.Property(e => e.EsthoursCaption)
                    .HasMaxLength(30)
                    .HasColumnName("ESTHOURS_CAPTION");

                entity.Property(e => e.EsthoursShow).HasColumnName("ESTHOURS_SHOW");

                entity.Property(e => e.EstmilesCaption)
                    .HasMaxLength(30)
                    .HasColumnName("ESTMILES_CAPTION");

                entity.Property(e => e.EstmilesShow).HasColumnName("ESTMILES_SHOW");

                entity.Property(e => e.FundCaption)
                    .HasMaxLength(30)
                    .HasColumnName("FUND_CAPTION");

                entity.Property(e => e.FundShow).HasColumnName("FUND_SHOW");

                entity.Property(e => e.GradeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("GRADE_CAPTION");

                entity.Property(e => e.GradeShow).HasColumnName("GRADE_SHOW");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.InternalCaption)
                    .HasMaxLength(30)
                    .HasColumnName("INTERNAL_CAPTION");

                entity.Property(e => e.InternalShow).HasColumnName("INTERNAL_SHOW");

                entity.Property(e => e.LeaveCaption)
                    .HasMaxLength(30)
                    .HasColumnName("LEAVE_CAPTION");

                entity.Property(e => e.LeaveShow).HasColumnName("LEAVE_SHOW");

                entity.Property(e => e.MultiMessage)
                    .HasMaxLength(30)
                    .HasColumnName("MULTI_MESSAGE");

                entity.Property(e => e.MultiShow).HasColumnName("MULTI_SHOW");

                entity.Property(e => e.PassengerCaption)
                    .HasMaxLength(30)
                    .HasColumnName("PASSENGER_CAPTION");

                entity.Property(e => e.PassengerShow).HasColumnName("PASSENGER_SHOW");

                entity.Property(e => e.PurposeCaption)
                    .HasMaxLength(30)
                    .HasColumnName("PURPOSE_CAPTION");

                entity.Property(e => e.PurposeShow).HasColumnName("PURPOSE_SHOW");

                entity.Property(e => e.ReplaceTripLabel)
                    .HasMaxLength(30)
                    .HasColumnName("REPLACE_TRIP_LABEL");

                entity.Property(e => e.ReplaceTripShow).HasColumnName("REPLACE_TRIP_SHOW");

                entity.Property(e => e.RetdateCaption)
                    .HasMaxLength(30)
                    .HasColumnName("RETDATE_CAPTION");

                entity.Property(e => e.RetdateShow).HasColumnName("RETDATE_SHOW");

                entity.Property(e => e.RettimeCaption)
                    .HasMaxLength(50)
                    .HasColumnName("RETTIME_CAPTION");

                entity.Property(e => e.RettimeShow).HasColumnName("RETTIME_SHOW");

                entity.Property(e => e.ShuttleMessage)
                    .HasMaxLength(20)
                    .HasColumnName("SHUTTLE_MESSAGE");

                entity.Property(e => e.ShuttleShow).HasColumnName("SHUTTLE_SHOW");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TemplateDesc)
                    .HasMaxLength(50)
                    .HasColumnName("TEMPLATE_DESC");

                entity.Property(e => e.TripnumLabel)
                    .HasMaxLength(20)
                    .HasColumnName("TRIPNUM_LABEL");

                entity.Property(e => e.TripnumShow).HasColumnName("TRIPNUM_SHOW");

                entity.Property(e => e.User).HasColumnName("USER");

                entity.Property(e => e.UserShow).HasColumnName("USER_SHOW");

                entity.Property(e => e.VehicleCaption)
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE_CAPTION");

                entity.Property(e => e.VehicleShow).HasColumnName("VEHICLE_SHOW");

                entity.Property(e => e.VtypeShow).HasColumnName("VTYPE_SHOW");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.Vehicle1)
                    .HasName("VEHICLE$PrimaryKey");

                entity.ToTable("VEHICLE");

                entity.Property(e => e.Vehicle1)
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Alternate).HasColumnName("ALTERNATE");

                entity.Property(e => e.Datelstuse)
                    .HasPrecision(0)
                    .HasColumnName("DATELSTUSE");

                entity.Property(e => e.Fueltype)
                    .HasMaxLength(1)
                    .HasColumnName("FUELTYPE");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Make)
                    .HasMaxLength(30)
                    .HasColumnName("MAKE");

                entity.Property(e => e.Manyear).HasColumnName("MANYEAR");

                entity.Property(e => e.Miles).HasColumnName("MILES");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Vehdesc)
                    .HasMaxLength(30)
                    .HasColumnName("VEHDESC");

                entity.Property(e => e.Vehlic)
                    .HasMaxLength(8)
                    .HasColumnName("VEHLIC");

                entity.Property(e => e.Vehtype)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("VEHTYPE");

                entity.Property(e => e.Vuser1)
                    .HasMaxLength(5)
                    .HasColumnName("VUSER1");

                entity.Property(e => e.Vuser2)
                    .HasMaxLength(5)
                    .HasColumnName("VUSER2");

                entity.Property(e => e.Vuser3)
                    .HasMaxLength(5)
                    .HasColumnName("VUSER3");

                entity.Property(e => e.Zonarid)
                    .HasMaxLength(50)
                    .HasColumnName("ZONARID");
            });

            modelBuilder.Entity<Vehicleque>(entity =>
            {
                entity.HasKey(e => new { e.Schedule, e.Vehicle })
                    .HasName("VEHICLEQUE$PrimaryKey");

                entity.ToTable("VEHICLEQUE");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(6)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.Vehicle)
                    .HasMaxLength(20)
                    .HasColumnName("VEHICLE");
            });

            modelBuilder.Entity<Vehtype>(entity =>
            {
                entity.HasKey(e => e.Vehtype1)
                    .HasName("VEHTYPE$PrimaryKey");

                entity.ToTable("VEHTYPE");

                entity.Property(e => e.Vehtype1)
                    .HasMaxLength(3)
                    .HasColumnName("VEHTYPE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.High).HasColumnName("HIGH");

                entity.Property(e => e.Highoverfill).HasColumnName("HIGHOVERFILL");

                entity.Property(e => e.Inactdate)
                    .HasPrecision(0)
                    .HasColumnName("INACTDATE");

                entity.Property(e => e.Low).HasColumnName("LOW");

                entity.Property(e => e.Lowoverfill).HasColumnName("LOWOVERFILL");

                entity.Property(e => e.Medium).HasColumnName("MEDIUM");

                entity.Property(e => e.Mediumoverfill).HasColumnName("MEDIUMOVERFILL");

                entity.Property(e => e.Numhand).HasColumnName("NUMHAND");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.Vtypdesc)
                    .HasMaxLength(30)
                    .HasColumnName("VTYPDESC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
