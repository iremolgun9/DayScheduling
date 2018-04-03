namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Accounts = new HashSet<Account>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(255)]
        public string UserSurname { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        [Required]
        [StringLength(255)]
        public string UserLifeStyle { get; set; }

        [Required]
        [StringLength(255)]
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string UserAddress { get; set; }

        [StringLength(255)]
        public string Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
