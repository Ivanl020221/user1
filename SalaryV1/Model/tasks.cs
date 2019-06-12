namespace SalaryV1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tasks
    {
        [Key]
        public int id_task { get; set; }

        public int executor_id { get; set; }

        [Required]
        [StringLength(250)]
        public string header { get; set; }

        public int hark { get; set; }

        public int status_id { get; set; }

        public int kind_id { get; set; }

        public int? run_time { get; set; }

        public int? delete_status_id { get; set; }

        public virtual delete_stasus delete_stasus { get; set; }

        public virtual executor executor { get; set; }

        public virtual kind_of_work kind_of_work { get; set; }

        public virtual status_task status_task { get; set; }
    }
}
