[![](https://img.shields.io/nuget/v/soenneker.enums.countrytype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.countrytype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.countrytype/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.countrytype/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.countrytype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.countrytype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.countrytype/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.countrytype/actions/workflows/codeql.yml)

# Soenneker.Enums.CountryType

A smart enum of countries and territories with stable numeric values, ISO 3166-1 alpha-2 abbreviations, and CLDR-style display names.

## Installation

```bash
dotnet add package Soenneker.Enums.CountryType
```

## Usage

```csharp
using Soenneker.Enums.CountryType;

CountryType country = CountryType.UnitedStates;

string name = country.Name;                 // "UnitedStates"
int value = country.Value;                  // 235
string code = country.Abbreviation;         // "US"
string displayName = country.Description;   // "United States"
```

Look up a country by its two-letter code:

```csharp
CountryType canada = CountryType.FromAbbreviation("CA");

if (CountryType.TryFromAbbreviation(input, ignoreCase: true, out CountryType? country))
{
    Console.WriteLine(country.Description);
}
```

`FromAbbreviation` throws when the code is unknown. Use `TryFromAbbreviation` for user or external input.

The inherited smart-enum APIs are also available for names and numeric values:

```csharp
CountryType germany = CountryType.FromName("Germany");
CountryType france = CountryType.FromValue(76);

foreach (CountryType option in CountryType.List)
{
    Console.WriteLine($"{option.Abbreviation}: {option.Description}");
}
```

`Name` is the C# identifier used by the enum entry, while `Description` is intended for display. They differ for entries such as `UnitedStates` / `United States`; use `Abbreviation` when exchanging ISO country codes.
