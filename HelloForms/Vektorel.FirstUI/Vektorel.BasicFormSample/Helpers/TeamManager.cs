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
            team.Name = name;

            teams.Add(team);
        }

        public List<Team> GetTeams()
        {
            return teams;
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
