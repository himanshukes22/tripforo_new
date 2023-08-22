using Tripforo.Models.RequestModel.Supplier;
using Tripforo.Models.ViewModels.Supplier;
using Tripforo.Repository.RepositoryContracts.Supplier;
using Tripforo.Service.ServiceContracts.Supplier;

namespace Tripforo.Service.Services.Supplier
{
    public class SupplierService : BaseService, ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public async Task<List<AirportNameViewModel>> GetAirportNamesAsync()
        {
            return await _supplierRepository.GetAirportNames();
        }

        public async Task<List<AirLineNameViewModel>> GetAirLineNamesAsync()
        {
            return await _supplierRepository.GetAirLineNames();
        }

         async Task<bool> ISupplierService.InsertAddNewPNRAsync(AddNewPNRRequestModel addNewPNR)
        {
            return await _supplierRepository.InsertAddNewPNRAsync(addNewPNR);
        }

        public async Task<List<FlightOrgDestFromAndToModel>> GetOrgDestFromResult()
        {
            return await _supplierRepository.GetOrgDestFromResult();
        }

        public async Task<List<FlightOrgDestFromAndToModel>> GetOrgDestToResult()
        {
            return await _supplierRepository.GetOrgDestToResult();
        }
    }
}
