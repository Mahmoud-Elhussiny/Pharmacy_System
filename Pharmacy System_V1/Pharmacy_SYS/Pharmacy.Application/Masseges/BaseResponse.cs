﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Application.Masseges
{
    public abstract class BaseRessponse:BaseMasseges
    {
        public BaseRessponse() {  }
        public BaseRessponse(Guid correlationId):base()
        {
            _correlationId = correlationId;
        }
    }
}
