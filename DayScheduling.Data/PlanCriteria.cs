namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlanCriteria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PCID { get; set; }

        public bool FirstBeenThere { get; set; }

        [StringLength(255)]
        public string PlanType { get; set; }

        public int BudgetInfo { get; set; }

        [Required]
        [StringLength(255)]
        public string GroupOfFriends { get; set; }

        public DateTime DateInterval { get; set; }

        [Required]
        [StringLength(255)]
        public string CurrentLocation { get; set; }

        [Required]
        [StringLength(255)]
        public string UserLifeStyle { get; set; }
    }
}
