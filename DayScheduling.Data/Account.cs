namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Plans = new HashSet<Plan>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountID { get; set; }

        public int UserID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountType { get; set; }

        [StringLength(255)]
        public string AccountPassword { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
