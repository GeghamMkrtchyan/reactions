﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace GhostNetwork.Reactions
{
    public interface IReactionStorage
    {
        Task<IDictionary<string, int>> GetStats(string key);
        Task UpsertAsync(string key, string author, string type);
        Task DeleteAsync(string key, string author);
    }
}
