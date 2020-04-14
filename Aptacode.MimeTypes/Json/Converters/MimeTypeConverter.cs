using System;
using Newtonsoft.Json;

namespace Aptacode.MimeTypes.Json.Converters
{
    public class MimeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(MimeType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {

                if (reader.TokenType != JsonToken.String)
                    return MimeType.None;

                var type = reader.Value.ToString();

                reader.Read();

                if (reader.TokenType != JsonToken.String)
                    return MimeType.None;

                var subtype = reader.Value.ToString();

                return new MimeType(type, subtype);

            }
            catch (Exception ex)
            {
                throw new JsonSerializationException($"Error converting value {reader.Value} to type '{objectType}'.", ex);
            }

            throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing {nameof(MimeType)}.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var mimeType = (MimeType)value;

            writer.WriteValue(mimeType.Type);
            writer.WriteValue(mimeType.Subtype);

        }
    }
}
