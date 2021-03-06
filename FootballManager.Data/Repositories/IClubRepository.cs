﻿using FootballManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.Data.Repositories
{
    public interface IClubRepository
    {
        Club GetSpecificClub(string clubName);
        IEnumerable<Club> GetAllClubs();
    }
}