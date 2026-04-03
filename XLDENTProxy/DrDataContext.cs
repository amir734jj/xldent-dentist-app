using XLDENTProxy.Models;
using Microsoft.EntityFrameworkCore;

namespace XLDENTProxy;

public partial class DrDataContext(DbContextOptions<DrDataContext> options) : DbContext(options)
{
    internal virtual DbSet<Acessosoper> Acessosopers { get; set; }

    internal virtual DbSet<Acfchpac> Acfchpacs { get; set; }

    internal virtual DbSet<Acumtrc> Acumtrcs { get; set; }

    internal virtual DbSet<Acumul> Acumuls { get; set; }

    internal virtual DbSet<Agdconf> Agdconfs { get; set; }

    internal virtual DbSet<Agddiasref> Agddiasrefs { get; set; }

    internal virtual DbSet<Agdmotivo> Agdmotivos { get; set; }

    internal virtual DbSet<Agendum> Agenda { get; set; }

    internal virtual DbSet<Anmtexto> Anmtextos { get; set; }

    internal virtual DbSet<Anmtitulo> Anmtitulos { get; set; }

    internal virtual DbSet<Apblockrecur> Apblockrecurs { get; set; }

    internal virtual DbSet<Apbutton> Apbuttons { get; set; }

    internal virtual DbSet<Apcategory> Apcategories { get; set; }

    internal virtual DbSet<Apday> Apdays { get; set; }

    internal virtual DbSet<Apdetail> Apdetails { get; set; }

    internal virtual DbSet<Apdetailp> Apdetailps { get; set; }

    internal virtual DbSet<Apevent> Apevents { get; set; }

    internal virtual DbSet<Apeventrecur> Apeventrecurs { get; set; }

    internal virtual DbSet<Apeventslog> Apeventslogs { get; set; }

    internal virtual DbSet<Apmatrixm> Apmatrixms { get; set; }

    internal virtual DbSet<Apmatrixt> Apmatrixts { get; set; }

    internal virtual DbSet<Approp> Approps { get; set; }

    internal virtual DbSet<Apresource> Apresources { get; set; }

    internal virtual DbSet<Aptimeblock> Aptimeblocks { get; set; }

    internal virtual DbSet<Aptimeblocklink> Aptimeblocklinks { get; set; }

    internal virtual DbSet<Apview> Apviews { get; set; }

    internal virtual DbSet<Atendim> Atendims { get; set; }

    internal virtual DbSet<Autoriza> Autorizas { get; set; }

    internal virtual DbSet<Benplan> Benplans { get; set; }

    internal virtual DbSet<Benplancat> Benplancats { get; set; }

    internal virtual DbSet<Benplanext> Benplanexts { get; set; }

    internal virtual DbSet<Cabalt> Cabalts { get; set; }

    internal virtual DbSet<Ccorrente> Ccorrentes { get; set; }

    internal virtual DbSet<Cell> Cells { get; set; }

    internal virtual DbSet<Checkintx> Checkintxes { get; set; }

    internal virtual DbSet<Claim> Claims { get; set; }

    internal virtual DbSet<Claimpo> Claimpos { get; set; }

    internal virtual DbSet<Claimtrt> Claimtrts { get; set; }

    internal virtual DbSet<Claimtxn> Claimtxns { get; set; }

    internal virtual DbSet<Classfac> Classfacs { get; set; }

    internal virtual DbSet<Classftt> Classftts { get; set; }

    internal virtual DbSet<Classif> Classifs { get; set; }

    internal virtual DbSet<Classpac> Classpacs { get; set; }

    internal virtual DbSet<Classtent> Classtents { get; set; }

    internal virtual DbSet<Classtrc> Classtrcs { get; set; }

    internal virtual DbSet<Clinica> Clinicas { get; set; }

    internal virtual DbSet<Comissao> Comissaos { get; set; }

    internal virtual DbSet<Comportamento> Comportamentos { get; set; }

    internal virtual DbSet<Confpa> Confpas { get; set; }

    internal virtual DbSet<Contract> Contracts { get; set; }

    internal virtual DbSet<Contractext> Contractexts { get; set; }

    internal virtual DbSet<Contractexto> Contractextos { get; set; }

    internal virtual DbSet<Contractshdr> Contractshdrs { get; set; }

    internal virtual DbSet<Contractso> Contractsos { get; set; }

    internal virtual DbSet<Cormaterial> Cormaterials { get; set; }

    internal virtual DbSet<Counttf> Counttfs { get; set; }

    internal virtual DbSet<Cpostal> Cpostals { get; set; }

    internal virtual DbSet<CustomizedStatus> CustomizedStatuses { get; set; }

    internal virtual DbSet<Defdoc> Defdocs { get; set; }

    internal virtual DbSet<Dfmdatum> Dfmdata { get; set; }

    internal virtual DbSet<Diagnosis> Diagnoses { get; set; }

    internal virtual DbSet<DiagnosisTabelat> DiagnosisTabelats { get; set; }

    internal virtual DbSet<Dochist> Dochists { get; set; }

    internal virtual DbSet<Doclin> Doclins { get; set; }

    internal virtual DbSet<Dspecialty> Dspecialties { get; set; }

    internal virtual DbSet<Employer> Employers { get; set; }

    internal virtual DbSet<Endo> Endos { get; set; }

    internal virtual DbSet<Endomat> Endomats { get; set; }

    internal virtual DbSet<Endoob> Endoobs { get; set; }

    internal virtual DbSet<Endositu> Endositus { get; set; }

    internal virtual DbSet<Entidade> Entidades { get; set; }

    internal virtual DbSet<EnvConnection> EnvConnections { get; set; }

    internal virtual DbSet<Era> Eras { get; set; }

    internal virtual DbSet<Era1> Eras1 { get; set; }

    internal virtual DbSet<ErasText> ErasTexts { get; set; }

    internal virtual DbSet<Especdatum> Especdata { get; set; }

    internal virtual DbSet<Especgrupo> Especgrupos { get; set; }

    internal virtual DbSet<Especialidade> Especialidades { get; set; }

    internal virtual DbSet<Especquest> Especquests { get; set; }

    internal virtual DbSet<Falta> Faltas { get; set; }

    internal virtual DbSet<Familia1> Familia1s { get; set; }

    internal virtual DbSet<Familia2> Familia2s { get; set; }

    internal virtual DbSet<Familia3> Familia3s { get; set; }

    internal virtual DbSet<FeeSchedule> FeeSchedules { get; set; }

    internal virtual DbSet<FeeScheduleItem> FeeScheduleItems { get; set; }

    internal virtual DbSet<Feria> Ferias { get; set; }

    internal virtual DbSet<Feriado> Feriados { get; set; }

    internal virtual DbSet<Fieldsdescription> Fieldsdescriptions { get; set; }

    internal virtual DbSet<Filesreport> Filesreports { get; set; }

    internal virtual DbSet<Fobra> Fobras { get; set; }

    internal virtual DbSet<Fobrasum> Fobrasums { get; set; }

    internal virtual DbSet<Fobratrt> Fobratrts { get; set; }

    internal virtual DbSet<Goal> Goals { get; set; }

    internal virtual DbSet<Implante> Implantes { get; set; }

    internal virtual DbSet<Implantecm> Implantecms { get; set; }

    internal virtual DbSet<Inkchart> Inkcharts { get; set; }

    internal virtual DbSet<Inkedform> Inkedforms { get; set; }

    internal virtual DbSet<Inkformpd> Inkformpds { get; set; }

    internal virtual DbSet<Inkformq> Inkformqs { get; set; }

    internal virtual DbSet<Integration> Integrations { get; set; }

    internal virtual DbSet<JsonvaluesInkform> JsonvaluesInkforms { get; set; }

    internal virtual DbSet<Labcase> Labcases { get; set; }

    internal virtual DbSet<Labcategory> Labcategories { get; set; }

    internal virtual DbSet<Laborat> Laborats { get; set; }

    internal virtual DbSet<Listaespera> Listaesperas { get; set; }

    internal virtual DbSet<Log> Logs { get; set; }

    internal virtual DbSet<Logscout> Logscouts { get; set; }

    internal virtual DbSet<Matatrib> Matatribs { get; set; }

    internal virtual DbSet<Materiai> Materiais { get; set; }

    internal virtual DbSet<Matlink> Matlinks { get; set; }

    internal virtual DbSet<Medicam> Medicams { get; set; }

    internal virtual DbSet<Medicamrec> Medicamrecs { get; set; }

    internal virtual DbSet<Medicamrpd> Medicamrpds { get; set; }

    internal virtual DbSet<Medicdent> Medicdents { get; set; }

    internal virtual DbSet<Medico> Medicos { get; set; }

    internal virtual DbSet<Numobra> Numobras { get; set; }

    internal virtual DbSet<Numpac> Numpacs { get; set; }

    internal virtual DbSet<Numtrc> Numtrcs { get; set; }

    internal virtual DbSet<Obsdent> Obsdents { get; set; }

    internal virtual DbSet<Obsger> Obsgers { get; set; }

    internal virtual DbSet<Obsimg> Obsimgs { get; set; }

    internal virtual DbSet<Obsloc> Obslocs { get; set; }

    internal virtual DbSet<Office> Offices { get; set; }

    internal virtual DbSet<OfficesAccess> OfficesAccesses { get; set; }

    internal virtual DbSet<Olkopt> Olkopts { get; set; }

    internal virtual DbSet<Opco> Opcoes { get; set; }

    internal virtual DbSet<Opcoesoper> Opcoesopers { get; set; }

    internal virtual DbSet<Orclivre> Orclivres { get; set; }

    internal virtual DbSet<Ortodontium> Ortodontia { get; set; }

    internal virtual DbSet<Ortoel> Ortoels { get; set; }

    internal virtual DbSet<Ortoelt> Ortoelts { get; set; }

    internal virtual DbSet<Ortoev> Ortoevs { get; set; }

    internal virtual DbSet<Ortort> Ortorts { get; set; }

    internal virtual DbSet<Ortowr> Ortowrs { get; set; }

    internal virtual DbSet<Pacalternativo> Pacalternativos { get; set; }

    internal virtual DbSet<Paciente> Pacientes { get; set; }

    internal virtual DbSet<Pacin> Pacins { get; set; }

    internal virtual DbSet<Payer> Payers { get; set; }

    internal virtual DbSet<Periodontium> Periodontia { get; set; }

    internal virtual DbSet<PhoneCountry> PhoneCountries { get; set; }

    internal virtual DbSet<Planonote> Planonotes { get; set; }

    internal virtual DbSet<Planotrat> Planotrats { get; set; }

    internal virtual DbSet<Posodont> Posodonts { get; set; }

    internal virtual DbSet<Printq> Printqs { get; set; }

    internal virtual DbSet<Processo> Processos { get; set; }

    internal virtual DbSet<Processostrat> Processostrats { get; set; }

    internal virtual DbSet<Profissa> Profissas { get; set; }

    internal virtual DbSet<Prognote> Prognotes { get; set; }

    internal virtual DbSet<PrognoteLog> PrognoteLogs { get; set; }

    internal virtual DbSet<Prognotelink> Prognotelinks { get; set; }

    internal virtual DbSet<Prognotepd> Prognotepds { get; set; }

    internal virtual DbSet<Prognoteref> Prognoterefs { get; set; }

    internal virtual DbSet<Protlab> Protlabs { get; set; }

    internal virtual DbSet<Protmat> Protmats { get; set; }

    internal virtual DbSet<Provgrp> Provgrps { get; set; }

    internal virtual DbSet<Queuet> Queuets { get; set; }

    internal virtual DbSet<Receita> Receitas { get; set; }

    internal virtual DbSet<Receitaspd> Receitaspds { get; set; }

    internal virtual DbSet<Receitatemplate> Receitatemplates { get; set; }

    internal virtual DbSet<Recurrencedef> Recurrencedefs { get; set; }

    internal virtual DbSet<Referral> Referrals { get; set; }

    internal virtual DbSet<Repinvoice> Repinvoices { get; set; }

    internal virtual DbSet<Rxpac> Rxpacs { get; set; }

    internal virtual DbSet<Rxpd> Rxpds { get; set; }

    internal virtual DbSet<Saaction> Saactions { get; set; }

    internal virtual DbSet<Sala> Salas { get; set; }

    internal virtual DbSet<Salasocp> Salasocps { get; set; }

    internal virtual DbSet<Scandoc> Scandocs { get; set; }

    internal virtual DbSet<ScheduledRelease> ScheduledReleases { get; set; }

    internal virtual DbSet<Segsoc> Segsocs { get; set; }

    internal virtual DbSet<Sigdoc> Sigdocs { get; set; }

    internal virtual DbSet<Sigpat> Sigpats { get; set; }

    internal virtual DbSet<StaticMessage> StaticMessages { get; set; }

    internal virtual DbSet<Stmt> Stmts { get; set; }

    internal virtual DbSet<Stmtbal> Stmtbals { get; set; }

    internal virtual DbSet<Stmtnote> Stmtnotes { get; set; }

    internal virtual DbSet<Stmtopt> Stmtopts { get; set; }

    internal virtual DbSet<Stmtoptimg> Stmtoptimgs { get; set; }

    internal virtual DbSet<Stmttemp> Stmttemps { get; set; }

    internal virtual DbSet<Stmttrt> Stmttrts { get; set; }

    internal virtual DbSet<Subproduct> Subproducts { get; set; }

    internal virtual DbSet<Tabcore> Tabcores { get; set; }

    internal virtual DbSet<Tabelap> Tabelaps { get; set; }

    internal virtual DbSet<Tabelat> Tabelats { get; set; }

    internal virtual DbSet<Tabelataviso> Tabelatavisos { get; set; }

    internal virtual DbSet<Tabelatimg> Tabelatimgs { get; set; }

    internal virtual DbSet<Tabfav> Tabfavs { get; set; }

    internal virtual DbSet<Tabimplante> Tabimplantes { get; set; }

    internal virtual DbSet<Taboprc> Taboprcs { get; set; }

    internal virtual DbSet<Tabpag> Tabpags { get; set; }

    internal virtual DbSet<Tabregossea> Tabregosseas { get; set; }

    internal virtual DbSet<Tabrptgroup> Tabrptgroups { get; set; }

    internal virtual DbSet<Tabspdgroup> Tabspdgroups { get; set; }

    internal virtual DbSet<Tccat> Tccats { get; set; }

    internal virtual DbSet<Tcevent> Tcevents { get; set; }

    internal virtual DbSet<Terceiro> Terceiros { get; set; }

    internal virtual DbSet<Timeblock> Timeblocks { get; set; }

    internal virtual DbSet<Timeblocklink> Timeblocklinks { get; set; }

    internal virtual DbSet<Tipoacesso> Tipoacessos { get; set; }

    internal virtual DbSet<Tipooper> Tipoopers { get; set; }

    internal virtual DbSet<Tipoprot> Tipoprots { get; set; }

    internal virtual DbSet<Tipot> Tipots { get; set; }

    internal virtual DbSet<Toothloc> Toothlocs { get; set; }

    internal virtual DbSet<Toothstat> Toothstats { get; set; }

    internal virtual DbSet<Tratdel> Tratdels { get; set; }

    internal virtual DbSet<Tratexec> Tratexecs { get; set; }

    internal virtual DbSet<Tratexecor> Tratexecors { get; set; }

    internal virtual DbSet<Tratlink> Tratlinks { get; set; }

    internal virtual DbSet<Tratpay> Tratpays { get; set; }

    internal virtual DbSet<Tratref> Tratrefs { get; set; }

    internal virtual DbSet<TwilioSm> TwilioSms { get; set; }

    internal virtual DbSet<Urgencia> Urgencias { get; set; }

    internal virtual DbSet<Userrepcalc> Userrepcalcs { get; set; }

    internal virtual DbSet<Userrepmlink> Userrepmlinks { get; set; }

    internal virtual DbSet<Userreport> Userreports { get; set; }

    internal virtual DbSet<Userrepqry> Userrepqries { get; set; }

    internal virtual DbSet<Userreptemplate> Userreptemplates { get; set; }

    internal virtual DbSet<VTwilioListPatient> VTwilioListPatients { get; set; }

    internal virtual DbSet<VTwilioListPatientsMessage> VTwilioListPatientsMessages { get; set; }

    internal virtual DbSet<VTwilioListUnreadMessage> VTwilioListUnreadMessages { get; set; }

    internal virtual DbSet<VagasTmp> VagasTmps { get; set; }

    internal virtual DbSet<Valaltln> Valaltlns { get; set; }

    internal virtual DbSet<Variable> Variables { get; set; }

    internal virtual DbSet<Wkstation> Wkstations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acessosoper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acessosoper");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.TipoAcesso, e.Classif, e.Operacao }, "idxPrimary").IsUnique();

