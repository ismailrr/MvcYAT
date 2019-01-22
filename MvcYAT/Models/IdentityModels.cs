using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MvcYAT.Data;
//using MySql.Data.Entity;

namespace MvcYAT.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base()

        {
            Database.SetInitializer<ApplicationDbContext>(new DbInitializer());
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        public DbSet<Admin> DaftarAdmin { get; set; }
        public DbSet<Tag> DaftarTag { get; set; }
        public DbSet<Inspirasi> DaftarInspirasi { get; set; }
        public DbSet<InspirasiTag> DaftarInspirasiTag { get; set; }
        public DbSet<AmanahBinaQuran> DaftarAmanahBinaQuran { get; set; }
        public DbSet<AmanahWakaf> DaftarAmanahWakaf { get; set; }
        public DbSet<Ambulance> DaftarAmbulance { get; set; }
        public DbSet<Baktilah> DaftarBaktilah { get; set; }
        public DbSet<BantuanKesehatan> DaftarBantuanKesehatan { get; set; }
        public DbSet<BantuanKritis> DaftarBantuanKritis { get; set; }
        public DbSet<BantuanSosial> DaftarBantuanSosial { get; set; }
        public DbSet<Beasiswa> DaftarBeasiswa { get; set; }
        public DbSet<BencanaAlam> DaftarBencanaAlam { get; set; }
        public DbSet<Best> DaftarBest { get; set; }
        public DbSet<Dpn> DaftarDpn { get; set; }
        public DbSet<DuniaIslam> DaftarDuniaIslam { get; set; }
        public DbSet<Koperasi> DaftarKoperasi { get; set; }
        public DbSet<Modal> DaftarModal { get; set; }
        public DbSet<Mtv> DaftarMtv { get; set; }
        public DbSet<Pelayanan> DaftarPelayanan { get; set; }
        public DbSet<Ramadhan> DaftarRamadhan { get; set; }
        public DbSet<Sejahtera> DaftarSejahtera { get; set; }
        public DbSet<Tas> DaftarTas { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Admin>().ToTable("admin");
            builder.Entity<Tag>().ToTable("tag");
            builder.Entity<Inspirasi>().ToTable("inspirasi");
            builder.Entity<InspirasiTag>().ToTable("inspirasitag");
            builder.Entity<AmanahBinaQuran>().ToTable("amanahbinaqruan");
            builder.Entity<AmanahWakaf>().ToTable("amanahwakaf");
            builder.Entity<Ambulance>().ToTable("ambulance");
            builder.Entity<Baktilah>().ToTable("baktilah");
            builder.Entity<BantuanKesehatan>().ToTable("bantuankesehatan");
            builder.Entity<BantuanKritis>().ToTable("bantuankritis");
            builder.Entity<BantuanSosial>().ToTable("bantuansosial");
            builder.Entity<Beasiswa>().ToTable("beasiswa");
            builder.Entity<BencanaAlam>().ToTable("becancaalam");
            builder.Entity<Best>().ToTable("best");
            builder.Entity<Dpn>().ToTable("dpn");
            builder.Entity<DuniaIslam>().ToTable("duniaislam");
            builder.Entity<Koperasi>().ToTable("koperasi");
            builder.Entity<Modal>().ToTable("modal");
            builder.Entity<Mtv>().ToTable("mtv");
            builder.Entity<Pelayanan>().ToTable("pelayanan");
            builder.Entity <Ramadhan>().ToTable("ramadhan");
            builder.Entity<Sejahtera>().ToTable("sejahtera");
            builder.Entity<Tas>().ToTable("tas");
            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        //}
    }

}