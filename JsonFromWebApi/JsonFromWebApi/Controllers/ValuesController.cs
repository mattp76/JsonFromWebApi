using JsonFromWebApi.Models;
using JsonFromWebApi.TypeConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JsonFromWebApi.Controllers
{
    public class ValuesController : ApiController
    {


        //// GET api/values
        //public IEnumerable<string> Get()
        //{

        //    return new string[] { "value1", "value2" };
        //}


        // GET api/values
        [HttpGet]
        public MyJsonObject Get(string test)
        {
            MyJsonObject obj = new MyJsonObject()
            {
                mynumber = 1234,
                myString1 = "Hello Matty",
                myString2 = "Hello Tester",
                myString3 = "Hello Vivi",
                myString4 = "Hello Leo",
                myString5 = "Hello Doft",
            };

            return obj;
        }

        // GET api/values
        //[HttpGet, ActionName("getgeo")]
        //public HttpResponseMessage GetGeo(GeoPoint location)
        //{


        //    string lnglat = string.Format("Lng:{0} Lat:{1}", location.Longitude, location.Latitude);

        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lnglat);

        //    return response;
        //}


        // GET api/values
        [HttpGet, ActionName("getgeo")]
        public MyJsonGeoObject GetGeo(GeoPoint location)
        {


           // string lnglat = string.Format("Lng:{0} Lat:{1}", location.Longitude, location.Latitude);

          //  HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lnglat);

            MyJsonGeoObject jsonGeo = new MyJsonGeoObject()
            {
                lat = location.Latitude,
                lng = location.Longitude
            };


            return jsonGeo;
        }



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}