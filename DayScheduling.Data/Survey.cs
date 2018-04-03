namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Survey")]
    public partial class Survey
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SurveyID { get; set; }

        [StringLength(255)]
        public string SurveyName { get; set; }
    }
}
