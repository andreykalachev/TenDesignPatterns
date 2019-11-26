using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Services
{
    public static class VehicleToFileLogger
    {
        private static readonly JsonSerializerSettings SettingsJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        private static readonly string VehiclesFile = "vehicles.txt";

        public static void SaveVehicles(IEnumerable<IVehicle> vehicles)
        {
            if (vehicles == null)
            {
                return;
            }

            using (var streamWriter = new StreamWriter(VehiclesFile))
            {
                var serializedObject = JsonConvert.SerializeObject(vehicles, SettingsJson);
                streamWriter.WriteLine(serializedObject);
            }
        }

        public static IEnumerable<IVehicle> GetVehicles()
        {
            IEnumerable<IVehicle> vehicles = new List<IVehicle>();

            if (!File.Exists(VehiclesFile))
            {
                return vehicles;
            }

            try
            {
                using (var streamReader = new StreamReader(VehiclesFile))
                {
                    var fileContent = streamReader.ReadToEnd();
                    vehicles = JsonConvert.DeserializeObject<IEnumerable<IVehicle>>(fileContent, SettingsJson);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("oops, something's gone wrong\n" + e.Message);
            }

            return vehicles;
        }
    }
}