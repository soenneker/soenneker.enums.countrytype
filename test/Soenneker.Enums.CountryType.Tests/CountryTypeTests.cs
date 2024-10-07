using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Enums.CountryType.Tests;

[Collection("Collection")]
public class CountryTypeTests : FixturedUnitTest
{
    public CountryTypeTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
