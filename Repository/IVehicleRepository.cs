using BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace Repository
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    { 
        //加一个带参数的存储过程
        string ExecExecQueryParamSP(string spName, string name, int Id);

        Task <List<Vehicle>> GetVehicles();

        Task PostVehicle(Vehicle entity);

        Task PutVehicle(Vehicle entity);

        Task DeleteVehicle(Guid Id);

        Task<Vehicle> GetVehicleDetail(Guid Id);


    }
}
