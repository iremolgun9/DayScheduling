namespace DayScheduling.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaceType")]
    public partial class PlaceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlaceType()
        {
            Places = new HashSet<Place>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaceTypeID { get; set; }

        [Column("PlaceType")]
        [Required]
        [StringLength(255)]
        public string PlaceType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Place> Places { get; set; }
    }
}
