using StudentControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FullDB
    {
        [Fact]
        void FullDataBase()
        {
            var data = new[] {
    new {
        Id = "3A3ACB42-8DC2-3956-1E4F-200CE297C5EF",
        Name = "Marshall",
        Surname = "Pierce",
        Middle_name = "Wing",
        Status = 1,
        Graduate = 4,
        rut = "12493736-1"
    },
    new {
        Id = "3E644A4B-5D67-5615-A86A-42298A54A754",
        Name = "Merrill",
        Surname = "Solis",
        Middle_name = "Kirk",
        Status = 1,
        Graduate = 4,
        rut = "48838120-2"
    },
    new {
        Id = "933D4A47-B1A3-BC08-836B-1052DCC77940",
        Name = "Wilma",
        Surname = "Nieves",
        Middle_name = "Stephen",
        Status = 0,
        Graduate = 1,
        rut = "20624580-8"
    },
    new {
        Id = "3EAD53D8-8CBE-26CD-56B6-8E3234371A37",
        Name = "Riley",
        Surname = "Olson",
        Middle_name = "Jonah",
        Status = 0,
        Graduate = 1,
        rut = "2068972-2"
    },
    new {
        Id = "3E7CB4D1-511C-61A2-1D35-4EB74D2DE958",
        Name = "Donovan",
        Surname = "Gibbs",
        Middle_name = "Zephania",
        Status = 0,
        Graduate = 5,
        rut = "23353675-K"
    },
    new {
        Id = "A28DB212-7848-2E61-750E-F65A8F4C0958",
        Name = "Cade",
        Surname = "Richmond",
        Middle_name = "Jesse",
        Status = 1,
        Graduate = 4,
        rut = "33183747-4"
    },
    new {
        Id = "EC1C64E2-64DE-9C93-1E48-74CA68902632",
        Name = "Wallace",
        Surname = "Palmer",
        Middle_name = "Dalton",
        Status = 1,
        Graduate = 3,
        rut = "45537615-7"
    },
    new {
        Id = "7CCA1535-C90A-E4E9-7ECE-B979983770D0",
        Name = "Edan",
        Surname = "Hawkins",
        Middle_name = "Jakeem",
        Status = 0,
        Graduate = 4,
        rut = "38123826-1"
    },
    new {
        Id = "91BC66D1-EAFA-F81D-2557-4C680D51CBD0",
        Name = "Gisela",
        Surname = "Reid",
        Middle_name = "Randall",
        Status = 0,
        Graduate = 2,
        rut = "4498626-4"
    },
    new {
        Id = "4C861227-13B6-B98B-A77E-60491D8FCBAF",
        Name = "Reuben",
        Surname = "Woodward",
        Middle_name = "Aristotle",
        Status = 0,
        Graduate = 4,
        rut = "44609375-4"
    },
    new {
        Id = "13BFEA27-DA77-C2B7-70BC-B6FAD043C615",
        Name = "Graham",
        Surname = "Potter",
        Middle_name = "Oliver",
        Status = 1,
        Graduate = 5,
        rut = "850488-1"
    },
    new {
        Id = "C5D8CAA2-E835-4AAC-A3C5-D5DB813B5152",
        Name = "Nathan",
        Surname = "Dunlap",
        Middle_name = "Dennis",
        Status = 1,
        Graduate = 4,
        rut = "44382126-0"
    },
    new {
        Id = "5C8F36CB-A7E9-CC51-E4A2-011DC90259CB",
        Name = "Nigel",
        Surname = "Floyd",
        Middle_name = "Alvin",
        Status = 0,
        Graduate = 2,
        rut = "50272573-4"
    },
    new {
        Id = "2AC7536D-5952-50F7-8876-55E45A4E98BC",
        Name = "Peter",
        Surname = "Sexton",
        Middle_name = "Jared",
        Status = 0,
        Graduate = 3,
        rut = "20106229-2"
    },
    new {
        Id = "85D68CE4-B54A-0EE9-7384-4958EDF3BAA6",
        Name = "Adria",
        Surname = "Wilcox",
        Middle_name = "Stuart",
        Status = 0,
        Graduate = 3,
        rut = "22922506-5"
    },
    new {
        Id = "2618D6FE-311B-38E9-35A7-844811C77ABC",
        Name = "Cody",
        Surname = "Graham",
        Middle_name = "Amos",
        Status = 0,
        Graduate = 4,
        rut = "39174997-3"
    },
    new {
        Id = "2047CEBA-344E-504E-AD17-A394D30D2CD6",
        Name = "Hamilton",
        Surname = "Elliott",
        Middle_name = "Hamilton",
        Status = 0,
        Graduate = 1,
        rut = "7994623-0"
    },
    new {
        Id = "B1B128A8-D363-5FA9-A4DD-D90D89B13F63",
        Name = "Wyatt",
        Surname = "Tyson",
        Middle_name = "Dylan",
        Status = 1,
        Graduate = 4,
        rut = "18884343-3"
    },
    new {
        Id = "8F6608C7-979E-D21C-4987-2C35DA5C8318",
        Name = "Nehru",
        Surname = "Hunt",
        Middle_name = "Austin",
        Status = 0,
        Graduate = 1,
        rut = "1210752-8"
    },
    new {
        Id = "4A4573AA-F5B2-D87B-2462-C785D91EC51A",
        Name = "Haviva",
        Surname = "Lucas",
        Middle_name = "Dolan",
        Status = 0,
        Graduate = 1,
        rut = "3165453-K"
    },
    new {
        Id = "6E45CD3A-0B5D-DA53-2A2D-A479FBB71548",
        Name = "Jacob",
        Surname = "Singleton",
        Middle_name = "Giacomo",
        Status = 1,
        Graduate = 3,
        rut = "45971775-7"
    },
    new {
        Id = "43118A59-6A41-13B5-3C9D-4DBD97C4C076",
        Name = "Cruz",
        Surname = "Weaver",
        Middle_name = "Aidan",
        Status = 0,
        Graduate = 2,
        rut = "4516812-3"
    },
    new {
        Id = "D5A84513-291E-711B-CD52-438B53BB2650",
        Name = "Kamal",
        Surname = "Mayo",
        Middle_name = "Tad",
        Status = 0,
        Graduate = 1,
        rut = "33995557-3"
    },
    new {
        Id = "2B606136-CDDA-6963-31AD-A3647879E3D8",
        Name = "Hedwig",
        Surname = "Nieves",
        Middle_name = "Mannix",
        Status = 0,
        Graduate = 4,
        rut = "47601240-6"
    },
    new {
        Id = "9124826B-EF2C-B795-15AD-A4630176CF08",
        Name = "Emerson",
        Surname = "Mccall",
        Middle_name = "Sean",
        Status = 1,
        Graduate = 1,
        rut = "3894289-1"
    },
    new {
        Id = "5EC8A973-1242-25B1-E7F0-6389D8F64B9F",
        Name = "Devin",
        Surname = "Campos",
        Middle_name = "Carlos",
        Status = 0,
        Graduate = 3,
        rut = "30452592-4"
    },
    new {
        Id = "31048EB5-5A35-42EE-EE70-3529C69398A4",
        Name = "Patricia",
        Surname = "Mann",
        Middle_name = "Micah",
        Status = 1,
        Graduate = 4,
        rut = "4767424-7"
    },
    new {
        Id = "228BA9EF-D93F-CEA9-7AE9-C245B80D0DCD",
        Name = "Jonah",
        Surname = "Chavez",
        Middle_name = "Wylie",
        Status = 1,
        Graduate = 3,
        rut = "27833554-2"
    },
    new {
        Id = "A5823249-AA7D-F1B9-B861-AB2C133896F7",
        Name = "Kenneth",
        Surname = "Glover",
        Middle_name = "Samson",
        Status = 0,
        Graduate = 5,
        rut = "46550990-2"
    },
    new {
        Id = "72482DF9-2158-B991-7E58-5731EFE27771",
        Name = "Hannah",
        Surname = "Ball",
        Middle_name = "Mohammad",
        Status = 1,
        Graduate = 2,
        rut = "38292841-5"
    },
    new {
        Id = "C361261F-19EF-2110-B3AE-2578EC5BC54C",
        Name = "Amery",
        Surname = "Webb",
        Middle_name = "Darius",
        Status = 0,
        Graduate = 2,
        rut = "24187240-8"
    },
    new {
        Id = "9B296873-B6A5-50C7-E82A-10E7DDAEAC6C",
        Name = "Octavius",
        Surname = "Conway",
        Middle_name = "Trevor",
        Status = 1,
        Graduate = 1,
        rut = "17584632-8"
    },
    new {
        Id = "EA7AF786-9E6C-0BE4-BA7E-EB36D514926D",
        Name = "Magee",
        Surname = "Garcia",
        Middle_name = "Chandler",
        Status = 0,
        Graduate = 3,
        rut = "4783229-2"
    },
    new {
        Id = "31A245C9-5485-CE86-5729-49E984399845",
        Name = "Cheyenne",
        Surname = "Marquez",
        Middle_name = "Aquila",
        Status = 0,
        Graduate = 4,
        rut = "28524631-8"
    },
    new {
        Id = "3561E138-4D13-16A6-F15E-6A03B3ADB37D",
        Name = "Regina",
        Surname = "Puckett",
        Middle_name = "Ronan",
        Status = 1,
        Graduate = 3,
        rut = "421919-8"
    },
    new {
        Id = "25A532BE-ECB9-7931-4AE6-2D6148436FB9",
        Name = "Adrian",
        Surname = "Delaney",
        Middle_name = "Kato",
        Status = 1,
        Graduate = 1,
        rut = "38864987-9"
    },
    new {
        Id = "1DBE0245-9398-E5C9-53D2-A7827256577B",
        Name = "Jordan",
        Surname = "Richard",
        Middle_name = "Oscar",
        Status = 1,
        Graduate = 1,
        rut = "8674361-2"
    },
    new {
        Id = "EE1F2489-157A-8953-6B11-06C3665334DD",
        Name = "Alice",
        Surname = "Tucker",
        Middle_name = "Castor",
        Status = 0,
        Graduate = 3,
        rut = "9488479-9"
    },
    new {
        Id = "DFD810ED-2AEA-DCC1-C58C-CCCB18382E7F",
        Name = "Laura",
        Surname = "Finch",
        Middle_name = "Vernon",
        Status = 0,
        Graduate = 1,
        rut = "13404554-K"
    },
    new {
        Id = "18CCD7F7-A73E-183B-E61C-0A945B7042CB",
        Name = "Lynn",
        Surname = "York",
        Middle_name = "Arsenio",
        Status = 1,
        Graduate = 1,
        rut = "34370335-K"
    },
    new {
        Id = "5659E179-FD74-5539-1F3D-AB2325B13989",
        Name = "Akeem",
        Surname = "Franco",
        Middle_name = "Ignatius",
        Status = 0,
        Graduate = 4,
        rut = "35628288-4"
    },
    new {
        Id = "958DD979-2CF0-25E1-51FE-B4A821C16669",
        Name = "Erin",
        Surname = "Ware",
        Middle_name = "Reece",
        Status = 1,
        Graduate = 2,
        rut = "45432516-8"
    },
    new {
        Id = "E8102CC9-531E-5992-1D25-EFB33C7A56C3",
        Name = "Ina",
        Surname = "Sharp",
        Middle_name = "Scott",
        Status = 0,
        Graduate = 1,
        rut = "1571400-K"
    },
    new {
        Id = "8FC1D0BE-EA78-5B94-CAB7-B3CEA32B0392",
        Name = "William",
        Surname = "Ramos",
        Middle_name = "Coby",
        Status = 1,
        Graduate = 3,
        rut = "2817464-0"
    },
    new {
        Id = "DB1A7D72-D3D6-4C7E-B6F8-B2B4E5B2517F",
        Name = "Alan",
        Surname = "Sharpe",
        Middle_name = "Ryder",
        Status = 0,
        Graduate = 3,
        rut = "12988425-8"
    },
    new {
        Id = "D16E5D78-D612-B726-4755-B9B1A8E9609B",
        Name = "Rhiannon",
        Surname = "Farrell",
        Middle_name = "Brandon",
        Status = 1,
        Graduate = 2,
        rut = "34403185-1"
    },
    new {
        Id = "CEBB8B5E-E7F4-03A7-05E6-06BEB4A7376C",
        Name = "Tiger",
        Surname = "Elliott",
        Middle_name = "Emery",
        Status = 1,
        Graduate = 4,
        rut = "32983513-8"
    },
    new {
        Id = "91DAB862-7869-66BF-C59A-8AA18D810821",
        Name = "Jin",
        Surname = "Blair",
        Middle_name = "Beau",
        Status = 0,
        Graduate = 4,
        rut = "7303904-5"
    },
    new {
        Id = "562E5793-6E62-B928-75A2-7A5467F5AAA6",
        Name = "Octavius",
        Surname = "Berger",
        Middle_name = "Elijah",
        Status = 1,
        Graduate = 1,
        rut = "23204964-2"
    },
    new {
        Id = "2E67C8AD-1189-B88E-162F-2CC67CD5822C",
        Name = "Odessa",
        Surname = "Clay",
        Middle_name = "Bradley",
        Status = 1,
        Graduate = 4,
        rut = "713724-9"
    },
    new {
        Id = "14851325-E51D-E6D0-85D8-37A65B492794",
        Name = "Mona",
        Surname = "Villarreal",
        Middle_name = "Tad",
        Status = 1,
        Graduate = 2,
        rut = "43364306-2"
    },
    new {
        Id = "C86C87AE-6E25-8134-5D17-9E095B573848",
        Name = "Sydnee",
        Surname = "Rhodes",
        Middle_name = "Jarrod",
        Status = 1,
        Graduate = 2,
        rut = "3618880-4"
    },
    new {
        Id = "333B1DDE-06B3-02E9-76A2-DAE404877319",
        Name = "Branden",
        Surname = "Graves",
        Middle_name = "Colby",
        Status = 0,
        Graduate = 4,
        rut = "30724210-9"
    },
    new {
        Id = "95B4A153-ABB7-7217-9835-144316E274AA",
        Name = "Rebecca",
        Surname = "Brock",
        Middle_name = "Aristotle",
        Status = 0,
        Graduate = 2,
        rut = "28817639-6"
    },
    new {
        Id = "E2DB7937-8F0A-B293-EE54-EA373B8D6981",
        Name = "Martin",
        Surname = "Mays",
        Middle_name = "Honorato",
        Status = 1,
        Graduate = 3,
        rut = "15958845-9"
    },
    new {
        Id = "3E7BF14C-D9B7-5239-6EB8-74B15F3C8904",
        Name = "Sacha",
        Surname = "Chambers",
        Middle_name = "Zephania",
        Status = 1,
        Graduate = 3,
        rut = "11143602-9"
    },
    new {
        Id = "3596B669-1F46-BC1C-3F39-5567CA178BCD",
        Name = "Destiny",
        Surname = "Foley",
        Middle_name = "Paul",
        Status = 1,
        Graduate = 2,
        rut = "11317480-3"
    },
    new {
        Id = "B2EA287D-2B51-418E-37B2-A4F8C9AE7390",
        Name = "Sasha",
        Surname = "Higgins",
        Middle_name = "Emmanuel",
        Status = 1,
        Graduate = 2,
        rut = "1928941-9"
    },
    new {
        Id = "720A3142-1BCC-C627-7CBE-2682B85E5558",
        Name = "Ralph",
        Surname = "Dejesus",
        Middle_name = "Brock",
        Status = 0,
        Graduate = 4,
        rut = "4568593-4"
    },
    new {
        Id = "B5A6D44D-DA37-D192-A76A-303A57A3AC88",
        Name = "Abel",
        Surname = "Herrera",
        Middle_name = "Amir",
        Status = 1,
        Graduate = 2,
        rut = "28451522-6"
    },
    new {
        Id = "4F246DFC-7EE0-D1A3-BF92-358C5C02066F",
        Name = "Arden",
        Surname = "Dawson",
        Middle_name = "Bruno",
        Status = 0,
        Graduate = 0,
        rut = "14722826-0"
    },
    new {
        Id = "837B6239-3424-CDA6-021D-B68570D3C74A",
        Name = "April",
        Surname = "Peterson",
        Middle_name = "Ryan",
        Status = 0,
        Graduate = 4,
        rut = "30179970-5"
    },
    new {
        Id = "29DC132E-217D-C571-9BC2-C1CD5AE92538",
        Name = "Darius",
        Surname = "Joyce",
        Middle_name = "Cadman",
        Status = 0,
        Graduate = 1,
        rut = "47892983-8"
    },
    new {
        Id = "C1255BBC-E3AE-9FAC-131E-79994D472D6B",
        Name = "Rebecca",
        Surname = "Martin",
        Middle_name = "Shad",
        Status = 1,
        Graduate = 2,
        rut = "49786370-8"
    },
    new {
        Id = "97EC6DC8-F595-1DD9-C036-3896988A2D51",
        Name = "Denton",
        Surname = "Hays",
        Middle_name = "Logan",
        Status = 1,
        Graduate = 3,
        rut = "30257190-2"
    },
    new {
        Id = "4E522B65-A967-33F9-0BDA-519566C0EDF6",
        Name = "Beau",
        Surname = "Smith",
        Middle_name = "Anthony",
        Status = 1,
        Graduate = 1,
        rut = "4956595-K"
    },
    new {
        Id = "60EDC1F3-DCD5-9698-0544-DC8C15F33852",
        Name = "Fuller",
        Surname = "Martinez",
        Middle_name = "Barrett",
        Status = 1,
        Graduate = 2,
        rut = "375725-0"
    },
    new {
        Id = "C21B1138-B56D-55B9-7893-E9EA0875E827",
        Name = "Stephen",
        Surname = "Dillard",
        Middle_name = "Damon",
        Status = 1,
        Graduate = 2,
        rut = "18458317-8"
    },
    new {
        Id = "6DECEB45-E80D-22BD-DF85-6292DB9C95A9",
        Name = "Paul",
        Surname = "Keith",
        Middle_name = "Elton",
        Status = 1,
        Graduate = 0,
        rut = "22249401-K"
    },
    new {
        Id = "9F0B7C55-5353-FD77-C85A-5713E31D008A",
        Name = "Kerry",
        Surname = "Knapp",
        Middle_name = "Xander",
        Status = 1,
        Graduate = 4,
        rut = "37642888-5"
    },
    new {
        Id = "176D2A0E-A0CC-DFA4-97DE-F82EF22646FB",
        Name = "Paul",
        Surname = "Gates",
        Middle_name = "Sylvester",
        Status = 0,
        Graduate = 3,
        rut = "36675395-8"
    },
    new {
        Id = "B0EE2A2E-C120-64D8-EBE5-FDF7A5E947BC",
        Name = "Alfreda",
        Surname = "Gill",
        Middle_name = "Brian",
        Status = 0,
        Graduate = 2,
        rut = "50597405-0"
    },
    new {
        Id = "698A53D1-8784-31CB-B48C-2D6A7223F433",
        Name = "Daquan",
        Surname = "Brock",
        Middle_name = "Walker",
        Status = 0,
        Graduate = 4,
        rut = "7549449-1"
    },
    new {
        Id = "6F3B7459-D89E-D705-4B9C-34313D25751E",
        Name = "Clinton",
        Surname = "Carson",
        Middle_name = "Fletcher",
        Status = 0,
        Graduate = 3,
        rut = "18451677-2"
    },
    new {
        Id = "2268B3C2-1617-B2D8-7339-25351A635437",
        Name = "Jesse",
        Surname = "Pickett",
        Middle_name = "Trevor",
        Status = 1,
        Graduate = 4,
        rut = "1815581-8"
    },
    new {
        Id = "C8EEECDA-D8E4-56E6-4A11-3C8B1715D4BB",
        Name = "India",
        Surname = "Owens",
        Middle_name = "Felix",
        Status = 0,
        Graduate = 5,
        rut = "24885699-8"
    },
    new {
        Id = "C60390AC-6308-7763-6E81-A44756B625A9",
        Name = "Clinton",
        Surname = "Taylor",
        Middle_name = "Ignatius",
        Status = 1,
        Graduate = 0,
        rut = "6603416-K"
    },
    new {
        Id = "0EB308E3-779C-C48A-A734-40C1E70BA226",
        Name = "Orlando",
        Surname = "Rogers",
        Middle_name = "Levi",
        Status = 0,
        Graduate = 3,
        rut = "37325344-8"
    },
    new {
        Id = "34E2ECD1-9540-273C-2DC8-9049252B4BA0",
        Name = "Buffy",
        Surname = "Osborne",
        Middle_name = "Geoffrey",
        Status = 0,
        Graduate = 0,
        rut = "28655796-1"
    },
    new {
        Id = "DFF928F2-83C3-25BE-B9A5-EB42E4779591",
        Name = "Gray",
        Surname = "Jones",
        Middle_name = "Declan",
        Status = 1,
        Graduate = 2,
        rut = "32932623-3"
    },
    new {
        Id = "B3DEFE10-F46A-52EA-E2DF-D8B61A277830",
        Name = "Lionel",
        Surname = "West",
        Middle_name = "Reuben",
        Status = 1,
        Graduate = 3,
        rut = "2959579-8"
    },
    new {
        Id = "FC9DF22A-F46E-B9B8-483A-54BC4D72E589",
        Name = "Tanya",
        Surname = "Espinoza",
        Middle_name = "Nissim",
        Status = 0,
        Graduate = 2,
        rut = "1738983-1"
    },
    new {
        Id = "A88B2167-7C05-4821-38DD-7D35257809D5",
        Name = "Germane",
        Surname = "Marquez",
        Middle_name = "Mufutau",
        Status = 1,
        Graduate = 4,
        rut = "17485252-9"
    },
    new {
        Id = "7D039A1D-A715-7C9B-DA44-45F933C8DC45",
        Name = "Marshall",
        Surname = "Cole",
        Middle_name = "Hedley",
        Status = 1,
        Graduate = 3,
        rut = "9620471-K"
    },
    new {
        Id = "C68DC834-38BE-E527-C2D8-36B93122C8B1",
        Name = "Maryam",
        Surname = "Perkins",
        Middle_name = "Harding",
        Status = 0,
        Graduate = 3,
        rut = "1262780-7"
    },
    new {
        Id = "68A01243-453C-81C0-4D11-8B78CBBFAA0B",
        Name = "Raymond",
        Surname = "Hooper",
        Middle_name = "Channing",
        Status = 0,
        Graduate = 4,
        rut = "37500549-2"
    },
    new {
        Id = "6C6238D7-1DED-2274-E5A6-58987231A5B7",
        Name = "Jenna",
        Surname = "Riddle",
        Middle_name = "Keefe",
        Status = 0,
        Graduate = 3,
        rut = "815177-6"
    },
    new {
        Id = "9A5E3BB1-EE42-D491-55A0-D8B92DC29E71",
        Name = "Griffin",
        Surname = "Christensen",
        Middle_name = "Len",
        Status = 1,
        Graduate = 1,
        rut = "47581453-3"
    },
    new {
        Id = "FCE1331D-EBCC-5191-16DB-003592410736",
        Name = "Dalton",
        Surname = "Mendoza",
        Middle_name = "Talon",
        Status = 1,
        Graduate = 2,
        rut = "12269786-K"
    },
    new {
        Id = "F91652A8-A463-3683-726C-98F63358806B",
        Name = "Aurora",
        Surname = "Lynch",
        Middle_name = "Burton",
        Status = 0,
        Graduate = 5,
        rut = "28785718-7"
    },
    new {
        Id = "5DC7124A-06F5-9D58-8B10-F2552210DEE8",
        Name = "Stacey",
        Surname = "Raymond",
        Middle_name = "Leo",
        Status = 1,
        Graduate = 3,
        rut = "29459520-1"
    },
    new {
        Id = "51534BEB-C636-C49A-2E68-A637D26B002E",
        Name = "Lynn",
        Surname = "Anderson",
        Middle_name = "Reed",
        Status = 1,
        Graduate = 3,
        rut = "44812898-9"
    },
    new {
        Id = "221F5036-7AB0-79A8-BB84-FC85A75234D8",
        Name = "Fleur",
        Surname = "Curtis",
        Middle_name = "Ulric",
        Status = 1,
        Graduate = 1,
        rut = "3696240-2"
    },
    new {
        Id = "C6F55A3B-8990-3923-D3E1-1CBC6ACAF44A",
        Name = "Jesse",
        Surname = "Thornton",
        Middle_name = "Drake",
        Status = 1,
        Graduate = 5,
        rut = "50260387-6"
    },
    new {
        Id = "B9DB281D-0B4B-9123-07A3-A7E2CDD77129",
        Name = "Lacey",
        Surname = "Thompson",
        Middle_name = "Timon",
        Status = 1,
        Graduate = 1,
        rut = "22300431-8"
    },
    new {
        Id = "53AF2C30-E875-9000-4B9B-A1384D2A7756",
        Name = "Brooke",
        Surname = "Savage",
        Middle_name = "Price",
        Status = 1,
        Graduate = 2,
        rut = "6495562-4"
    },
    new {
        Id = "C99251EE-B0A2-76B4-CD1B-D203938576BE",
        Name = "Donna",
        Surname = "Frank",
        Middle_name = "Davis",
        Status = 0,
        Graduate = 3,
        rut = "25789132-1"
    },
    new {
        Id = "40DB718E-5668-8A72-90CE-59F96E827217",
        Name = "Lenore",
        Surname = "Vang",
        Middle_name = "Reuben",
        Status = 1,
        Graduate = 2,
        rut = "179514-7"
    },
    new {
        Id = "60958511-68EA-CE9F-21E8-3B47D4AC8BBE",
        Name = "Maggie",
        Surname = "Rowe",
        Middle_name = "Victor",
        Status = 0,
        Graduate = 3,
        rut = "49161430-7"
    },
    new {
        Id = "98DB3AE9-83C3-5123-8EEC-09F5C20634BA",
        Name = "Boris",
        Surname = "Ramirez",
        Middle_name = "Daquan",
        Status = 1,
        Graduate = 3,
        rut = "43433309-1"
    }
};
            var TestHelper = new TestHelper();
            var Repository = TestHelper.StudentRepository;
            foreach (var element in data)
            {
                Student student = new Student();
                student.Name= element.Name;
                student.Surname = element.Surname;
                student.Middle_name= element.Middle_name;
                student.Graduate =(short) element.Graduate;
                if (element.Status == 0) student.Status = Status.Studying;
                else student.Status = Status.Notstudying;
                student.Snils = element.rut;

                Repository.AddAsync(student).Wait();
                Repository.ChangeTrackerClear();
            }
            
            

            Assert.Equal(1, 1);
        }
    }
}
