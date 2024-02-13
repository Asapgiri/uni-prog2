namespace Maraton {
    internal class Race {
        Team[] teams;

        public Race(Team[] teams) {
            this.teams = teams;
        }

        public void Progress() {
            for (int i = 0; i < teams.Length; i++) {
                teams[i].Progress();
            }
        }

        public bool End() {
            for (int i = 0; i < teams.Length; i++) {
                if (!teams[i].End()) {
                    return false;
                }
            }
            return true;
        }

        public string Display() {
            string planes = string.Empty;

            for (int i = 0; i < teams.Length; i++) {
                planes += teams[i].Display() + Environment.NewLine;
            }

            Console.Write(planes);
            return planes;
        }

        public Team[] Results() {
            Team[] end_results = teams;
            Team temp;

            for (int i = 0; i < end_results.Length + 1; i++) {
                for (int j = i + 1; j < end_results.Length; j++) {
                    if ((end_results[i].Distance < end_results[j].Distance)
                     || ((end_results[i].Distance == end_results[j].Distance)
                        && (end_results[i].Time > end_results[j].Time))) {
                        temp = end_results[i];
                        end_results[i] = end_results[j];
                        end_results[j] = temp;
                    }
                }
            }

            return end_results;
        }
    }
}
