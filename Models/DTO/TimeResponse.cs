using System.Text.Json;
using System.Text.Json.Serialization;

namespace PetScanner.Models.DTO;

public class TimeResponseConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        long unixTimeSeconds = reader.GetInt64();
        return DateTimeOffset.FromUnixTimeSeconds(unixTimeSeconds).DateTime;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        long unixTimeSeconds = new DateTimeOffset(value).ToUnixTimeSeconds();
        writer.WriteNumberValue(unixTimeSeconds);
    }
}

public class TimeResponse
{
    [JsonPropertyName("time")]
    [JsonConverter(typeof(TimeResponseConverter))]
    public DateTime Time { get; set; }
}
