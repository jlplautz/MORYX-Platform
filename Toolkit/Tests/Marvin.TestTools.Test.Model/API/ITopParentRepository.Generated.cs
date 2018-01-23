﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating Repositories and a Unit of Work for Entity Framework.
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs. I allways need feedback to improve.
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. So even when you think you can do better,
// don't touch it.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Marvin.Model;


namespace Marvin.TestTools.Test.Model
{
    /// <summary>
    /// The public API of the TopParent repository.
    /// </summary>
    public partial interface ITopParentRepository : IRepository<TopParent>
    {
		/// <summary>
        /// Get all TopParents from the database
        /// </summary>
		/// <param name="deleted">Include deleted entities in result</param>
		/// <returns>A collection of entities. The result may be empty but not null.</returns>
        ICollection<TopParent> GetAll(bool deleted);
        /// <summary>
        /// Get all TopParents where Updated equals given value
        /// </summary>
        /// <param name="updated">Value the entities have to match</param>
        /// <returns>Collection of all matching TopParents</returns>
        ICollection<TopParent> GetAllByUpdated(global::System.DateTime updated);
        /// <summary>
        /// Get first TopParent that matches the given parameter 
        /// or null if no match was found.
        /// </summary>
        /// <param name="number">Value the entity has to match</param>
        /// <returns>First matching TopParent</returns>
        TopParent GetByNumber(int number);
        /// <summary>
        /// Creates instance with all not nullable properties prefilled
        /// </summary>
        TopParent Create(int number); 
        /// <summary>
        /// This method returns the first matching TopParent for given parameters
        /// </summary>
        /// <param name="created">Value for Created the TopParent has to match</param>
        /// <param name="updated">Value for Updated the TopParent has to match</param>
        TopParent GetCreatedAndUpdated(global::System.DateTime created, global::System.DateTime updated);

        /// <summary>
        /// This method returns all matching TopParents for given parameters
        /// </summary>
        /// <param name="updated">Value for Updated the TopParents have to match</param>
        /// <param name="number">Value for Number the TopParents have to match</param>
        IEnumerable<TopParent> GetUpdatedAndNumber(global::System.DateTime updated, int number);

    }
}