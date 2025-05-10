using System.Collections.Generic;
using Test_Taste_Console_Application.Domain.DataTransferObjects; 

namespace Test_Taste_Console_Application.Domain.Services.Interfaces
{
   
    public interface ITemperatureService
    {
        
        //void OutputAllPlanetsAndTheirAverageMoonGravityToConsole();
         double? CalculateAverageMoonTemperature(List<MoonDto> moons);
    }
}
