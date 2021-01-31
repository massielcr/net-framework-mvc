using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientData.Models {
    public static class PatientDB {

        public static IMongoCollection<Patient> Open() {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("PatientDB");

            return db.GetCollection<Patient>("Patients");
        }
        
    }
}