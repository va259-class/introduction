using System.Drawing;
using Vektorel.CommonLibraries.Helpers;

namespace Vektorel.Tests
{
    public class TeamManagementFixture
    {
        public TeamManager Sut { get; set; }
        [SetUp]
        public void Setup()
        {
            Sut = new TeamManager();
        }

        [Test]
        public void CanCreate_Team()
        {
            Sut.CreateTeam("Team Name");
            var teams = Sut.GetTeams();
            Assert.That(teams.Count, Is.EqualTo(1));
        }

        [Test]
        public void CanCreate_Team_WithColors()
        {
            Sut.CreateTeam("Team Name", Color.Red, Color.Yellow);

            var team = Sut.GetTeams()[0];
            Assert.That(team.Color1, Is.EqualTo(Color.Red));
        }

        [Test]
        public void CanUpdate_Team_Color()
        {
            Sut.CreateTeam("Team Name", Color.Red, Color.Yellow);
            var team = Sut.GetTeams()[0];
            Sut.SetTeamColor(team, Color.Pink, Color.Purple);
            team = Sut.GetTeams()[0];
            Assert.That(team.Color1, Is.EqualTo(Color.Pink));
            Assert.That(team.Color2, Is.EqualTo(Color.Purple));
        }
    }
}