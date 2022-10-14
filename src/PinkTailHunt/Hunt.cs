namespace PinkTailHunt;

public class Hunt {
    const int FLAN_PRINCESS_PARTY = 6;
    const int FLAN_PRINCESS_EXP_AWARDED = 10000;

    readonly int _timeSpentSeconds;

    public Hunt(int sirensStart, int startDustsStart) {
        SirensLeft = sirensStart > 99
            ? 99
            : sirensStart;
        StarDustsLeft = startDustsStart > 99
            ? 99
            : startDustsStart;
        Random rnd = new();
        bool gotPinkTail = false;
        do {
            if (SirensLeft == 0) {
                do {
                    Encounters++;
                    int monsterParty = rnd.Next(1, 64);
                    if (monsterParty == 1) {
                        break;
                    }

                    RunTimes++;
                    _timeSpentSeconds += rnd.Next(10, 20);
                } while (true);
            }

            Encounters++;
            FlanPrincessesKilled += FLAN_PRINCESS_PARTY;
            if (StarDustsLeft > 0) {
                _timeSpentSeconds += rnd.Next(60, 90);
                StarDustsLeft--;
            } else {
                _timeSpentSeconds += rnd.Next(300, 420);
            }
            GilEarned += rnd.Next(50000, 60000);
            ExpEarned += FLAN_PRINCESS_EXP_AWARDED;
            int drop = rnd.Next(1, 64);
            if (drop == 1) {
                gotPinkTail = true;
            }

            if (SirensLeft > 0) {
                SirensLeft--;
            }
        } while (!gotPinkTail);
    }

    public TimeSpan TotalTimeSpent => TimeSpan.FromSeconds(_timeSpentSeconds);
    public int Encounters { get; set; }
    public int FlanPrincessesKilled { get; set; }
    public int GilEarned { get; set; }
    public int ExpEarned { get; set; }
    public int RunTimes { get; set; }
    public int SirensLeft { get; set; }
    public int StarDustsLeft { get; set; }

}