namespace AspNetExercise1.Application.Dtos;

public sealed record RequestInfoDto(
    string HttpMethod,
    string UserAgent);

