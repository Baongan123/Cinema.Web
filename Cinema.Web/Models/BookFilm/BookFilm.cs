﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Models.BookFilm
{
    public class BookFilm
    {
        public int CusId { get; set; }
        public int ShowingId { get; set; }
        public string ListChair { get; set; }
        public int CountTicket { get; set; }
        public int PriceTiket { get; set; }
        public int TotalPrice { get; set; }
    }
}
