using System.Diagnostics.Metrics;
using System.Xml.Linq;
using Amazon.SecurityToken.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using PFormula1MongoDB;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criar conexão com o banco ==============================================================================

        ConectionDB conectionDB = new("mongodb", "localhost", 27017);
        string pathConection = conectionDB.PathConection(conectionDB);


        MongoClient mongo = new MongoClient(pathConection); // ("mongodb://localhost:27017");
        //Console.WriteLine(mongo);

               var listabancos = mongo.ListDatabaseNames().ToList();
        
               foreach (var banco in listabancos)
               {
                   Console.WriteLine(banco);
               }

        var basedados = mongo.GetDatabase("Formula1");
        var collection = basedados.GetCollection<BsonDocument>("Pilotos"); //dentro de collections há os documentos
                                                                           //        var document = collection.Find(new BsonDocument()).FirstOrDefault(); //achar o primeiro documento ou o default do tipo Bson // Bson é como o mongo trabalha

        //       Console.WriteLine(document.ToString());

        var documents = collection.Find(new BsonDocument()).ToList();



        /*
        Console.WriteLine(documents.Count());

        foreach (var document in documents)
        {
            Console.WriteLine(document.ToString());
            Console.ReadLine();
        }



        
        // Select ==============================================================================
        //Console.WriteLine("Informe o nome do piloto:");
        var p = Console.ReadLine();

        //var filtro = Builders<BsonDocument>.Filter.Eq("Driver", p); //Campo, valor  // O Builders garante que está na formatação correta
        var filtro = Builders<BsonDocument>.Filter.Regex("Driver", p);

        var piloto = collection.Find(filtro).FirstOrDefault();

        Console.WriteLine(piloto.ToString());

        //Console.WriteLine("Informe o nome da equipe:");
        var e = Console.ReadLine();

        filtro = Builders<BsonDocument>.Filter.Regex("Team", e);
        
        var pilotos = collection.Find(filtro).ToList();

        foreach (var driver in pilotos)
        {
            Console.WriteLine(driver);
        }
        */


        // Create ==============================================================================
        /*
        Console.WriteLine("Nome: ");
        string n = Console.ReadLine();

        Console.WriteLine("Abreviação: ");
        string a = Console.ReadLine();

        Console.WriteLine("Numero: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Equipe: ");
        string equip = Console.ReadLine();

        Console.WriteLine("País: ");
        string pa = Console.ReadLine();

        Console.WriteLine("Podio: ");
        int pod = int.Parse(Console.ReadLine());

        Console.WriteLine("Pontos: ");
        int pont = int.Parse(Console.ReadLine());

        Console.WriteLine("aniversario: ");
        string aniv = Console.ReadLine();
        
        Driver pilot = new Driver(n, a, num, equip, pa, pod, pont, aniv);

       // Console.WriteLine(pilot.ToString());

        var pilotDoc = new BsonDocument
        {
            {"Driver", pilot.Name},
            {"Abbreviation", pilot.Abbreviation},
            {"No", pilot.Number},
            {"Team", pilot.Team},
            {"Country", pilot.Country },
            {"Podium", pilot.Podiums },
            {"Points", pilot.Points },
            {"Date of Birth", pilot.BirthDate }
        };

        var pilotDoc2 = new BsonDocument
        {
            {"Teste", pilot.Name},
            {"Abbreviation", pilot.Abbreviation},
            {"No", pilot.Number},
            {"Team", pilot.Team},
            {"Country", pilot.Country },
            {"Podium", pilot.Podiums },
            {"Points", pilot.Points },
            {"Date of Birth", pilot.BirthDate }
        };

        //Console.WriteLine(pilotDoc);

        collection.InsertOne(pilotDoc2);
        */




        /*
        Console.WriteLine("Qual o nome do piloto?");
        var p = Console.ReadLine();

        var filtro = Builders<BsonDocument>.Filter.Regex("Driver", p);

        var piloto = collection.Find(filtro).FirstOrDefault();

        var piloto2 = BsonSerializer.Deserialize<Driver>(piloto);

        Console.WriteLine(piloto2.ToString());
        */



        // Update ==============================================================================
        /*
        Console.WriteLine("Informe onome do piloto: ");
        string n = Console.ReadLine();

        var filtro = Builders<BsonDocument>.Filter.Regex("Driver", n);

        var p = collection.Find(filtro).First();

        var driver = BsonSerializer.Deserialize<Driver>(p); //não seria necessário transformar em objeto, é feito dentro do update.set

        Console.WriteLine("Informe o novo número:");
        int m = int.Parse(Console.ReadLine());
        driver.Number = m; //não seria necessário, é feito dentro do update.set

        var update = Builders<BsonDocument>.Update.Set("No", m);

        collection.UpdateOne(filtro, update);
        */


        //Delete ==============================================================================
        /*
        Console.WriteLine("Qual piloto vc quer deletar?");
        string s = Console.ReadLine();
        var filtro = Builders<BsonDocument>.Filter.Regex("Driver", s);
        collection.FindOneAndDelete(filtro);
        */
    }
}