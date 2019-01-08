// <copyright file="ICacheLogic.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.BLL.Interface
{
    /// <summary>  
    ///  This class describes a ICacheLogic.
    /// </summary>  
    public interface ICacheLogic
    {
        /// <summary>
        /// Add new data
        /// </summary>
        /// <typeparam name="T">type of current data</typeparam>
        /// <param name="key">new key</param>
        /// <param name="value">new value</param>
        /// <returns>successfully or no</returns>
        bool Add<T>(string key, T value);

        /// <summary>
        /// Get data
        /// </summary>
        /// <typeparam name="T">type of current data</typeparam>
        /// <param name="key">Current key</param>
        /// <returns>award by id</returns>
        T Get<T>(string key);

        /// <summary>
        /// Delete data
        /// </summary>
        /// <param name="key">Current key</param>
        /// <returns>successfully or no</returns>
        bool Delete(string key);

        /// <summary>
        /// Contains user award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <param name="title">title of award</param>
        /// <returns>successfully or no</returns>
        bool ContainsUserAward(int idUser, string title);

        /// <summary>
        /// Count of data
        /// </summary>
        /// <returns>count data</returns>
        int Count();
    }
}
