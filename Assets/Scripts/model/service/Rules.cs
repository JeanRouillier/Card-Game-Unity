using System;
using System.Collections.Generic;

public class Rules {

    public static Encounter selectEncounter(Encounters list, int level) {
        Encounter result = new Encounter();
        Random rand = new Random();
        switch (level) {
            case 1:
                List<Encounter> one = list.one;
                result = one[rand.Next(one.Count)];
                break;
            case 2:
                List<Encounter> two = list.two;
                result = two[rand.Next(two.Count)];
                break;
            case 3:
                List<Encounter> three = list.three;
                result = three[rand.Next(three.Count)];
                break;
        }
        return result;
    }

    public static void placePlayers(AlliesBoard alliesBoard, Player player, BoardPosition wishedPosition){
        bool b = alliesBoard.setAtPosition(wishedPosition, player);
        if(b){
            Console.WriteLine("Player placed: "+player.name);
        }
        alliesBoard.print();
    }
}
