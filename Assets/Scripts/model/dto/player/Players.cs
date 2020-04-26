using System.Collections.Generic;

public class Players {

    private static Player WIZARD = new Player(PlayersAvailable.WIZARD, "wizard", null, null,
            "wizard_front");
    private static Player ASSASSIN = new Player(PlayersAvailable.ASSASSIN, "assassin", null, null,
            "assassin_front");
    private static Player KNIGHT = new Player(PlayersAvailable.KNIGHT, "knight", null, null,
            "knight_front");
    private static Player HERALD = new Player(PlayersAvailable.HERALD, "herald", null, null,
            "herald_front");

    public List<Player> activePlayers = new List<Player>{ WIZARD, ASSASSIN, KNIGHT, HERALD};

    public List<Player> playersList = new List<Player> { WIZARD, ASSASSIN, KNIGHT, HERALD };

    public void InitActivePlayers(HashSet<PlayersAvailable> list)
    {
        foreach( PlayersAvailable p in list)
        {
            switch (p)
            {
                case PlayersAvailable.ASSASSIN:
                    activePlayers.Add(ASSASSIN);
                    break;
                case PlayersAvailable.HERALD:
                    activePlayers.Add(HERALD);
                    break;
                case PlayersAvailable.KNIGHT:
                    activePlayers.Add(KNIGHT);
                    break;
                case PlayersAvailable.WIZARD:
                    activePlayers.Add(WIZARD);
                    break;
            }
        }
    }

    public static Player getWIZARD() {
        return WIZARD;
    }

    public static Player getASSASSIN() {
        return ASSASSIN;
    }

    public static Player getKNIGHT(){
        return KNIGHT;
    }

    public static Player getHERALD(){
        return HERALD;
    }
}
