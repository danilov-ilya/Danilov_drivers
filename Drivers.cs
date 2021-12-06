namespace ВодителиВАР3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string middlename { get; set; }

        [Required]
        public string patronymic { get; set; }

        [Required]
        public string Ссерия_и_номер_паспорта { get; set; }

        [Required]
        public string postcode { get; set; }

        [Required]
        public string address { get; set; }

        public string address_life { get; set; }

        [Required]
        public string company { get; set; }

        [Required]
        public string jobname { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string photo { get; set; }

        public string decription { get; set; }
    }
}
