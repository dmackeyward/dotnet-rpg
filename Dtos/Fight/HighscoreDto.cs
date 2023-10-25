using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Fight
{
    public class HighscoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Fights { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}