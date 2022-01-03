using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Mapping.Console.Dtos;
using Mapping.Console.Providers;

namespace Mapping.Console;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class MappingBenchmarks
{
    [Benchmark]
    public ProductDto ManualMap() => MappingProvider.ManuelMap();

    [Benchmark]
    public ProductDto ExpressMapperMap() => MappingProvider.ExpressMapperMap();

    [Benchmark]
    public ProductDto AutoMapperMap() => MappingProvider.AutoMapperMap();

    [Benchmark]
    public ProductDto MapsterAdaptWithoutConfigMap() => MappingProvider.MapsterAdaptWithoutConfigMap();

    [Benchmark]
    public ProductDto MapsterAdaptWithConfigMap() => MappingProvider.MapsterAdaptWithConfigMap();

    [Benchmark]
    public ProductDto MapsterAdaptToTypeMap() => MappingProvider.MapsterAdaptToTypeMap();
}