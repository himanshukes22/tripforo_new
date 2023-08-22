using Tripforo.Models.RequestModel.Supplier;
using Tripforo.Models.ViewModels.Supplier;

namespace Tripforo.Repository.RepositoryContracts.Supplier
{
    public interface ISupplierRepository : IBaseRepository
    {
        public Task<List<AirportNameViewModel>> GetAirportNames();
        public Task<List<AirLineNameViewModel>> GetAirLineNames();
        Task<bool> InsertAddNewPNRAsync(AddNewPNRRequestModel addNewPNR);
        public Task<List<FlightOrgDestFromAndToModel>> GetOrgDestFromResult();
        public Task<List<FlightOrgDestFromAndToModel>> GetOrgDestToResult();
    }
}
