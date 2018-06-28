using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTeamBuild
{
    public enum Color
    {
        White,
        Red,
        Green,
        Blue
    }
    public class Team
    {
        string Name { get; set; }
        string NickName { get; set; }
        Color ShirtColor { get; set; }
        string HomeTown { get; set; }
        string Ground { get; set; }

        public Team(
            string name,
            string nickName,
            Color shirtColor,
            string homeTown,
            string ground)
        {
            Name = name;
            NickName = nickName;
            ShirtColor = shirtColor;
            HomeTown = homeTown;
            Ground = ground;
        }
    }
}
