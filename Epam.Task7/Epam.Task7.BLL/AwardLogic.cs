// <copyright file="AwardLogic.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.BLL
{
    using System;
    using System.Collections.Generic;
    using Epam.Task7.BLL.Interface;
    using Epam.Task7.DAL.Interface;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a AwardLogic.
    /// </summary>  
    public class AwardLogic : IAwardLogic
    {
        /// <summary>
        /// Declare variable ALL_USERS_CACHE_KEY
        /// </summary>
        private const string ALLAWARDSCACHEKEY = "GetAllAwards";

        /// <summary>
        /// Declare variable this.awardDao
        /// </summary>
        private readonly IAwardDao awardDao;

        /// <summary>
        /// Declare variable this.cacheLogic
        /// </summary>
        private readonly ICacheLogic cacheLogic;

        /// <summary>
        ///  Initializes a new instance of the <see cref="AwardLogic" /> class
        /// </summary>  
        /// <param name="awardDao">award Dao</param>
        /// <param name="cacheLogic">cache logic</param>
        public AwardLogic(IAwardDao awardDao, ICacheLogic cacheLogic)
        {
            this.awardDao = awardDao;
            this.cacheLogic = cacheLogic;
        }

        /// <summary>
        /// Add new award
        /// </summary>
        /// <param name="idUser">Current user</param>
        /// <param name="title">new award</param>
        public void Add(int idUser, string title)
        {
            try
            {
                if (title == null)
                {
                    throw new Exception("User is null");
                }

                if (this.cacheLogic.Count() == 0)
                {
                    this.cacheLogic.Add(idUser.ToString(), this.awardDao.GetAllByUserId(idUser));
                }

                if (!this.cacheLogic.ContainsUserAward(idUser, title))
                {
                    this.cacheLogic.Delete(idUser.ToString());
                    this.awardDao.Add(new Award(idUser, title));
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Delete award
        /// </summary>
        /// <param name="id">award id</param>
        /// <returns>successfully or no</returns>
        public bool Delete(int id)
        {
            return this.awardDao.Delete(id);
        }

        /// <summary>
        /// Delete by user award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <returns>successfully or no</returns>
        public bool DeleteByUser(int idUser)
        {
            return this.awardDao.DeleteByUser(idUser);
        }

        /// <summary>
        /// Update award
        /// </summary>
        /// <param name="id">id of current award</param>
        /// <param name="title">new title of award</param>
        /// <returns>successfully or no</returns>
        public bool Update(int id, string title)
        {
            if (title != null)
            {
                this.cacheLogic.Delete(this.awardDao.GetById(id).IdUser.ToString());
                return this.awardDao.Update(new Award(title) { Id = id });
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get by id award
        /// </summary>
        /// <param name="id">award id</param>
        /// <returns>current award</returns>
        public Award GetById(int id)
        {
            return this.awardDao.GetById(id);
        }

        /// <summary>
        /// Get all by user id award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <returns>collection of awards by user</returns>
        public IEnumerable<Award> GetAllByUserId(int idUser)
        {
            var cacheResult = this.cacheLogic.Get<IEnumerable<Award>>(idUser.ToString());

            if (cacheResult == null)
            {
                var result = this.awardDao.GetAllByUserId(idUser);
                this.cacheLogic.Add(idUser.ToString(), result);
                Console.WriteLine("From dao");
                return result;
            }

            Console.WriteLine("From cache");
            return cacheResult;
        }

        /// <summary>
        /// Get all awards
        /// </summary>
        /// <returns>collection of awards</returns>
        public IEnumerable<Award> GetAll()
        {
            var cacheResult = this.cacheLogic.Get<IEnumerable<Award>>(ALLAWARDSCACHEKEY);

            if (cacheResult == null)
            {
                var result = this.awardDao.GetAll();
                this.cacheLogic.Add(ALLAWARDSCACHEKEY, result);
                Console.WriteLine("From dao");
                return result;
            }

            Console.WriteLine("From cache");
            return cacheResult;
        }

        /// <summary>
        /// Save awards into file
        /// </summary>
        public void Save()
        {
            this.awardDao.Save();
        }
    }
}
