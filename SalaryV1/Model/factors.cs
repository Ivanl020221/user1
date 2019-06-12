namespace SalaryV1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class factors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int manager_id { get; set; }

        public int Junior__min_ { get; set; }

        public int Middle__min_ { get; set; }

        public int Senior__min_ { get; set; }

        public decimal analysis { get; set; }

        public decimal deployment { get; set; }

        public decimal support { get; set; }

        public decimal time_factor { get; set; }

        public decimal hard_factor { get; set; }

        public decimal money_factor { get; set; }

        public virtual manager manager { get; set; }
    }
}
