using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model.ViewModel;
namespace Service
{
    interface IVehicleService
    {
        Task<WebApiResult<bool>> DeleteAsync(Guid id);

        Task<WebApiResult<IEnumerable<VehicleDTO>>> GetAllVehicle(string filter, int pageIndex, int pageSize, string sortExpression);

        Task<WebApiResult<VehicleDTO>> GetDetailById(Guid Id);

        Task<WebApiResult<bool>> CreateVehicle(Vehicle Entity);

        Task<WebApiResult<bool>> UpdateVehicle(Vehicle Entity);
    }
}
