﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    class TacoBell : TacoParser,ITrackable
    {

        public TacoBell()
        {

        }
        public string Name { get ; set; }
        public Point Location { get; set; }


    }
}
