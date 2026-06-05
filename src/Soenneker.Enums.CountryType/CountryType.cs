using Soenneker.SmartEnum.AbbreviatedDescriptive;

namespace Soenneker.Enums.CountryType;

/// <summary>
/// An enumeration for countries from CLDR
/// </summary>
public sealed class CountryType : AbbreviatedDescriptiveSmartEnum<CountryType>
{
    /// <summary>
    /// The afghanistan.
    /// </summary>
    public static readonly CountryType Afghanistan = new(nameof(Afghanistan), 1, "AF");
    /// <summary>
    /// The albania.
    /// </summary>
    public static readonly CountryType Albania = new(nameof(Albania), 2, "AL");
    /// <summary>
    /// The algeria.
    /// </summary>
    public static readonly CountryType Algeria = new(nameof(Algeria), 3, "DZ");
    /// <summary>
    /// The american samoa.
    /// </summary>
    public static readonly CountryType AmericanSamoa = new(nameof(AmericanSamoa), 4, "AS", "American Samoa");
    /// <summary>
    /// The andorra.
    /// </summary>
    public static readonly CountryType Andorra = new(nameof(Andorra), 5, "AD");
    /// <summary>
    /// The angola.
    /// </summary>
    public static readonly CountryType Angola = new(nameof(Angola), 6, "AO");
    /// <summary>
    /// The anguilla.
    /// </summary>
    public static readonly CountryType Anguilla = new(nameof(Anguilla), 7, "AI");
    /// <summary>
    /// The antarctica.
    /// </summary>
    public static readonly CountryType Antarctica = new(nameof(Antarctica), 8, "AQ");
    /// <summary>
    /// The antigua and barbuda.
    /// </summary>
    public static readonly CountryType AntiguaAndBarbuda = new(nameof(AntiguaAndBarbuda), 9, "AG", "Antigua & Barbuda");
    /// <summary>
    /// The argentina.
    /// </summary>
    public static readonly CountryType Argentina = new(nameof(Argentina), 10, "AR");
    /// <summary>
    /// The armenia.
    /// </summary>
    public static readonly CountryType Armenia = new(nameof(Armenia), 11, "AM");
    /// <summary>
    /// The aruba.
    /// </summary>
    public static readonly CountryType Aruba = new(nameof(Aruba), 12, "AW");
    /// <summary>
    /// The australia.
    /// </summary>
    public static readonly CountryType Australia = new(nameof(Australia), 13, "AU");
    /// <summary>
    /// The austria.
    /// </summary>
    public static readonly CountryType Austria = new(nameof(Austria), 14, "AT");
    /// <summary>
    /// The azerbaijan.
    /// </summary>
    public static readonly CountryType Azerbaijan = new(nameof(Azerbaijan), 15, "AZ");
    /// <summary>
    /// The bahamas.
    /// </summary>
    public static readonly CountryType Bahamas = new(nameof(Bahamas), 16, "BS");
    /// <summary>
    /// The bahrain.
    /// </summary>
    public static readonly CountryType Bahrain = new(nameof(Bahrain), 17, "BH");
    /// <summary>
    /// The bangladesh.
    /// </summary>
    public static readonly CountryType Bangladesh = new(nameof(Bangladesh), 18, "BD");
    /// <summary>
    /// The barbados.
    /// </summary>
    public static readonly CountryType Barbados = new(nameof(Barbados), 19, "BB");
    /// <summary>
    /// The belarus.
    /// </summary>
    public static readonly CountryType Belarus = new(nameof(Belarus), 20, "BY");
    /// <summary>
    /// The belgium.
    /// </summary>
    public static readonly CountryType Belgium = new(nameof(Belgium), 21, "BE");
    /// <summary>
    /// The belize.
    /// </summary>
    public static readonly CountryType Belize = new(nameof(Belize), 22, "BZ");
    /// <summary>
    /// The benin.
    /// </summary>
    public static readonly CountryType Benin = new(nameof(Benin), 23, "BJ");
    /// <summary>
    /// The bermuda.
    /// </summary>
    public static readonly CountryType Bermuda = new(nameof(Bermuda), 24, "BM");
    /// <summary>
    /// The bhutan.
    /// </summary>
    public static readonly CountryType Bhutan = new(nameof(Bhutan), 25, "BT");
    /// <summary>
    /// The bolivia.
    /// </summary>
    public static readonly CountryType Bolivia = new(nameof(Bolivia), 26, "BO");
    /// <summary>
    /// The bonaire.
    /// </summary>
    public static readonly CountryType Bonaire = new(nameof(Bonaire), 27, "BQ", "Bonaire, Sint Eustatius and Saba");
    /// <summary>
    /// The bosnia and herzegovina.
    /// </summary>
    public static readonly CountryType BosniaAndHerzegovina = new(nameof(BosniaAndHerzegovina), 28, "BA", "Bosnia & Herzegovina");
    /// <summary>
    /// The botswana.
    /// </summary>
    public static readonly CountryType Botswana = new(nameof(Botswana), 29, "BW");
    /// <summary>
    /// The bouvet island.
    /// </summary>
    public static readonly CountryType BouvetIsland = new(nameof(BouvetIsland), 30, "BV", "Bouvet Island");
    /// <summary>
    /// The brazil.
    /// </summary>
    public static readonly CountryType Brazil = new(nameof(Brazil), 31, "BR");
    /// <summary>
    /// The british indian ocean territory.
    /// </summary>
    public static readonly CountryType BritishIndianOceanTerritory = new(nameof(BritishIndianOceanTerritory), 32, "IO", "British Indian Ocean Territory");
    /// <summary>
    /// The brunei.
    /// </summary>
    public static readonly CountryType Brunei = new(nameof(Brunei), 33, "BN");
    /// <summary>
    /// The bulgaria.
    /// </summary>
    public static readonly CountryType Bulgaria = new(nameof(Bulgaria), 34, "BG");
    /// <summary>
    /// The burkina faso.
    /// </summary>
    public static readonly CountryType BurkinaFaso = new(nameof(BurkinaFaso), 35, "BF");
    /// <summary>
    /// The burundi.
    /// </summary>
    public static readonly CountryType Burundi = new(nameof(Burundi), 36, "BI");
    /// <summary>
    /// The cabo verde.
    /// </summary>
    public static readonly CountryType CaboVerde = new(nameof(CaboVerde), 37, "CV", "Cape Verde");
    /// <summary>
    /// The cambodia.
    /// </summary>
    public static readonly CountryType Cambodia = new(nameof(Cambodia), 38, "KH");
    /// <summary>
    /// The cameroon.
    /// </summary>
    public static readonly CountryType Cameroon = new(nameof(Cameroon), 39, "CM");
    /// <summary>
    /// The canada.
    /// </summary>
    public static readonly CountryType Canada = new(nameof(Canada), 40, "CA");
    /// <summary>
    /// The cayman islands.
    /// </summary>
    public static readonly CountryType CaymanIslands = new(nameof(CaymanIslands), 41, "KY", "Cayman Islands");
    /// <summary>
    /// The central african republic.
    /// </summary>
    public static readonly CountryType CentralAfricanRepublic = new(nameof(CentralAfricanRepublic), 42, "CF", "Central African Republic");
    /// <summary>
    /// The chad.
    /// </summary>
    public static readonly CountryType Chad = new(nameof(Chad), 43, "TD");
    /// <summary>
    /// The chile.
    /// </summary>
    public static readonly CountryType Chile = new(nameof(Chile), 44, "CL");
    /// <summary>
    /// The china.
    /// </summary>
    public static readonly CountryType China = new(nameof(China), 45, "CN");
    /// <summary>
    /// The christmas island.
    /// </summary>
    public static readonly CountryType ChristmasIsland = new(nameof(ChristmasIsland), 46, "CX", "Christmas Island");
    /// <summary>
    /// The cocos keeling islands.
    /// </summary>
    public static readonly CountryType CocosKeelingIslands = new(nameof(CocosKeelingIslands), 47, "CC", "Cocos (Keeling) Islands");
    /// <summary>
    /// The colombia.
    /// </summary>
    public static readonly CountryType Colombia = new(nameof(Colombia), 48, "CO");
    /// <summary>
    /// The comoros.
    /// </summary>
    public static readonly CountryType Comoros = new(nameof(Comoros), 49, "KM");
    /// <summary>
    /// The congo brazzaville.
    /// </summary>
    public static readonly CountryType CongoBrazzaville = new(nameof(CongoBrazzaville), 50, "CG", "Congo - Brazzaville");
    /// <summary>
    /// The congo kinshasa.
    /// </summary>
    public static readonly CountryType CongoKinshasa = new(nameof(CongoKinshasa), 51, "CD", "Congo - Kinshasa");
    /// <summary>
    /// The cook islands.
    /// </summary>
    public static readonly CountryType CookIslands = new(nameof(CookIslands), 52, "CK", "Cook Islands");
    /// <summary>
    /// The costa rica.
    /// </summary>
    public static readonly CountryType CostaRica = new(nameof(CostaRica), 53, "CR");
    /// <summary>
    /// The cote d ivoire.
    /// </summary>
    public static readonly CountryType CoteDIvoire = new(nameof(CoteDIvoire), 54, "CI", "Cote d'Ivoire");
    /// <summary>
    /// The croatia.
    /// </summary>
    public static readonly CountryType Croatia = new(nameof(Croatia), 55, "HR");
    /// <summary>
    /// The cuba.
    /// </summary>
    public static readonly CountryType Cuba = new(nameof(Cuba), 56, "CU");
    /// <summary>
    /// The curacao.
    /// </summary>
    public static readonly CountryType Curacao = new(nameof(Curacao), 57, "CW", "Cura�ao");
    /// <summary>
    /// The cyprus.
    /// </summary>
    public static readonly CountryType Cyprus = new(nameof(Cyprus), 58, "CY");
    /// <summary>
    /// The czechia.
    /// </summary>
    public static readonly CountryType Czechia = new(nameof(Czechia), 59, "CZ");
    /// <summary>
    /// The denmark.
    /// </summary>
    public static readonly CountryType Denmark = new(nameof(Denmark), 60, "DK");
    /// <summary>
    /// The djibouti.
    /// </summary>
    public static readonly CountryType Djibouti = new(nameof(Djibouti), 61, "DJ");
    /// <summary>
    /// The dominica.
    /// </summary>
    public static readonly CountryType Dominica = new(nameof(Dominica), 62, "DM");
    /// <summary>
    /// The dominican republic.
    /// </summary>
    public static readonly CountryType DominicanRepublic = new(nameof(DominicanRepublic), 63, "DO", "Dominican Republic");
    /// <summary>
    /// The ecuador.
    /// </summary>
    public static readonly CountryType Ecuador = new(nameof(Ecuador), 64, "EC");
    /// <summary>
    /// The egypt.
    /// </summary>
    public static readonly CountryType Egypt = new(nameof(Egypt), 65, "EG");
    /// <summary>
    /// The el salvador.
    /// </summary>
    public static readonly CountryType ElSalvador = new(nameof(ElSalvador), 66, "SV", "El Salvador");
    /// <summary>
    /// The equatorial guinea.
    /// </summary>
    public static readonly CountryType EquatorialGuinea = new(nameof(EquatorialGuinea), 67, "GQ", "Equatorial Guinea");
    /// <summary>
    /// The eritrea.
    /// </summary>
    public static readonly CountryType Eritrea = new(nameof(Eritrea), 68, "ER");
    /// <summary>
    /// The estonia.
    /// </summary>
    public static readonly CountryType Estonia = new(nameof(Estonia), 69, "EE");
    /// <summary>
    /// The eswatini.
    /// </summary>
    public static readonly CountryType Eswatini = new(nameof(Eswatini), 70, "SZ");
    /// <summary>
    /// The ethiopia.
    /// </summary>
    public static readonly CountryType Ethiopia = new(nameof(Ethiopia), 71, "ET");
    /// <summary>
    /// The falkland islands.
    /// </summary>
    public static readonly CountryType FalklandIslands = new(nameof(FalklandIslands), 72, "FK", "Falkland Islands");
    /// <summary>
    /// The faroe islands.
    /// </summary>
    public static readonly CountryType FaroeIslands = new(nameof(FaroeIslands), 73, "FO", "Faroe Islands");
    /// <summary>
    /// The fiji.
    /// </summary>
    public static readonly CountryType Fiji = new(nameof(Fiji), 74, "FJ");
    /// <summary>
    /// The finland.
    /// </summary>
    public static readonly CountryType Finland = new(nameof(Finland), 75, "FI");
    /// <summary>
    /// The france.
    /// </summary>
    public static readonly CountryType France = new(nameof(France), 76, "FR");
    /// <summary>
    /// The french guiana.
    /// </summary>
    public static readonly CountryType FrenchGuiana = new(nameof(FrenchGuiana), 77, "GF", "French Guiana");
    /// <summary>
    /// The french polynesia.
    /// </summary>
    public static readonly CountryType FrenchPolynesia = new(nameof(FrenchPolynesia), 78, "PF", "French Polynesia");
    /// <summary>
    /// The french southern territories.
    /// </summary>
    public static readonly CountryType FrenchSouthernTerritories = new(nameof(FrenchSouthernTerritories), 79, "TF", "French Southern Territories");
    /// <summary>
    /// The gabon.
    /// </summary>
    public static readonly CountryType Gabon = new(nameof(Gabon), 80, "GA");
    /// <summary>
    /// The gambia.
    /// </summary>
    public static readonly CountryType Gambia = new(nameof(Gambia), 81, "GM");
    /// <summary>
    /// The georgia.
    /// </summary>
    public static readonly CountryType Georgia = new(nameof(Georgia), 82, "GE");
    /// <summary>
    /// The germany.
    /// </summary>
    public static readonly CountryType Germany = new(nameof(Germany), 83, "DE");
    /// <summary>
    /// The ghana.
    /// </summary>
    public static readonly CountryType Ghana = new(nameof(Ghana), 84, "GH");
    /// <summary>
    /// The gibraltar.
    /// </summary>
    public static readonly CountryType Gibraltar = new(nameof(Gibraltar), 85, "GI");
    /// <summary>
    /// The greece.
    /// </summary>
    public static readonly CountryType Greece = new(nameof(Greece), 86, "GR");
    /// <summary>
    /// The greenland.
    /// </summary>
    public static readonly CountryType Greenland = new(nameof(Greenland), 87, "GL");
    /// <summary>
    /// The grenada.
    /// </summary>
    public static readonly CountryType Grenada = new(nameof(Grenada), 88, "GD");
    /// <summary>
    /// The guadeloupe.
    /// </summary>
    public static readonly CountryType Guadeloupe = new(nameof(Guadeloupe), 89, "GP");
    /// <summary>
    /// The guam.
    /// </summary>
    public static readonly CountryType Guam = new(nameof(Guam), 90, "GU");
    /// <summary>
    /// The guatemala.
    /// </summary>
    public static readonly CountryType Guatemala = new(nameof(Guatemala), 91, "GT");
    /// <summary>
    /// The guernsey.
    /// </summary>
    public static readonly CountryType Guernsey = new(nameof(Guernsey), 92, "GG");
    /// <summary>
    /// The guinea.
    /// </summary>
    public static readonly CountryType Guinea = new(nameof(Guinea), 93, "GN");
    /// <summary>
    /// The guinea bissau.
    /// </summary>
    public static readonly CountryType GuineaBissau = new(nameof(GuineaBissau), 94, "GW", "Guinea-Bissau");
    /// <summary>
    /// The guyana.
    /// </summary>
    public static readonly CountryType Guyana = new(nameof(Guyana), 95, "GY");
    /// <summary>
    /// The haiti.
    /// </summary>
    public static readonly CountryType Haiti = new(nameof(Haiti), 96, "HT");
    /// <summary>
    /// The heard island and mc donald islands.
    /// </summary>
    public static readonly CountryType HeardIslandAndMcDonaldIslands = new(nameof(HeardIslandAndMcDonaldIslands), 97, "HM", "Heard & McDonald Islands");
    /// <summary>
    /// The holy see.
    /// </summary>
    public static readonly CountryType HolySee = new(nameof(HolySee), 98, "VA", "Vatican City");
    /// <summary>
    /// The honduras.
    /// </summary>
    public static readonly CountryType Honduras = new(nameof(Honduras), 99, "HN");
    /// <summary>
    /// The hong kong.
    /// </summary>
    public static readonly CountryType HongKong = new(nameof(HongKong), 100, "HK", "Hong Kong SAR China");
    /// <summary>
    /// The hungary.
    /// </summary>
    public static readonly CountryType Hungary = new(nameof(Hungary), 101, "HU");
    /// <summary>
    /// The iceland.
    /// </summary>
    public static readonly CountryType Iceland = new(nameof(Iceland), 102, "IS");
    /// <summary>
    /// The india.
    /// </summary>
    public static readonly CountryType India = new(nameof(India), 103, "IN");
    /// <summary>
    /// The indonesia.
    /// </summary>
    public static readonly CountryType Indonesia = new(nameof(Indonesia), 104, "ID");
    /// <summary>
    /// The iran.
    /// </summary>
    public static readonly CountryType Iran = new(nameof(Iran), 105, "IR");
    /// <summary>
    /// The iraq.
    /// </summary>
    public static readonly CountryType Iraq = new(nameof(Iraq), 106, "IQ");
    /// <summary>
    /// The ireland.
    /// </summary>
    public static readonly CountryType Ireland = new(nameof(Ireland), 107, "IE");
    /// <summary>
    /// The isle of man.
    /// </summary>
    public static readonly CountryType IsleOfMan = new(nameof(IsleOfMan), 108, "IM", "Isle of Man");
    /// <summary>
    /// The israel.
    /// </summary>
    public static readonly CountryType Israel = new(nameof(Israel), 109, "IL");
    /// <summary>
    /// The italy.
    /// </summary>
    public static readonly CountryType Italy = new(nameof(Italy), 110, "IT");
    /// <summary>
    /// The jamaica.
    /// </summary>
    public static readonly CountryType Jamaica = new(nameof(Jamaica), 111, "JM");
    /// <summary>
    /// The japan.
    /// </summary>
    public static readonly CountryType Japan = new(nameof(Japan), 112, "JP");
    /// <summary>
    /// The jersey.
    /// </summary>
    public static readonly CountryType Jersey = new(nameof(Jersey), 113, "JE");
    /// <summary>
    /// The jordan.
    /// </summary>
    public static readonly CountryType Jordan = new(nameof(Jordan), 114, "JO");
    /// <summary>
    /// The kazakhstan.
    /// </summary>
    public static readonly CountryType Kazakhstan = new(nameof(Kazakhstan), 115, "KZ");
    /// <summary>
    /// The kenya.
    /// </summary>
    public static readonly CountryType Kenya = new(nameof(Kenya), 116, "KE");
    /// <summary>
    /// The kiribati.
    /// </summary>
    public static readonly CountryType Kiribati = new(nameof(Kiribati), 117, "KI");
    /// <summary>
    /// The korea north.
    /// </summary>
    public static readonly CountryType KoreaNorth = new(nameof(KoreaNorth), 118, "KP", "North Korea");
    /// <summary>
    /// The korea south.
    /// </summary>
    public static readonly CountryType KoreaSouth = new(nameof(KoreaSouth), 119, "KR", "South Korea");
    /// <summary>
    /// The kuwait.
    /// </summary>
    public static readonly CountryType Kuwait = new(nameof(Kuwait), 120, "KW");
    /// <summary>
    /// The kyrgyzstan.
    /// </summary>
    public static readonly CountryType Kyrgyzstan = new(nameof(Kyrgyzstan), 121, "KG");
    /// <summary>
    /// The lao pdr.
    /// </summary>
    public static readonly CountryType LaoPDR = new(nameof(LaoPDR), 122, "LA", "Laos");
    /// <summary>
    /// The latvia.
    /// </summary>
    public static readonly CountryType Latvia = new(nameof(Latvia), 123, "LV");
    /// <summary>
    /// The lebanon.
    /// </summary>
    public static readonly CountryType Lebanon = new(nameof(Lebanon), 124, "LB");
    /// <summary>
    /// The lesotho.
    /// </summary>
    public static readonly CountryType Lesotho = new(nameof(Lesotho), 125, "LS");
    /// <summary>
    /// The liberia.
    /// </summary>
    public static readonly CountryType Liberia = new(nameof(Liberia), 126, "LR");
    /// <summary>
    /// The libya.
    /// </summary>
    public static readonly CountryType Libya = new(nameof(Libya), 127, "LY");
    /// <summary>
    /// The liechtenstein.
    /// </summary>
    public static readonly CountryType Liechtenstein = new(nameof(Liechtenstein), 128, "LI");
    /// <summary>
    /// The lithuania.
    /// </summary>
    public static readonly CountryType Lithuania = new(nameof(Lithuania), 129, "LT");
    /// <summary>
    /// The luxembourg.
    /// </summary>
    public static readonly CountryType Luxembourg = new(nameof(Luxembourg), 130, "LU");
    /// <summary>
    /// The macao.
    /// </summary>
    public static readonly CountryType Macao = new(nameof(Macao), 131, "MO", "Macao SAR China");
    /// <summary>
    /// The madagascar.
    /// </summary>
    public static readonly CountryType Madagascar = new(nameof(Madagascar), 132, "MG");
    /// <summary>
    /// The malawi.
    /// </summary>
    public static readonly CountryType Malawi = new(nameof(Malawi), 133, "MW");
    /// <summary>
    /// The malaysia.
    /// </summary>
    public static readonly CountryType Malaysia = new(nameof(Malaysia), 134, "MY");
    /// <summary>
    /// The maldives.
    /// </summary>
    public static readonly CountryType Maldives = new(nameof(Maldives), 135, "MV");
    /// <summary>
    /// The mali.
    /// </summary>
    public static readonly CountryType Mali = new(nameof(Mali), 136, "ML");
    /// <summary>
    /// The malta.
    /// </summary>
    public static readonly CountryType Malta = new(nameof(Malta), 137, "MT");
    /// <summary>
    /// The marshall islands.
    /// </summary>
    public static readonly CountryType MarshallIslands = new(nameof(MarshallIslands), 138, "MH", "Marshall Islands");
    /// <summary>
    /// The martinique.
    /// </summary>
    public static readonly CountryType Martinique = new(nameof(Martinique), 139, "MQ");
    /// <summary>
    /// The mauritania.
    /// </summary>
    public static readonly CountryType Mauritania = new(nameof(Mauritania), 140, "MR");
    /// <summary>
    /// The mauritius.
    /// </summary>
    public static readonly CountryType Mauritius = new(nameof(Mauritius), 141, "MU");
    /// <summary>
    /// The mayotte.
    /// </summary>
    public static readonly CountryType Mayotte = new(nameof(Mayotte), 142, "YT");
    /// <summary>
    /// The mexico.
    /// </summary>
    public static readonly CountryType Mexico = new(nameof(Mexico), 143, "MX");
    /// <summary>
    /// The micronesia.
    /// </summary>
    public static readonly CountryType Micronesia = new(nameof(Micronesia), 144, "FM");
    /// <summary>
    /// The moldova.
    /// </summary>
    public static readonly CountryType Moldova = new(nameof(Moldova), 145, "MD");
    /// <summary>
    /// The monaco.
    /// </summary>
    public static readonly CountryType Monaco = new(nameof(Monaco), 146, "MC");
    /// <summary>
    /// The mongolia.
    /// </summary>
    public static readonly CountryType Mongolia = new(nameof(Mongolia), 147, "MN");
    /// <summary>
    /// The montenegro.
    /// </summary>
    public static readonly CountryType Montenegro = new(nameof(Montenegro), 148, "ME");
    /// <summary>
    /// The montserrat.
    /// </summary>
    public static readonly CountryType Montserrat = new(nameof(Montserrat), 149, "MS");
    /// <summary>
    /// The morocco.
    /// </summary>
    public static readonly CountryType Morocco = new(nameof(Morocco), 150, "MA");
    /// <summary>
    /// The mozambique.
    /// </summary>
    public static readonly CountryType Mozambique = new(nameof(Mozambique), 151, "MZ");
    /// <summary>
    /// The myanmar.
    /// </summary>
    public static readonly CountryType Myanmar = new(nameof(Myanmar), 152, "MM");
    /// <summary>
    /// The namibia.
    /// </summary>
    public static readonly CountryType Namibia = new(nameof(Namibia), 153, "NA");
    /// <summary>
    /// The nauru.
    /// </summary>
    public static readonly CountryType Nauru = new(nameof(Nauru), 154, "NR");
    /// <summary>
    /// The nepal.
    /// </summary>
    public static readonly CountryType Nepal = new(nameof(Nepal), 155, "NP");
    /// <summary>
    /// The netherlands.
    /// </summary>
    public static readonly CountryType Netherlands = new(nameof(Netherlands), 156, "NL");
    /// <summary>
    /// The new caledonia.
    /// </summary>
    public static readonly CountryType NewCaledonia = new(nameof(NewCaledonia), 157, "NC", "New Caledonia");
    /// <summary>
    /// The new zealand.
    /// </summary>
    public static readonly CountryType NewZealand = new(nameof(NewZealand), 158, "NZ", "New Zealand");
    /// <summary>
    /// The nicaragua.
    /// </summary>
    public static readonly CountryType Nicaragua = new(nameof(Nicaragua), 159, "NI");
    /// <summary>
    /// The niger.
    /// </summary>
    public static readonly CountryType Niger = new(nameof(Niger), 160, "NE");
    /// <summary>
    /// The nigeria.
    /// </summary>
    public static readonly CountryType Nigeria = new(nameof(Nigeria), 161, "NG");
    /// <summary>
    /// The niue.
    /// </summary>
    public static readonly CountryType Niue = new(nameof(Niue), 162, "NU");
    /// <summary>
    /// The norfolk island.
    /// </summary>
    public static readonly CountryType NorfolkIsland = new(nameof(NorfolkIsland), 163, "NF", "Norfolk Island");
    /// <summary>
    /// The northern mariana islands.
    /// </summary>
    public static readonly CountryType NorthernMarianaIslands = new(nameof(NorthernMarianaIslands), 164, "MP", "Northern Mariana Islands");
    /// <summary>
    /// The norway.
    /// </summary>
    public static readonly CountryType Norway = new(nameof(Norway), 165, "NO");
    /// <summary>
    /// The oman.
    /// </summary>
    public static readonly CountryType Oman = new(nameof(Oman), 166, "OM");
    /// <summary>
    /// The pakistan.
    /// </summary>
    public static readonly CountryType Pakistan = new(nameof(Pakistan), 167, "PK");
    /// <summary>
    /// The palau.
    /// </summary>
    public static readonly CountryType Palau = new(nameof(Palau), 168, "PW");
    /// <summary>
    /// The palestine.
    /// </summary>
    public static readonly CountryType Palestine = new(nameof(Palestine), 169, "PS", "Palestinian Territories");
    /// <summary>
    /// The panama.
    /// </summary>
    public static readonly CountryType Panama = new(nameof(Panama), 170, "PA");
    /// <summary>
    /// The papua new guinea.
    /// </summary>
    public static readonly CountryType PapuaNewGuinea = new(nameof(PapuaNewGuinea), 171, "PG", "Papua New Guinea");
    /// <summary>
    /// The paraguay.
    /// </summary>
    public static readonly CountryType Paraguay = new(nameof(Paraguay), 172, "PY");
    /// <summary>
    /// The peru.
    /// </summary>
    public static readonly CountryType Peru = new(nameof(Peru), 173, "PE");
    /// <summary>
    /// The philippines.
    /// </summary>
    public static readonly CountryType Philippines = new(nameof(Philippines), 174, "PH");
    /// <summary>
    /// The pitcairn islands.
    /// </summary>
    public static readonly CountryType PitcairnIslands = new(nameof(PitcairnIslands), 175, "PN", "Pitcairn Islands");
    /// <summary>
    /// The poland.
    /// </summary>
    public static readonly CountryType Poland = new(nameof(Poland), 176, "PL");
    /// <summary>
    /// The portugal.
    /// </summary>
    public static readonly CountryType Portugal = new(nameof(Portugal), 177, "PT");
    /// <summary>
    /// The puerto rico.
    /// </summary>
    public static readonly CountryType PuertoRico = new(nameof(PuertoRico), 178, "PR", "Puerto Rico");
    /// <summary>
    /// The qatar.
    /// </summary>
    public static readonly CountryType Qatar = new(nameof(Qatar), 179, "QA");
    /// <summary>
    /// The north macedonia.
    /// </summary>
    public static readonly CountryType NorthMacedonia = new(nameof(NorthMacedonia), 180, "MK", "North Macedonia");
    /// <summary>
    /// The romania.
    /// </summary>
    public static readonly CountryType Romania = new(nameof(Romania), 181, "RO");
    /// <summary>
    /// The russia.
    /// </summary>
    public static readonly CountryType Russia = new(nameof(Russia), 182, "RU");
    /// <summary>
    /// The rwanda.
    /// </summary>
    public static readonly CountryType Rwanda = new(nameof(Rwanda), 183, "RW");
    /// <summary>
    /// The reunion.
    /// </summary>
    public static readonly CountryType Reunion = new(nameof(Reunion), 184, "RE");
    /// <summary>
    /// The saint barthelemy.
    /// </summary>
    public static readonly CountryType SaintBarthelemy = new(nameof(SaintBarthelemy), 185, "BL", "St. Barthelemy");
    /// <summary>
    /// The saint helena.
    /// </summary>
    public static readonly CountryType SaintHelena = new(nameof(SaintHelena), 186, "SH", "St. Helena");
    /// <summary>
    /// The saint kitts and nevis.
    /// </summary>
    public static readonly CountryType SaintKittsAndNevis = new(nameof(SaintKittsAndNevis), 187, "KN", "St. Kitts & Nevis");
    /// <summary>
    /// The saint lucia.
    /// </summary>
    public static readonly CountryType SaintLucia = new(nameof(SaintLucia), 188, "LC", "St. Lucia");
    /// <summary>
    /// The saint martin.
    /// </summary>
    public static readonly CountryType SaintMartin = new(nameof(SaintMartin), 189, "MF", "St. Martin");
    /// <summary>
    /// The saint pierre and miquelon.
    /// </summary>
    public static readonly CountryType SaintPierreAndMiquelon = new(nameof(SaintPierreAndMiquelon), 190, "PM", "St. Pierre & Miquelon");
    /// <summary>
    /// The saint vincent and the grenadines.
    /// </summary>
    public static readonly CountryType SaintVincentAndTheGrenadines = new(nameof(SaintVincentAndTheGrenadines), 191, "VC", "St. Vincent & Grenadines");
    /// <summary>
    /// The samoa.
    /// </summary>
    public static readonly CountryType Samoa = new(nameof(Samoa), 192, "WS");
    /// <summary>
    /// The san marino.
    /// </summary>
    public static readonly CountryType SanMarino = new(nameof(SanMarino), 193, "SM", "San Marino");
    /// <summary>
    /// The sao tome and principe.
    /// </summary>
    public static readonly CountryType SaoTomeAndPrincipe = new(nameof(SaoTomeAndPrincipe), 194, "ST", "Sao Tome & Principe");
    /// <summary>
    /// The saudi arabia.
    /// </summary>
    public static readonly CountryType SaudiArabia = new(nameof(SaudiArabia), 195, "SA");
    /// <summary>
    /// The senegal.
    /// </summary>
    public static readonly CountryType Senegal = new(nameof(Senegal), 196, "SN");
    /// <summary>
    /// The serbia.
    /// </summary>
    public static readonly CountryType Serbia = new(nameof(Serbia), 197, "RS");
    /// <summary>
    /// The seychelles.
    /// </summary>
    public static readonly CountryType Seychelles = new(nameof(Seychelles), 198, "SC");
    /// <summary>
    /// The sierra leone.
    /// </summary>
    public static readonly CountryType SierraLeone = new(nameof(SierraLeone), 199, "SL", "Sierra Leone");
    /// <summary>
    /// The singapore.
    /// </summary>
    public static readonly CountryType Singapore = new(nameof(Singapore), 200, "SG");
    /// <summary>
    /// The sint maarten.
    /// </summary>
    public static readonly CountryType SintMaarten = new(nameof(SintMaarten), 201, "SX", "Sint Maarten");
    /// <summary>
    /// The slovakia.
    /// </summary>
    public static readonly CountryType Slovakia = new(nameof(Slovakia), 202, "SK");
    /// <summary>
    /// The slovenia.
    /// </summary>
    public static readonly CountryType Slovenia = new(nameof(Slovenia), 203, "SI");
    /// <summary>
    /// The solomon islands.
    /// </summary>
    public static readonly CountryType SolomonIslands = new(nameof(SolomonIslands), 204, "SB", "Solomon Islands");
    /// <summary>
    /// The somalia.
    /// </summary>
    public static readonly CountryType Somalia = new(nameof(Somalia), 205, "SO");
    /// <summary>
    /// The south africa.
    /// </summary>
    public static readonly CountryType SouthAfrica = new(nameof(SouthAfrica), 206, "ZA", "South Africa");
    /// <summary>
    /// The south georgia and south sandwich islands.
    /// </summary>
    public static readonly CountryType SouthGeorgiaAndSouthSandwichIslands = new(nameof(SouthGeorgiaAndSouthSandwichIslands), 207, "GS", "South Georgia & South Sandwich Islands");
    /// <summary>
    /// The south sudan.
    /// </summary>
    public static readonly CountryType SouthSudan = new(nameof(SouthSudan), 208, "SS", "South Sudan");
    /// <summary>
    /// The spain.
    /// </summary>
    public static readonly CountryType Spain = new(nameof(Spain), 209, "ES");
    /// <summary>
    /// The sri lanka.
    /// </summary>
    public static readonly CountryType SriLanka = new(nameof(SriLanka), 210, "LK", "Sri Lanka");
    /// <summary>
    /// The sudan.
    /// </summary>
    public static readonly CountryType Sudan = new(nameof(Sudan), 211, "SD");
    /// <summary>
    /// The suriname.
    /// </summary>
    public static readonly CountryType Suriname = new(nameof(Suriname), 212, "SR");
    /// <summary>
    /// The svalbard and jan mayen.
    /// </summary>
    public static readonly CountryType SvalbardAndJanMayen = new(nameof(SvalbardAndJanMayen), 213, "SJ", "Svalbard & Jan Mayen");
    /// <summary>
    /// The sweden.
    /// </summary>
    public static readonly CountryType Sweden = new(nameof(Sweden), 214, "SE");
    /// <summary>
    /// The switzerland.
    /// </summary>
    public static readonly CountryType Switzerland = new(nameof(Switzerland), 215, "CH");
    /// <summary>
    /// The syria.
    /// </summary>
    public static readonly CountryType Syria = new(nameof(Syria), 216, "SY");
    /// <summary>
    /// The taiwan.
    /// </summary>
    public static readonly CountryType Taiwan = new(nameof(Taiwan), 217, "TW");
    /// <summary>
    /// The tajikistan.
    /// </summary>
    public static readonly CountryType Tajikistan = new(nameof(Tajikistan), 218, "TJ");
    /// <summary>
    /// The tanzania.
    /// </summary>
    public static readonly CountryType Tanzania = new(nameof(Tanzania), 219, "TZ");
    /// <summary>
    /// The thailand.
    /// </summary>
    public static readonly CountryType Thailand = new(nameof(Thailand), 220, "TH");
    /// <summary>
    /// The timor leste.
    /// </summary>
    public static readonly CountryType TimorLeste = new(nameof(TimorLeste), 221, "TL", "Timor-Leste");
    /// <summary>
    /// The togo.
    /// </summary>
    public static readonly CountryType Togo = new(nameof(Togo), 222, "TG");
    /// <summary>
    /// The tokelau.
    /// </summary>
    public static readonly CountryType Tokelau = new(nameof(Tokelau), 223, "TK");
    /// <summary>
    /// The tonga.
    /// </summary>
    public static readonly CountryType Tonga = new(nameof(Tonga), 224, "TO");
    /// <summary>
    /// The trinidad and tobago.
    /// </summary>
    public static readonly CountryType TrinidadAndTobago = new(nameof(TrinidadAndTobago), 225, "TT", "Trinidad & Tobago");
    /// <summary>
    /// The tunisia.
    /// </summary>
    public static readonly CountryType Tunisia = new(nameof(Tunisia), 226, "TN");
    /// <summary>
    /// The turkey.
    /// </summary>
    public static readonly CountryType Turkey = new(nameof(Turkey), 227, "TR");
    /// <summary>
    /// The turkmenistan.
    /// </summary>
    public static readonly CountryType Turkmenistan = new(nameof(Turkmenistan), 228, "TM");
    /// <summary>
    /// The turks and caicos islands.
    /// </summary>
    public static readonly CountryType TurksAndCaicosIslands = new(nameof(TurksAndCaicosIslands), 229, "TC", "Turks & Caicos Islands");
    /// <summary>
    /// The tuvalu.
    /// </summary>
    public static readonly CountryType Tuvalu = new(nameof(Tuvalu), 230, "TV");
    /// <summary>
    /// The uganda.
    /// </summary>
    public static readonly CountryType Uganda = new(nameof(Uganda), 231, "UG");
    /// <summary>
    /// The ukraine.
    /// </summary>
    public static readonly CountryType Ukraine = new(nameof(Ukraine), 232, "UA");
    /// <summary>
    /// The united arab emirates.
    /// </summary>
    public static readonly CountryType UnitedArabEmirates = new(nameof(UnitedArabEmirates), 233, "AE", "United Arab Emirates");
    /// <summary>
    /// The united kingdom.
    /// </summary>
    public static readonly CountryType UnitedKingdom = new(nameof(UnitedKingdom), 234, "GB", "United Kingdom");
    /// <summary>
    /// The united states.
    /// </summary>
    public static readonly CountryType UnitedStates = new(nameof(UnitedStates), 235, "US", "United States");
    /// <summary>
    /// The uruguay.
    /// </summary>
    public static readonly CountryType Uruguay = new(nameof(Uruguay), 236, "UY");
    /// <summary>
    /// The uzbekistan.
    /// </summary>
    public static readonly CountryType Uzbekistan = new(nameof(Uzbekistan), 237, "UZ");
    /// <summary>
    /// The vanuatu.
    /// </summary>
    public static readonly CountryType Vanuatu = new(nameof(Vanuatu), 238, "VU");
    /// <summary>
    /// The venezuela.
    /// </summary>
    public static readonly CountryType Venezuela = new(nameof(Venezuela), 239, "VE");
    /// <summary>
    /// The vietnam.
    /// </summary>
    public static readonly CountryType Vietnam = new(nameof(Vietnam), 240, "VN");
    /// <summary>
    /// The wallis and futuna.
    /// </summary>
    public static readonly CountryType WallisAndFutuna = new(nameof(WallisAndFutuna), 241, "WF", "Wallis & Futuna");
    /// <summary>
    /// The western sahara.
    /// </summary>
    public static readonly CountryType WesternSahara = new(nameof(WesternSahara), 242, "EH", "Western Sahara");
    /// <summary>
    /// The yemen.
    /// </summary>
    public static readonly CountryType Yemen = new(nameof(Yemen), 243, "YE");
    /// <summary>
    /// The zambia.
    /// </summary>
    public static readonly CountryType Zambia = new(nameof(Zambia), 244, "ZM");
    /// <summary>
    /// The zimbabwe.
    /// </summary>
    public static readonly CountryType Zimbabwe = new(nameof(Zimbabwe), 245, "ZW");

    private CountryType(string name, int value, string abbreviation, string? description = null) : base(name, value, abbreviation, description)
    {
    }
}
