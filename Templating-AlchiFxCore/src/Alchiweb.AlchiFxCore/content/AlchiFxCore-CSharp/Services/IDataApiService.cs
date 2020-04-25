using JqueryDataTables.ServerSide.AspNetCoreWeb;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Company.WebApplication1.Services
{
    public interface IDataApiService
    {
        Task<JsonResult> GetDataAsync(IQueryable<object> dbset, JqueryDataTablesParameters table);
    }
}
