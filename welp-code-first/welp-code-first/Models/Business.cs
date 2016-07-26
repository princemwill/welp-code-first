using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Business
    {

        public int BusinessID { get; set; }

        [MaxLength(50)]
        public string BusinessName { get; set; }
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Hours { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Menu { get; set; }
        public int UserID { get; set; }

        //Navigation properties
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual BusinessType BusinessType { get; set; }


    }
}