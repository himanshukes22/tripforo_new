using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tripforo.Models.RequestModel.Supplier;
using Tripforo.Models.ViewModels.Supplier;
using Tripforo.Repository.EFCoreModels.ScaffoldedEntity;
using Tripforo.Repository.RepositoryContracts.Supplier;

namespace Tripforo.Repository.Repositories.Supplier
{
    public class SupplierRepository : BaseRepository, ISupplierRepository
    {

        private readonly IConfiguration _configuration;
        public readonly FlyrajaContext _db;
        private readonly IMapper _mapper;

        public SupplierRepository(FlyrajaContext dbContext, IConfiguration configuration, IMapper mapper)
        {
            _db = dbContext;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<List<AirportNameViewModel>> GetAirportNames()
        {
            List<AirportNameViewModel> listAirportNameViewModel = new List<AirportNameViewModel>();
            var list = _db.WorldAirportInfos.OrderBy(b => b.CreatedDate).ToList();
            list.ForEach(s =>
            {
                AirportNameViewModel airportNameViewModel = new AirportNameViewModel();
                airportNameViewModel.AirportCode = s.AirportCode;
                airportNameViewModel.AirportName = s.AirportName;
                listAirportNameViewModel.Add(airportNameViewModel);
            });
            return listAirportNameViewModel;
        }

        public async Task<List<AirLineNameViewModel>> GetAirLineNames()
        {
            var list = _db.AirLineNames.OrderBy(b => b.CreatedDate).ToList();
            List<AirLineNameViewModel> obj = new();
            list.ForEach(s =>
            {
                //AirLineNameViewModel airLineNameViewModel = _mapper.Map<AirLineNameViewModel>(s);
                AirLineNameViewModel airLineNameViewModel = new AirLineNameViewModel();
                airLineNameViewModel.AirportName = s.AlName;
                airLineNameViewModel.AirLineCode = s.AlCode;
                obj.Add(airLineNameViewModel);
            });
            return obj;
        }

        public async Task<bool> InsertAddNewPNRAsync(AddNewPNRRequestModel addNewPNRmodel)
        {
            try
            {
                FlightSearchResult FlightSearchResultData = new FlightSearchResult()
                {
                    Triptype = addNewPNRmodel.Triptype,
                    OrgDestFrom = addNewPNRmodel.OrgDestFrom,
                    OrgDestTo = addNewPNRmodel.OrgDestTo,
                    AirLineName = addNewPNRmodel.AirLineName,
                    FlightNo = addNewPNRmodel.FlightNo,
                    DepartureDate = addNewPNRmodel.DepartureDate,
                    ArrivalDate = addNewPNRmodel.ArrivalDate,
                    DepartureTime = addNewPNRmodel.DepartureTime,
                    ArrivalTime = addNewPNRmodel.ArrivalTime,
                    DepartureTerminal = addNewPNRmodel.DepartureTerminal,
                    ArrivalTerminal = addNewPNRmodel.ArrivalTerminal,
                    FareBasis = addNewPNRmodel.FareBasis,
                    FareDet = addNewPNRmodel.FareDet,
                    BagInfo = addNewPNRmodel.BagInfo,
                    ClassType = addNewPNRmodel.ClassType,
                    FareRule = addNewPNRmodel.FareRule,
                    RtAirLineName = addNewPNRmodel.RtAirLineName,
                    RtFlightNo = addNewPNRmodel.RtFlightNo,
                    RtDepartureDate = addNewPNRmodel.RtDepartureDate,
                    RtDepartureTime = addNewPNRmodel.RtDepartureTime,
                    RtArrivalDate = addNewPNRmodel.RtArrivalDate,
                    RtArrivalTime = addNewPNRmodel.RtArrivalTime,
                    RtDepartureTerminal = addNewPNRmodel.RtDepartureTerminal,
                    RtArrivalTerminal = addNewPNRmodel.RtArrivalTerminal,
                    RtRbd = addNewPNRmodel.RtRbd,
                    RtFareBasis = addNewPNRmodel.RtFareBasis,
                    RtClassType = addNewPNRmodel.RtClassType,

                };
                await _db.FlightSearchResults.AddAsync(FlightSearchResultData);
                var rowcount = await _db.SaveChangesAsync();
                if (rowcount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _db.Database.RollbackTransaction();
                throw ex;
            }
        }

        public async Task<List<FlightOrgDestFromAndToModel>> GetOrgDestFromResult()
        {
            try
            {
                List<FlightOrgDestFromAndToModel> flightOrgDestFromAndToModel = new List<FlightOrgDestFromAndToModel>();
                flightOrgDestFromAndToModel = await _db.FlightSearchResults
                                .Select(s => new FlightOrgDestFromAndToModel
                                {
                                    Name = s.OrgDestFrom
                                }).Distinct().ToListAsync();
                return flightOrgDestFromAndToModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<FlightOrgDestFromAndToModel>> GetOrgDestToResult()
        {
            try
            {
                List<FlightOrgDestFromAndToModel> flightOrgDestFromAndToModel = new List<FlightOrgDestFromAndToModel>();
                flightOrgDestFromAndToModel = await _db.FlightSearchResults
                                .Select(s => new FlightOrgDestFromAndToModel
                                {
                                    Name = s.OrgDestTo
                                }).Distinct().ToListAsync();
                return flightOrgDestFromAndToModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
