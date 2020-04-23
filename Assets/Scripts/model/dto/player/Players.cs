using System.Collections.Generic;

public class Players {

    private static Player WIZARD = new Player("wizard", null, null,
            "wizard.png");
    private static Player ASSASSIN = new Player("assassin", null, null,
            "assassin.png");
    private static Player KNIGHT = new Player("knight", null, null,
            "knight.png");
    private static Player HERALD = new Player("herald", null, null,
            "herald.png");

    public List<Player> activePlayers = new List<Player>();

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
