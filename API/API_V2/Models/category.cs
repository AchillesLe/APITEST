namespace API_V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shoptestdb.category")]
    public partial class category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCategory { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        public int idCreator { get; set; }

        public int? isDelete { get; set; }

        public DateTime? createdDate { get; set; }

        public DateTime? updatedDate { get; set; }
    }
}
