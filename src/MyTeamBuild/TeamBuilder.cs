using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTeamBuild
{
    public class TeamBuilder
    {
        //http://stefanoricciardi.com/2010/04/14/a-fluent-builder-in-c/
        private string name;
        private string nickName;
        private Color shirtColor;
        private string homeTown;
        private string ground;

        public TeamBuilder CreateTeam(string name)
        {
            this.name = name;
            return this;
        }

        public TeamBuilder WithNickName(string nickName)
        {
            this.nickName = nickName;
            return this;
        }

        public TeamBuilder WithShirtColor(Color shirtColor)
        {
            this.shirtColor = shirtColor;
            return this;
        }

        public TeamBuilder FromTown(string homeTown)
        {
            this.homeTown = homeTown;
            return this;
        }

        public TeamBuilder PlayingAt(string ground)
        {
            this.ground = ground;
            return this;
        }

        public Team Build()
        {
            return new Team(name, nickName, shirtColor, homeTown, ground);
        }
    }
}