            entity.Property(e => e.Condicionada)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoAcesso).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Acfchpac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acfchpac");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Operador, "idxPrimary").IsUnique();

            entity.Property(e => e.Cmp01)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp02)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp03)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp04)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp05)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp06)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp07)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp08)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp09)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp10)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp11)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp12)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp13)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp14)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp15)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp16)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp17)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp18)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp19)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp20)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp21)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp22)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp23)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp24)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp25)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp26)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp27)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp28)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp29)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp30)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp31)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp32)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp33)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp34)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp35)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp36)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp37)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp38)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp39)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cmp40)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Operador).HasDefaultValueSql("'0'");
            entity.Property(e => e.Psqalargada)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("PSQAlargada");
            entity.Property(e => e.Psqautomatica)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("PSQAutomatica");
            entity.Property(e => e.Psqmaiusculas)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("PSQMaiusculas");
            entity.Property(e => e.PsqmaxNumerica).HasColumnName("PSQMaxNumerica");
            entity.Property(e => e.Psqsegundos).HasColumnName("PSQSegundos");
            entity.Property(e => e.PsqshowProp)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("PSQShowProp");
        });

        modelBuilder.Entity<Acumtrc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acumtrc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Trc, e.Ano, e.Mes }, "idxPrimary").IsUnique();

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Trc).HasDefaultValueSql("'0'");
            entity.Property(e => e.Vcre)
                .HasPrecision(12)
                .HasColumnName("VCre");
            entity.Property(e => e.Vdeb)
                .HasPrecision(12)
                .HasColumnName("VDeb");
        });

        modelBuilder.Entity<Acumul>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acumul");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Ano, e.Mes }, "idxPrimary").IsUnique();

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Vcre)
                .HasPrecision(12)
                .HasColumnName("VCre");
            entity.Property(e => e.Vdeb)
                .HasPrecision(12)
                .HasColumnName("VDeb");
        });

        modelBuilder.Entity<Agdconf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("agdconf");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Medico, e.Inicio, e.Fim, e.DiaSemana, e.Minicio, e.Tinicio }, "idxPrimary").IsUnique();

            entity.Property(e => e.Fim)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Inicio)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Mfim)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("MFim");
            entity.Property(e => e.Minicio)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("MInicio");
            entity.Property(e => e.Mmin).HasColumnName("MMin");
            entity.Property(e => e.Obs).HasColumnType("tinytext");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Tfim)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("TFim");
            entity.Property(e => e.Tinicio)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("TInicio");
            entity.Property(e => e.Tmin).HasColumnName("TMin");
            entity.Property(e => e.VerObs)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Agddiasref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("agddiasref");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Operador, e.Medico, e.Data }, "idxPrimary").IsUnique();

            entity.Property(e => e.Data)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Operador).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Agdmotivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("agdmotivos");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Medico, e.Atribuido, e.Mecano, e.DiaReg }, "idxAtrib");

            entity.HasIndex(e => new { e.Medico, e.Mecano, e.DiaReg }, "idxPacDia");

            entity.HasIndex(e => new { e.Medico, e.Mecano, e.DiaMarca, e.HoraMarca }, "idxPrimary").IsUnique();

            entity.Property(e => e.Atribuido)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.DiaMarca)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DiaReg)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.HoraMarca)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Motivo).HasMaxLength(50);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Agendum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("agenda");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Dia, "idxData");

            entity.HasIndex(e => e.DiaMarcacao, "idxDiaMarca");

            entity.HasIndex(e => new { e.Mecano, e.Dia }, "idxMecano");

            entity.HasIndex(e => e.Marcacao, "idxNome");

            entity.HasIndex(e => new { e.Medico, e.Dia, e.Hora }, "idxPrimary").IsUnique();

            entity.Property(e => e.Conf)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DiaMarcacao)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Entidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Marcacao)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Obs)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Operador).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Anmtexto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("anmtexto");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodAnmTxt, e.Mecano }, "idxPrimary").IsUnique();

            entity.Property(e => e.Automatica)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Texto).HasMaxLength(250);
        });

        modelBuilder.Entity<Anmtitulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("anmtitulo");

            entity.HasIndex(e => e.CodAnm, "IdxPrimary").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.CodAnm).ValueGeneratedOnAdd();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TextoAnm).HasMaxLength(150);
        });

        modelBuilder.Entity<Apblockrecur>(entity =>
        {
            entity.HasKey(e => e.RecurrenceId).HasName("PRIMARY");

            entity.ToTable("apblockrecur");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.RecurrenceId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("RecurrenceID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RActiveDates)
                .HasColumnType("text")
                .HasColumnName("R_ActiveDates");
            entity.Property(e => e.RDuration).HasColumnName("R_Duration");
            entity.Property(e => e.REndDate)
                .HasColumnType("datetime")
                .HasColumnName("R_EndDate");
            entity.Property(e => e.RExceptDates)
                .HasColumnType("text")
                .HasColumnName("R_ExceptDates");
            entity.Property(e => e.RInterval).HasColumnName("R_Interval");
            entity.Property(e => e.RModifier)
                .HasMaxLength(21)
                .HasColumnName("R_Modifier");
            entity.Property(e => e.ROccurSpecifier)
                .HasMaxLength(10)
                .HasColumnName("R_OccurSpecifier");
            entity.Property(e => e.RRecurEndType).HasColumnName("R_RecurEndType");
            entity.Property(e => e.RRule).HasColumnName("R_Rule");
            entity.Property(e => e.RRuleType).HasColumnName("R_RuleType");
            entity.Property(e => e.RStartDate)
                .HasColumnType("datetime")
                .HasColumnName("R_StartDate");
            entity.Property(e => e.RStartOfWeek).HasColumnName("R_StartOfWeek");
            entity.Property(e => e.RWeekEndMove).HasColumnName("R_WeekEndMove");
        });

        modelBuilder.Entity<Apbutton>(entity =>
        {
            entity.HasKey(e => e.SeqId).HasName("PRIMARY");

            entity.ToTable("apbuttons");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.SeqId).HasColumnName("SeqID");
            entity.Property(e => e.ButtonId).HasColumnName("ButtonID");
            entity.Property(e => e.Caption).HasMaxLength(20);
            entity.Property(e => e.CategoryId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CategoryID");
            entity.Property(e => e.CodT)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Apcategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PRIMARY");

            entity.ToTable("apcategory");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Apday>(entity =>
        {
            entity.HasKey(e => e.SpDaysAuxId).HasName("PRIMARY");

            entity.ToTable("apdays");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.SpDaysAuxId).HasColumnName("SpDaysAuxID");
            entity.Property(e => e.Aday).HasColumnName("ADay");
            entity.Property(e => e.Amonth).HasColumnName("AMonth");
            entity.Property(e => e.Color).HasDefaultValueSql("'0'");
            entity.Property(e => e.Enabled)
                .HasMaxLength(3)
                .HasDefaultValueSql("'Yes'")
                .IsFixedLength();
            entity.Property(e => e.FixedDay)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.IsHoliday)
                .HasMaxLength(3)
                .HasDefaultValueSql("'No'")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.SpDate).HasColumnType("date");
            entity.Property(e => e.SpecialDateName).HasMaxLength(15);
        });

        modelBuilder.Entity<Apdetail>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("apdetail");

            entity.HasIndex(e => e.Account, "Account");

            entity.HasIndex(e => e.EventId, "EventID");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.EventId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("EventID");
            entity.Property(e => e.Account).HasDefaultValueSql("'0'");
            entity.Property(e => e.CategoryId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CategoryID");
            entity.Property(e => e.ClaimId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ClaimID");
            entity.Property(e => e.Duration).HasMaxLength(20);
            entity.Property(e => e.EndTime).HasColumnType("time");
            entity.Property(e => e.EventType).HasDefaultValueSql("'0'");
            entity.Property(e => e.LabCaseId).HasColumnName("LabCaseID");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.NumGeral).HasDefaultValueSql("'0'");
            entity.Property(e => e.NumOrc).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.RespParty).HasDefaultValueSql("'0'");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.StartTime).HasColumnType("time");
        });

        modelBuilder.Entity<Apdetailp>(entity =>
        {
            entity.HasKey(e => e.SeqId).HasName("PRIMARY");

            entity.ToTable("apdetailp");

            entity.HasIndex(e => e.EventId, "EventID");

            entity.HasIndex(e => new { e.EventId, e.CodT }, "EventIDCodT");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.SeqId, "SeqID").IsUnique();

            entity.Property(e => e.SeqId).HasColumnName("SeqID");
            entity.Property(e => e.CodT).HasMaxLength(6);
            entity.Property(e => e.EventId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("EventID");
            entity.Property(e => e.Face).HasDefaultValueSql("'0'");
            entity.Property(e => e.Guia).HasMaxLength(15);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Surface).HasMaxLength(6);
            entity.Property(e => e.Tooth)
                .HasMaxLength(2)
                .IsFixedLength();
        });

        modelBuilder.Entity<Apevent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("apevents");

            entity.HasIndex(e => e.ChangedOn, "ChangedOn");

            entity.HasIndex(e => new { e.EventCode, e.StartDate }, "EventCodeStartDate");

            entity.HasIndex(e => new { e.EventCode, e.StartDate, e.RecallFlag }, "EventCodeStartDateRecall");

            entity.HasIndex(e => e.LabCaseId, "LabCaseID");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.EventKind, e.StartDate }, "idx_ItemKind");

            entity.HasIndex(e => e.RecurrenceId, "idx_RecurrenceID");

            entity.HasIndex(e => e.ResourceId, "idx_ResourceID");

            entity.Property(e => e.EventId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("EventID");
            entity.Property(e => e.AlarmFileName).HasMaxLength(50);
            entity.Property(e => e.AlarmLeadIndex).HasDefaultValueSql("'0'");
            entity.Property(e => e.AlarmMsg).HasColumnType("text");
            entity.Property(e => e.ArrivedTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Attachments).HasColumnType("text");
            entity.Property(e => e.BackColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.CategoryId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryIndex).HasDefaultValueSql("'0'");
            entity.Property(e => e.ChangedOn)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Contact).HasMaxLength(25);
            entity.Property(e => e.CreatedBy).HasMaxLength(15);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime");
            entity.Property(e => e.DismissedTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.DueDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.EventCode).HasDefaultValueSql("'0'");
            entity.Property(e => e.EventType).HasDefaultValueSql("'0'");
            entity.Property(e => e.EventTypeName).HasMaxLength(32);
            entity.Property(e => e.ExceptionFields).HasColumnType("text");
            entity.Property(e => e.FontColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.FontName).HasMaxLength(20);
            entity.Property(e => e.FontStyle).HasMaxLength(10);
            entity.Property(e => e.IconImage).HasColumnType("blob");
            entity.Property(e => e.LabCaseId).HasColumnName("LabCaseID");
            entity.Property(e => e.Location).HasMaxLength(75);
            entity.Property(e => e.Matrix).HasMaxLength(255);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OwnedBy).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(15);
            entity.Property(e => e.ReadOnly).HasDefaultValueSql("'0'");
            entity.Property(e => e.RecallFlag)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.RecurrenceId)
                .HasMaxLength(36)
                .HasColumnName("RecurrenceID");
            entity.Property(e => e.ReminderDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.ReminderTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.SeatedTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.ShareId)
                .HasMaxLength(36)
                .HasColumnName("ShareID");
            entity.Property(e => e.ShowTimeAs).HasMaxLength(15);
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(75);
            entity.Property(e => e.UpdatedBy).HasMaxLength(15);
            entity.Property(e => e.Visible).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Apeventrecur>(entity =>
        {
            entity.HasKey(e => e.RecurrenceId).HasName("PRIMARY");

            entity.ToTable("apeventrecur");

            entity.HasIndex(e => e.EventId, "ActivityID");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.ShareId, "ShareID");

            entity.HasIndex(e => e.ResourceId, "idx_ResourceID");

            entity.Property(e => e.RecurrenceId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("RecurrenceID");
            entity.Property(e => e.AlarmFileName).HasMaxLength(50);
            entity.Property(e => e.AlarmLeadIndex).HasDefaultValueSql("'0'");
            entity.Property(e => e.AlarmMsg).HasColumnType("text");
            entity.Property(e => e.Attachments).HasColumnType("text");
            entity.Property(e => e.BackColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.CategoryId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryIndex).HasDefaultValueSql("'0'");
            entity.Property(e => e.Contact).HasMaxLength(25);
            entity.Property(e => e.CreatedBy).HasMaxLength(15);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime");
            entity.Property(e => e.DueDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.EventCode).HasMaxLength(10);
            entity.Property(e => e.EventId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("EventID");
            entity.Property(e => e.EventType).HasDefaultValueSql("'0'");
            entity.Property(e => e.EventTypeName).HasMaxLength(32);
            entity.Property(e => e.ExceptionFields).HasColumnType("text");
            entity.Property(e => e.FontName).HasMaxLength(20);
            entity.Property(e => e.FontStyle).HasMaxLength(10);
            entity.Property(e => e.IconImage).HasColumnType("blob");
            entity.Property(e => e.Location).HasMaxLength(75);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OwnedBy).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(15);
            entity.Property(e => e.RDuration).HasColumnName("R_Duration");
            entity.Property(e => e.REndDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("R_EndDate");
            entity.Property(e => e.RExceptDates)
                .HasColumnType("text")
                .HasColumnName("R_ExceptDates");
            entity.Property(e => e.RInterval).HasColumnName("R_Interval");
            entity.Property(e => e.RModifier)
                .HasMaxLength(21)
                .HasColumnName("R_Modifier");
            entity.Property(e => e.ROccurSpecifier)
                .HasMaxLength(10)
                .HasColumnName("R_OccurSpecifier");
            entity.Property(e => e.RRecurEndType).HasColumnName("R_RecurEndType");
            entity.Property(e => e.RRule).HasColumnName("R_Rule");
            entity.Property(e => e.RRuleType).HasColumnName("R_RuleType");
            entity.Property(e => e.RStartDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("R_StartDate");
            entity.Property(e => e.RStartOfWeek).HasColumnName("R_StartOfWeek");
            entity.Property(e => e.RWeekEndMove).HasColumnName("R_WeekEndMove");
            entity.Property(e => e.ReadOnly).HasDefaultValueSql("'0'");
            entity.Property(e => e.ReminderDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.ReminderTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.ShareId)
                .HasMaxLength(36)
                .HasColumnName("ShareID");
            entity.Property(e => e.ShowTimeAs).HasMaxLength(15);
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(75);
            entity.Property(e => e.Visible).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Apeventslog>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("apeventslog");

            entity.HasIndex(e => e.ChangedOn, "ChangedOn");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.ChangedOn)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.CreatedBy).HasMaxLength(15);
            entity.Property(e => e.DeletedDate).HasColumnType("date");
            entity.Property(e => e.DeletedId)
                .HasMaxLength(36)
                .HasColumnName("DeletedID");
            entity.Property(e => e.Details).HasColumnType("text");
            entity.Property(e => e.DueDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EndTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.EventCode).HasMaxLength(10);
            entity.Property(e => e.EventTypeName).HasMaxLength(15);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RecallFlag)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')");
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Subject).HasMaxLength(40);
            entity.Property(e => e.UpdatedId)
                .HasMaxLength(36)
                .HasColumnName("UpdatedID");
        });

        modelBuilder.Entity<Apmatrixm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("apmatrixm");

            entity.HasIndex(e => e.Caption, "CaptionIDX").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Caption).HasMaxLength(40);
            entity.Property(e => e.Mcolor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MColor");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Apmatrixt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("apmatrixt");

            entity.HasIndex(e => e.Caption, "CaptionIDX").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Caption).HasMaxLength(40);
            entity.Property(e => e.MatrixTmpl).HasMaxLength(100);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Approp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("approp");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.AlphaBlendValue).HasDefaultValueSql("'75'");
            entity.Property(e => e.AlphaBlending).HasDefaultValueSql("'1'");
            entity.Property(e => e.ApptShadow).HasDefaultValueSql("'1'");
            entity.Property(e => e.CalendarMonths).HasDefaultValueSql("'2'");
            entity.Property(e => e.CalendarMonthsD).HasDefaultValueSql("'1'");
            entity.Property(e => e.CompressWeekEnds).HasDefaultValueSql("'1'");
            entity.Property(e => e.DayBegins)
                .HasDefaultValueSql("'08:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.DayEnds)
                .HasDefaultValueSql("'20:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.EventHint).HasDefaultValueSql("'1'");
            entity.Property(e => e.GradientFill).HasDefaultValueSql("'1'");
            entity.Property(e => e.HideOffHrs).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinInterval).HasDefaultValueSql("'10'");
            entity.Property(e => e.NetRefresh)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.OffHrsColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PropertySeq).HasDefaultValueSql("'0'");
            entity.Property(e => e.ResourceTask).HasDefaultValueSql("'1'");
            entity.Property(e => e.RowHeight).HasDefaultValueSql("'18'");
            entity.Property(e => e.ShowAllTimeBars).HasDefaultValueSql("'0'");
            entity.Property(e => e.ShowHeader).HasDefaultValueSql("'0'");
            entity.Property(e => e.ShowResourceDate).HasDefaultValueSql("'1'");
            entity.Property(e => e.ShowStatusBar).HasDefaultValueSql("'1'");
            entity.Property(e => e.ShowTimeBlockText).HasDefaultValueSql("'1'");
            entity.Property(e => e.StartAtCurrentTime).HasDefaultValueSql("'1'");
            entity.Property(e => e.VisibleResources).HasDefaultValueSql("'3'");
            entity.Property(e => e.WeekendColorNoChange).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Apresource>(entity =>
        {
            entity.HasKey(e => e.ResourceId).HasName("PRIMARY");

            entity.ToTable("apresources");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Caption, "idx_Caption");

            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.ApptBufferTime).HasDefaultValueSql("'0'");
            entity.Property(e => e.Caption)
                .HasMaxLength(32)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ConflictingAppt).HasDefaultValueSql("'0'");
            entity.Property(e => e.DayBegins).HasColumnType("time");
            entity.Property(e => e.DayEnds).HasColumnType("time");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.TimeBlocks).HasColumnType("text");
        });

        modelBuilder.Entity<Aptimeblock>(entity =>
        {
            entity.HasKey(e => e.TimeBlockId).HasName("PRIMARY");

            entity.ToTable("aptimeblock");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.TimeBlockId, "TimeBlockID").IsUnique();

            entity.Property(e => e.TimeBlockId)
                .HasMaxLength(36)
                .HasDefaultValueSql("'0'")
                .HasColumnName("TimeBlockID");
            entity.Property(e => e.Caption).HasMaxLength(32);
            entity.Property(e => e.EndTime).HasColumnType("time");
            entity.Property(e => e.FontName).HasMaxLength(20);
            entity.Property(e => e.FontSize).HasDefaultValueSql("'0'");
            entity.Property(e => e.FontStyle).HasMaxLength(10);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RecurrenceId)
                .HasMaxLength(36)
                .HasColumnName("RecurrenceID");
            entity.Property(e => e.StartTime).HasColumnType("time");
        });

        modelBuilder.Entity<Aptimeblocklink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aptimeblocklinks");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.BlockCaption).HasMaxLength(32);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Resource).HasMaxLength(32);
        });

        modelBuilder.Entity<Apview>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.OfficeId }).HasName("PRIMARY");

            entity.ToTable("apviews");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Resources).HasColumnType("text");
            entity.Property(e => e.Sorted)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Atendim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("atendim");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Med }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Med).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Autoriza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("autoriza");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "idxPrimary").IsUnique();

            entity.Property(e => e.Autoriza1).HasColumnName("Autoriza");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Benplan>(entity =>
        {
            entity.HasKey(e => e.PlanId).HasName("PRIMARY");

            entity.ToTable("benplan");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.CalcFormula)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.Deductible)
                .HasMaxLength(3)
                .HasDefaultValueSql("'No'")
                .IsFixedLength();
            entity.Property(e => e.FromProc).HasMaxLength(6);
            entity.Property(e => e.MaxBenefit).HasPrecision(12);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PatDeductible).HasPrecision(12);
            entity.Property(e => e.PlanName)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Ppo)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')")
                .HasColumnName("PPO");
            entity.Property(e => e.ToProc).HasMaxLength(6);
        });

        modelBuilder.Entity<Benplancat>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.Category }).HasName("PRIMARY");

            entity.ToTable("benplancat");

            entity.HasIndex(e => e.CatSeq, "CatSeqKey").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.PlanId, e.FromRange, e.ThruRange }, "PlanIDFromThru");

            entity.Property(e => e.PlanId).HasColumnName("PlanID");
            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.CatSeq).ValueGeneratedOnAdd();
            entity.Property(e => e.Deductible)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.FromRange).HasMaxLength(6);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Percent).HasDefaultValueSql("'0'");
            entity.Property(e => e.ThruRange).HasMaxLength(6);
        });

        modelBuilder.Entity<Benplanext>(entity =>
        {
            entity.HasKey(e => e.PlanSeq).HasName("PRIMARY");

            entity.ToTable("benplanext");

            entity.HasIndex(e => new { e.PlanId, e.Code }, "Codeidx").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.AllowedAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Code)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Deductible)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Percent).HasDefaultValueSql("'0'");
            entity.Property(e => e.PlanId).HasColumnName("PlanID");
        });

        modelBuilder.Entity<Cabalt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cabalt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.TipoDoc, "idxPrimary").IsUnique();

            entity.Property(e => e.Lin1).HasMaxLength(80);
            entity.Property(e => e.Lin2).HasMaxLength(80);
            entity.Property(e => e.Lin3).HasMaxLength(80);
            entity.Property(e => e.Lin4).HasMaxLength(80);
            entity.Property(e => e.Lin5).HasMaxLength(80);
            entity.Property(e => e.Lin6).HasMaxLength(80);
            entity.Property(e => e.Lin7).HasMaxLength(80);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Ref)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.TipoDoc).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Ccorrente>(entity =>
        {
            entity.HasKey(e => new { e.TipDoc, e.Terc, e.DocPri }).HasName("PRIMARY");

            entity.ToTable("ccorrentes");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Dia, e.Anulado }, "idxBalance");

            entity.HasIndex(e => new { e.TipDoc, e.DocPri }, "idxDoc");

            entity.HasIndex(e => new { e.MovCaixa, e.Dia, e.TipDoc, e.DocPri }, "idxMovCaixa");

            entity.HasIndex(e => new { e.Terc, e.Dia }, "idxValCaixa");

            entity.Property(e => e.Anulado)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Dccaixa)
                .HasDefaultValueSql("'RecTrt'")
                .HasColumnType("enum('RecTrat','Debito','Credito','RecTrt','Debit','Credit')")
                .HasColumnName("DCCaixa");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.MovCaixa)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RelacionaTipo).HasDefaultValueSql("'0'");
            entity.Property(e => e.TipPag).HasDefaultValueSql("'0'");
            entity.Property(e => e.TipoNovo).HasDefaultValueSql("'0'");
            entity.Property(e => e.TipoOld).HasDefaultValueSql("'0'");
            entity.Property(e => e.Valor).HasPrecision(12);
            entity.Property(e => e.ValorPago).HasPrecision(12);
        });

        modelBuilder.Entity<Cell>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cell");

            entity.HasIndex(e => e.MobileCarrier, "CarrierName").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CellAuxAuto, "idxPrimary").IsUnique();

            entity.Property(e => e.CellAuxAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.EmailToText)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.MobileCarrier)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Checkintx>(entity =>
        {
            entity.HasKey(e => e.CheckinId).HasName("PRIMARY");

            entity.ToTable("checkintx");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.CheckinId).HasColumnName("CheckinID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ResetSecs).HasDefaultValueSql("'15'");
            entity.Property(e => e.SkinName).HasMaxLength(50);
            entity.Property(e => e.Text1).HasColumnType("text");
            entity.Property(e => e.Text1Color).HasDefaultValueSql("'0'");
            entity.Property(e => e.Text1Font)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Tahoma'");
            entity.Property(e => e.Text1Size).HasDefaultValueSql("'20'");
            entity.Property(e => e.Text2).HasColumnType("text");
            entity.Property(e => e.Text2Color).HasDefaultValueSql("'0'");
            entity.Property(e => e.Text2Font)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Tahoma'");
            entity.Property(e => e.Text2Size).HasDefaultValueSql("'20'");
            entity.Property(e => e.Text3).HasColumnType("text");
            entity.Property(e => e.Text3Color).HasDefaultValueSql("'0'");
            entity.Property(e => e.Text3Font)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Tahoma'");
            entity.Property(e => e.Text3Size).HasDefaultValueSql("'30'");
        });

        modelBuilder.Entity<Claim>(entity =>
        {
            entity.HasKey(e => new { e.ClaimId, e.InsSeq }).HasName("PRIMARY");

            entity.ToTable("claim");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.PatientNo, "PatientNo");

            entity.HasIndex(e => new { e.PatientNo, e.ClaimStatus }, "PatientStatus");

            entity.HasIndex(e => e.InsSeq, "PrimaryLink");

            entity.HasIndex(e => new { e.LastSubmitDate, e.PatientNo, e.ClaimType, e.ClaimStatus }, "SDatePacTypeStatus");

            entity.HasIndex(e => new { e.ClaimStatus, e.ClaimType }, "StatusTypeIDX");

            entity.HasIndex(e => new { e.NumGeral, e.NumOrc }, "idxTPlan");

            entity.Property(e => e.ClaimId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ClaimID");
            entity.Property(e => e.InsSeq)
                .HasDefaultValueSql("'Primary'")
                .HasColumnType("enum('Primary','Secondary','Additional')");
            entity.Property(e => e.AccidentDate).HasColumnType("date");
            entity.Property(e => e.AccidentState)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.AddAcceptAsgn)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.AddDiag1).HasMaxLength(10);
            entity.Property(e => e.AddDiag10).HasMaxLength(10);
            entity.Property(e => e.AddDiag11).HasMaxLength(10);
            entity.Property(e => e.AddDiag12).HasMaxLength(10);
            entity.Property(e => e.AddDiag2).HasMaxLength(10);
            entity.Property(e => e.AddDiag3).HasMaxLength(10);
            entity.Property(e => e.AddDiag4).HasMaxLength(10);
            entity.Property(e => e.AddDiag5).HasMaxLength(10);
            entity.Property(e => e.AddDiag6).HasMaxLength(10);
            entity.Property(e => e.AddDiag7).HasMaxLength(10);
            entity.Property(e => e.AddDiag8).HasMaxLength(10);
            entity.Property(e => e.AddDiag9).HasMaxLength(10);
            entity.Property(e => e.AddHospFrom)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.AddHospTo)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.AddI2address1)
                .HasMaxLength(30)
                .HasColumnName("AddI2Address1");
            entity.Property(e => e.AddI2address2)
                .HasMaxLength(30)
                .HasColumnName("AddI2Address2");
            entity.Property(e => e.AddI2city)
                .HasMaxLength(20)
                .HasColumnName("AddI2City");
            entity.Property(e => e.AddI2insType)
                .HasColumnType("enum('Dental','Medical')")
                .HasColumnName("AddI2InsType");
            entity.Property(e => e.AddI2name)
                .HasMaxLength(40)
                .HasColumnName("AddI2Name");
            entity.Property(e => e.AddI2state)
                .HasMaxLength(2)
                .HasColumnName("AddI2State");
            entity.Property(e => e.AddI2zip)
                .HasMaxLength(10)
                .HasColumnName("AddI2Zip");
            entity.Property(e => e.AddIcd)
                .HasMaxLength(1)
                .HasColumnName("AddICD");
            entity.Property(e => e.AddIllnessDt)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.AddInsLink).HasDefaultValueSql("'0'");
            entity.Property(e => e.AddInsPaid)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.AddLabCharges)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.AddMedicaid).HasMaxLength(15);
            entity.Property(e => e.AddMedicaidRef).HasMaxLength(15);
            entity.Property(e => e.AddNotWorkFrom)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.AddNotWorkTo)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.AddOutsideLab)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.AddPriorAuth).HasMaxLength(15);
            entity.Property(e => e.AddProvNpi)
                .HasMaxLength(10)
                .HasColumnName("AddProvNPI");
            entity.Property(e => e.AddQual11B).HasMaxLength(2);
            entity.Property(e => e.AddQual14).HasMaxLength(3);
            entity.Property(e => e.AddQual15).HasMaxLength(3);
            entity.Property(e => e.AddQual17).HasMaxLength(2);
            entity.Property(e => e.AddRefProvider).HasMaxLength(30);
            entity.Property(e => e.AddRelationIns).HasMaxLength(6);
            entity.Property(e => e.AddReserved1).HasMaxLength(20);
            entity.Property(e => e.AddReserved2).HasMaxLength(83);
            entity.Property(e => e.AddS2dob)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("AddS2DOB");
            entity.Property(e => e.AddS2employerName)
                .HasMaxLength(30)
                .HasColumnName("AddS2EmployerName");
            entity.Property(e => e.AddS2first)
                .HasMaxLength(15)
                .HasColumnName("AddS2First");
            entity.Property(e => e.AddS2groupNumber)
                .HasMaxLength(15)
                .HasColumnName("AddS2GroupNumber");
            entity.Property(e => e.AddS2insCardId)
                .HasMaxLength(15)
                .HasColumnName("AddS2InsCardID");
            entity.Property(e => e.AddS2last)
                .HasMaxLength(20)
                .HasColumnName("AddS2Last");
            entity.Property(e => e.AddS2middle)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("AddS2Middle");
            entity.Property(e => e.AddS2sex)
                .HasColumnType("enum('Male','Female','Unspecified')")
                .HasColumnName("AddS2Sex");
            entity.Property(e => e.AddSameIllnessDt)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.AdjAmount).HasPrecision(10);
            entity.Property(e => e.AttachmentId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("AttachmentID");
            entity.Property(e => e.BenAssign)
                .HasDefaultValueSql("'Provider'")
                .HasColumnType("enum('Provider','Patient')");
            entity.Property(e => e.ClaimStatus)
                .HasDefaultValueSql("'To Submit'")
                .HasColumnType("enum('To Submit','Submitted','Paid','Hold','Approved','Denied','Partial')");
            entity.Property(e => e.ClaimType)
                .HasDefaultValueSql("'Claim'")
                .HasColumnType("enum('Claim','PreAuth')");
            entity.Property(e => e.CreateMethod).HasMaxLength(4);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DateLastSrp)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("DateLastSRP");
            entity.Property(e => e.DoctorId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DoctorID");
            entity.Property(e => e.Enclosures).HasDefaultValueSql("'0'");
            entity.Property(e => e.EracheckNo)
                .HasMaxLength(30)
                .HasColumnName("ERACheckNo");
            entity.Property(e => e.Eralink)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ERALink");
            entity.Property(e => e.Eratext)
                .HasColumnType("mediumtext")
                .HasColumnName("ERAText");
            entity.Property(e => e.EstAdj).HasPrecision(10);
            entity.Property(e => e.EstValue)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Form).HasMaxLength(15);
            entity.Property(e => e.InsuranceId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID");
            entity.Property(e => e.LastSubmitDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.LocAddress1).HasMaxLength(30);
            entity.Property(e => e.LocAddress2).HasMaxLength(30);
            entity.Property(e => e.LocCity).HasMaxLength(20);
            entity.Property(e => e.LocName).HasMaxLength(30);
            entity.Property(e => e.LocNpi2)
                .HasMaxLength(15)
                .HasColumnName("LocNPI2");
            entity.Property(e => e.LocState)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.LocZip).HasMaxLength(10);
            entity.Property(e => e.MedClaimType).HasDefaultValueSql("'4'");
            entity.Property(e => e.Method)
                .HasDefaultValueSql("'Electronic'")
                .HasColumnType("enum('Electronic','Batch','Immediate')");
            entity.Property(e => e.Note).HasColumnType("tinytext");
            entity.Property(e => e.NumOrc).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Ortho)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.OrthoDate).HasColumnType("date");
            entity.Property(e => e.OrthoMonths).HasDefaultValueSql("'0'");
            entity.Property(e => e.OtheInsValue).HasPrecision(10);
            entity.Property(e => e.PaidAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PaidDate).HasColumnType("date");
            entity.Property(e => e.PatEstValue)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PlaceOfTrt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'11'")
                .IsFixedLength();
            entity.Property(e => e.PlanId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PlanID");
            entity.Property(e => e.PrimAuth).HasMaxLength(20);
            entity.Property(e => e.PrimAuthAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PrimAuthDate).HasColumnType("date");
            entity.Property(e => e.Prosthesis)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No','Initial')");
            entity.Property(e => e.ProsthesisDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.ProviderLocumTenens)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Remark1).HasMaxLength(50);
            entity.Property(e => e.Remark2).HasMaxLength(50);
            entity.Property(e => e.Remark3).HasMaxLength(50);
            entity.Property(e => e.Remark4).HasMaxLength(50);
            entity.Property(e => e.SecAuth).HasMaxLength(20);
            entity.Property(e => e.SecAuthAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.SecAuthDate).HasColumnType("date");
            entity.Property(e => e.SubmitValue)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.TrtResultOf).HasDefaultValueSql("'0'");
            entity.Property(e => e.UserNotes).HasColumnType("text");
        });

        modelBuilder.Entity<Claimpo>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PRIMARY");

            entity.ToTable("claimpos");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.LocationId)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("LocationID");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Claimtrt>(entity =>
        {
            entity.HasKey(e => e.ClaimTrtId).HasName("PRIMARY");

            entity.ToTable("claimtrt");

            entity.HasIndex(e => e.ClaimId, "ClaimID");

            entity.HasIndex(e => new { e.ClaimId, e.InsSeq }, "ClaimIDInsSeq");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.PatientNo, e.NumGeral, e.NumOrc }, "PacNumOrc");

            entity.HasIndex(e => e.PatientNo, "PatientNo");

            entity.HasIndex(e => new { e.PatientNo, e.ClaimStatus }, "PatientStatus");

            entity.Property(e => e.ClaimTrtId).HasColumnName("ClaimTrtID");
            entity.Property(e => e.AddEpsdt1)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("AddEPSDT1");
            entity.Property(e => e.AddEpsdt2)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("AddEPSDT2");
            entity.Property(e => e.AddSuplInfo).HasMaxLength(60);
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimStatus).HasDefaultValueSql("'1'");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DiagIndex).HasMaxLength(4);
            entity.Property(e => e.Emg)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("EMG");
            entity.Property(e => e.EstValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.InsSeq).HasDefaultValueSql("'0'");
            entity.Property(e => e.InsuranceId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID");
            entity.Property(e => e.LastSubmitDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Modifier).HasMaxLength(12);
            entity.Property(e => e.NumOrc).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OtheInsValue).HasPrecision(12);
            entity.Property(e => e.PlanId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PlanID");
            entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");
            entity.Property(e => e.SubmitValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Surface).HasDefaultValueSql("'0'");
            entity.Property(e => e.Tdate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("TDate");
            entity.Property(e => e.ToPrimary)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ToSecondary)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Tooth)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Trat).HasMaxLength(6);
            entity.Property(e => e.Units).HasMaxLength(3);
            entity.Property(e => e.Value).HasPrecision(12);
            entity.Property(e => e.ValueEnt).HasPrecision(12);
        });

        modelBuilder.Entity<Claimtxn>(entity =>
        {
            entity.HasKey(e => e.ClaimTxnId).HasName("PRIMARY");

            entity.ToTable("claimtxn");

            entity.HasIndex(e => e.ClaimId, "ClaimID");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.PatientNo, "PatientNo");

            entity.HasIndex(e => new { e.PatientNo, e.ClaimStatus }, "PatientStatus");

            entity.Property(e => e.ClaimTxnId).HasColumnName("ClaimTxnID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimStatus).HasDefaultValueSql("'1'");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DiagIndex).HasDefaultValueSql("'0'");
            entity.Property(e => e.EstValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.InsSeq).HasDefaultValueSql("'1'");
            entity.Property(e => e.InsuranceId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID");
            entity.Property(e => e.LastSubmitDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OtheInsValue).HasPrecision(12);
            entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");
            entity.Property(e => e.SubmitValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Surface).HasDefaultValueSql("'0'");
            entity.Property(e => e.Tdate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("TDate");
            entity.Property(e => e.Tooth)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Value).HasPrecision(12);
            entity.Property(e => e.ValueEnt).HasPrecision(12);
        });

        modelBuilder.Entity<Classfac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classfac");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodClassFac, "idxPrimary").IsUnique();

            entity.Property(e => e.CodClassFac).HasDefaultValueSql("'0'");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Classftt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classftt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodClassFac, e.CodTipoTrat }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodClassFac).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodTipoTrat).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Classif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classif");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodClass, "idxPrimary").IsUnique();

            entity.Property(e => e.CodClass).HasDefaultValueSql("'0'");
            entity.Property(e => e.NomeClass).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Classpac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classpac");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Classification }, "idxPrimary").IsUnique();

            entity.Property(e => e.Classification).HasMaxLength(25);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Classtent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classtent");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodEnt, e.TrtPro, e.CodTipo }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodEnt).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodTipo).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TrtPro).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Classtrc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classtrc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.GenTrc, "idxPrimary").IsUnique();

            entity.Property(e => e.ClassTerc).HasMaxLength(40);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoCliente)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Clinica>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("clinica");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Cod, "idxPrimary").IsUnique();

            entity.Property(e => e.Address1).HasMaxLength(30);
            entity.Property(e => e.Address2).HasMaxLength(30);
            entity.Property(e => e.Blk)
                .HasMaxLength(20)
                .HasColumnName("BLK");
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Clinica1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("Clinica");
            entity.Property(e => e.Cod).HasDefaultValueSql("'0'");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("EMail");
            entity.Property(e => e.ExternalIp)
                .HasMaxLength(60)
                .HasColumnName("ExternalIP");
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.Lin1).HasMaxLength(100);
            entity.Property(e => e.Lin2).HasMaxLength(100);
            entity.Property(e => e.Lin3).HasMaxLength(100);
            entity.Property(e => e.Lin4).HasMaxLength(100);
            entity.Property(e => e.Lin5).HasMaxLength(100);
            entity.Property(e => e.Lin6).HasMaxLength(100);
            entity.Property(e => e.Multiclinica)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Products).HasMaxLength(200);
            entity.Property(e => e.Pt)
                .HasMaxLength(20)
                .HasColumnName("PT");
            entity.Property(e => e.Ref).HasMaxLength(40);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UserLimit).HasDefaultValueSql("'1'");
            entity.Property(e => e.WebAddress).HasMaxLength(150);
            entity.Property(e => e.Zip).HasMaxLength(10);
        });

        modelBuilder.Entity<Comissao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("comissao");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.TipoComissao, e.TipoClinico }, "idxPrimary").IsUnique();

            entity.Property(e => e.Comissao1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("Comissao");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoClinico).HasDefaultValueSql("'0'");
            entity.Property(e => e.TipoComissao).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Comportamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("comportamentos");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodComp, "idxprimary").IsUnique();

            entity.Property(e => e.CodComp).HasDefaultValueSql("'0'");
            entity.Property(e => e.Comportamento1)
                .HasMaxLength(30)
                .HasColumnName("Comportamento");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Confpa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("confpa");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.KeyPa, "idxprimary").IsUnique();

            entity.Property(e => e.KeyPa)
                .ValueGeneratedOnAdd()
                .HasColumnName("KeyPA");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PasswA)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PRIMARY");

            entity.ToTable("contracts");

            entity.HasIndex(e => e.NextDueDate, "NextDueDateIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.AmountBilled)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.CompletedCycles).HasDefaultValueSql("'0'");
            entity.Property(e => e.Cycle).HasDefaultValueSql("'1'");
            entity.Property(e => e.CycleAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DownPayment)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.NextDueDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.NumberOfCycles).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.RemainingAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Trat).HasMaxLength(6);
        });

        modelBuilder.Entity<Contractext>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contractext");

            entity.HasIndex(e => e.ContractId, "ContractID");

            entity.HasIndex(e => new { e.DueDates, e.ContractId }, "DueDatesIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ContractId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ContractID");
            entity.Property(e => e.CycleAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.DueDates)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Contractexto>(entity =>
        {
            entity.HasKey(e => e.AuxAutoExt).HasName("PRIMARY");

            entity.ToTable("contractexto");

            entity.HasIndex(e => new { e.ContractId, e.ContractKind }, "ContractID");

            entity.HasIndex(e => new { e.DueDate, e.ContractId }, "DueDatesIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.AuxAutoTrt).HasDefaultValueSql("'0'");
            entity.Property(e => e.Billed)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.BilledDate).HasColumnType("date");
            entity.Property(e => e.ClaimId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ClaimID");
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.ContractKind).HasDefaultValueSql("'0'");
            entity.Property(e => e.CycleAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.PaidAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PaidDate).HasColumnType("date");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.Trat).HasMaxLength(6);
        });

        modelBuilder.Entity<Contractshdr>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PRIMARY");

            entity.ToTable("contractshdr");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.ContractId, e.Pac }, "PacIDX");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OrthoDate).HasColumnType("date");
            entity.Property(e => e.OrthoMonths).HasDefaultValueSql("'0'");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<Contractso>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.Pac, e.ContractKind }).HasName("PRIMARY");

            entity.ToTable("contractso");

            entity.HasIndex(e => e.NextDueDate, "NextDueDateIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.AmountBilled)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.CompletedCycles).HasDefaultValueSql("'0'");
            entity.Property(e => e.ContractAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.CycleAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DownPayment)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.MonthsPerCycle).HasDefaultValueSql("'1'");
            entity.Property(e => e.NextDueDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.NumberOfCycles).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.RemainingAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Trat).HasMaxLength(6);
        });

        modelBuilder.Entity<Cormaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cormaterial");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RefTipo, "idxPrimary").IsUnique();

            entity.Property(e => e.CorMat)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RefTipo).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Counttf>(entity =>
        {
            entity.HasKey(e => e.AuxAutoCountTf).HasName("PRIMARY");

            entity.ToTable("counttf");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Cpostal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cpostal");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Cpcod, "idxPrimary").IsUnique();

            entity.Property(e => e.Cpcod)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CPCod");
            entity.Property(e => e.Cpnome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("CPNome");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<CustomizedStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("customized_status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Defdoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("defdocs");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.TipoDef, e.Cod }, "idxPrimary").IsUnique();

            entity.Property(e => e.CabAlternativo)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Cod).HasDefaultValueSql("'0'");
            entity.Property(e => e.CreCaixaCli)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("CreCaixa_Cli");
            entity.Property(e => e.CreCaixaFor)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("CreCaixa_For");
            entity.Property(e => e.CreCcCli)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("CreCC_Cli");
            entity.Property(e => e.CreCcFor)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("CreCC_For");
            entity.Property(e => e.DebCaixaCli)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("DebCaixa_Cli");
            entity.Property(e => e.DebCaixaFor)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("DebCaixa_For");
            entity.Property(e => e.DebCcCli)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("DebCC_Cli");
            entity.Property(e => e.DebCcFor)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("DebCC_For");
            entity.Property(e => e.DebCreCaixa)
                .HasDefaultValueSql("'RecTrt'")
                .HasColumnType("enum('RecTrat','Debito','Credito','RecTrt','Debit','Credit')");
            entity.Property(e => e.Impressao)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.ImprimeCab)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.ImprimeLogo)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.MovCaixa)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NomeImp)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Portrait)
                .HasDefaultValueSql("'Vertical'")
                .HasColumnType("enum('Vertical','Horizontal')");
            entity.Property(e => e.Rodape)
                .HasMaxLength(250)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Rodape2)
                .HasMaxLength(250)
                .HasDefaultValueSql("''");
            entity.Property(e => e.TipoDef)
                .HasDefaultValueSql("'Pacientes'")
                .HasColumnType("enum('Pacientes','Terceiros')");
            entity.Property(e => e.TipoEcran)
                .HasDefaultValueSql("'Treatments'")
                .HasColumnType("enum('Tratamentos','Notas de Lançamento','Treatments','Free')");
        });

        modelBuilder.Entity<Dfmdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dfmdata");

            entity.HasIndex(e => new { e.Pac, e.CreateDate, e.GroupName, e.ValueName }, "DateGroupValueName").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.ChangeDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DisplayKind).HasMaxLength(30);
            entity.Property(e => e.DisplayText).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.Tag).HasMaxLength(30);
            entity.Property(e => e.Value).HasMaxLength(40);
            entity.Property(e => e.ValueName).HasMaxLength(40);
        });

        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("diagnosis");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.TypeDiagnosis)
                .HasDefaultValueSql("''")
                .HasColumnType("enum('','ICD-10','SNODENT')")
                .HasColumnName("type_diagnosis");
        });

        modelBuilder.Entity<DiagnosisTabelat>(entity =>
        {
            entity.HasKey(e => new { e.CodT, e.DiagnosisId }).HasName("PRIMARY");

            entity.ToTable("diagnosis_tabelat");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.CodT)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.DiagnosisId).HasColumnName("diagnosis_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Dochist>(entity =>
        {
            entity.HasKey(e => e.Auxauto).HasName("PRIMARY");

            entity.ToTable("dochist");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.Auxauto).HasColumnName("auxauto");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Description).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Doclin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("doclin");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.AuxAutoInc, "idxAux").IsUnique();

            entity.HasIndex(e => new { e.Entid, e.Dia }, "idxEntDia");

            entity.HasIndex(e => new { e.Clinico, e.Dia, e.Entid }, "idxFacCli");

            entity.HasIndex(e => new { e.Anul, e.FacEnt, e.Entid, e.DiaTrt }, "idxFacEnt");

            entity.HasIndex(e => new { e.TipDoc, e.Ndoc }, "idxNumDoc");

            entity.HasIndex(e => new { e.Terc, e.CodTt, e.Entid, e.DiaTrt, e.Dente }, "idxRelacionaTrt");

            entity.HasIndex(e => new { e.TipDoc, e.Terc, e.Ndoc }, "idxTDoc");

            entity.Property(e => e.Anul)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Assinado)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.AuxAutoInc).ValueGeneratedOnAdd();
            entity.Property(e => e.Benef)
                .HasMaxLength(15)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Clinico).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodTt)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .HasColumnName("CodTT");
            entity.Property(e => e.Deb)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.DescLin)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DiaTrt)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Entid).HasDefaultValueSql("'0'");
            entity.Property(e => e.Guia)
                .HasMaxLength(15)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Ndoc).HasColumnName("NDoc");
            entity.Property(e => e.NguiaTt).HasColumnName("NGuiaTT");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipDoc).HasDefaultValueSql("'0'");
            entity.Property(e => e.ValEnt).HasPrecision(12);
            entity.Property(e => e.ValPac).HasPrecision(12);
        });

        modelBuilder.Entity<Dspecialty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dspecialty");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodEsp, "idxPrimary").IsUnique();

            entity.Property(e => e.CodEsp).ValueGeneratedOnAdd();
            entity.Property(e => e.Icon).HasColumnType("blob");
            entity.Property(e => e.NomeEsp)
                .HasMaxLength(35)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProvType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SpCode).HasMaxLength(10);
        });

        modelBuilder.Entity<Employer>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PRIMARY");

            entity.ToTable("employer");

            entity.HasIndex(e => e.Code, "Code").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.Address1).HasMaxLength(30);
            entity.Property(e => e.Address2).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Contact).HasMaxLength(25);
            entity.Property(e => e.Fax)
                .HasMaxLength(10)
                .HasColumnName("FAX");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Zip).HasMaxLength(9);
        });

        modelBuilder.Entity<Endo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("endo");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dente, e.Dia, e.Raiz }, "idxDente");

            entity.HasIndex(e => new { e.Pac, e.InicialTrat, e.Dente, e.Dia, e.Raiz }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.InicialTrat)
                .HasDefaultValueSql("'Trt'")
                .HasColumnType("enum('Inic','Trat','Init','Trt')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Raiz)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Valores)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<Endomat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("endomat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dente, e.Dia, e.Provisorio, e.CodMat }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodMat)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Provisorio)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Endoob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("endoobs");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dente, e.Dia }, "idxPrimay").IsUnique();

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.LesApical)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.MedApical)
                .HasMaxLength(50)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Obs).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Endositu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("endositu");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.InicialTrat, e.Dente }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.InicialTrat)
                .HasDefaultValueSql("'Inic'")
                .HasColumnType("enum('Inic','Trat','Init','Trt')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Entidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("entidades");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Ecod, "idxPrimary").IsUnique();

            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Contact).HasMaxLength(25);
            entity.Property(e => e.Eabrevia)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("EAbrevia");
            entity.Property(e => e.Eacordo)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EAcordo");
            entity.Property(e => e.EaltVal)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EAltVal");
            entity.Property(e => e.EaskGuia)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EAskGuia");
            entity.Property(e => e.EbenefNum)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EBenefNum");
            entity.Property(e => e.Ecab1)
                .HasMaxLength(50)
                .HasColumnName("ECab1");
            entity.Property(e => e.Ecab2)
                .HasMaxLength(50)
                .HasColumnName("ECab2");
            entity.Property(e => e.Ecab3)
                .HasMaxLength(50)
                .HasColumnName("ECab3");
            entity.Property(e => e.Ecampo1)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo1");
            entity.Property(e => e.Ecampo10)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo10");
            entity.Property(e => e.Ecampo2)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo2");
            entity.Property(e => e.Ecampo3)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo3");
            entity.Property(e => e.Ecampo4)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo4");
            entity.Property(e => e.Ecampo5)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo5");
            entity.Property(e => e.Ecampo6)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo6");
            entity.Property(e => e.Ecampo7)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo7");
            entity.Property(e => e.Ecampo8)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo8");
            entity.Property(e => e.Ecampo9)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECampo9");
            entity.Property(e => e.EcbF1)
                .HasMaxLength(80)
                .HasColumnName("ECbF1");
            entity.Property(e => e.EcbF2)
                .HasMaxLength(80)
                .HasColumnName("ECbF2");
            entity.Property(e => e.EcbF3)
                .HasMaxLength(80)
                .HasColumnName("ECbF3");
            entity.Property(e => e.EcbF4)
                .HasMaxLength(80)
                .HasColumnName("ECbF4");
            entity.Property(e => e.EcbF5)
                .HasMaxLength(80)
                .HasColumnName("ECbF5");
            entity.Property(e => e.EcbF6)
                .HasMaxLength(80)
                .HasColumnName("ECbF6");
            entity.Property(e => e.EcbF7)
                .HasMaxLength(80)
                .HasColumnName("ECbF7");
            entity.Property(e => e.Ecod)
                .ValueGeneratedOnAdd()
                .HasColumnName("ECod");
            entity.Property(e => e.EcodPclinica)
                .HasMaxLength(10)
                .HasColumnName("ECodPClinica");
            entity.Property(e => e.EcodPent)
                .HasMaxLength(10)
                .HasColumnName("ECodPEnt");
            entity.Property(e => e.EcodProt)
                .HasMaxLength(20)
                .HasColumnName("ECodProt");
            entity.Property(e => e.EcodTrat)
                .HasMaxLength(20)
                .HasColumnName("ECodTrat");
            entity.Property(e => e.Econtribuinte)
                .HasMaxLength(20)
                .HasColumnName("EContribuinte");
            entity.Property(e => e.EctrlValor)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ECtrlValor");
            entity.Property(e => e.EfacPreDef)
                .HasMaxLength(10)
                .HasColumnName("EFacPreDef");
            entity.Property(e => e.Efax)
                .HasMaxLength(15)
                .HasColumnName("EFax");
            entity.Property(e => e.EfchFac)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EFchFac");
            entity.Property(e => e.Eformul)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EFormul");
            entity.Property(e => e.Egt1)
                .HasMaxLength(50)
                .HasColumnName("EGT1");
            entity.Property(e => e.Egt2)
                .HasMaxLength(50)
                .HasColumnName("EGT2");
            entity.Property(e => e.Egt3)
                .HasMaxLength(50)
                .HasColumnName("EGT3");
            entity.Property(e => e.Egt4)
                .HasMaxLength(50)
                .HasColumnName("EGT4");
            entity.Property(e => e.Egt5)
                .HasMaxLength(50)
                .HasColumnName("EGT5");
            entity.Property(e => e.Egt6)
                .HasMaxLength(50)
                .HasColumnName("EGT6");
            entity.Property(e => e.Egtseq).HasColumnName("EGTSeq");
            entity.Property(e => e.Egtvias).HasColumnName("EGTVias");
            entity.Property(e => e.EguiaTrt)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EGuiaTrt");
            entity.Property(e => e.ElocEnt)
                .HasMaxLength(40)
                .HasColumnName("ELocEnt");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("EMail");
            entity.Property(e => e.EmesesVmax).HasColumnName("EMesesVMax");
            entity.Property(e => e.EmoradaClinica)
                .HasMaxLength(40)
                .HasColumnName("EMoradaClinica");
            entity.Property(e => e.EmoradaEnt)
                .HasMaxLength(40)
                .HasColumnName("EMoradaEnt");
            entity.Property(e => e.Enome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("ENome");
            entity.Property(e => e.EnomeClinica)
                .HasMaxLength(40)
                .HasColumnName("ENomeClinica");
            entity.Property(e => e.EnomeFfac)
                .HasMaxLength(128)
                .HasColumnName("ENomeFFac");
            entity.Property(e => e.Eobs)
                .HasColumnType("tinytext")
                .HasColumnName("EObs");
            entity.Property(e => e.Eord1).HasColumnName("EOrd1");
            entity.Property(e => e.Eord10).HasColumnName("EOrd10");
            entity.Property(e => e.Eord2).HasColumnName("EOrd2");
            entity.Property(e => e.Eord3).HasColumnName("EOrd3");
            entity.Property(e => e.Eord4).HasColumnName("EOrd4");
            entity.Property(e => e.Eord5).HasColumnName("EOrd5");
            entity.Property(e => e.Eord6).HasColumnName("EOrd6");
            entity.Property(e => e.Eord7).HasColumnName("EOrd7");
            entity.Property(e => e.Eord8).HasColumnName("EOrd8");
            entity.Property(e => e.Eord9).HasColumnName("EOrd9");
            entity.Property(e => e.EtamCmp1).HasColumnName("ETamCmp1");
            entity.Property(e => e.EtamCmp10).HasColumnName("ETamCmp10");
            entity.Property(e => e.EtamCmp2).HasColumnName("ETamCmp2");
            entity.Property(e => e.EtamCmp3).HasColumnName("ETamCmp3");
            entity.Property(e => e.EtamCmp4).HasColumnName("ETamCmp4");
            entity.Property(e => e.EtamCmp5).HasColumnName("ETamCmp5");
            entity.Property(e => e.EtamCmp6).HasColumnName("ETamCmp6");
            entity.Property(e => e.EtamCmp7).HasColumnName("ETamCmp7");
            entity.Property(e => e.EtamCmp8).HasColumnName("ETamCmp8");
            entity.Property(e => e.EtamCmp9).HasColumnName("ETamCmp9");
            entity.Property(e => e.Etelef)
                .HasMaxLength(15)
                .HasColumnName("ETelef");
            entity.Property(e => e.EusaCabAlt)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("EUsaCabAlt");
            entity.Property(e => e.EvalMax)
                .HasPrecision(12)
                .HasColumnName("EValMax");
            entity.Property(e => e.Evias).HasColumnName("EVias");
            entity.Property(e => e.FormType)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ADA2018'");
            entity.Property(e => e.InsType)
                .HasDefaultValueSql("'Dental'")
                .HasColumnType("enum('Dental','Medical')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PayerId)
                .HasMaxLength(15)
                .HasColumnName("PayerID");
            entity.Property(e => e.PayerOffice).HasMaxLength(15);
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.SubmissionType)
                .HasMaxLength(15)
                .HasDefaultValueSql("'Electronic'");
            entity.Property(e => e.WebAddress).HasMaxLength(40);
        });

        modelBuilder.Entity<EnvConnection>(entity =>
        {
            entity.HasKey(e => e.Address).HasName("PRIMARY");

            entity.ToTable("env_connections");

            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("address");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.UserId)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Era>(entity =>
        {
            entity.HasKey(e => e.EraAuxAuto).HasName("PRIMARY");

            entity.ToTable("era");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.EraCheckNo)
                .HasMaxLength(30)
                .HasComment("For Orphan Payements");
            entity.Property(e => e.EraText).HasColumnType("mediumtext");
            entity.Property(e => e.Eralink)
                .HasDefaultValueSql("'0'")
                .HasComment("For Orphan Payements")
                .HasColumnName("ERALink");
            entity.Property(e => e.ErapayAmount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'")
                .HasComment("For Orphan Payements")
                .HasColumnName("ERAPayAmount");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
        });

        modelBuilder.Entity<Era1>(entity =>
        {
            entity.HasKey(e => e.Idera).HasName("PRIMARY");

            entity.ToTable("eras");

            entity.Property(e => e.Idera).HasColumnName("idera");
            entity.Property(e => e.Carrier)
                .HasMaxLength(30)
                .HasColumnName("carrier");
            entity.Property(e => e.Eradate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("eradate");
            entity.Property(e => e.Eraid).HasColumnName("eraid");
            entity.Property(e => e.Eranum)
                .HasMaxLength(30)
                .HasColumnName("eranum");
            entity.Property(e => e.Etext)
                .HasColumnType("mediumtext")
                .HasColumnName("etext");
            entity.Property(e => e.Payamount)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("payamount");
            entity.Property(e => e.Paymethod)
                .HasMaxLength(30)
                .HasColumnName("paymethod");
        });

        modelBuilder.Entity<ErasText>(entity =>
        {
            entity.HasKey(e => e.Idera).HasName("PRIMARY");

            entity.ToTable("eras_texts");

            entity.Property(e => e.Idera).HasColumnName("idera");
            entity.Property(e => e.Text)
                .HasColumnType("mediumtext")
                .HasColumnName("text");
        });

        modelBuilder.Entity<Especdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("especdata");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodEspec, e.Mecano, e.CodGrupo, e.CodGrupoQuest, e.CodQuest }, "idxMecano");

            entity.HasIndex(e => new { e.CodEspec, e.CodGrupo, e.CodGrupoQuest, e.CodQuest, e.Mecano }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodEspec).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodGrupo).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodGrupoQuest).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodQuest).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Texto).HasColumnType("text");
            entity.Property(e => e.Tipo)
                .HasDefaultValueSql("'Check'")
                .HasColumnType("enum('Check','Memo')");
        });

        modelBuilder.Entity<Especgrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("especgrupos");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodEspec, e.CodGrupo, e.CodSubGrupo }, "idxprimary").IsUnique();

            entity.Property(e => e.CodEspec).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodGrupo).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodSubGrupo).HasDefaultValueSql("'0'");
            entity.Property(e => e.Descricao).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ShowNumbers)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Especialidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("especialidades");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodEsp, "idxPrimary").IsUnique();

            entity.Property(e => e.CodEsp).HasDefaultValueSql("'0'");
            entity.Property(e => e.Icon).HasColumnType("blob");
            entity.Property(e => e.NomeEsp)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProvType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SpCode).HasMaxLength(10);
        });

        modelBuilder.Entity<Especquest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("especquest");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodEspec, e.CodGrupo, e.CodGrupoTitulo, e.CodTitulo }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodEspec).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodGrupo).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodGrupoTitulo).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodSubGrupo).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodTitulo).HasDefaultValueSql("'0'");
            entity.Property(e => e.LinesTxt).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Question).HasMaxLength(150);
            entity.Property(e => e.QuestionBold)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Tipo)
                .HasDefaultValueSql("'Texto'")
                .HasColumnType("enum('Texto','Pergunta','SubGrupo')");
        });

        modelBuilder.Entity<Falta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("faltas");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Medico, e.Dia, e.Hora, e.FaltaCancela }, "idxDia");

            entity.HasIndex(e => new { e.Mecano, e.FaltaCancela, e.Dia, e.Hora }, "idxMecano");

            entity.HasIndex(e => new { e.Medico, e.Mecano, e.Dia, e.Hora, e.FaltaCancela }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.FaltaCancela)
                .HasDefaultValueSql("'Failed'")
                .HasColumnType("enum('Falta','Cancela','Failed','Canceled')");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Marcacao)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Obs)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Familia1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("familia1");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodFam1, "idxPrimary").IsUnique();

            entity.Property(e => e.CodFam1).HasDefaultValueSql("'0'");
            entity.Property(e => e.Descricao).HasMaxLength(40);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Familia2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("familia2");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodFam1, e.CodFam2 }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodFam1).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodFam2).HasDefaultValueSql("'0'");
            entity.Property(e => e.Descricao).HasMaxLength(40);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Familia3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("familia3");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.CodFam1, e.CodFam2, e.CodFam3 }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodFam1).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodFam2).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodFam3).HasDefaultValueSql("'0'");
            entity.Property(e => e.Descricao).HasMaxLength(40);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<FeeSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("fee_schedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FeeName)
                .HasMaxLength(255)
                .HasColumnName("fee_name");
        });

        modelBuilder.Entity<FeeScheduleItem>(entity =>
        {
            entity.HasKey(e => new { e.FeeId, e.CodT }).HasName("PRIMARY");

            entity.ToTable("fee_schedule_items");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.FeeId).HasColumnName("fee_id");
            entity.Property(e => e.CodT)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.FeeValue)
                .HasPrecision(12)
                .HasColumnName("fee_value");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Feria>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ferias");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Medico, e.Inicio, e.Fim }, "idxPrimary").IsUnique();

            entity.Property(e => e.Fim)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Inicio)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Obs)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Feriado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("feriados");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Dia, e.Anual }, "idxPrimary").IsUnique();

            entity.Property(e => e.Anual)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Feriado1)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("Feriado");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Fieldsdescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fieldsdescription");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.FileName, e.FieldName }, "idxPrimary").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(96)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FieldCalc).HasMaxLength(80);
            entity.Property(e => e.FieldName)
                .HasMaxLength(32)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FileName)
                .HasMaxLength(32)
                .HasDefaultValueSql("''");
            entity.Property(e => e.JoinAux)
                .HasMaxLength(128)
                .HasDefaultValueSql("''");
            entity.Property(e => e.JoinField).HasMaxLength(128);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Filesreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("filesreports");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Descricao, "idxDescr");

            entity.HasIndex(e => e.Ficheiro, "idxPrimary").IsUnique();

            entity.Property(e => e.Descricao)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Ficheiro)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Fobra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fobra");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Fdia, e.Ftipo, e.Fclinico }, "idxDia");

            entity.HasIndex(e => new { e.Fpac, e.Fobra1, e.Ftipo, e.Fdia, e.Fref }, "idxPrimary").IsUnique();

            entity.Property(e => e.Fclinico)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("FClinico");
            entity.Property(e => e.Fdesc)
                .HasMaxLength(100)
                .HasColumnName("FDesc");
            entity.Property(e => e.Fdev).HasColumnName("FDev");
            entity.Property(e => e.Fdia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("FDia");
            entity.Property(e => e.Fiva)
                .HasPrecision(10)
                .HasColumnName("FIva");
            entity.Property(e => e.Flaboratorio)
                .HasMaxLength(20)
                .HasColumnName("FLaboratorio");
            entity.Property(e => e.Fmarca)
                .HasMaxLength(20)
                .HasColumnName("FMarca");
            entity.Property(e => e.Fobra1).HasColumnName("FObra");
            entity.Property(e => e.FoperDev).HasColumnName("FOperDev");
            entity.Property(e => e.FoperEnt).HasColumnName("FOperEnt");
            entity.Property(e => e.Fpac).HasColumnName("FPac");
            entity.Property(e => e.Fpreco)
                .HasPrecision(12)
                .HasColumnName("FPreco");
            entity.Property(e => e.Fquant).HasColumnName("FQuant");
            entity.Property(e => e.Fref)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("FRef");
            entity.Property(e => e.Ftipo).HasColumnName("FTipo");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Fobrasum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fobrasum");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Obra }, "idxPrimary").IsUnique();

            entity.Property(e => e.Concluida).HasColumnType("date");
            entity.Property(e => e.Coordena).HasMaxLength(60);
            entity.Property(e => e.Debitada).HasColumnType("date");
            entity.Property(e => e.DescTratamento).HasMaxLength(60);
            entity.Property(e => e.Iniciada).HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Fobratrt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fobratrt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Fobra, e.Dia, e.Medico }, "idxDia");

            entity.HasIndex(e => new { e.Pac, e.Trat, e.Dia, e.Dente, e.Medico, e.Entidade }, "idxFacClinico");

            entity.HasIndex(e => new { e.Pac, e.Fobra, e.Dia }, "idxFace");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Trat, e.Hora, e.Inicial }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Especialidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Fobra).HasColumnName("FObra");
            entity.Property(e => e.Guia).HasMaxLength(10);
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Inicial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity.HasKey(e => e.GoalAuxAuto).HasName("PRIMARY");

            entity.ToTable("goals");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.ResourceId, e.GoalDate }, "ResourceDateIX").IsUnique();

            entity.Property(e => e.GoalDate).HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
        });

        modelBuilder.Entity<Implante>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("implantes");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.CodImpl, e.Dnt }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dnt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.MatCoroa).HasMaxLength(12);
            entity.Property(e => e.Obs).HasMaxLength(50);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RegOssea).HasDefaultValueSql("'0'");
            entity.Property(e => e.TipoImpl).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Implantecm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("implantecm");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.NumImplante, e.Dnt, e.Dia }, "idxPrimary").IsUnique();

            entity.Property(e => e.Bolsas).HasMaxLength(10);
            entity.Property(e => e.CicatrizaObs).HasColumnType("mediumtext");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Dnt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Estabilidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.HigLimpezaObs).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Inkchart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("inkchart");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "Pac").IsUnique();

            entity.Property(e => e.InkStrokes).HasColumnType("mediumblob");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Inkedform>(entity =>
        {
            entity.HasKey(e => e.InkedAuxAuto).HasName("PRIMARY");

            entity.ToTable("inkedform");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.InkFormId, "idxInkFormID");

            entity.HasIndex(e => e.Pac, "idxPac");

            entity.HasIndex(e => new { e.Pac, e.Stage }, "idxPacStage");

            entity.HasIndex(e => e.ParentId, "idxParentID");

            entity.Property(e => e.Caption)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Dfm).HasColumnName("DFM");
            entity.Property(e => e.FormLocation).HasColumnType("text");
            entity.Property(e => e.Htmlfm).HasColumnName("HTMLFM");
            entity.Property(e => e.InkFormId).HasColumnName("InkFormID");
            entity.Property(e => e.Location)
                .HasDefaultValueSql("'General'")
                .HasColumnType("enum('Clinical','Patient','General')");
            entity.Property(e => e.Locked)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PageOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Stage).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Inkformpd>(entity =>
        {
            entity.HasKey(e => e.InkFormId).HasName("PRIMARY");

            entity.ToTable("inkformpd");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.InkFormId).HasColumnName("InkFormID");
            entity.Property(e => e.Caption)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Dfm).HasColumnName("DFM");
            entity.Property(e => e.FormLocation).HasColumnType("text");
            entity.Property(e => e.Htmlfm).HasColumnName("HTMLFM");
            entity.Property(e => e.Location)
                .HasDefaultValueSql("'General'")
                .HasColumnType("enum('Clinical','Patient','General')");
            entity.Property(e => e.Locked)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.MonthFreq).HasDefaultValueSql("'9999'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PageOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Stage).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Inkformq>(entity =>
        {
            entity.HasKey(e => e.InkqAuxAuto).HasName("PRIMARY");

            entity.ToTable("inkformq");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "idxPac");

            entity.Property(e => e.Caption)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Forced)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.InkFormId).HasColumnName("InkFormID");
            entity.Property(e => e.Location)
                .HasDefaultValueSql("'General'")
                .HasColumnType("enum('Clinical','Patient','General')");
            entity.Property(e => e.Locked)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PageOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
        });

        modelBuilder.Entity<Integration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("integrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.ConstIntegrationName)
                .HasMaxLength(50)
                .HasColumnName("const_integration_name");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entity_id");
            entity.Property(e => e.EntityName)
                .HasMaxLength(50)
                .HasColumnName("entity_name");
            entity.Property(e => e.EntryType)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("entry_type");
            entity.Property(e => e.Error)
                .HasColumnType("text")
                .HasColumnName("error");
        });

        modelBuilder.Entity<JsonvaluesInkform>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.InkedAuxAuto }).HasName("PRIMARY");

            entity.ToTable("jsonvalues_inkform");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.JsonformValues).HasColumnName("JSONFormValues");
        });

        modelBuilder.Entity<Labcase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("labcase");

            entity.HasIndex(e => e.LabId, "LabID");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CaseId, "idxPrimary").IsUnique();

            entity.Property(e => e.CaseDue).HasColumnType("date");
            entity.Property(e => e.CaseId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CaseID");
            entity.Property(e => e.ClosedDate).HasColumnType("date");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.LabCategoryId).HasColumnName("LabCategoryID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.ReceivedDate).HasColumnType("date");
            entity.Property(e => e.SentDate).HasColumnType("date");
            entity.Property(e => e.Tooth).HasMaxLength(100);
        });

        modelBuilder.Entity<Labcategory>(entity =>
        {
            entity.HasKey(e => e.LabCategoryId).HasName("PRIMARY");

            entity.ToTable("labcategory");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.LabCategoryId).HasColumnName("LabCategoryID");
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Laborat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("laborat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodLab, "idxPrimary").IsUnique();

            entity.Property(e => e.Address1).HasMaxLength(40);
            entity.Property(e => e.Address2).HasMaxLength(40);
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CodLab).ValueGeneratedOnAdd();
            entity.Property(e => e.Contact).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(40);
            entity.Property(e => e.Fax).HasMaxLength(10);
            entity.Property(e => e.LabName)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.State).HasMaxLength(2);
            entity.Property(e => e.Tel).HasMaxLength(10);
            entity.Property(e => e.WebAddress).HasMaxLength(40);
            entity.Property(e => e.Zip).HasMaxLength(9);
        });

        modelBuilder.Entity<Listaespera>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("listaespera");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Clinico, e.Dia, e.HoraAgenda }, "idxdiahora");

            entity.HasIndex(e => new { e.Clinico, e.Dia, e.Ordem }, "idxprimary").IsUnique();

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.HoraAgenda)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.HoraRegisto)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Obs)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Ordem).HasDefaultValueSql("'0'");
            entity.Property(e => e.Urgencia)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.LogSeq).HasName("PRIMARY");

            entity.ToTable("logs");

            entity.HasIndex(e => new { e.LogDate, e.LogTime }, "DateTimeIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.UserId, "UserIDIDX");

            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.LogText).HasMaxLength(200);
            entity.Property(e => e.LogTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RecordLink).HasMaxLength(32);
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Logscout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("logscout");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Message).HasColumnName("message");
        });

        modelBuilder.Entity<Matatrib>(entity =>
        {
            entity.HasKey(e => e.MatAtribAuxId).HasName("PRIMARY");

            entity.ToTable("matatrib");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodMat, "idxCodmat");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Trat, e.Dente, e.CodMat, e.Clinico, e.OfficeId }, "idxPrimary").IsUnique();

            entity.Property(e => e.MatAtribAuxId).HasColumnName("MatAtribAuxID");
            entity.Property(e => e.Clinico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<Materiai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("materiais");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Familia1, e.Familia2, e.Familia3 }, "idxFamilia");

            entity.HasIndex(e => e.ParentId, "idxParentID");

            entity.HasIndex(e => e.CodMat, "idxPrimary").IsUnique();

            entity.Property(e => e.Active)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.CodMat).ValueGeneratedOnAdd();
            entity.Property(e => e.DiaUltCompra).HasColumnType("date");
            entity.Property(e => e.Familia1).HasDefaultValueSql("'0'");
            entity.Property(e => e.Familia2).HasDefaultValueSql("'0'");
            entity.Property(e => e.Familia3).HasDefaultValueSql("'0'");
            entity.Property(e => e.Iva)
                .HasDefaultValueSql("'0'")
                .HasColumnName("IVA");
            entity.Property(e => e.Localizacao).HasMaxLength(30);
            entity.Property(e => e.NomMat).HasColumnType("text");
            entity.Property(e => e.Obs).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ParentID");
            entity.Property(e => e.QtdEncomendada)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.QtdExistencia)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.QtdMaxima)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.QtdMinima)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.QtdPontoEnc)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.QtdReservada)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Unidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.ValorCompra)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValorPmp)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("ValorPMP");
            entity.Property(e => e.ValorVenda)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<Matlink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("PRIMARY");

            entity.ToTable("matlink");

            entity.HasIndex(e => e.LinkId, "LinkID").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.NoteId, "idxNoteID");

            entity.HasIndex(e => e.Trt, "idxTrt");

            entity.Property(e => e.LinkId).HasColumnName("LinkID");
            entity.Property(e => e.NoteId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("NoteID");
            entity.Property(e => e.NoteOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Trt)
                .HasMaxLength(6)
                .IsFixedLength();
        });

        modelBuilder.Entity<Medicam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("medicam");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodMedicam, "idxPrimary").IsUnique();

            entity.Property(e => e.CodMedicam).ValueGeneratedOnAdd();
            entity.Property(e => e.NomeMed)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Medicamrec>(entity =>
        {
            entity.HasKey(e => new { e.Mecano, e.Dia, e.Receita, e.CodMedicam }).HasName("PRIMARY");

            entity.ToTable("medicamrec");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.CodMedicam)
                .HasMaxLength(12)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Medicamrpd>(entity =>
        {
            entity.HasKey(e => new { e.ReceitaPd, e.CodMedicam }).HasName("PRIMARY");

            entity.ToTable("medicamrpd");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ReceitaPd).HasColumnName("ReceitaPD");
            entity.Property(e => e.CodMedicam)
                .HasMaxLength(12)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Medicdent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("medicdent");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dnt, e.Dia }, "idxPrimary").IsUnique();

            entity.HasIndex(e => new { e.Pac, e.Warning, e.Dia, e.Dnt }, "idxWarning");

            entity.Property(e => e.CodMed).HasMaxLength(12);
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime");
            entity.Property(e => e.Dnt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Warning)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Medico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("medicos", tb => tb.HasComment("StateTin=NPI Type 1,Medicaid=NPI Type 2"));

            entity.HasIndex(e => e.ChangedOn, "ChangedOn");

            entity.HasIndex(e => e.NomeA, "NomeA").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Codigo, "idxPrimary").IsUnique();

            entity.Property(e => e.AceitaMsg)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("AceitaMSG");
            entity.Property(e => e.Activo)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.BotoesTrat).HasMaxLength(250);
            entity.Property(e => e.CalcPerc)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.CardData).HasMaxLength(32);
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.ChangedOn)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.ClaimPayProvider)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Codigo).ValueGeneratedOnAdd();
            entity.Property(e => e.ConfirmaMarcaTrt)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Dea)
                .HasMaxLength(15)
                .HasColumnName("DEA");
            entity.Property(e => e.DoseUserId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DoseUserID");
            entity.Property(e => e.EhrfacilityId)
                .HasMaxLength(30)
                .HasColumnName("EHRFacilityID");
            entity.Property(e => e.EhruserId)
                .HasMaxLength(30)
                .HasColumnName("EHRUserID");
            entity.Property(e => e.EhruserPass)
                .HasMaxLength(30)
                .HasColumnName("EHRUserPass");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FedTin)
                .HasMaxLength(10)
                .HasColumnName("FedTIN");
            entity.Property(e => e.Fee).HasDefaultValueSql("'0'");
            entity.Property(e => e.FeeId).HasColumnName("fee_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(15)
                .HasDefaultValueSql("''");
            entity.Property(e => e.HomePhone).HasMaxLength(10);
            entity.Property(e => e.InsId1)
                .HasMaxLength(15)
                .HasColumnName("InsID1");
            entity.Property(e => e.InsId10)
                .HasMaxLength(15)
                .HasColumnName("InsID10");
            entity.Property(e => e.InsId2)
                .HasMaxLength(15)
                .HasColumnName("InsID2");
            entity.Property(e => e.InsId3)
                .HasMaxLength(15)
                .HasColumnName("InsID3");
            entity.Property(e => e.InsId4)
                .HasMaxLength(15)
                .HasColumnName("InsID4");
            entity.Property(e => e.InsId5)
                .HasMaxLength(15)
                .HasColumnName("InsID5");
            entity.Property(e => e.InsId6)
                .HasMaxLength(15)
                .HasColumnName("InsID6");
            entity.Property(e => e.InsId7)
                .HasMaxLength(15)
                .HasColumnName("InsID7");
            entity.Property(e => e.InsId8)
                .HasMaxLength(15)
                .HasColumnName("InsID8");
            entity.Property(e => e.InsId9)
                .HasMaxLength(15)
                .HasColumnName("InsID9");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.LicenseNo).HasMaxLength(10);
            entity.Property(e => e.LocAddress1).HasMaxLength(30);
            entity.Property(e => e.LocAddress2).HasMaxLength(30);
            entity.Property(e => e.LocCity).HasMaxLength(20);
            entity.Property(e => e.LocEmail).HasMaxLength(40);
            entity.Property(e => e.LocFax).HasMaxLength(15);
            entity.Property(e => e.LocName).HasMaxLength(40);
            entity.Property(e => e.LocNpi2)
                .HasMaxLength(15)
                .HasColumnName("LocNPI2");
            entity.Property(e => e.LocPhone).HasMaxLength(15);
            entity.Property(e => e.LocState)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.LocZip).HasMaxLength(10);
            entity.Property(e => e.MedicAid).HasMaxLength(15);
            entity.Property(e => e.MiddleInit)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.MobilePhone).HasMaxLength(10);
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NomeA).HasMaxLength(40);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PassA).HasMaxLength(20);
            entity.Property(e => e.PlaceOfTrt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'11'")
                .IsFixedLength();
            entity.Property(e => e.ProgNoteGroup).HasDefaultValueSql("'0'");
            entity.Property(e => e.ProvColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.ProvType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ProviderCd)
                .HasMaxLength(4)
                .HasColumnName("ProviderCD");
            entity.Property(e => e.SecurityGroup)
                .HasMaxLength(30)
                .HasDefaultValueSql("'Administrator'");
            entity.Property(e => e.SpCode).HasMaxLength(10);
            entity.Property(e => e.Specialty).HasMaxLength(35);
            entity.Property(e => e.Ssn)
                .HasMaxLength(9)
                .HasColumnName("SSN");
            entity.Property(e => e.StateTin)
                .HasMaxLength(10)
                .HasColumnName("StateTIN");
            entity.Property(e => e.TimeClockAdmin)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.UseLocForIns)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.UseTimeClock)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ValPerc).HasPrecision(10);
            entity.Property(e => e.ValTrat).HasPrecision(10);
        });

        modelBuilder.Entity<Numobra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("numobra");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.NumObra, "idxPrimary").IsUnique();

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Numpac>(entity =>
        {
            entity.HasKey(e => e.NumeroPac).HasName("PRIMARY");

            entity.ToTable("numpac");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RecordId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("RecordID");
        });

        modelBuilder.Entity<Numtrc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("numtrc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RecordId, "idxPrimary").IsUnique();

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RecordId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("RecordID");
        });

        modelBuilder.Entity<Obsdent>(entity =>
        {
            entity.HasKey(e => e.Odauxauto).HasName("PRIMARY");

            entity.ToTable("obsdent");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dnt, e.Dia, e.Odauxauto }, "idxPrimary").IsUnique();

            entity.HasIndex(e => new { e.Pac, e.Warning, e.Dia, e.Dnt }, "idxWarning");

            entity.Property(e => e.Odauxauto).HasColumnName("ODAuxauto");
            entity.Property(e => e.AuxAutoTrt).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Dnt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Obs).HasMaxLength(120);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Warning)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Obsger>(entity =>
        {
            entity.HasKey(e => e.AuxAutoObsGer).HasName("PRIMARY");

            entity.ToTable("obsger");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.AuxAutoTrt, e.Pac, e.Tipo }, "idxAux");

            entity.HasIndex(e => new { e.Pac, e.Tipo, e.Dia }, "idxPacTipeDia");

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Obs).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Patient'");
            entity.Property(e => e.Vista)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Obsimg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("obsimg");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Mecano, e.NomeFichImg, e.Dente }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.FactorCm).HasColumnName("Factor_Cm");
            entity.Property(e => e.FactorPixels).HasColumnName("Factor_Pixels");
            entity.Property(e => e.NomeFichImg)
                .HasMaxLength(250)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Obs).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Obsloc>(entity =>
        {
            entity.HasKey(e => e.Location).HasName("PRIMARY");

            entity.ToTable("obsloc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Location).HasMaxLength(20);
            entity.Property(e => e.Custom)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("office");

            entity.HasIndex(e => e.OfficeId, "idxPrimary").IsUnique();

            entity.Property(e => e.Active)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Address1).HasMaxLength(30);
            entity.Property(e => e.Address2).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("EMail");
            entity.Property(e => e.ExternalIp)
                .HasMaxLength(60)
                .HasColumnName("ExternalIP");
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.FedTin)
                .HasMaxLength(10)
                .HasColumnName("FedTIN");
            entity.Property(e => e.FeeId).HasColumnName("fee_id");
            entity.Property(e => e.ForClaimsUseOffice).HasDefaultValueSql("'0'");
            entity.Property(e => e.Npitype2)
                .HasMaxLength(15)
                .HasColumnName("NPIType2");
            entity.Property(e => e.OfficeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OfficeID");
            entity.Property(e => e.OfficeName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.WebAddress).HasMaxLength(150);
            entity.Property(e => e.Zip).HasMaxLength(10);
        });

        modelBuilder.Entity<OfficesAccess>(entity =>
        {
            entity.HasKey(e => new { e.DoctorId, e.OfficeId }).HasName("PRIMARY");

            entity.ToTable("offices_access");

            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Olkopt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("olkopt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ID");
            entity.Property(e => e.Balance)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ClearOutlook)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PatientAddress)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.PatientAge)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.PatientEmail)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.PatientPhones)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.PrescAlerts)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Prescriptions)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.TrtCode)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.TrtDesc)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.TrtSurface)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.TrtTooth)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
        });

        modelBuilder.Entity<Opco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("opcoes");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RecordId, "idxPrimary").IsUnique();

            entity.Property(e => e.ApresLupa)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.AvisaAnivers)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.CorPerMes).HasDefaultValueSql("'0'");
            entity.Property(e => e.DirAppRx)
                .HasMaxLength(250)
                .HasColumnName("DirAppRX");
            entity.Property(e => e.DirAppRxDaview)
                .HasMaxLength(250)
                .HasColumnName("DirAppRX_DAView");
            entity.Property(e => e.DirAppRxDigora)
                .HasMaxLength(250)
                .HasColumnName("DirAppRX_Digora");
            entity.Property(e => e.DirAppRxRvg)
                .HasMaxLength(250)
                .HasColumnName("DirAppRX_RVG");
            entity.Property(e => e.DirAppRxVw)
                .HasMaxLength(250)
                .HasColumnName("DirAppRX_VW");
            entity.Property(e => e.DirReports).HasMaxLength(250);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .HasColumnName("emailAddress");
            entity.Property(e => e.EmailHost)
                .HasMaxLength(250)
                .HasColumnName("emailHost");
            entity.Property(e => e.EmailNome)
                .HasMaxLength(250)
                .HasColumnName("emailNome");
            entity.Property(e => e.EmailUser)
                .HasMaxLength(250)
                .HasColumnName("emailUser");
            entity.Property(e => e.FacturaMultiClinico)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.ImprimeFichaEnvelope)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Logotipo).HasColumnType("blob");
            entity.Property(e => e.MostraFaltas)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.NetAutoConnect)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.NetAutoDisconnect)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PerioLinesGap).HasDefaultValueSql("'6'");
            entity.Property(e => e.ProgNoteLock).HasDefaultValueSql("'7'");
            entity.Property(e => e.RecordId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("RecordID");
            entity.Property(e => e.SoTratInicial)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.TipoAppRx).HasColumnName("TipoAppRX");
            entity.Property(e => e.ToothChart)
                .HasDefaultValueSql("'Adult'")
                .HasColumnType("enum('Adult','Child')");
        });

        modelBuilder.Entity<Opcoesoper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("opcoesoper");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Operador, "idxPrimary").IsUnique();

            entity.Property(e => e.AllResources)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.AltPocketRecession)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.ApresentaOrtodontia)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.ApresentaPeriodontia)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.ColorToothBmp)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.ColunasTratamentos).HasMaxLength(20);
            entity.Property(e => e.ConditionsOn)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.ExamSeq1).HasColumnType("text");
            entity.Property(e => e.ExamSeq2).HasColumnType("text");
            entity.Property(e => e.ExamSeq3).HasColumnType("text");
            entity.Property(e => e.ExamSeq4).HasColumnType("text");
            entity.Property(e => e.ExamSeqDesc1).HasMaxLength(100);
            entity.Property(e => e.ExamSeqDesc2).HasMaxLength(100);
            entity.Property(e => e.ExamSeqDesc3).HasMaxLength(100);
            entity.Property(e => e.ExamSeqDesc4).HasMaxLength(100);
            entity.Property(e => e.FlagColor).HasDefaultValueSql("'255'");
            entity.Property(e => e.FlagValue).HasDefaultValueSql("'3'");
            entity.Property(e => e.InitialAndTrt)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.InkColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.InkWidth)
                .HasDefaultValueSql("'30'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.Mgjcolor)
                .HasDefaultValueSql("'16711935'")
                .HasColumnName("MGJColor");
            entity.Property(e => e.MgjcompColor)
                .HasDefaultValueSql("'16711935'")
                .HasColumnName("MGJCompColor");
            entity.Property(e => e.MultiPost)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.NumericDisplay).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PerioAutoSeq)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.PerioExamOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.PerioLoadPrevious)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.PocketColor).HasDefaultValueSql("'0'");
            entity.Property(e => e.PocketCompColor).HasDefaultValueSql("'16711680'");
            entity.Property(e => e.RecessionColor).HasDefaultValueSql("'128'");
            entity.Property(e => e.RecessionCompColor).HasDefaultValueSql("'32768'");
            entity.Property(e => e.ShowInk)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.StatusTimes)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.VoiceDelay).HasDefaultValueSql("'1000'");
        });

        modelBuilder.Entity<Orclivre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orclivre");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Norc }, "idxPrimary").IsUnique();

            entity.Property(e => e.Aprovado)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Norc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("NOrc");
            entity.Property(e => e.Obs).HasColumnType("blob");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Texto).HasColumnType("blob");
            entity.Property(e => e.Valor).HasPrecision(12);
        });

        modelBuilder.Entity<Ortodontium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ortodontia");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dente }, "idxPrimary").IsUnique();

            entity.Property(e => e.Band)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Ortoel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ortoel");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.ToothFrom, e.ToothTo, e.ElasticDate }, "idxPrimary").IsUnique();

            entity.Property(e => e.Active)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ElasticDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.ElasticDesc)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ElasticId).HasColumnName("ElasticID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ToothFrom)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.ToothTo)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.WireDescLower)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.WireDescUpper)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Ortoelt>(entity =>
        {
            entity.HasKey(e => e.ElasticId).HasName("PRIMARY");

            entity.ToTable("ortoelt");

            entity.HasIndex(e => e.ElasticDesc, "ElasticDescIDX").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ElasticId).HasColumnName("ElasticID");
            entity.Property(e => e.ElasticDesc)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Ortoev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ortoev");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.DiaOrto }, "idxPrimary").IsUnique();

            entity.Property(e => e.ArcadaMand).HasMaxLength(20);
            entity.Property(e => e.ArcadaMax).HasMaxLength(20);
            entity.Property(e => e.DiaOrto)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Elasticos).HasMaxLength(20);
            entity.Property(e => e.Fotos)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Higiene).HasMaxLength(20);
            entity.Property(e => e.Medicacao).HasMaxLength(20);
            entity.Property(e => e.Obs).HasMaxLength(50);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProxConsulta).HasColumnType("date");
        });

        modelBuilder.Entity<Ortort>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ortort");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dente }, "idxPrimary").IsUnique();

            entity.Property(e => e.Band)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Ortowr>(entity =>
        {
            entity.HasKey(e => e.WireId).HasName("PRIMARY");

            entity.ToTable("ortowr");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.WireId).HasColumnName("WireID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.WireDesc)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Pacalternativo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pacalternativo");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Especialidade, e.TipoDoc, e.NumDoc }, "idxPrimary").IsUnique();

            entity.Property(e => e.Beneficiario).HasMaxLength(20);
            entity.Property(e => e.Contribuinte).HasMaxLength(20);
            entity.Property(e => e.Entidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Especialidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PacData).HasColumnType("text");
            entity.Property(e => e.TipoDoc).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Pmecano).HasName("PRIMARY");

            entity.ToTable("paciente");

            entity.HasIndex(e => e.Pnascim, "BirthDayIdx");

            entity.HasIndex(e => e.ChangedOn, "ChangedOn");

            entity.HasIndex(e => e.Pemail, "Emaildx");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Plast, "PLast");

            entity.HasIndex(e => e.Pstatus, "PStatus");

            entity.HasIndex(e => e.PsubAccount1, "PSubAccount1");

            entity.HasIndex(e => e.PsubAccount2, "PSubAccount2");

            entity.HasIndex(e => e.Pmecano, "idxMecano").IsUnique();

            entity.HasIndex(e => e.Pnome, "idxNome");

            entity.HasIndex(e => e.PrespParty, "idxRespParty");

            entity.Property(e => e.Pmecano).HasColumnName("PMecano");
            entity.Property(e => e.AcceptEmail)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.AcceptText)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.Anniversary1).HasColumnType("date");
            entity.Property(e => e.Anniversary2).HasColumnType("date");
            entity.Property(e => e.BenAssign1).HasColumnType("enum('Provider','Patient')");
            entity.Property(e => e.BenAssign2).HasMaxLength(10);
            entity.Property(e => e.ChangedOn)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.ChrgInterest)
                .HasMaxLength(3)
                .HasDefaultValueSql("'Yes'")
                .IsFixedLength();
            entity.Property(e => e.ComplaintDate).HasColumnType("date");
            entity.Property(e => e.DdswebLinkUrl)
                .HasMaxLength(120)
                .HasColumnName("DDSWebLinkURL");
            entity.Property(e => e.DoctorId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DoctorID");
            entity.Property(e => e.DosePatientId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DosePatientID");
            entity.Property(e => e.EmployerName1).HasMaxLength(40);
            entity.Property(e => e.EmployerName2).HasMaxLength(40);
            entity.Property(e => e.EmploymentStatus1).HasColumnType("enum('Full Time','Part Time','FT Student','PT Student')");
            entity.Property(e => e.EmploymentStatus2).HasColumnType("enum('Full Time','Part Time','FT Student','PT Student')");
            entity.Property(e => e.FailedAppt).HasDefaultValueSql("'0'");
            entity.Property(e => e.GroupNumber1).HasMaxLength(15);
            entity.Property(e => e.GroupNumber2).HasMaxLength(15);
            entity.Property(e => e.HygenistId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("HygenistID");
            entity.Property(e => e.InsCardId1)
                .HasMaxLength(25)
                .HasColumnName("InsCardID1");
            entity.Property(e => e.InsCardId2)
                .HasMaxLength(25)
                .HasColumnName("InsCardID2");
            entity.Property(e => e.InsuranceId1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID1");
            entity.Property(e => e.InsuranceId2)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID2");
            entity.Property(e => e.LastRcvisit)
                .HasColumnType("date")
                .HasColumnName("LastRCVisit");
            entity.Property(e => e.MaxBenefit1)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.MaxBenefit2)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.MobileCarrier).HasMaxLength(20);
            entity.Property(e => e.NoticeDate).HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Panivers)
                .HasMaxLength(4)
                .HasColumnName("PAnivers");
            entity.Property(e => e.Papresent)
                .HasColumnType("date")
                .HasColumnName("PApresent");
            entity.Property(e => e.ParqBi)
                .HasMaxLength(15)
                .HasColumnName("PArqBI");
            entity.Property(e => e.PatDeductible1)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PatDeductible2)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Pbenefi)
                .HasMaxLength(20)
                .HasColumnName("PBenefi");
            entity.Property(e => e.PcartaoCredito).HasColumnName("PCartaoCredito");
            entity.Property(e => e.Pcity)
                .HasMaxLength(20)
                .HasColumnName("PCity");
            entity.Property(e => e.PcodPos)
                .HasMaxLength(8)
                .HasColumnName("PCodPos");
            entity.Property(e => e.PcontactMethod)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PContactMethod");
            entity.Property(e => e.Pcontrib)
                .HasMaxLength(15)
                .HasColumnName("PContrib");
            entity.Property(e => e.Pcorresp)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("PCorresp");
            entity.Property(e => e.Pcountry)
                .HasMaxLength(10)
                .HasDefaultValueSql("'USA'")
                .HasColumnName("PCountry");
            entity.Property(e => e.PdataBi)
                .HasColumnType("date")
                .HasColumnName("PDataBI");
            entity.Property(e => e.PdiaProces)
                .HasColumnType("date")
                .HasColumnName("PDiaProces");
            entity.Property(e => e.PdirImg)
                .HasMaxLength(250)
                .HasColumnName("PDirImg");
            entity.Property(e => e.PdirRad)
                .HasMaxLength(250)
                .HasColumnName("PDirRad");
            entity.Property(e => e.PdirTrophy)
                .HasMaxLength(10)
                .HasColumnName("PDirTrophy");
            entity.Property(e => e.Pecivil)
                .HasDefaultValueSql("'Single'")
                .HasColumnType("enum('Solteiro','Casado','Divorciado','Viuvo','Married','Single','Other')")
                .HasColumnName("PECivil");
            entity.Property(e => e.Pemail)
                .HasMaxLength(40)
                .HasColumnName("PEmail");
            entity.Property(e => e.Pentidade)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PEntidade");
            entity.Property(e => e.Pfax)
                .HasMaxLength(15)
                .HasColumnName("PFAX");
            entity.Property(e => e.Pfilhos).HasColumnName("PFilhos");
            entity.Property(e => e.Pfirst)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("PFirst");
            entity.Property(e => e.PfirstVisit)
                .HasColumnType("date")
                .HasColumnName("PFirstVisit");
            entity.Property(e => e.Pfoto).HasColumnName("PFoto");
            entity.Property(e => e.PindicadoPor)
                .HasMaxLength(40)
                .HasColumnName("PIndicadoPor");
            entity.Property(e => e.PlanId1).HasColumnName("PlanID1");
            entity.Property(e => e.PlanId2).HasColumnName("PlanID2");
            entity.Property(e => e.Plast)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("PLast");
            entity.Property(e => e.Plocalid)
                .HasMaxLength(30)
                .HasColumnName("PLocalid");
            entity.Property(e => e.Pmascul)
                .HasDefaultValueSql("'Male'")
                .HasColumnType("enum('Masculino','Feminino','Male','Female','Unspecified')")
                .HasColumnName("PMascul");
            entity.Property(e => e.Pmedico).HasColumnName("PMedico");
            entity.Property(e => e.PmemoObs)
                .HasColumnType("text")
                .HasColumnName("PMemoObs");
            entity.Property(e => e.Pmeses).HasColumnName("PMeses");
            entity.Property(e => e.Pmiddle)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("PMiddle");
            entity.Property(e => e.Pmorada)
                .HasMaxLength(30)
                .HasColumnName("PMorada");
            entity.Property(e => e.Pnascim)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("PNascim");
            entity.Property(e => e.Pnome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("PNome");
            entity.Property(e => e.PnumBi)
                .HasMaxLength(15)
                .HasColumnName("PNumBI");
            entity.Property(e => e.PpayWarning)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("PPayWarning");
            entity.Property(e => e.Ppreferred)
                .HasMaxLength(15)
                .HasColumnName("PPreferred");
            entity.Property(e => e.Pprocesso).HasColumnName("PProcesso");
            entity.Property(e => e.Pprofis)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PProfis");
            entity.Property(e => e.PreMed)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.PrecallFreq)
                .HasDefaultValueSql("'6'")
                .HasColumnName("PRecallFreq");
            entity.Property(e => e.Prelation)
                .HasDefaultValueSql("'Self'")
                .HasColumnType("enum('Self','Spouse','Child','Other')")
                .HasColumnName("PRelation");
            entity.Property(e => e.PrelationIns1)
                .HasMaxLength(6)
                .HasColumnName("PRelationIns1");
            entity.Property(e => e.PrelationIns2)
                .HasMaxLength(6)
                .HasColumnName("PRelationIns2");
            entity.Property(e => e.PrespParty).HasColumnName("PRespParty");
            entity.Property(e => e.Pssn)
                .HasMaxLength(9)
                .HasColumnName("PSSN");
            entity.Property(e => e.Pstate)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("PState");
            entity.Property(e => e.Pstatus)
                .HasMaxLength(11)
                .HasDefaultValueSql("'Active'")
                .HasColumnName("PStatus");
            entity.Property(e => e.PsubAccount1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PSubAccount1");
            entity.Property(e => e.PsubAccount2).HasColumnName("PSubAccount2");
            entity.Property(e => e.Ptitular)
                .HasMaxLength(40)
                .HasColumnName("PTitular");
            entity.Property(e => e.Ptitulo)
                .HasMaxLength(10)
                .HasColumnName("PTitulo");
            entity.Property(e => e.PtlfCasa)
                .HasMaxLength(15)
                .HasColumnName("PTlfCasa");
            entity.Property(e => e.PtlfEmpr)
                .HasMaxLength(15)
                .HasColumnName("PTlfEmpr");
            entity.Property(e => e.Ptmovel)
                .HasMaxLength(15)
                .HasColumnName("PTMovel");
            entity.Property(e => e.PultConAnoMes)
                .HasMaxLength(6)
                .HasColumnName("PUltConAnoMes");
            entity.Property(e => e.PultCons)
                .HasColumnType("date")
                .HasColumnName("PUltCons");
            entity.Property(e => e.PvalCartao)
                .HasColumnType("date")
                .HasColumnName("PValCartao");
            entity.Property(e => e.Pzip)
                .HasMaxLength(10)
                .HasColumnName("PZip");
            entity.Property(e => e.RefAccount).HasDefaultValueSql("'0'");
            entity.Property(e => e.RefDate).HasColumnType("date");
            entity.Property(e => e.RefSourceId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("RefSourceID");
            entity.Property(e => e.ReferredTo).HasMaxLength(30);
            entity.Property(e => e.ResponseDate).HasColumnType("date");
            entity.Property(e => e.SchoolName1).HasMaxLength(20);
            entity.Property(e => e.SchoolName2).HasMaxLength(20);
            entity.Property(e => e.SendDunning)
                .HasMaxLength(3)
                .HasDefaultValueSql("'Yes'")
                .IsFixedLength();
            entity.Property(e => e.SendStmt)
                .HasMaxLength(3)
                .HasDefaultValueSql("'Yes'")
                .IsFixedLength();
            entity.Property(e => e.Tpoconsent)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("TPOConsent");
            entity.Property(e => e.WebPass).HasMaxLength(15);
        });

        modelBuilder.Entity<Pacin>(entity =>
        {
            entity.HasKey(e => e.AuxAutoPacIns).HasName("PRIMARY");

            entity.ToTable("pacins");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.BenAssign).HasColumnType("enum('Provider','Patient')");
            entity.Property(e => e.EmployerName).HasMaxLength(40);
            entity.Property(e => e.EmploymentStatus).HasColumnType("enum('Full Time','Part Time','FT Student','PT Student')");
            entity.Property(e => e.GroupNumber).HasMaxLength(15);
            entity.Property(e => e.InsCardId)
                .HasMaxLength(25)
                .HasColumnName("InsCardID");
            entity.Property(e => e.InsuranceId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.RelationIns)
                .HasDefaultValueSql("'Self'")
                .HasColumnType("enum('Self','Spouse','Child','Other')");
            entity.Property(e => e.SubAccount).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Payer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payers");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Model).HasMaxLength(20);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PayerId)
                .HasMaxLength(5)
                .HasColumnName("PayerID");
            entity.Property(e => e.PayerName).HasMaxLength(50);
            entity.Property(e => e.PayerOffice).HasMaxLength(10);
            entity.Property(e => e.State).HasMaxLength(2);
        });

        modelBuilder.Entity<Periodontium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("periodontia");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.AuxAuto, "idxAuxAuto");

            entity.HasIndex(e => new { e.Pac, e.VestLingual, e.Dente }, "idxDente");

            entity.HasIndex(e => new { e.Pac, e.Bolsa1Dia, e.VestLingual, e.Dente }, "idxPrimary").IsUnique();

            entity.Property(e => e.BleedingC)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.BleedingD)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.BleedingM)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Bolsa1).HasMaxLength(8);
            entity.Property(e => e.Bolsa1Dia).HasColumnType("date");
            entity.Property(e => e.Bolsa2).HasMaxLength(8);
            entity.Property(e => e.Bolsa2Dia).HasColumnType("date");
            entity.Property(e => e.Bolsa3).HasMaxLength(8);
            entity.Property(e => e.Bolsa3Dia).HasColumnType("date");
            entity.Property(e => e.Bolsa4).HasMaxLength(8);
            entity.Property(e => e.Bolsa4Dia).HasColumnType("date");
            entity.Property(e => e.Bolsa5).HasMaxLength(8);
            entity.Property(e => e.Bolsa5Dia).HasColumnType("date");
            entity.Property(e => e.BolsaObs).HasMaxLength(40);
            entity.Property(e => e.CalculusC)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.CalculusD)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.CalculusM)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ChildTooth)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Furca).HasDefaultValueSql("'0'");
            entity.Property(e => e.Furca2).HasDefaultValueSql("'0'");
            entity.Property(e => e.Furca3).HasDefaultValueSql("'0'");
            entity.Property(e => e.FurcaObs).HasMaxLength(40);
            entity.Property(e => e.Gmc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("GMC");
            entity.Property(e => e.Gmd)
                .HasDefaultValueSql("'0'")
                .HasColumnName("GMD");
            entity.Property(e => e.Gmm)
                .HasDefaultValueSql("'0'")
                .HasColumnName("GMM");
            entity.Property(e => e.ImpactaDnt)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Mgjc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MGJC");
            entity.Property(e => e.Mgjd)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MGJD");
            entity.Property(e => e.Mgjm)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MGJM");
            entity.Property(e => e.Mob1).HasDefaultValueSql("'0'");
            entity.Property(e => e.Mob1Dia).HasColumnType("date");
            entity.Property(e => e.Mob2).HasDefaultValueSql("'0'");
            entity.Property(e => e.Mob2Dia).HasColumnType("date");
            entity.Property(e => e.Mob3).HasDefaultValueSql("'0'");
            entity.Property(e => e.Mob3Dia).HasColumnType("date");
            entity.Property(e => e.MobObs).HasMaxLength(40);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pdc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PDC");
            entity.Property(e => e.Pdd)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PDD");
            entity.Property(e => e.Pdm)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PDM");
            entity.Property(e => e.PlaqueC)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.PlaqueD)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.PlaqueM)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Recession).HasMaxLength(8);
            entity.Property(e => e.SuppurationC)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.SuppurationD)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.SuppurationM)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.VestLingual)
                .HasDefaultValueSql("'Vest'")
                .HasColumnType("enum('Vest','Ling')");
        });

        modelBuilder.Entity<PhoneCountry>(entity =>
        {
            entity.HasKey(e => new { e.Phonecode, e.Iso }).HasName("PRIMARY");

            entity.ToTable("phone_country");

            entity.Property(e => e.Phonecode).HasColumnName("phonecode");
            entity.Property(e => e.Iso)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("iso");
            entity.Property(e => e.Iso3)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("iso3");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .HasColumnName("name");
            entity.Property(e => e.Nicename)
                .HasMaxLength(80)
                .HasColumnName("nicename");
            entity.Property(e => e.Numcode).HasColumnName("numcode");
        });

        modelBuilder.Entity<Planonote>(entity =>
        {
            entity.HasKey(e => new { e.NumGeral, e.NumOrc, e.Pac }).HasName("PRIMARY");

            entity.ToTable("planonote");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.NumGeral).HasDefaultValueSql("'1'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PlanNote).HasColumnType("text");
        });

        modelBuilder.Entity<Planotrat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("planotrat");

            entity.HasIndex(e => e.AuxAuto, "AuxAuto");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.AuxAutoTrt, "idxAuxAutoTrt");

            entity.HasIndex(e => new { e.NumGeral, e.Pac, e.NumOrc, e.Dia, e.Trat, e.Dente, e.AuxAuto, e.Entidade }, "idxPrimary").IsUnique();

            entity.Property(e => e.Aprovado)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.AuxAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.Clinico).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Face).HasDefaultValueSql("'0'");
            entity.Property(e => e.Guia).HasMaxLength(15);
            entity.Property(e => e.Minutes).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Phase).HasDefaultValueSql("'1'");
            entity.Property(e => e.Situacao)
                .HasDefaultValueSql("'Pending'")
                .HasColumnType("enum('Executar','Executado','Cancelado','Pending','Executed','Canceled','Scheduled')");
            entity.Property(e => e.Titulo).HasMaxLength(40);
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Valor)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueChanged)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueEnt1)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueEnt2)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<Posodont>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("posodont");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dnt }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dnt).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Printq>(entity =>
        {
            entity.HasKey(e => e.Auxauto).HasName("PRIMARY");

            entity.ToTable("printq");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.Archive)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Description).HasMaxLength(30);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EventId)
                .HasMaxLength(50)
                .HasColumnName("EventID");
            entity.Property(e => e.MsgType)
                .HasDefaultValueSql("'EMail'")
                .HasColumnType("enum('EMail','Text')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Processo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("processos");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Especialidade, e.Mecano, e.Processo1, e.Dia }, "idxPrimary").IsUnique();

            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Especialidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Obs).HasMaxLength(50);
            entity.Property(e => e.ObsDescricao).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pclose)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("PClose");
            entity.Property(e => e.Popen)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("POpen");
            entity.Property(e => e.Processo1).HasColumnName("Processo");
            entity.Property(e => e.Titulo).HasMaxLength(50);
        });

        modelBuilder.Entity<Processostrat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("processostrat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Mecano, e.SitFac }, "idxMecano");

            entity.HasIndex(e => new { e.Especialidade, e.Mecano, e.Processo, e.Dia, e.Trat, e.Entidade }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Especialidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ValorFact).HasPrecision(12);
        });

        modelBuilder.Entity<Profissa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("profissa");

            entity.HasIndex(e => e.Pfcod, "IdxPrimary").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pfcod)
                .ValueGeneratedOnAdd()
                .HasColumnName("PFCod");
            entity.Property(e => e.Pfnome)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("PFNome");
        });

        modelBuilder.Entity<Prognote>(entity =>
        {
            entity.HasKey(e => e.AuxAuto).HasName("PRIMARY");

            entity.ToTable("prognote");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.AuxAutoTrt, "idxAuxAutoTrt");

            entity.HasIndex(e => new { e.LinkDate, e.Locked }, "idxLinkDate");

            entity.HasIndex(e => e.Pac, "idxPac");

            entity.Property(e => e.AuxAutoTrt).HasDefaultValueSql("'0'");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.CreatedBy).HasDefaultValueSql("'0'");
            entity.Property(e => e.LinkDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.LockRow)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')")
                .HasColumnName("lock_row");
            entity.Property(e => e.Locked)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.LockedDate).HasColumnType("date");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.NoteOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.Trat).HasMaxLength(6);
        });

        modelBuilder.Entity<PrognoteLog>(entity =>
        {
            entity.HasKey(e => e.NoteSeq).HasName("PRIMARY");

            entity.ToTable("prognote_logs");

            entity.Property(e => e.Kind)
                .HasDefaultValueSql("'Insert'")
                .HasColumnType("enum('Insert','Update','Delete')");
            entity.Property(e => e.NoteDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.NoteId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("NoteID");
            entity.Property(e => e.NoteLinkDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.NoteMessage).HasColumnType("text");
            entity.Property(e => e.NoteText).HasColumnType("text");
            entity.Property(e => e.NoteTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PatientId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PatientID");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Prognotelink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("PRIMARY");

            entity.ToTable("prognotelink");

            entity.HasIndex(e => e.LinkId, "LinkID").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.NoteId, "idxNoteID");

            entity.HasIndex(e => e.Trt, "idxTrt");

            entity.Property(e => e.LinkId).HasColumnName("LinkID");
            entity.Property(e => e.NoteId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("NoteID");
            entity.Property(e => e.NoteOrder).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Trt).HasMaxLength(6);
        });

        modelBuilder.Entity<Prognotepd>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PRIMARY");

            entity.ToTable("prognotepd");

            entity.HasIndex(e => e.NoteId, "ID").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.NoteGroup, "idxNoteGroup");

            entity.HasIndex(e => e.ParentId, "idxParentID");

            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.Caption)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.NoteGroup).HasDefaultValueSql("'0'");
            entity.Property(e => e.NoteGroupCaption).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
        });

        modelBuilder.Entity<Prognoteref>(entity =>
        {
            entity.HasKey(e => e.AuxAuto).HasName("PRIMARY");

            entity.ToTable("prognoteref");

            entity.HasIndex(e => e.AuxAuto, "AuxAuto").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.CreateDate }, "idxPac");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.Provider).HasMaxLength(35);
        });

        modelBuilder.Entity<Protlab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("protlab");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.CodProt }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodProt)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.DiaAplicacao).HasColumnType("date");
            entity.Property(e => e.EnvioLab).HasColumnType("date");
            entity.Property(e => e.Laboratorio).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OrcamLab).HasPrecision(12);
            entity.Property(e => e.OrcamPac).HasPrecision(12);
            entity.Property(e => e.Pago)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.PrevLab).HasColumnType("date");
            entity.Property(e => e.TipoProt).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Protmat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("protmat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.CodProt, e.Dnt }, "idxprimary").IsUnique();

            entity.Property(e => e.Dia).HasColumnType("date");
            entity.Property(e => e.Dnt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.FabNome).HasMaxLength(30);
            entity.Property(e => e.FabRef).HasMaxLength(15);
            entity.Property(e => e.Obs).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoM).HasMaxLength(12);
        });

        modelBuilder.Entity<Provgrp>(entity =>
        {
            entity.HasKey(e => e.GroupName).HasName("PRIMARY");

            entity.ToTable("provgrp");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.GroupName).HasMaxLength(30);
            entity.Property(e => e.GroupList).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Queuet>(entity =>
        {
            entity.HasKey(e => e.QueueId).HasName("PRIMARY");

            entity.ToTable("queuet");

            entity.HasIndex(e => new { e.ComputerName, e.QueueType }, "NameTypeIX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.QueueId).HasColumnName("QueueID");
            entity.Property(e => e.ComputerName).HasMaxLength(120);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Params).HasMaxLength(255);
            entity.Property(e => e.QueueType).HasMaxLength(16);
        });

        modelBuilder.Entity<Receita>(entity =>
        {
            entity.HasKey(e => new { e.Mecano, e.Dia, e.IndexRec }).HasName("PRIMARY");

            entity.ToTable("receitas");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Texto).HasColumnType("mediumblob");
            entity.Property(e => e.Titulo).HasMaxLength(40);
        });

        modelBuilder.Entity<Receitaspd>(entity =>
        {
            entity.HasKey(e => e.IdxRp).HasName("PRIMARY");

            entity.ToTable("receitaspd");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.IdxRp).HasColumnName("idxRP");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Text).HasColumnType("blob");
            entity.Property(e => e.Titulo).HasMaxLength(96);
        });

        modelBuilder.Entity<Receitatemplate>(entity =>
        {
            entity.HasKey(e => e.Doctor).HasName("PRIMARY");

            entity.ToTable("receitatemplates");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Doctor)
                .HasMaxLength(6)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ReceitaTemplate).HasColumnType("blob");
        });

        modelBuilder.Entity<Recurrencedef>(entity =>
        {
            entity.HasKey(e => e.RecurrenceId).HasName("PRIMARY");

            entity.ToTable("recurrencedefs");

            entity.HasIndex(e => e.EventId, "ActivityID");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.ShareId, "ShareID");

            entity.HasIndex(e => e.ResourceId, "idx_ResourceID");

            entity.Property(e => e.RecurrenceId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("RecurrenceID");
            entity.Property(e => e.AlarmFileName).HasMaxLength(50);
            entity.Property(e => e.AlarmMsg).HasColumnType("text");
            entity.Property(e => e.Attachments).HasColumnType("text");
            entity.Property(e => e.Category).HasMaxLength(10);
            entity.Property(e => e.Contact).HasMaxLength(25);
            entity.Property(e => e.CreatedBy).HasMaxLength(15);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.EndTime).HasMaxLength(10);
            entity.Property(e => e.EventId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("EventID");
            entity.Property(e => e.EventTypeName).HasMaxLength(32);
            entity.Property(e => e.ExceptionFields).HasColumnType("text");
            entity.Property(e => e.FontStyle).HasMaxLength(10);
            entity.Property(e => e.Location).HasMaxLength(75);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OwnedBy).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(15);
            entity.Property(e => e.RDuration).HasColumnName("R_Duration");
            entity.Property(e => e.REndDate)
                .HasColumnType("datetime")
                .HasColumnName("R_EndDate");
            entity.Property(e => e.RExceptDates)
                .HasColumnType("text")
                .HasColumnName("R_ExceptDates");
            entity.Property(e => e.RInterval).HasColumnName("R_Interval");
            entity.Property(e => e.RModifier)
                .HasMaxLength(10)
                .HasColumnName("R_Modifier");
            entity.Property(e => e.ROccurSpecifier)
                .HasMaxLength(10)
                .HasColumnName("R_OccurSpecifier");
            entity.Property(e => e.RRecurEndType).HasColumnName("R_RecurEndType");
            entity.Property(e => e.RRule).HasColumnName("R_Rule");
            entity.Property(e => e.RRuleType).HasColumnName("R_RuleType");
            entity.Property(e => e.RStartDate)
                .HasColumnType("datetime")
                .HasColumnName("R_StartDate");
            entity.Property(e => e.RStartOfWeek).HasColumnName("R_StartOfWeek");
            entity.Property(e => e.RWeekEndMove).HasColumnName("R_WeekEndMove");
            entity.Property(e => e.ReminderDate).HasMaxLength(19);
            entity.Property(e => e.ReminderTime).HasMaxLength(8);
            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            entity.Property(e => e.ShareId)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("ShareID");
            entity.Property(e => e.ShowTimeAs).HasMaxLength(15);
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.StartTime).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(75);
        });

        modelBuilder.Entity<Referral>(entity =>
        {
            entity.HasKey(e => e.ReferralId).HasName("PRIMARY");

            entity.ToTable("referral");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.ReferralId, "ReferralSeq").IsUnique();

            entity.Property(e => e.ReferralId).HasColumnName("ReferralID");
            entity.Property(e => e.Address1).HasMaxLength(30);
            entity.Property(e => e.Address2).HasMaxLength(30);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(10);
            entity.Property(e => e.RefSource).HasMaxLength(25);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Zip).HasMaxLength(9);
        });

        modelBuilder.Entity<Repinvoice>(entity =>
        {
            entity.HasKey(e => e.RepName).HasName("PRIMARY");

            entity.ToTable("repinvoices");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.RepName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Rxpac>(entity =>
        {
            entity.HasKey(e => e.RxId).HasName("PRIMARY");

            entity.ToTable("rxpac");

            entity.HasIndex(e => e.DoseRxId, "DoseRXIdIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.CreateDate }, "PacDiaIDX");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.CreatedBy).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dispense).HasMaxLength(96);
            entity.Property(e => e.DoctorId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DoctorID");
            entity.Property(e => e.Dosage).HasColumnType("tinytext");
            entity.Property(e => e.DoseRxId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DoseRxID");
            entity.Property(e => e.DoseRxstatus)
                .HasMaxLength(12)
                .HasColumnName("DoseRXStatus");
            entity.Property(e => e.Medicine).HasMaxLength(96);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
            entity.Property(e => e.Refills)
                .HasMaxLength(60)
                .HasDefaultValueSql("'**0**'");
        });

        modelBuilder.Entity<Rxpd>(entity =>
        {
            entity.HasKey(e => e.RxId).HasName("PRIMARY");

            entity.ToTable("rxpd");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RxId, "RxId").IsUnique();

            entity.HasIndex(e => e.RxId, "RxId_2");

            entity.Property(e => e.Dispense).HasMaxLength(96);
            entity.Property(e => e.Dosage).HasColumnType("tinytext");
            entity.Property(e => e.Medicine).HasMaxLength(96);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Refills)
                .HasMaxLength(60)
                .HasDefaultValueSql("'**0**'");
        });

        modelBuilder.Entity<Saaction>(entity =>
        {
            entity.HasKey(e => new { e.GroupName, e.Said }).HasName("PRIMARY");

            entity.ToTable("saactions");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .HasDefaultValueSql("'Administrator'");
            entity.Property(e => e.Said).HasColumnName("SAID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Allow)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("salas");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.NumSala, "idxPrimary").IsUnique();

            entity.Property(e => e.AbvSala)
                .HasMaxLength(8)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.NumSala).HasDefaultValueSql("'0'");
            entity.Property(e => e.Obs).HasColumnType("tinytext");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Salasocp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("salasocp");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Dia, e.Hora, e.Medico }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Sala).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Scandoc>(entity =>
        {
            entity.HasKey(e => e.Auxauto).HasName("PRIMARY");

            entity.ToTable("scandoc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "PacIDX");

            entity.Property(e => e.Auxauto).HasColumnName("auxauto");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Description).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Pac).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<ScheduledRelease>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.ScheduledDate }).HasName("PRIMARY");

            entity.ToTable("scheduled_release");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ScheduledDate)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_date");
            entity.Property(e => e.Applied)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("applied");
            entity.Property(e => e.Downloaded)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("downloaded");
            entity.Property(e => e.Onerror)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("onerror");
            entity.Property(e => e.OnerrorLog)
                .HasColumnType("text")
                .HasColumnName("onerror_log");
            entity.Property(e => e.PathBridge)
                .HasColumnType("text")
                .HasColumnName("path_bridge");
            entity.Property(e => e.ReleaseId).HasColumnName("release_id");
            entity.Property(e => e.UpgradedBridge)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("upgraded_bridge");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
            entity.Property(e => e.VersionName)
                .HasColumnType("text")
                .HasColumnName("version_name");
        });

        modelBuilder.Entity<Segsoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("segsoc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "idxPrimary").IsUnique();

            entity.Property(e => e.CentroSaude).HasMaxLength(50);
            entity.Property(e => e.CodCartao).HasMaxLength(20);
            entity.Property(e => e.NumSsoc)
                .HasMaxLength(20)
                .HasColumnName("NumSSoc");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Sigdoc>(entity =>
        {
            entity.HasKey(e => e.SeqId).HasName("PRIMARY");

            entity.ToTable("sigdoc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.SeqId).HasColumnName("SeqID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.DateEntered)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DocName).HasMaxLength(30);
            entity.Property(e => e.DocText).HasColumnType("mediumblob");
            entity.Property(e => e.DocType).HasDefaultValueSql("'0'");
            entity.Property(e => e.Locked)
                .HasMaxLength(3)
                .HasDefaultValueSql("'No'")
                .IsFixedLength();
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Sigpat>(entity =>
        {
            entity.HasKey(e => e.AuxAuto).HasName("PRIMARY");

            entity.ToTable("sigpat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RecordNo, "PatRecord");

            entity.Property(e => e.DateSigned)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.DocSeqId).HasColumnName("DocSeqID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.SigImage).HasColumnType("mediumblob");
        });

        modelBuilder.Entity<StaticMessage>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.MedicoId }).HasName("PRIMARY");

            entity.ToTable("static_messages");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MedicoId).HasColumnName("medico_id");
            entity.Property(e => e.StaticMessage1).HasColumnName("static_message");
        });

        modelBuilder.Entity<Stmt>(entity =>
        {
            entity.HasKey(e => e.StatementId).HasName("PRIMARY");

            entity.ToTable("stmt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RespParty, "RespParty");

            entity.HasIndex(e => e.Sdate, "SDate");

            entity.Property(e => e.StatementId).HasColumnName("StatementID");
            entity.Property(e => e.AmountDue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime");
            entity.Property(e => e.Current)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Days30)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Days60)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Days90)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.DunMsg).HasMaxLength(80);
            entity.Property(e => e.EstDueValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.EstInsValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.FinCharge)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.LastBalance)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Message).HasMaxLength(80);
            entity.Property(e => e.MsgServFee).HasMaxLength(80);
            entity.Property(e => e.NewBalance)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OldBalance)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.OverPay)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PatEstDueValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PersonalMsg).HasMaxLength(80);
            entity.Property(e => e.Print)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Printed)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.RespParty).HasDefaultValueSql("'0'");
            entity.Property(e => e.Sdate)
                .HasColumnType("date")
                .HasColumnName("SDate");
            entity.Property(e => e.StmtType)
                .HasDefaultValueSql("'Batch'")
                .HasColumnType("enum('Batch','Immediate')");
        });

        modelBuilder.Entity<Stmtbal>(entity =>
        {
            entity.HasKey(e => e.AuxAuto).HasName("PRIMARY");

            entity.ToTable("stmtbal");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RespParty, "RespParty");

            entity.HasIndex(e => new { e.RespParty, e.Sdate }, "RespPartySDate");

            entity.HasIndex(e => e.Sdate, "SDate");

            entity.Property(e => e.Balance)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RespParty).HasDefaultValueSql("'0'");
            entity.Property(e => e.Sdate)
                .HasColumnType("date")
                .HasColumnName("SDate");
            entity.Property(e => e.StatementId).HasColumnName("StatementID");
        });

        modelBuilder.Entity<Stmtnote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stmtnote");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RespParty, "RespParty").IsUnique();

            entity.Property(e => e.Note).HasMaxLength(80);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Recur)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
        });

        modelBuilder.Entity<Stmtopt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stmtopt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ID");
            entity.Property(e => e.AmExpress)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Apr)
                .HasPrecision(4, 3)
                .HasDefaultValueSql("'0.000'")
                .HasColumnName("APR");
            entity.Property(e => e.Discover)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.DueDays).HasDefaultValueSql("'25'");
            entity.Property(e => e.DunMinBalance)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.DunMsgOn)
                .HasDefaultValueSql("'Balance'")
                .HasColumnType("enum('Last Payment','Balance')");
            entity.Property(e => e.Esp)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')")
                .HasColumnName("ESP");
            entity.Property(e => e.InsPending)
                .HasMaxLength(15)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.LastSentDays).HasDefaultValueSql("'0'");
            entity.Property(e => e.MasterCard)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.MinServiceFee)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.MsgAll).HasMaxLength(80);
            entity.Property(e => e.MsgCurrent).HasMaxLength(80);
            entity.Property(e => e.MsgDun30).HasMaxLength(80);
            entity.Property(e => e.MsgDun60).HasMaxLength(80);
            entity.Property(e => e.MsgDun90).HasMaxLength(80);
            entity.Property(e => e.MsgServFee).HasMaxLength(80);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PastHistory)
                .HasDefaultValueSql("'Standard'")
                .HasColumnType("enum('Standard','90','60','120')");
            entity.Property(e => e.PrintBalance)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PrintCredit)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ServFeeDays).HasDefaultValueSql("'0'");
            entity.Property(e => e.ServFeeInt)
                .HasDefaultValueSql("'30'")
                .HasColumnType("mediumint unsigned");
            entity.Property(e => e.Visa)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
        });

        modelBuilder.Entity<Stmtoptimg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stmtoptimg");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.Id, "ID_2");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OptionsImage).HasColumnType("mediumblob");
            entity.Property(e => e.Sdate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("SDate");
            entity.Property(e => e.Stime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("STime");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Stmttemp>(entity =>
        {
            entity.HasKey(e => e.RespParty).HasName("PRIMARY");

            entity.ToTable("stmttemp");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ChrgInterest)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Current)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Days30)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Days60)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Days90)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.SendDunning)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
        });

        modelBuilder.Entity<Stmttrt>(entity =>
        {
            entity.HasKey(e => e.TrtId).HasName("PRIMARY");

            entity.ToTable("stmttrt");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.StatementId, "StatementID");

            entity.Property(e => e.TrtId).HasColumnName("TrtID");
            entity.Property(e => e.ClaimId)
                .HasMaxLength(15)
                .HasColumnName("ClaimID");
            entity.Property(e => e.ClaimStatus).HasDefaultValueSql("'1'");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.EstValue)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.InsuranceId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("InsuranceID");
            entity.Property(e => e.LastSubmitDate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ProviderID");
            entity.Property(e => e.StatementId).HasColumnName("StatementID");
            entity.Property(e => e.Surface).HasDefaultValueSql("'0'");
            entity.Property(e => e.Tdate)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("TDate");
            entity.Property(e => e.ToPrimary)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.ToSecondary)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Tooth)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.TrtDesc)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Ttime)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time")
                .HasColumnName("TTime");
            entity.Property(e => e.ValueEnt).HasPrecision(12);
            entity.Property(e => e.ValuePac).HasPrecision(12);
        });

        modelBuilder.Entity<Subproduct>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("subproducts");

            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("active");
        });

        modelBuilder.Entity<Tabcore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabcores");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodCor, "idxprimary").IsUnique();

            entity.Property(e => e.CodCor).ValueGeneratedOnAdd();
            entity.Property(e => e.NomeCor)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Tabelap>(entity =>
        {
            entity.HasKey(e => e.CodT).HasName("PRIMARY");

            entity.ToTable("tabelap");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.CodT)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Abrev).HasMaxLength(30);
            entity.Property(e => e.AdjType)
                .HasDefaultValueSql("'Patient Adjustment'")
                .HasColumnType("enum('Patient Payment','Insurance Payment','Insurance Adjustment','Patient Adjustment','System')");
            entity.Property(e => e.Billable)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Category).HasDefaultValueSql("'0'");
            entity.Property(e => e.Credit)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.Inactive)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
            entity.Property(e => e.NameP).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RptGroupId).HasColumnName("RptGroupID");
            entity.Property(e => e.Warning)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Yes','No')");
        });

        modelBuilder.Entity<Tabelat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabelat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Desactivar, e.Entidade, e.TipoTrat, e.Abrev }, "idxAbrev");

            entity.HasIndex(e => e.Abrev, "idxNomeAbrev");

            entity.HasIndex(e => new { e.Especialidade, e.CodT, e.Entidade }, "idxPrimary").IsUnique();

            entity.HasIndex(e => new { e.TipoTrat, e.Abrev }, "idxTipo");

            entity.HasIndex(e => e.FlexGroup, "idxTrtGroup");

            entity.HasIndex(e => e.TrtRecall, "idxTrtRecall");

            entity.Property(e => e.Abrev)
                .HasMaxLength(30)
                .HasDefaultValueSql("''");
            entity.Property(e => e.AvisaAuto)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.CodComissao).HasDefaultValueSql("'0'");
            entity.Property(e => e.CodE).HasMaxLength(20);
            entity.Property(e => e.CodT)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Desactivar)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Entidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Especial)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Especialidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Factura)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No','Patient','Insurance')");
            entity.Property(e => e.FlexGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Grafico).HasColumnType("blob");
            entity.Property(e => e.ImprimeUltimoDia)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Location)
                .HasDefaultValueSql("'N/A'")
                .HasColumnType("enum('Anterior','Posterior','N/A')");
            entity.Property(e => e.MarcaFaces)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.MesesPorDente)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.NeedQuad)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.NomeT).HasMaxLength(50);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ProgressNote)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.ShowShapes)
                .HasDefaultValueSql("'Yes'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.SurfacesReq).HasDefaultValueSql("'0'");
            entity.Property(e => e.TipoTrat).HasDefaultValueSql("'0'");
            entity.Property(e => e.TiraDente)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.ToothKind)
                .HasDefaultValueSql("'N/A'")
                .HasColumnType("enum('Incisor','Cuspid','Bicuspid','Molar','N/A')");
            entity.Property(e => e.ToothType)
                .HasDefaultValueSql("'N/A'")
                .HasColumnType("enum('Primary','Permanent','N/A')");
            entity.Property(e => e.TrtClass)
                .HasDefaultValueSql("'Other'")
                .HasColumnType("enum('Doctor','Hygienist','Other')");
            entity.Property(e => e.TrtKind)
                .HasDefaultValueSql("'Treatment'")
                .HasColumnType("enum('Treatment','Debit','System','Condition')");
            entity.Property(e => e.TrtRecall)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.UseMaterial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('No','Yes')");
            entity.Property(e => e.ValBenef).HasPrecision(12);
            entity.Property(e => e.ValEntid).HasPrecision(12);
            entity.Property(e => e.ValUnit)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
        });

        modelBuilder.Entity<Tabelataviso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabelataviso");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Especialidade, e.CodT, e.Entidade }, "idxPrimary").IsUnique();

            entity.Property(e => e.CodT)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Entidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.Especialidade).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Texto).HasColumnType("tinytext");
        });

        modelBuilder.Entity<Tabelatimg>(entity =>
        {
            entity.HasKey(e => new { e.Especialidade, e.CodT, e.Entidade, e.Dente }).HasName("PRIMARY");

            entity.ToTable("tabelatimg");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.CodT)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CoroaL)
                .HasColumnType("blob")
                .HasColumnName("Coroa_L");
            entity.Property(e => e.CoroaO)
                .HasColumnType("blob")
                .HasColumnName("Coroa_O");
            entity.Property(e => e.CoroaV)
                .HasColumnType("blob")
                .HasColumnName("Coroa_V");
            entity.Property(e => e.LingualD)
                .HasColumnType("blob")
                .HasColumnName("Lingual_D");
            entity.Property(e => e.LingualL)
                .HasColumnType("blob")
                .HasColumnName("Lingual_L");
            entity.Property(e => e.LingualM)
                .HasColumnType("blob")
                .HasColumnName("Lingual_M");
            entity.Property(e => e.OclusalD)
                .HasColumnType("blob")
                .HasColumnName("Oclusal_D");
            entity.Property(e => e.OclusalL)
                .HasColumnType("blob")
                .HasColumnName("Oclusal_L");
            entity.Property(e => e.OclusalM)
                .HasColumnType("blob")
                .HasColumnName("Oclusal_M");
            entity.Property(e => e.OclusalO)
                .HasColumnType("blob")
                .HasColumnName("Oclusal_O");
            entity.Property(e => e.OclusalV)
                .HasColumnType("blob")
                .HasColumnName("Oclusal_V");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RaizL)
                .HasColumnType("blob")
                .HasColumnName("Raiz_L");
            entity.Property(e => e.RaizV)
                .HasColumnType("blob")
                .HasColumnName("Raiz_V");
            entity.Property(e => e.VestibularD)
                .HasColumnType("blob")
                .HasColumnName("Vestibular_D");
            entity.Property(e => e.VestibularM)
                .HasColumnType("blob")
                .HasColumnName("Vestibular_M");
            entity.Property(e => e.VestibularV)
                .HasColumnType("blob")
                .HasColumnName("Vestibular_V");
        });

        modelBuilder.Entity<Tabfav>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabfav");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.UserId, e.CodT }, "UserIdIdx").IsUnique();

            entity.Property(e => e.CodT).HasMaxLength(6);
            entity.Property(e => e.Kind)
                .HasDefaultValueSql("'Treatment'")
                .HasColumnType("enum('Treatment','Payment')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.UserId).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Tabimplante>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabimplante");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodImp, "idxPrimary").IsUnique();

            entity.Property(e => e.CodImp).HasDefaultValueSql("'0'");
            entity.Property(e => e.NomeImp).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Taboprc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("taboprc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Acod, "idxPrimary").IsUnique();

            entity.Property(e => e.Aclass).HasColumnName("AClass");
            entity.Property(e => e.Acod)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ACod");
            entity.Property(e => e.Acond)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')")
                .HasColumnName("ACond");
            entity.Property(e => e.AnomeOper)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("ANomeOper");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Tabpag>(entity =>
        {
            entity.HasKey(e => e.CodPag).HasName("PRIMARY");

            entity.ToTable("tabpag");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoPag)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Tabregossea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabregossea");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.RegTipo, "idxPrimary").IsUnique();

            entity.Property(e => e.DescRegOssea).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RegTipo).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Tabrptgroup>(entity =>
        {
            entity.HasKey(e => e.RptGroupId).HasName("PRIMARY");

            entity.ToTable("tabrptgroup");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.RptGroupId).HasColumnName("RptGroupID");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RptGroup)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Tabspdgroup>(entity =>
        {
            entity.HasKey(e => e.SpdGroupId).HasName("PRIMARY");

            entity.ToTable("tabspdgroup");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.UserId, e.Category }, "UserIdIdx");

            entity.Property(e => e.SpdGroupId).HasColumnName("SpdGroupID");
            entity.Property(e => e.Category).HasMaxLength(30);
            entity.Property(e => e.CodT).HasMaxLength(6);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Tccat>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PRIMARY");

            entity.ToTable("tccat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.TimeCategory, "TimeCategoryIDX").IsUnique();

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TimeCategory)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Tcevent>(entity =>
        {
            entity.HasKey(e => e.ClockEventId).HasName("PRIMARY");

            entity.ToTable("tcevents");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.UserId, e.ClockInTime }, "UserIDClockInTimeIDX");

            entity.HasIndex(e => e.UserId, "UserIDX");

            entity.Property(e => e.ClockEventId).HasColumnName("ClockEventID");
            entity.Property(e => e.ClockInTime).HasColumnType("datetime");
            entity.Property(e => e.ClockOutTime).HasColumnType("datetime");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TimeCategory)
                .HasMaxLength(40)
                .HasDefaultValueSql("'Regular'");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Terceiro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("terceiro");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Numero, "idxPrimary").IsUnique();

            entity.Property(e => e.CodPos).HasMaxLength(8);
            entity.Property(e => e.Contrib).HasMaxLength(15);
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("EMail");
            entity.Property(e => e.Foto).HasColumnType("blob");
            entity.Property(e => e.Localid).HasMaxLength(40);
            entity.Property(e => e.MemoObs).HasColumnType("tinytext");
            entity.Property(e => e.Morada).HasMaxLength(40);
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TelMov).HasMaxLength(15);
            entity.Property(e => e.Telef1).HasMaxLength(15);
            entity.Property(e => e.Telef2).HasMaxLength(15);
            entity.Property(e => e.Www)
                .HasMaxLength(128)
                .HasColumnName("www");
        });

        modelBuilder.Entity<Timeblock>(entity =>
        {
            entity.HasKey(e => e.TimeBlockId).HasName("PRIMARY");

            entity.ToTable("timeblock");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.TimeBlockId, "TimeBlockID").IsUnique();

            entity.Property(e => e.TimeBlockId)
                .HasMaxLength(36)
                .HasDefaultValueSql("'0'")
                .HasColumnName("TimeBlockID");
            entity.Property(e => e.Caption).HasMaxLength(32);
            entity.Property(e => e.EndTime).HasColumnType("time");
            entity.Property(e => e.FontSize).HasDefaultValueSql("'0'");
            entity.Property(e => e.FontStyle).HasMaxLength(10);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.RecurrenceId)
                .HasMaxLength(36)
                .HasColumnName("RecurrenceID");
            entity.Property(e => e.StartTime).HasColumnType("time");
        });

        modelBuilder.Entity<Timeblocklink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timeblocklinks");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.BlockCaption).HasMaxLength(32);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Resource).HasMaxLength(32);
        });

        modelBuilder.Entity<Tipoacesso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tipoacesso");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.CodTipo, "idxPrimary").IsUnique();

            entity.Property(e => e.NomeTipo)
                .HasMaxLength(40)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Tipooper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tipooper");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Cod, "idxPrimary").IsUnique();

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoOper)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Tipoprot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tipoprot");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.TipoPt, "idxPrimary").IsUnique();

            entity.Property(e => e.NomePt)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("NomePT");
            entity.Property(e => e.Obs).HasMaxLength(30);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TipoPt)
                .HasDefaultValueSql("'0'")
                .HasColumnName("TipoPT");
        });

        modelBuilder.Entity<Tipot>(entity =>
        {
            entity.HasKey(e => e.TipoTrat).HasName("PRIMARY");

            entity.ToTable("tipot");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.TipoTrat, "idxPrimary").IsUnique();

            entity.Property(e => e.DescTipoTt)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("DescTipoTT");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Toothloc>(entity =>
        {
            entity.HasKey(e => e.Tooth).HasName("PRIMARY");

            entity.ToTable("toothloc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.Tooth)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Location).HasMaxLength(20);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ToothKind).HasMaxLength(20);
        });

        modelBuilder.Entity<Toothstat>(entity =>
        {
            entity.HasKey(e => e.PatientNumber).HasName("PRIMARY");

            entity.ToTable("toothstat");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.ToothPage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Tratdel>(entity =>
        {
            entity.HasKey(e => e.DelSeq).HasName("PRIMARY");

            entity.ToTable("tratdel");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.CctransId)
                .HasMaxLength(10)
                .HasColumnName("CCTransID");
            entity.Property(e => e.Clinico).HasDefaultValueSql("'0'");
            entity.Property(e => e.CorMaterial).HasDefaultValueSql("'0'");
            entity.Property(e => e.DeleteUser).HasDefaultValueSql("'0'");
            entity.Property(e => e.DeleteWhen).HasColumnType("date");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Especial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Guia)
                .HasMaxLength(15)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Inicial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.TaxValue)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.TrtKind)
                .HasDefaultValueSql("'Debit'")
                .HasColumnType("enum('Credit','Debit')");
            entity.Property(e => e.Tstatus)
                .HasDefaultValueSql("'ToCheck'")
                .HasColumnType("enum('ToCheck','Checked','ToClaim')")
                .HasColumnName("TStatus");
            entity.Property(e => e.ValueChanged)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueChangedGlobal)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueEnt)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValuePac)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValuePaid)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValuePay).HasPrecision(12);
        });

        modelBuilder.Entity<Tratexec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tratexec");

            entity.HasIndex(e => e.Guia, "ClaimIDIDX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Tstatus }, "PacTStatus");

            entity.HasIndex(e => new { e.SitFac, e.IsPaid }, "SitFacIDX");

            entity.HasIndex(e => new { e.Pac, e.Dente, e.Inicial, e.Face }, "idxDente");

            entity.HasIndex(e => e.Dia, "idxDia");

            entity.HasIndex(e => new { e.Pac, e.Entidade }, "idxEntidade");

            entity.HasIndex(e => new { e.Pac, e.Especial, e.Dia, e.Time }, "idxPacEspDiaTime");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Trat, e.Time, e.Inicial, e.Face, e.AuxAuto, e.OfficeId }, "idxPrimary").IsUnique();

            entity.HasIndex(e => new { e.Pac, e.Trat, e.Entidade, e.Dia }, "idxRelaciona");

            entity.HasIndex(e => e.AuxAuto, "idxTratexecAuxAuto").IsUnique();

            entity.Property(e => e.AuxAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.CorMaterial).HasDefaultValueSql("'0'");
            entity.Property(e => e.CreatedBy).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Especial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.Guia)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Inicial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.IsPaid).HasColumnType("enum('Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PlanoGeral).HasDefaultValueSql("'-1'");
            entity.Property(e => e.TaxValue)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tstatus)
                .HasDefaultValueSql("'None'")
                .HasColumnType("enum('None','ToCheck','Checked','ToClaim','ToXClaim')")
                .HasColumnName("TStatus");
            entity.Property(e => e.ValueChanged)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueEnt)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValueEnt2)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValuePac)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValuePaid)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ValuePpo)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("ValuePPO");
        });

        modelBuilder.Entity<Tratexecor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tratexecor");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Mecano, e.InicialTrat, e.Dente }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'")
                .IsFixedLength();
            entity.Property(e => e.InicialTrat)
                .HasDefaultValueSql("'Inic'")
                .HasColumnType("enum('Inic','Trat','Init','Trt')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Tratlink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tratlink");

            entity.HasIndex(e => e.AuxAuto, "AuxAuto").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.PayLink, "PayLink");

            entity.HasIndex(e => e.TratLink, "TratLink");

            entity.HasIndex(e => new { e.Pac, e.Inicial }, "idxDente");

            entity.HasIndex(e => e.Dia, "idxDia");

            entity.HasIndex(e => e.Pac, "idxEntidade");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Time }, "idxPacEspDiaTime");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Trat, e.Time, e.Inicial, e.AuxAuto }, "idxPrimary").IsUnique();

            entity.HasIndex(e => new { e.Pac, e.Trat, e.Dia }, "idxRelaciona");

            entity.Property(e => e.AuxAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Doctor).HasDefaultValueSql("'0'");
            entity.Property(e => e.Guia)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Inicial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PayLink).HasDefaultValueSql("'0'");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TratLink).HasDefaultValueSql("'0'");
            entity.Property(e => e.ValuePaid)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<Tratpay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tratpay");

            entity.HasIndex(e => e.AuxAuto, "AuxAuto").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Inicial }, "idxDente");

            entity.HasIndex(e => e.Dia, "idxDia");

            entity.HasIndex(e => e.Pac, "idxEntidade");

            entity.HasIndex(e => e.Inicial, "idxInicial");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Time }, "idxPacEspDiaTime");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Trat, e.Time, e.Inicial, e.AuxAuto }, "idxPrimary").IsUnique();

            entity.HasIndex(e => new { e.Pac, e.Trat, e.Dia }, "idxRelaciona");

            entity.Property(e => e.AltDesc).HasColumnType("tinytext");
            entity.Property(e => e.AuxAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.Ccard)
                .HasMaxLength(4)
                .HasColumnName("CCard");
            entity.Property(e => e.CcrefId)
                .HasMaxLength(64)
                .HasColumnName("CCRefID");
            entity.Property(e => e.CctransId)
                .HasMaxLength(12)
                .HasColumnName("CCTransID");
            entity.Property(e => e.ClaimId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ClaimID");
            entity.Property(e => e.Clinico).HasDefaultValueSql("'0'");
            entity.Property(e => e.CreatedBy).HasDefaultValueSql("'0'");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Guia)
                .HasMaxLength(15)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Inicial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.InsSeq).HasMaxLength(10);
            entity.Property(e => e.LastTrtAuxAuto).HasDefaultValueSql("'0'");
            entity.Property(e => e.MasterLink).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.TransType)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ValuePay).HasPrecision(12);
        });

        modelBuilder.Entity<Tratref>(entity =>
        {
            entity.HasKey(e => e.AuxAuto).HasName("PRIMARY");

            entity.ToTable("tratref");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => e.Pac, "TratRefPacIDX");

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OtherData)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Provider)
                .HasMaxLength(20)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Surface)
                .HasMaxLength(6)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Tooth)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Trat)
                .HasMaxLength(10)
                .HasDefaultValueSql("''");
            entity.Property(e => e.TrtDesc).HasMaxLength(40);
            entity.Property(e => e.ValuePac)
                .HasPrecision(12)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<TwilioSm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("twilio_sms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NumberFrom)
                .HasMaxLength(50)
                .HasColumnName("number_from");
            entity.Property(e => e.NumberTo)
                .HasMaxLength(50)
                .HasColumnName("number_to");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Readed)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("readed");
            entity.Property(e => e.Sended)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')")
                .HasColumnName("sended");
            entity.Property(e => e.SidTwilio)
                .HasColumnType("text")
                .HasColumnName("sid_twilio");
            entity.Property(e => e.TextMessage)
                .HasColumnType("text")
                .HasColumnName("text_message");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.TypeMessage)
                .HasDefaultValueSql("'InToOut'")
                .HasColumnType("enum('InToOut','OutToIn')")
                .HasColumnName("type_message");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Urgencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("urgencias");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Medico, e.Dia, e.Hora }, "idxPrimary").IsUnique();

            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Medico).HasDefaultValueSql("'0'");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Urgencia1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("Urgencia");
        });

        modelBuilder.Entity<Userrepcalc>(entity =>
        {
            entity.HasKey(e => new { e.ReportName, e.FieldName }).HasName("PRIMARY");

            entity.ToTable("userrepcalc");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ReportName)
                .HasMaxLength(128)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FieldName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.CalcExpression).HasMaxLength(250);
            entity.Property(e => e.FieldType).HasMaxLength(10);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Userrepmlink>(entity =>
        {
            entity.HasKey(e => new { e.ReportName, e.FileNameRel, e.FieldNameBase }).HasName("PRIMARY");

            entity.ToTable("userrepmlink");

            entity.HasIndex(e => e.FieldShowRel, "FieldShowKey");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ReportName)
                .HasMaxLength(128)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FileNameRel)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FieldNameBase)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FieldNameRel)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FieldShowRel)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.FieldShowRelType)
                .HasMaxLength(32)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Userreport>(entity =>
        {
            entity.HasKey(e => new { e.ReportName, e.ReportField }).HasName("PRIMARY");

            entity.ToTable("userreports");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ReportName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ReportField)
                .HasMaxLength(32)
                .HasDefaultValueSql("''");
            entity.Property(e => e.AppAgenda)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.AppDentalChart)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.AppEspec)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.AppFact)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.AppFichasPac)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.AppMenu)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.AppTab)
                .HasDefaultValueSql("'Não'")
                .HasColumnType("enum('Sim','Não')");
            entity.Property(e => e.CallAutoReport1).HasMaxLength(64);
            entity.Property(e => e.CallAutoReport2).HasMaxLength(64);
            entity.Property(e => e.CallAutoReport3).HasMaxLength(64);
            entity.Property(e => e.Caption).HasMaxLength(64);
            entity.Property(e => e.JoinAux).HasMaxLength(32);
            entity.Property(e => e.JoinAuxField).HasMaxLength(64);
            entity.Property(e => e.JoinBaseFieldExt)
                .HasMaxLength(64)
                .HasColumnName("JoinBaseField_Ext");
            entity.Property(e => e.JoinTable).HasMaxLength(32);
            entity.Property(e => e.JoinTableField).HasMaxLength(32);
            entity.Property(e => e.JoinTableFieldExt)
                .HasMaxLength(64)
                .HasColumnName("JoinTableField_Ext");
            entity.Property(e => e.JoinTableFieldShow).HasMaxLength(64);
            entity.Property(e => e.JoinTableFieldType)
                .HasMaxLength(250)
                .HasColumnName("JoinTableField_Type");
            entity.Property(e => e.Logo16).HasColumnType("blob");
            entity.Property(e => e.Logo32).HasColumnType("blob");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OrderFields).HasColumnType("text");
            entity.Property(e => e.ReportFile)
                .HasMaxLength(32)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Sql)
                .HasColumnType("text")
                .HasColumnName("SQL");
        });

        modelBuilder.Entity<Userrepqry>(entity =>
        {
            entity.HasKey(e => new { e.ReportName, e.QueryField }).HasName("PRIMARY");

            entity.ToTable("userrepqry");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.ReportName)
                .HasMaxLength(128)
                .HasDefaultValueSql("''");
            entity.Property(e => e.QueryField)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("Query_Field");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.QueryDesc)
                .HasMaxLength(250)
                .HasColumnName("Query_Desc");
            entity.Property(e => e.QueryOper)
                .HasMaxLength(32)
                .HasColumnName("Query_Oper");
            entity.Property(e => e.QueryRefTable).HasColumnName("Query_Ref_Table");
            entity.Property(e => e.QueryType)
                .HasMaxLength(32)
                .HasColumnName("Query_Type");
            entity.Property(e => e.QueryValue1)
                .HasMaxLength(128)
                .HasColumnName("Query_Value1");
            entity.Property(e => e.QueryValue2)
                .HasMaxLength(128)
                .HasColumnName("Query_Value2");
            entity.Property(e => e.QueryValueEnum)
                .HasMaxLength(250)
                .HasColumnName("Query_Value_Enum");
        });

        modelBuilder.Entity<Userreptemplate>(entity =>
        {
            entity.HasKey(e => e.RbnameField).HasName("PRIMARY");

            entity.ToTable("userreptemplates");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.RbnameField)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("RBNameField");
            entity.Property(e => e.Logo16).HasColumnType("blob");
            entity.Property(e => e.Logo32).HasColumnType("blob");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Rbdescription)
                .HasColumnType("text")
                .HasColumnName("RBDescription");
            entity.Property(e => e.RbmenuTag)
                .HasDefaultValueSql("'0'")
                .HasColumnName("RBMenuTag");
            entity.Property(e => e.Rbquery)
                .HasColumnType("text")
                .HasColumnName("RBQuery");
            entity.Property(e => e.Rbtemplate)
                .HasColumnType("mediumblob")
                .HasColumnName("RBTemplate");
        });

        modelBuilder.Entity<VTwilioListPatient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_twilio_list_patients");

            entity.Property(e => e.CurrTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("curr_timestamp");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastMessage)
                .HasColumnType("text")
                .HasColumnName("last_message");
            entity.Property(e => e.NumberFrom)
                .HasMaxLength(50)
                .HasColumnName("number_from");
            entity.Property(e => e.NumberTo)
                .HasMaxLength(50)
                .HasColumnName("number_to");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.OwnerSms)
                .HasMaxLength(50)
                .HasColumnName("owner_sms");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PatientName)
                .HasMaxLength(54)
                .HasColumnName("patient_name");
            entity.Property(e => e.Picture)
                .HasMaxLength(0)
                .HasColumnName("picture");
        });

        modelBuilder.Entity<VTwilioListPatientsMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_twilio_list_patients_messages");

            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DoctorId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("doctor_id");
            entity.Property(e => e.DoctorName)
                .HasMaxLength(30)
                .HasColumnName("doctor_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MessageType)
                .HasMaxLength(7)
                .HasColumnName("message_type");
            entity.Property(e => e.NumberFrom)
                .HasMaxLength(50)
                .HasColumnName("number_from");
            entity.Property(e => e.NumberTo)
                .HasMaxLength(50)
                .HasColumnName("number_to");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PatientName)
                .HasMaxLength(19)
                .HasColumnName("patient_name");
            entity.Property(e => e.Prespparty)
                .HasDefaultValueSql("'0'")
                .HasColumnName("prespparty");
            entity.Property(e => e.TextMessage)
                .HasColumnType("text")
                .HasColumnName("text_message");
            entity.Property(e => e.Time)
                .HasColumnType("time")
                .HasColumnName("time");
        });

        modelBuilder.Entity<VTwilioListUnreadMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_twilio_list_unread_messages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NumberFrom)
                .HasMaxLength(50)
                .HasColumnName("number_from");
            entity.Property(e => e.NumberTo)
                .HasMaxLength(50)
                .HasColumnName("number_to");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.OwnerSms)
                .HasMaxLength(50)
                .HasColumnName("owner_sms");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PatientName)
                .HasMaxLength(54)
                .HasColumnName("patient_name");
            entity.Property(e => e.Picture).HasColumnName("picture");
            entity.Property(e => e.TextMessage)
                .HasColumnType("text")
                .HasColumnName("text_message");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<VagasTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vagas_tmp");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Dia, e.Clinico }, "idxvagas").IsUnique();

            entity.Property(e => e.Clinico).HasColumnName("clinico");
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date")
                .HasColumnName("dia");
            entity.Property(e => e.Ocupado).HasColumnName("ocupado");
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Percocup).HasColumnName("percocup");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<Valaltln>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("valaltln");

            entity.HasIndex(e => e.AuxAuto, "AuxAuto").IsUnique();

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.HasIndex(e => new { e.Pac, e.Dia, e.Trat, e.Time, e.Inicial, e.Face, e.AuxAuto }, "idxPrimary").IsUnique();

            entity.Property(e => e.AuxAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.Dia)
                .HasDefaultValueSql("'0000-00-00'")
                .HasColumnType("date");
            entity.Property(e => e.Inicial)
                .HasDefaultValueSql("'No'")
                .HasColumnType("enum('Sim','Não','Yes','No')");
            entity.Property(e => e.NovoValor).HasPrecision(12);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'00:00:00'")
                .HasColumnType("time");
            entity.Property(e => e.Trat)
                .HasMaxLength(6)
                .HasDefaultValueSql("''");
            entity.Property(e => e.ValorGlobal).HasPrecision(12);
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.HasKey(e => new { e.KeyName, e.OfficeId }).HasName("PRIMARY");

            entity.ToTable("variables");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.KeyName)
                .HasMaxLength(128)
                .HasDefaultValueSql("''");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<Wkstation>(entity =>
        {
            entity.HasKey(e => e.WkStationId).HasName("PRIMARY");

            entity.ToTable("wkstations");

            entity.HasIndex(e => new { e.ComputerName, e.WkType }, "NameTypeIX");

            entity.HasIndex(e => e.OfficeId, "OfficeIDX");

            entity.Property(e => e.WkStationId).HasColumnName("WkStationID");
            entity.Property(e => e.ComputerName).HasMaxLength(120);
            entity.Property(e => e.OfficeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("OfficeID");
            entity.Property(e => e.WkType)
                .HasDefaultValueSql("'Ink'")
                .HasColumnType("enum('Ink')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
