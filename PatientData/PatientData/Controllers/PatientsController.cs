using MongoDB.Bson;
using MongoDB.Driver;
using PatientData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PatientData.Controllers
{
    [EnableCors("*", "*", "GET")]
    [Authorize]
    public class PatientsController : ApiController
    {
        IMongoCollection<Patient> patients;

        public PatientsController() {
            patients = PatientDB.Open();
        }

        public IEnumerable<Patient> Get() {
            var filter = new BsonDocument();
            return patients.Find<Patient>(filter).ToList();
        }

        public IHttpActionResult Get(string id) {
            var patient = patients.Find<Patient>(p => p.Id.Equals(id)).FirstOrDefault();
            
            if(patient == null) {
                return NotFound();
            }

            return Ok(patient);
        }

        [Route("api/patients/{id}/medications")]
        public IHttpActionResult GetMedications(string id) {
            var patient = patients.Find<Patient>(p => p.Id.Equals(id)).FirstOrDefault();

            if (patient == null) {
                return NotFound();
            }

            return Ok(patient.Medications);
        }
    }
}
