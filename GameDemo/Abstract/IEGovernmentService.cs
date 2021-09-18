using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IEGovernmentService
    {
        bool IdentifyNationalityId(string firstName, string lastName, string nationalityId, int dateOfBirth);
    }
}
