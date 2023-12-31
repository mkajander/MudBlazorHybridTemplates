﻿namespace MudBlazorHybridTemplates.Application;
public interface IWeatherForecastService
{
    Task<WeatherForecastDto[]> GetForecastAsync(DateTime startDate);
}
public class WeatherForecastService : IWeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public Task<WeatherForecastDto[]> GetForecastAsync(DateTime startDate)
    {
        var rng = new Random();
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
        {
            Date = startDate.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToArray());
    }
}