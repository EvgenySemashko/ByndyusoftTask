using Newtonsoft.Json;

namespace ByndyusoftTest.Utils
{
    public static class JsonReader
    {
        private static object deserializedObject;

        public enum FormatString
        {
            Path,
            JsonString
        }

        public static T GetDeserializedObject<T>(string value, FormatString format)
        {
            switch (format)
            {
                case FormatString.Path:
                    deserializedObject = JsonConvert.DeserializeObject<T>(File.ReadAllText(value));
                    return (T)deserializedObject;
                case FormatString.JsonString:
                    deserializedObject = JsonConvert.DeserializeObject<T>(value);
                    return (T)deserializedObject;
                default:
                    throw new ArgumentException("Provided wrong argument");
            }
        }
    }
}
