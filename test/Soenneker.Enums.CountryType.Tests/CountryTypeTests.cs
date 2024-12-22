using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Enums.CountryType.Tests;

[Collection("Collection")]
public class CountryTypeTests : FixturedUnitTest
{
    public CountryTypeTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
