using AgeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp.Service
{
    public interface IDetermineService
    {
        int ShowAge(DateCollectorModel model);

        DateTime GetDate(int age);
    }
}
