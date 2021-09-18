using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class EGovernmentManager : IEGovernmentService
    {
        public bool IdentifyNationalityId(string firstName, string lastName, string nationalityId, int dateOfBirth)
        {
            bool result = false;
            if (firstName.Equals("Egemen") && lastName.Equals("Özyürek") && nationalityId.Equals("12345678910") && dateOfBirth==1996)
            {
                result = true;
            }
            return result;
        }
    }
}
