namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaceOwner")]
    public partial class PlaceOwner
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaceOwnerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PlaceOwnerName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PlaceOwnerSurname { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
    }
}
