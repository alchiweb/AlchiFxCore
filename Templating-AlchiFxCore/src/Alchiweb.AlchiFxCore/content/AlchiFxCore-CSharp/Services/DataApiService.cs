using AutoMapper;
using AutoMapper.QueryableExtensions;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Company.WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
// using Company.WebApplication1.Api.Models;

namespace Company.WebApplication1.Services
{
    public class DataApiService : IDataApiService
    {
        private readonly IConfigurationProvider _mappingConfiguration;

        public DataApiService(IConfigurationProvider mappingConfiguration)
        {
            _mappingConfiguration = mappingConfiguration;
        }

        public async Task<JsonResult> GetDataAsync(IQueryable<object> dbset, DTParameters param)
        {
            switch (dbset)
            {
                // case IQueryable<Chauffeur> chauffeurs:
                //     return await GetDataAsync<Chauffeur, ChauffeurApi>(chauffeurs, param);
                default:
                    await Task.CompletedTask;
                    return null;
            }
        }


        public async Task<JsonResult> GetDataAsync<TEntity, TEntityApi>(IQueryable<TEntity> query, DTParameters param) where TEntity : class
        {

            query = new SearchOptionsProcessor<TEntityApi, TEntity>().Apply(query, param.Columns);
            query = new SortOptionsProcessor<TEntityApi, TEntity>().Apply(query, param);

            var items = await query
                .AsNoTracking()
                .Skip(param.Start)
                .Take(param.Length)
                .ProjectTo<TEntityApi>(_mappingConfiguration)
                .ToArrayAsync();

            return new JsonResult(new DTResult<TEntityApi>
            {
                draw = param.Draw,
                data = items,
                recordsFiltered = items.Length,
                recordsTotal = items.Length
            });
        }

    }
}
