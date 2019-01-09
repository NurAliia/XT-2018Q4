// <copyright file="AwardMemoryDao.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.DAL
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Epam.Task7.DAL.Interface;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a AwardMemoryDao.
    /// </summary>  
    public class AwardMemoryDao : IAwardDao
    {
        /// <summary>
        /// Declare variable repo awards
        /// </summary>
        private static readonly Dictionary<int, Award> REPOAWARDS = new Dictionary<int, Award>();

        /// <summary>
        /// Add new award
        /// </summary>
        /// <param name="award">new award</param>
        public void Add(Award award)
        {
            var lastId = REPOAWARDS.Any()
                ? REPOAWARDS.Keys.Max()
                : 0;
            award.Id = ++lastId;
            REPOAWARDS.Add(award.Id, award);
        }

        /// <summary>
        /// Delete award
        /// </summary>
        /// <param name="id">award id</param>
        /// <returns>successfully or no</returns>
        public bool Delete(int id)
        {
            return REPOAWARDS.Remove(id);
        }

        /// <summary>
        /// Get all by user id award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <returns>collection of awards by user</returns>
        public IEnumerable<Award> GetAllByUserId(int idUser)
        {
            return REPOAWARDS.Values.Where(x => x.IdUser == idUser);
        }

        /// <summary>
        /// Get all awards
        /// </summary>
        /// <returns>collection of awards</returns>
        public IEnumerable<Award> GetAll()
        {
            return REPOAWARDS.Values;
        }

        /// <summary>
        /// Get by id award
        /// </summary>
        /// <param name="id">award id</param>
        /// <returns>current award</returns>
        public Award GetById(int id)
        {
            return REPOAWARDS.TryGetValue(id, out var user)
                ? user
                : null;
        }

        /// <summary>
        /// Delete by user award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <returns>successfully or no</returns>
        public bool DeleteByUser(int idUser)
        {
            bool result = false;
            var keys = REPOAWARDS.Keys;
            for (int i = 0; i < REPOAWARDS.Count;)
            {
                if (REPOAWARDS.ElementAt(i).Value.IdUser == idUser)
                {
                    REPOAWARDS.Remove(keys.ElementAt(i));
                    result = true;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }

        /// <summary>
        /// Update award
        /// </summary>
        /// <param name="award">update award</param>
        /// <returns>successfully or no</returns>
        public bool Update(Award award)
        {
            if (!REPOAWARDS.ContainsKey(award.Id))
            {
                return false;
            }

            REPOAWARDS[award.Id].Title = award.Title;
            return true;
        }

        /// <summary>
        /// Save awards into file
        /// </summary>
        public void Terminate()
        {
        }
    }
}
