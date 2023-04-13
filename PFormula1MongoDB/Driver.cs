using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PFormula1MongoDB
{
    [BsonIgnoreExtraElements]
    internal class Driver
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ID { get; set; }

        [BsonElement("Driver")]
        public string? Name { get; set; }

        [BsonElement("Abbreviation")]
        public string? Abbreviation { get; set; }

        [BsonElement("No")]
        [BsonRepresentation(BsonType.Int32)]
        public int? Number { get; set; }

        [BsonElement("Team")]
        public string? Team { get; set; }

        [BsonElement("Country")]
        public string? Country { get; set; }

        [BsonElement("Podiums")]
        public int? Podiums { get; set; }

        [BsonElement("Points")]
        public int? Points { get; set; }

        [BsonElement("Date of Birth")]
        public string BirthDate { get; set; }

        public Driver(string? name, string? abbreviation, int? number, string? team, string? country, int? podiums, int? points, string? birthDate)
        {
            Name = name;
            Abbreviation = abbreviation;
            Number = number;
            Team = team;
            Country = country;
            Podiums = podiums;
            Points = points;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nAbreviação: {Abbreviation}\nNumero: {Number}\nEquipe: {Team}\nPaís de Origem: {Country}\nData de Nascimento: {BirthDate}";
        }
    }
}
