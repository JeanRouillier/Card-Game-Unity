using System;
using System.Collections.Generic;

public class Encounters {

    public List<Encounter> one { get; set; }
    public List<Encounter> two { get; set; }
    public List<Encounter> three { get; set; }

    public Encounters() {
        this.one = initLevelOne();
        this.two = initLevelTwo();
    }

    public static List<Encounter> initLevelOne() {
        return new List<Encounter>
        { new Encounter("Shattered Dungeon",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 0, 1, 0) },
                            {3,  new EncounterRow(2, 1, 1, 0) },
                            {4,  new EncounterRow(2, 2, 1, 0) },
                        }, true, "class_encounters-33"),
        new Encounter("Hollow Cave",
                                new Dictionary<int?, EncounterRow>
                                {
                                    {1,  new EncounterRow(1, 1, 0, 0) },
                                    {2,  new EncounterRow(1, 2, 0, 0) },
                                    {3,  new EncounterRow(2, 3, 0, 0) },
                                    {4,  new EncounterRow(2, 4, 0, 0) },
                                }, true, "class_encounters-34"),
        new Encounter("The Deeps",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 3, 0, 0) },
                            {3,  new EncounterRow(2, 4, 0, 0) },
                            {4,  new EncounterRow(2, 3, 1, 0) },
                        }, true, "class_encounters-35"),
        new Encounter("Ash Gardens",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 1, 1, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 1, 1, 0) },
                        }, true, "class_encounters-36"),
        new Encounter("Road of Sacrifices",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 2, 0, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 1, 2, 0) },
                        }, true, "class_encounters-37"),
        new Encounter("Ashen Hollow",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 3, 0, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 5, 0, 0) },
                        }, true, "class_encounters-38"),
        new Encounter("Dark Hollow",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 2, 1, 0) },
                            {3,  new EncounterRow(2, 1, 1, 0) },
                            {4,  new EncounterRow(2, 0, 2, 0) },
                        }, true, "class_encounters-39"),
        new Encounter("Lightless Passage",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 1, 1, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 1, 2, 0) },
                        }, true, "class_encounters-40"),
        new Encounter("Ghostly Keep",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 2, 1, 0) },
                            {3,  new EncounterRow(2, 1, 1, 0) },
                            {4,  new EncounterRow(2, 2, 1, 0) },
                        }, true, "class_encounters-41"),
            new Encounter("The Forgotten",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 2, 0, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 4, 0, 0) },
                        }, true, "class_encounters-42")
        };
    }

    public static List<Encounter> initLevelTwo() {
        return new List<Encounter>
        { new Encounter("Forgotten Gorge",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 0, 3, 0) },
                            {4,  new EncounterRow(2, 0, 4, 0) },
                        }, true, "class_encounters-43"),
            new Encounter("High Wall of Lothric",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 3, 2, 0) },
                            {4,  new EncounterRow(2, 3, 3, 0) },
                        }, true, "class_encounters-44"),
            new Encounter("Hollow Cell",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 4, 2, 0) },
                            {3,  new EncounterRow(2, 4, 1, 0) },
                            {4,  new EncounterRow(2, 4, 2, 0) },
                        }, true, "class_encounters-45"),
        new Encounter("Burned Gardens",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 2, 2, 0) },
                            {4,  new EncounterRow(2, 4, 0, 1) },
                        }, true, "class_encounters-46"),
        new Encounter("Temple of the Deeps",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 2, 1, 0) },
                            {3,  new EncounterRow(2, 6, 0, 0) },
                            {4,  new EncounterRow(2, 2, 3, 0) },
                        }, true, "class_encounters_00047"),
        new Encounter("Sunrise Pass",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 2, 1, 0) },
                            {3,  new EncounterRow(2, 1, 2, 0) },
                            {4,  new EncounterRow(2, 3, 2, 0) },
                        }, true, "class_encounters-48"),
    new Encounter("Stormwind Gorge",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 1, 0, 2) },
                            {4,  new EncounterRow(2, 1, 1, 2) },
                        }, true, "class_encounters-49"),
    new Encounter("Demon Ruins",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 1, 0) },
                            {2,  new EncounterRow(2, 0, 0, 1) },
                            {3,  new EncounterRow(2, 2, 2, 0) },
                            {4,  new EncounterRow(2, 0, 4, 0) },
                        }, true, "class_encounters-50"),
    new Encounter("Lost Labyrinth",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 1, 1, 0) },
                            {3,  new EncounterRow(2, 4, 1, 0) },
                            {4,  new EncounterRow(2, 4, 2, 0) },
                        }, true, "class_encounters-51"),
    new Encounter("Weathered Peak",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 2, 0, 1) },
                            {4,  new EncounterRow(2, 0, 2, 1) },
                        }, true, "class_encounters-52"),
    new Encounter("Black Dungeon",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 3, 1, 0) },
                            {3,  new EncounterRow(2, 0, 1, 1) },
                            {4,  new EncounterRow(2, 3, 1, 1) },
                        }, true, "class_encounter-53"),
    new Encounter("Prison Tower",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 2, 1, 0) },
                            {3,  new EncounterRow(2, 2, 2, 0) },
                            {4,  new EncounterRow(2, 2, 3, 0) },
                        }, true, "class_encounters-54"),
        };
      
    }
}
