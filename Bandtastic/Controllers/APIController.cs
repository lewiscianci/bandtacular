using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bandtastic.Models;

namespace Bandtastic.Controllers
{
    public class APIController : ApiController
    {

        private BandtasticData db = new BandtasticData();

        // GET: api/API
        //[Route("api/API/{partype}/{risk}/{amount}")]
        public APIModel.Response Get(int partype, int parrisk, int paramount)
        {
            // this all happens in the controller which is bad
            // should shift to service layer eventually


            // business logic :O

            //< option value = "" disabled selected> Choose your option</ option >

            //< option value = "1" > Type 1 </ option >

            //< option value = "2" > Type 2 </ option >

            //< option value = "3" > Type 3 </ option >

            //< option value = "4" > Type 4 </ option >

            //< option value = "5" > Type 5 </ option >

            //< option value = "" disabled selected> Choose your option</ option >

            //   < option value = "1" > Low </ option >

            //   < option value = "2" > Medium </ option >

            //   < option value = "3" > High </ option >

            //< option value = "" disabled selected> Choose your option</ option >

            //< option value = "1" > Recurrent </ option >

            //< option value = "2" > Non - recurrent </ option >
            APIModel.Response response = new APIModel.Response();




            var types = db.ProcurementTypes.Where(x => x.Name.Contains(parrisk.ToString())).ToList();
            var band = types.FirstOrDefault(x => x.MaxDelegation > paramount);

                var model = new APIModel.Response()
                {
                    FinancialTypeBandRequired = band.ProcurementBand.Name,
                    Explanation = $"For a Type {paramount} procurement, you require {band.ProcurementBand.Name} authorisation"
                };


            return response;
        }

        //// GET: api/API/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/API
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/API/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/API/5
        //public void Delete(int id)
        //{
        //}
    }
}
