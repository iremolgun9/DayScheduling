namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanCreator")]
    public partial class PlanCreator
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlanCreatorID { get; set; }
    }
}
