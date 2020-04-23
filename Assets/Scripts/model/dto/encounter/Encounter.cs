using System;
using System.Collections.Generic;


public class Encounter {
    public Encounter()
    {
    }

    public Encounter(string name, Dictionary<int?, EncounterRow> detail, bool isActive, string textureName)
    {
        this.name = name;
        this.detail = detail;
        this.isActive = isActive;
        this.textureName = textureName;
    }

    public String name { get; set; }
    public Dictionary<int?, EncounterRow> detail { get; set; }
    public bool isActive { get; set; }
    public String textureName { get; set; }
}
