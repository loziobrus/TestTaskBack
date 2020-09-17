using System;
using System.Collections.Generic;
using TestTask.Core.DTO;

namespace TestTask.Core.Entities
{
    public class Announcement
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
