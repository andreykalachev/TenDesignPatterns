﻿using System.Collections.Generic;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models.Commands.Interfaces
{
    public interface IPainter
    {
        List<string> AvailableColors { get; set; }

        void Paint(ICar car, string color);
    }
}