namespace DayScheduling.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DaySchedulingModelDataModels : DbContext
    {
        public DaySchedulingModelDataModels()
            : base("name=DaySchedulingModelDataModels")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<PlaceType> PlaceTypes { get; set; }
        public virtual DbSet<PlanCreator> PlanCreators { get; set; }
        public virtual DbSet<PlanCriteria> PlanCriterias { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PlaceOwner> PlaceOwners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Plans)
                .WithMany(e => e.Accounts)
                .Map(m => m.ToTable("PlanHistory").MapLeftKey("AccountID").MapRightKey("PlanID"));

            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityName)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityType)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityPlaceID);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Plans)
                .WithMany(e => e.Activities)
                .Map(m => m.ToTable("PlanActivity").MapLeftKey("ActivityID").MapRightKey("PlanID"));

            modelBuilder.Entity<Place>()
                .Property(e => e.PlaceName)
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.PlaceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<PlaceType>()
                .Property(e => e.PlaceType1)
                .IsUnicode(false);

            modelBuilder.Entity<PlanCriteria>()
                .Property(e => e.PlanType)
                .IsUnicode(false);

            modelBuilder.Entity<PlanCriteria>()
                .Property(e => e.GroupOfFriends)
                .IsUnicode(false);

            modelBuilder.Entity<PlanCriteria>()
                .Property(e => e.CurrentLocation)
                .IsUnicode(false);

            modelBuilder.Entity<PlanCriteria>()
                .Property(e => e.UserLifeStyle)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .Property(e => e.PlanName)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .Property(e => e.PlanType)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.QS)
                .IsUnicode(false);

            modelBuilder.Entity<Survey>()
                .Property(e => e.SurveyName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserSurname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserLifeStyle)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserAddress)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlaceOwner>()
                .Property(e => e.PlaceOwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<PlaceOwner>()
                .Property(e => e.PlaceOwnerSurname)
                .IsUnicode(false);

            modelBuilder.Entity<PlaceOwner>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<PlaceOwner>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
