﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Rating
    {

        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public double? StarReview { get; set; }
        public string TextReview { get; set; }


        //Navigation properties... first "User" is the class User and 2nd is property User...Same for "Business"
        public virtual User User { get; set; }
        public virtual Business Business { get; set; }

    }
}