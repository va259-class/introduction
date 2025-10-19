namespace Vektorel.BasicFormSample.Helpers
{
    class TeamManager
    {
        //takımları saklayacağımız alan
        //bu liste bir class
        // -> başlangışta null
        private List<Team> teams;

        //Constructor method: Yapıcı method
        //class oluşmaya başlarken yapılacak işler varsa onları
        //en baştan ayarlamamızı sağlar
        public TeamManager()
        {
            teams = new List<Team>();
        }

        public void CreateTeam(string name)
        {
            var team = new Team();
            team.name = name;

            teams.Add(team);
        }
    }

    class Team
    {
        public string name;
        public Color color1;
        public Color color2;
    }
}
