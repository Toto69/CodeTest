using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace ConsumerService.Services;

public class FruitService
{
    private readonly HttpClient _httpClient;
    private readonly FruitServiceConfiguration _configuration;

    public FruitService(HttpClient httpClient, IOptions<FruitServiceConfiguration> fruitConfiguration)
    {
        _configuration = fruitConfiguration.Value;
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(_configuration.Url);

        _httpClient.DefaultRequestHeaders.Add(
            HeaderNames.Accept, "application/json");
    }

    public async Task<FruitViewmodel?> GetFruits() =>
        await _httpClient.GetFromJsonAsync<FruitViewmodel>(
            _configuration.FruitEndpoint);
    
    public async Task<Fruit?> GetFruit(int id) =>
        await _httpClient.GetFromJsonAsync<Fruit>(
            _configuration.FruitEndpoint+$"/{id}");
}

