﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDesignPatterns.Models.Interfaces
{
    public interface IVehicle
    {
        void Drive();
        void Stop();
        string Info();
    }
}
