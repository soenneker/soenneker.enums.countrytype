using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.CountryType.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CountryTypeTests : HostedUnitTest
{
    public CountryTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
