
using System;
using System.Collections.Generic;

public class Player : Person {

    public List<Card> hand {get;set;}
    public List<Card> deck {get;set;}
    public PlayersAvailable type;

    public Player(PlayersAvailable ty, String name, List<Card> h, List<Card> d , String t): base(name, null, t){
        type = ty;
        hand = h;
        deck = d;
    }

    public void defend(int hitValue){
        Console.WriteLine("Position attacked " + position);
        Console.WriteLine("ATTACKED ! hit point " + hitValue);
    }
}
