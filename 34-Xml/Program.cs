using _34_xml_json;
using Newtonsoft.Json;


Console.WriteLine("JSON");







StreamReader sr = new StreamReader("../../../Kitap.json");
string strJson = sr.ReadToEnd();


var kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(strJson);

foreach (var item in kitaplar)
{
    Console.WriteLine(item.ID + " " + item.Ad + " " + item.Yazar + " " + item.Fiyat);
}


Console.WriteLine("JSON String" + JsonConvert.SerializeObject(kitaplar));


