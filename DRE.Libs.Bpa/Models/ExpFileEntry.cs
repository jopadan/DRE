﻿namespace DRE.Libs.Bpa.Models
{
    public class ExpFileEntry
    {
        public int id { get; set; }

        public Byte[] Data { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public bool rix { get; set; }
    }
}
