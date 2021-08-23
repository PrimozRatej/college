using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UrnikGooG_AdminClient
{
    public static class RestHelper
    {
        /// <summary>
        /// Pošlje objekt na želeni naslov (POST)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objekt">Objekt</param>
        /// <param name="uploadString">URL storitve</param>
        /// <returns>Vrne rezultat pošiljanja tipa string</returns>
        public static string PostObject<T>(T objekt, string uploadString)
        {
            return UploadString(objekt, uploadString, "POST");
        }

        /// <summary>
        /// Posodobi objekt na želeni naslov (PUT)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objekt">Objekt</param>
        /// <param name="uploadString">URL storitve</param>
        /// <returns>Vrne rezultat pošiljanja tipa string</returns>
        public static string PutObject<T>(T objekt, string uploadString)
        {
            return UploadString(objekt, uploadString, "PUT");
        }

        /// <summary>
        /// Pridobi želeni objekt (GET) 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceURL">URL storitve</param>
        /// <returns>Objekt tipa, ki ga metoda določa.</returns>
        public static T GetObject<T>(string serviceURL)
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(T));

            T returnObj = (T)obj.ReadObject(stream);
            return returnObj;
        }

        /// <summary>
        /// Pridobi seznam želenih objektov (GET)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceURL">URL storitve</param>
        /// <returns>Seznam objektov tipa, ki ga metoda določa.</returns>
        public static List<T> GetListOfObjects<T>(string serviceURL)
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<T>));

            List<T> listOfObjects = (List<T>)obj.ReadObject(stream);
            return listOfObjects;
        }

        /// <summary>
        /// Pridobi vrednost glede na poizvedbo
        /// </summary>
        /// <param name="serviceURL">URL storitve</param>
        /// <returns>Vrednost tipa string</returns>
        public static string GetValue(string serviceURL)
        {
            WebClient proxy = new WebClient();
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            stream.Position = 0;
            var sr = new StreamReader(stream);

            var returnValue = sr.ReadToEnd();
            return returnValue;
        }

        public static string DeleteObject(string url)
        {
            using (var client = new WebClient())
            {
                return client.UploadString(url, "DELETE", "");
            }
        }


        #region Helpers

        /// <summary>
        /// Pomožna metoda za pošiljanje podatkov
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objekt"></param>
        /// <param name="uploadString"></param>
        /// <param name="method"></param>
        /// <returns>Rezultat metode tipa string</returns>
        private static string UploadString<T>(T objekt, string uploadString, string method)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, objekt);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;

            return webClient.UploadString(uploadString, method, data);
        }
        #endregion
    }
}
