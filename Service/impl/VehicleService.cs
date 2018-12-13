using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.ViewModel;

namespace Service.impl
{
    public class VehicleService : IVehicleService
    {
        public async Task<WebApiResult<bool>> CreateVehicle(Vehicle Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<WebApiResult<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<WebApiResult<IEnumerable<VehicleDTO>>> GetAllVehicle(string filter, int pageIndex, int pageSize, string sortExpression)
        {
            throw new NotImplementedException();
        }

        public async Task<WebApiResult<VehicleDTO>> GetDetailById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<WebApiResult<bool>> UpdateVehicle(Vehicle Entity)
        {
            throw new NotImplementedException();
        }
    }
}
