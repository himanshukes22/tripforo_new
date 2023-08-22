using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tripforo.Common;
using Tripforo.Common.Constants;
using Tripforo.Models.RequestModel.Supplier;
using Tripforo.Service.ServiceContracts.Supplier;

namespace TripForo.API.Controllers.Supplier
{
    [Produces("application/json")]
    [Route("api/Supplier")]
    [ApiController]
    public class SupplierController : BaseController
    {
        private readonly ISupplierService _supplierService;
        private readonly IConfiguration _config;

        public SupplierController(IConfiguration config, ISupplierService supplierService)
        {
            _supplierService = supplierService;
            _config = config;
        }

        [HttpGet]
        [Route("GetAirportNamesAndCodes")]
        public async Task<IActionResult> GetAirportNameAndCode()
        {
            ResponseStatus<dynamic> response = new ResponseStatus<dynamic>();
            var result = await _supplierService.GetAirportNamesAsync();
            if (result != null)
            {
                response.Data = result;
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.Messages = ErrorMessages.CommonError;
                response.StatusCode = HttpStatusCode.NoContent;
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAirLineNames")]
        public async Task<IActionResult> GetAirLineNames()
        {
            ResponseStatus<dynamic> response = new ResponseStatus<dynamic>();
            var result = await _supplierService.GetAirLineNamesAsync();
            if (result != null)
            {
                response.Data = result;
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.Messages = ErrorMessages.CommonError;
                response.StatusCode = HttpStatusCode.NoContent;
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("AddNewPNR")]
        public async Task<string> InsertAddNewPNRAsync([FromBody] AddNewPNRRequestModel addNewPNR)
        {
            // var user = this.GetUserDetails(this.HttpContext);
            var result = await _supplierService.InsertAddNewPNRAsync(addNewPNR);
            if (result)
            {
                return "Data Saved Successfully";
            }
            else
            {
                return "Failed to Save Data";
            }
        }

        [HttpGet]
        [Route("GetOrgDestFrom")]
        public async Task<IActionResult> GetOrgDestFromResult()
        {
            ResponseStatus<dynamic> response = new ResponseStatus<dynamic>();
            var result = await _supplierService.GetOrgDestFromResult();
            if (result != null)
            {
                response.Data = result;
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.Messages = ErrorMessages.CommonError;
                response.StatusCode = HttpStatusCode.NoContent;
            }
            return Ok(response);
        }


        [HttpGet]
        [Route("GetOrgDestTo")]
        public async Task<IActionResult> GetOrgDestToResult()
        {
            ResponseStatus<dynamic> response = new ResponseStatus<dynamic>();
            var result = await _supplierService.GetOrgDestToResult();
            if (result != null)
            {
                response.Data = result;
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.Messages = ErrorMessages.CommonError;
                response.StatusCode = HttpStatusCode.NoContent;
            }
            return Ok(response);
        }
    }
}
