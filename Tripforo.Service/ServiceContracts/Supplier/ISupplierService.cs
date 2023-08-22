using Tripforo.Models.RequestModel.Supplier;
using Tripforo.Models.ViewModels.Supplier;

namespace Tripforo.Service.ServiceContracts.Supplier
{
    public interface ISupplierService: IBaseService
    {
        public Task<List<AirportNameViewModel>> GetAirportNamesAsync();
        public Task<List<AirLineNameViewModel>> GetAirLineNamesAsync();
        public Task<bool> InsertAddNewPNRAsync(AddNewPNRRequestModel addNewPNR);
        public Task<List<FlightOrgDestFromAndToModel>> GetOrgDestFromResult();
        public Task<List<FlightOrgDestFromAndToModel>> GetOrgDestToResult();
    }
}
