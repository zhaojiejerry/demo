using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public async Task Delete(Guid Id, string deleteSql)
        {
            using(IDbConnection conn = DataBaseConfig.Connection())
            {
                await conn.ExecuteAsync(deleteSql, new { Id = Id });

            }
        }

        public async Task<T> Detail(Guid Id, string detailSql)
        {
            using(IDbConnection conn= DataBaseConfig.Connection())
            {
               return  await conn.QueryFirstOrDefault(detailSql,new { Id = Id});
            }
        }

        public async Task<List<T>> ExecQuerySP(string SPName)
        {
            using(IDbConnection conn = DataBaseConfig.Connection()) {
               return  await Task.Run(() => conn.Query<T>(SPName, null, null, true, null, CommandType.StoredProcedure).ToList());
            }
            
        }

        public async Task Insert(T entity, string insertSql)
        {
            using (IDbConnection conn = DataBaseConfig.Connection())
            {
                await conn.ExecuteAsync(insertSql, entity);
             
              }
        
        }

        public async Task<List<T>> Select(string selectSql)
        {
            using (IDbConnection conn = DataBaseConfig.Connection())
            {
                return await Task.Run(()=>conn.Query<T>(selectSql).ToList());
            }
        }

        public async Task Update(T entity, string updateSql)
        {
            using(IDbConnection conn = DataBaseConfig.Connection())
            {
                await conn.ExecuteAsync(updateSql, entity);
            }
        }
    }
}
