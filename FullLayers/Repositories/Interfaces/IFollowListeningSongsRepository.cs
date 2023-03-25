﻿using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IFollowListeningSongsRepository : IRepository<FollowListeningSongs>
    {
        public List<Songs> GetTopTenMostPlayedSongsLastWeek();
    }
}
