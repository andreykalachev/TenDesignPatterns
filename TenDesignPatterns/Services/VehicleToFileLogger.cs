using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Services
{
    public class VehicleToFileLogger
    {
        public IEnumerable<IVehicle> Vehicles { get; set; }

        private static readonly JsonSerializerSettings SettingsJson = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        private static readonly string VehiclesFile = "vehicles.txt";

        public VehicleToFileLogger(IEnumerable<IVehicle> vehicles)
        {
            Vehicles = vehicles;
        }

        public void SaveVehicles()
        {
            if (Vehicles == null)
            {
                return;
            }

            using (var streamWriter = new StreamWriter(VehiclesFile))
            {
                var serializedObject = JsonConvert.SerializeObject(Vehicles, SettingsJson);
                streamWriter.WriteLine(serializedObject);
            }
        }

        public void GetVehicles()
        {
            Vehicles = new List<IVehicle>();

            if (!File.Exists(VehiclesFile))
            {
                return;
            }

            try
            {
                using (var streamReader = new StreamReader(VehiclesFile))
                {
                    var fileContent = streamReader.ReadToEnd();
                    Vehicles = JsonConvert.DeserializeObject<IEnumerable<IVehicle>>(fileContent, SettingsJson);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("oops, something's gone wrong\n" + e.Message);
            }
        }
    }
}