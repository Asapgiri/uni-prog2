namespace Maraton {
    internal class Team {
        private int[] TEAM_DISTANCE_MAP;

        Runner[] runners;
        int current_runner = 0;
        int time = 0;
        int distanceKm = 0;

        public int Time {
            get => time;
        }
        public int Distance {
            get => distanceKm;
        }
        public bool GaveUp {
            get {
                for (int i = 0; i < runners.Length; i++) {
                    if (runners[i].GaveUp) {
                        return true;
                    }
                }
                return false;
            }
        }

        public Team(Runner[] runners) {
            if (runners.Length > 5) {
                this.runners = TakeRunners(runners, 5);
            }
            else if (4 == runners.Length) {
                this.runners = TakeRunners(runners, 3);
            }
            else {
                this.runners = runners;
            }

            if (5 == this.runners.Length) {
                this.TEAM_DISTANCE_MAP = Consts.TEAM_OF_5_KM;
            }
            else if (3 == this.runners.Length) {
                this.TEAM_DISTANCE_MAP = Consts.TEAM_OF_3_KM;
            }
            else if (2 == this.runners.Length) {
                this.TEAM_DISTANCE_MAP = Consts.TEAM_OF_2_KM;
            }
            else {
                this.TEAM_DISTANCE_MAP = new int[0];
            }
        }

        private Runner[] TakeRunners(Runner[] runners, int count) {
            Runner[] runnersTemp = new Runner[count];
            for (int i = 0; i < count; i++) {
                runnersTemp[i] = runners[i];
            }
            return runnersTemp;
        }

        public void Progress() {
            if (this.GaveUp || Consts.MARATON_KM <= this.distanceKm) {
                return;
            }

            time++;

            distanceKm += runners[current_runner].Progress();

            if ((current_runner < (runners.Length - 1)) && (distanceKm > this.TEAM_DISTANCE_MAP[current_runner])) {
                current_runner++;
            }
        }

        public bool End() {
            return GaveUp || Consts.MARATON_KM <= this.distanceKm;
        }

        public string NameList() {
            string names = runners[0].Display();

            for (int i = 1; i < runners.Length; i++) {
                names += ", " + runners[i].Display();
            }

            return names;
        }

        public string Display() {
            string plane = string.Empty;

            for (int i = 0; i < distanceKm - 1; i++) {
                plane += " ";
            }

            plane += $"X {runners[current_runner].Display()}";

            return plane;
        }
    }
}
