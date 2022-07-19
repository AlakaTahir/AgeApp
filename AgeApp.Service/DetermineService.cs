using AgeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp.Service
{
    public class DetermineService : IDetermineService
    {
        public DetermineService()
        {
         
        }

        public int ShowAge(DateCollectorModel model)
        {
            return DateTime.Now.Year - model.DateofBirth.Year;
        }
    }
}
