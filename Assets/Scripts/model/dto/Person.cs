using System;

public class Person {
    public String name { get; set; }
    public BoardPosition position { get; set; }
    public String textureName { get; set; }

    public bool hasAtatcked = false;

    public Person()
    {

    }

    public Person(string n, BoardPosition p, string t)
    {
        name = n;
        position = p;
        textureName = t;
    }
}
