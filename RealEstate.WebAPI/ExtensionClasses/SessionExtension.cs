using Newtonsoft.Json;

namespace RealEstate.WebAPI.ExtensionClasses
{
    /// <summary>
    /// Session genişletme metotları için statik sınıf
    /// </summary>
    public static class SessionExtension
    {
        /// <summary>
        /// SetObject metodu, bir nesneyi oturumda saklamak için kullanılır.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetObject(this ISession session,string key,object value)
        {
            //Nesneyi JSON formatına çevirir.
            string objectString = JsonConvert.SerializeObject(value);
            // JSON stringini oturuma kaydeder.
            session.SetString(key, objectString);
        }

        // GetObject metodu, oturumdan bir nesneyi geri almak için kullanılır.
        public static T GetObject<T>(this ISession session,string key) where T:class
        {
            // Oturumdan JSON stringini alır.
            string objectString = session.GetString(key);
            // Eğer string null veya boşsa, null döner.
            if(string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            // JSON stringini deserialization (geri dönüşüm) ile nesneye çevirir.
            T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
            // Deserialized nesneyi döner.
            return deserializedObject;
        }
    }
}
