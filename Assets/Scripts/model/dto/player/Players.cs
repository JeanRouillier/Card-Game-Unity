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

    public Players(){
        initHands();
    }

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

    public void initHands(){
        WIZARD.hand = new List<Card>(){
            new Card("class_encounters-1"),
            new Card("class_encounters-2"),
            new Card("class_encounters-3"),
            new Card("class_encounters-4"),
            new Card("class_encounters-5"),
            new Card("class_encounters-6"),
            new Card("class_encounters-6"),
        };

        ASSASSIN.hand = new List<Card>(){
            new Card("class_encounters-9"),
            new Card("class_encounters-10"),
            new Card("class_encounters-11"),
            new Card("class_encounters-12"),
            new Card("class_encounters-13"),
            new Card("class_encounters-14"),
            new Card("class_encounters-15"),
        };

        KNIGHT.hand = new List<Card>(){
            new Card("class_encounters-17"),
            new Card("class_encounters-18"),
            new Card("class_encounters-19"),
            new Card("class_encounters-20"),
            new Card("class_encounters-21"),
            new Card("class_encounters-22"),
            new Card("class_encounters-23"),
        };       
        
        HERALD.hand = new List<Card>(){
            new Card("class_encounters-25"),
            new Card("class_encounters-26"),
            new Card("class_encounters-27"),
            new Card("class_encounters-28"),
            new Card("class_encounters-29"),
            new Card("class_encounters-30"),
            new Card("class_encounters-31"),
        };
    }
}
