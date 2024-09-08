using AspNetExercise1.Application.Dtos;

namespace AspNetExercise1.Middlewares.Contracts;

public interface ISaveInfoService
{
    Task Save(RequestInfoDto requestInfoDto);
}
