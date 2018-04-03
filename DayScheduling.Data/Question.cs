namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionID { get; set; }

        [Required]
        [StringLength(50)]
        public string QS { get; set; }
    }
}
