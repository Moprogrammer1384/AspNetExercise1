using AspNetExercise1.Application.Dtos;
using AspNetExercise1.Middlewares.Contracts;
using AspNetExercise1.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetExercise1.Services;

public class SqlSaveInfoService : ISaveInfoService
{
    private readonly DbContext _dbContext;

    public SqlSaveInfoService(DbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public async Task Save(RequestInfoDto requestInfoDto)
    {
        RequestInfo request = new()
        {
            HttpMethod = requestInfoDto.HttpMethod,
            UserAgent = requestInfoDto.UserAgent
        };

        await _dbContext.AddAsync(request);
        await _dbContext.SaveChangesAsync();        
    }
}
