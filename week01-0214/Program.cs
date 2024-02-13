namespace Maraton {
    internal class Program {
        static void Main() {
            Team t1 = new Team(new Runner[] {
                new Runner("Christoper Mcknight", 9),
                new Runner("Karen Walls", 9),
                new Runner("Luis Rojas", 9),
                new Runner("Dennis Zimmerman", 9),
                new Runner("Kermit Porter", 9)
            });
            Team t2 = new Team(new Runner[] {
                new Runner("Randell Fuentes", 8),
                new Runner("Tara Sharp", 9),
                new Runner("Herb Meadows", 9)
            });
            Team t3 = new Team(new Runner[] {
                new Runner("Laurel Cisneros", 5)
            });
            Team t4 = new Team(new Runner[] {
                new Runner("Justine Whitney", 5)
            });
            Team t5 = new Team(new Runner[] {
                new Runner("Isabelle Herrera", 9),
                new Runner("Ariel Gomez", 7),
                new Runner("Bryan Odom", 9)
            });
            Team t6 = new Team(new Runner[] {
                new Runner("Rosalyn Petersen", 9),
                new Runner("Felton Mckay", 9)
            });
            Team t7 = new Team(new Runner[] {
                new Runner("Francesca Jacobs", 5),
                new Runner("Alfreda Rush", 9),
                new Runner("Elliott Hamilton", 9),
                new Runner("Zelma Strong", 9),
                new Runner("Erna Robinson", 9)
            });

            Team[] teams = new Team[] {
                t1, t2, t3, t4, t5, t6, t7
            };

            Race race = new Race(teams);

            Console.WriteLine("Race begin!");
            while (!race.End()) {
                race.Progress();
                race.Display();
                Console.CursorTop -= teams.Length;
            }
            race.Display();

            Console.WriteLine("");
            Console.WriteLine("Results:");
            Team[] results = race.Results();

            for (int i = 0; i < results.Length; i++) {
                Console.WriteLine($"{i + 1}: ({results[i].Distance}km) ({results[i].Time}perc) {results[i].NameList()}");
            }
        }
    }
}
