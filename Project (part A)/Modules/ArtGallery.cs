﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ArtGallery
    {
        public string Name { get; set; }
        public Curator Curator { get; set; }
        public List<Painting> Paintings { get; set; }

        public ArtGallery(string name, Curator curator, List<Artist> artists)
        {
            throw new NotImplementedException();
        }
    }
}
