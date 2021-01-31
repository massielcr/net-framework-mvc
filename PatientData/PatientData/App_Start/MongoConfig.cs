using PatientData.Models;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace PatientData {
    public static class MongoConfig {

        public static void Seed() {
            var patients = PatientDB.Open();

            if (!patients.Find<Patient>(p => p.Name.Equals("Scott")).Any()) {
                var data = new List<Patient>() {
                    new Patient {
                    Name = "Scott",
                    Ailments = new List<Ailment> { new Ailment { Name = "Crazy" } },
                    Medications = new List<Medication> { new Medication { Name = "Dance", Doses = 1 } }
                },

                new Patient {
                    Name = "Joy",
                    Ailments = new List<Ailment> { new Ailment { Name = "Crazy" } },
                    Medications = new List<Medication> { new Medication { Name = "Dance", Doses = 1 } }
                },

                new Patient {
                    Name = "Sarah",
                    Ailments = new List<Ailment> { new Ailment { Name = "Crazy" } },
                    Medications = new List<Medication> { new Medication { Name = "Dance", Doses = 1 } }
                }
            };

                patients.InsertMany(data);
            }
        }
    }
}