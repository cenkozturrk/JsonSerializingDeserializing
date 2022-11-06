using JsonSerializingDeserializing;
using Newtonsoft.Json;

class program
{
    static void Main(string[] args)
    {
        var data = GetJson();

        var MyEntities = DeSerialize(data);

        ConvertJson(MyEntities);
    }

    public static void ConvertJson(Weather model)
    {
        WriteMessage("Convert back to Json data:");
        var covertJson = JsonConvert.SerializeObject(model);
        WriteMessage(covertJson);
    }

    public static Weather DeSerialize(string model)
    {
        WriteMessage("Configuration of c# model.");
        var convertData = JsonConvert.DeserializeObject<Weather>(model);
        WriteMessage(convertData.GetType().ToString());
        WriteMessage(convertData.Summary);
        return convertData;
    }


    public static void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static string GetJson()
    {
        var model = @"{
            'Date': '2019 - 08 - 01T00: 00:00 - 07:00',
            'TemperatureCelsius': 25,
            'Summary': 'Hot',
            'TemperatureRanges': {
                          'coldMinTemp': 20,
              'hotMinTemp': 40
            }
           }";
        return model; 
    }

}
