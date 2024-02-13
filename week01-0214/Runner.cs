namespace Maraton {
    internal class Runner {
        string name = string.Empty;
        int speed = 3;
        int time = 0;
        bool gave_up = false;

        public string Name {
            get => name;
        }
        public int Speed {
            get => speed;
            set {
                if ((value >= 3) && (value <= 9)) {
                    speed = value;
                }
            }
        }
        public bool GaveUp {
            get => gave_up;
        }

        public Runner(string name, int speed) {
            this.name = name;
            this.Speed = speed;
        }

        public int Progress() {
            Random random = new Random();
            int km_diff = 0;

            if (gave_up) {
                return 0;
            }

            time++;

            if ((time > 60) && (time <= 90)) {
                gave_up = (1 == random.Next(1, 10000));
            }
            else if ((time > 90) && (time <= 120)) {
                gave_up = (1 == random.Next(1, 5000));
            }
            else if ((time > 120) && (time <= 180)) {
                gave_up = (1 == random.Next(1, 3330));
            }
            else if (time > 180) {
                gave_up = (1 == random.Next(1, 2000));
            }

            km_diff = (speed * time) % Consts.KM_TO_METER;
            if ((km_diff >= 0) && (km_diff <= speed)) {
                return 1;
            }

            return 0;
        }

        public string Display() {
            string ret = name;

            if (gave_up) {
                ret += " (gave up)";
            }

            return ret;
        }
    }
}
