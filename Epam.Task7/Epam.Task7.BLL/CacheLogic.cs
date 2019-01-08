// <copyright file="CacheLogic.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.BLL
{
    using System.Collections.Generic;
    using System.Linq;
    using Epam.Task7.BLL.Interface;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a CacheLogic.
    /// </summary>  
    public class CacheLogic : ICacheLogic
    {
        /// <summary>
        /// Declare variable data
        /// </summary>
        private static Dictionary<string, object> data = new Dictionary<string, object>();

        /// <summary>
        /// Add new data
        /// </summary>
        /// <typeparam name="T">type of current data</typeparam>
        /// <param name="key">new key</param>
        /// <param name="value">new value</param>
        /// <returns>successfully or no</returns>
        public bool Add<T>(string key, T value)
        {
            if (data.ContainsKey(key))
            {
                return false;
            }

            data.Add(key, value);

            return true;
        }

        /// <summary>
        /// Get data
        /// </summary>
        /// <typeparam name="T">type of current data</typeparam>
        /// <param name="key">Current key</param>
        /// <returns>award by id</returns>
        public T Get<T>(string key)
        {
            if (!data.ContainsKey(key))
            {
                return default(T);
            }

            return (T)data[key];
        }

        /// <summary>
        /// Delete data
        /// </summary>
        /// <param name="key">Current key</param>
        /// <returns>successfully or no</returns>
        public bool Delete(string key)
        {
            return data.Remove(key);
        }

        /// <summary>
        /// Contains user award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <param name="title">title of award</param>
        /// <returns>successfully or no</returns>
        public bool ContainsUserAward(int idUser, string title)
        {
            if (data.ContainsKey(idUser.ToString()))
            {
                IEnumerable<Award> list = (IEnumerable<Award>)data[idUser.ToString()];
                foreach (var item in list)
                {
                    if (list.ElementAt(0).ToString() == title)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Count of data
        /// </summary>
        /// <returns>count data</returns>
        public int Count()
        {
            return data.Count();
        }
    }
}
