using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Guitar : MusicalInstrument
    {
        public string GuitarColor { get; set; }

        public override string ToString()
        {
            return ($"Brand: {Brand}, Color: {GuitarColor}");
        }
    }
}
