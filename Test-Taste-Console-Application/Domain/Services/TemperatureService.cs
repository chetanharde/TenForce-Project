using System;
using System.Collections.Generic;
using System.Linq;
using Test_Taste_Console_Application.Domain.Services.Interfaces;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Services
{
    public class TemperatureService:ITemperatureService
    {
        public double? CalculateAverageMoonTemperature(List<MoonDto> moons)
        {
            if (moons == null || moons.Count == 0)
                return null;

            var validTemperatures = moons
                .Where(m => m.Temperature.HasValue) 
                .Select(m => m.Temperature.Value)  
                .ToList();

            if (validTemperatures.Count == 0)
                return null;

            return validTemperatures.Average();  
        }
    }
}
