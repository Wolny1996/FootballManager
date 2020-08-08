﻿using FootballManager.API.DTOs.Transfer;
using FootballManager.Data.Models;

namespace FootballManager.API.DTOs.Response
{
    public class CoachResponse
    {
        public string FullName { get; set; }
        public string CurrentClub { get; set; }
    }
}