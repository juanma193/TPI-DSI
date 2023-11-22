﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDSI.Modelos
{
    public class Finalizada : Estado
    {
        public override bool esEnCurso()
        {
            return false;
        }
        public override bool esFinalizada()
        {
            return true;
        }
    }
}