﻿using Dentistry_Diplom.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Dentistry_Diplom.Data.Interfaces
{
    interface IAllDentistry
    {
        IEnumerable<DentistryInfo> Dentistrys { get; }
        IEnumerable<DentistryInfo> getFavDentistry { get; }
        DentistryInfo getSingleDentistry(int dentistryId);
    }
}
