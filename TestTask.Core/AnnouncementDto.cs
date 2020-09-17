﻿using System;
using System.Collections.Generic;

namespace TestTask.Core.DTO
{
    public class AnnouncementDto 
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
