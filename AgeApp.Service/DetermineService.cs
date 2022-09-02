using AgeApp.Migrations;
using AgeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp.Service
{
    public class DetermineService : IDetermineService
    {
        private readonly AgeAppDatabaseContext _context;

        public DetermineService(AgeAppDatabaseContext context)
        {
            _context = context;
        }

        public int ShowAge(DateCollectorModel model)
        {

            var result = DateTime.Now.Year - model.DateofBirth.Year;
            _context.DateHistory.Add(model);
            return result;
        }

        public DateTime GetDate(int age)
        {
            return DateTime.Now.AddYears(-age);
        }
    }
}
