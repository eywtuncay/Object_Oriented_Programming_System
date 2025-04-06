using _35_jsonKullanimiOrnek;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;




//Console.WriteLine("ReqRes");

//HttpClient client = new HttpClient();

//string strJson = await client.GetStringAsync("https://reqres.in/api/users?page=2");


//JsonNode jsonNode = JsonNode.Parse(strJson);
//JsonArray kullanicilar = jsonNode["data"].AsArray();

//List<User> users = new List<User>();

//foreach (JsonNode kullanici in kullanicilar)
//{
//    User user = new User
//    {
//        FirstName = kullanici["first_name"].ToString(),
//        LastName = kullanici["last_name"].ToString()
//    };
//    users.Add(user);
//}

//foreach (var user in users)
//{
//    Console.WriteLine($"Ad: {user.FirstName}, Soyad: {user.LastName}");
//}


//Düzgün çalışmıyor - Hatalı
Console.WriteLine("ReqRes");

HttpClient client = new HttpClient();

string strJson = await client.GetStringAsync("https://reqres.in/api/users?page=2");

Console.WriteLine(strJson);

ResponseData responseData = JsonConverter.DeserializerObject<ResponseData>(strJson);


foreach (var item in responseData.Data)
{
    Console.WriteLine(item.Id+" "+ item.First_Name + " "+ item.Last_Name);
}



