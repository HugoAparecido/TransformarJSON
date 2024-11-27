// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using TransformarJSON;

// Convertendo Json para um objeto
var json = "{\"produto\":\"tenis\",\"preco\":150.00,\"quantidade\":2}";
var jsonObject = JsonConvert.DeserializeObject<ProductModel>(json);
var ObjectToJson = JsonConvert.SerializeObject(jsonObject);
Console.WriteLine(ObjectToJson);