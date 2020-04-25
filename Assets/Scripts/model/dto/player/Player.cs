
using System;
using System.Collections.Generic;

public class Player : Person {

    public List<Object> hand = new List<Object>(5);
    public List<Object> deck = new List<Object>();
    public PlayersAvailable type;

    public Player(PlayersAvailable ty, String name, List<Object> h, List<Object> d , String t): base(name, null, t){
        type = ty;
        hand = h;
        deck = d;
    }

    public void defend(int hitValue){
        Console.WriteLine("Position attacked " + position);
        Console.WriteLine("ATTACKED ! hit point " + hitValue);
    }
}
