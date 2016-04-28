using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace oxkiller.Utility
{
    /// <summary>
    /// A class wrapping json operations.
    /// </summary>
    public class JSONManager
    {
        #region object <==> string

        /// <summary>
        /// Convert a json string into an object.
        /// </summary>
        /// <typeparam name="T">The type of this object.</typeparam>
        /// <param name="s">The json string.</param>
        /// <returns>The object converted.</returns>
        public T stringToObject<T> (string s) where T : class
        {
            try
            {
                JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
                jsonSerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
                return JsonConvert.DeserializeObject<T>(s,jsonSerializerSettings);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Converts an object into a json string.
        /// </summary>
        /// <param name="obj">The object to be converted.</param>
        /// <returns>The string of the object.</returns>
        public string objectToString(object obj)
        {
            try
            {
                JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
                jsonSerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
                return JsonConvert.SerializeObject(obj,jsonSerializerSettings); 
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

    }
}
