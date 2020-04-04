﻿using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModel
{
    public class GigFormViewModel
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}