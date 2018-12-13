using BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public async Task DeleteVehicle(Guid Id)
        {
            string deleteSql = "delete form Vehicle where Id=@Id";
            await Delete(Id, deleteSql);
        }

        public string ExecExecQueryParamSP(string spName, string name, int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Vehicle> GetVehicleDetail(Guid Id)
        {
            string detailsql = "select vehicle_name,vehicle_year,manufacturer,vehicle_price,vehicle_seriesId from vehicle WHERE Id=@Id";
            return await Detail(Id, detailsql); 
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            string listsql = "select id ,vehicle_name,vehicle_year, create_time from vehicle";
            return await Select(listsql);
        }

        public async Task PostVehicle(Vehicle entity)
        {
            string insertsql = "insert into vehicle (id ,vehicle_name,vehicle_year,manufacturer,vehicle_price,vehicle_seriesId) values(@Id，@VehicleName,@VehicleYear,@Manufacturer,@VehiclePrice,@VehicleSeriesId)";
            await Insert(entity, insertsql);
        }

        public async  Task PutVehicle(Vehicle entity)
        {
            string updatesql = "update vehicle set id=@Id ,vehicle_name=@VehicleName,vehicle_year=@VehicleYear,manufacturer=@Manufacturer,vehicle_price=@VehiclePrice,vehicle_seriesId=@VehicleSeriesId";
            await Update(entity, updatesql);
        }
    }
}
