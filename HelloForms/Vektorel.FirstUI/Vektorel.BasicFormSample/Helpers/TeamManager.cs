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
            CreateTeam(name, Color.Transparent, Color.Transparent);
        }

        // method overloading
        public void CreateTeam(string name, Color color1, Color color2)
        {
            var team = new Team();
            team.Name = name;
            team.Color1 = color1;
            team.Color2 = color2;

            teams.Add(team);
        }

        public List<Team> GetTeams()
        {
            return teams;
        }

        public void SetTeamColor(Team team, Color color1, Color color2) 
        {
            team.Color1 = color1;    
            team.Color2 = color2;    
        }
    }

    class Team
    {
        //public string name; -> Property yaptık çünkü listbox kullanmak istedik. Binding sebepli buna mecburuz
        public string Name { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
    }
}

/*
 * NAMING CONVENSIONS:
 * 
 Camel Case: vektorelBilisimAkademi -> değişken isimleri
 Pascal Case: VektorelBilisimAkademi -> Class, Interface gibi tipler, Method isimleri
 kebab Case: vektorel-bilisim-akademi -> CSS
 snakecase: _vektorel_bilisim_akademi -> bazen fieldlar, ya da değişkenler
 */
