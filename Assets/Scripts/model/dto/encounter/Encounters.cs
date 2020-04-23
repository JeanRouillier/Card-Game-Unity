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
                        }, true, "class_encounters_00033"),
        new Encounter("Hollow Cave",
                                new Dictionary<int?, EncounterRow>
                                {
                                    {1,  new EncounterRow(1, 1, 0, 0) },
                                    {2,  new EncounterRow(1, 2, 0, 0) },
                                    {3,  new EncounterRow(2, 3, 0, 0) },
                                    {4,  new EncounterRow(2, 4, 0, 0) },
                                }, true, "class_encounters_00034"),
        new Encounter("The Deeps",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 3, 0, 0) },
                            {3,  new EncounterRow(2, 4, 0, 0) },
                            {4,  new EncounterRow(2, 3, 1, 0) },
                        }, true, "class_encounters_00035"),
        new Encounter("Ash Gardens",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 1, 1, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 1, 1, 0) },
                        }, true, "class_encounters_00036"),
        new Encounter("Road of Sacrifices",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 2, 0, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 1, 2, 0) },
                        }, true, "class_encounters_00037"),
        new Encounter("Ashen Hollow",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 3, 0, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 5, 0, 0) },
                        }, true, "class_encounters_00038"),
        new Encounter("Dark Hollow",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 2, 1, 0) },
                            {3,  new EncounterRow(2, 1, 1, 0) },
                            {4,  new EncounterRow(2, 0, 2, 0) },
                        }, true, "class_encounters_00039"),
        new Encounter("Lightless Passage",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 1, 1, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 1, 2, 0) },
                        }, true, "class_encounters_00040"),
        new Encounter("Ghostly Keep",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 1, 0, 0) },
                            {2,  new EncounterRow(1, 2, 1, 0) },
                            {3,  new EncounterRow(2, 1, 1, 0) },
                            {4,  new EncounterRow(2, 2, 1, 0) },
                        }, true, "class_encounters_00041"),
            new Encounter("The Forgotten",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(1, 2, 0, 0) },
                            {2,  new EncounterRow(1, 2, 0, 0) },
                            {3,  new EncounterRow(2, 2, 1, 0) },
                            {4,  new EncounterRow(2, 4, 0, 0) },
                        }, true, "class_encounters_00042")
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
                        }, true, "class_encounters_00043"),
            new Encounter("High Wall of Lothric",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 3, 2, 0) },
                            {4,  new EncounterRow(2, 3, 3, 0) },
                        }, true, "class_encounters_00044"),
            new Encounter("Hollow Cell",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 4, 2, 0) },
                            {3,  new EncounterRow(2, 4, 1, 0) },
                            {4,  new EncounterRow(2, 4, 2, 0) },
                        }, true, "class_encounters_00045"),
        new Encounter("Burned Gardens",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 2, 2, 0) },
                            {4,  new EncounterRow(2, 4, 0, 1) },
                        }, true, "class_encounters_00046"),
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
                        }, true, "class_encounters_00048"),
    new Encounter("Stormwind Gorge",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 1, 0, 2) },
                            {4,  new EncounterRow(2, 1, 1, 2) },
                        }, true, "class_encounters_00049"),
    new Encounter("Demon Ruins",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 1, 0) },
                            {2,  new EncounterRow(2, 0, 0, 1) },
                            {3,  new EncounterRow(2, 2, 2, 0) },
                            {4,  new EncounterRow(2, 0, 4, 0) },
                        }, true, "class_encounters_00050"),
    new Encounter("Lost Labyrinth",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 1, 1, 0) },
                            {3,  new EncounterRow(2, 4, 1, 0) },
                            {4,  new EncounterRow(2, 4, 2, 0) },
                        }, true, "class_encounters_00051"),
    new Encounter("Weathered Peak",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 0, 2, 0) },
                            {3,  new EncounterRow(2, 2, 0, 1) },
                            {4,  new EncounterRow(2, 0, 2, 1) },
                        }, true, "class_encounters_00052"),
    new Encounter("Black Dungeon",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 2, 0, 0) },
                            {2,  new EncounterRow(2, 3, 1, 0) },
                            {3,  new EncounterRow(2, 0, 1, 1) },
                            {4,  new EncounterRow(2, 3, 1, 1) },
                        }, true, "class_encounters_00053"),
    new Encounter("Prison Tower",
                        new Dictionary<int?, EncounterRow>
                        {
                            {1,  new EncounterRow(2, 0, 1, 0) },
                            {2,  new EncounterRow(2, 2, 1, 0) },
                            {3,  new EncounterRow(2, 2, 2, 0) },
                            {4,  new EncounterRow(2, 2, 3, 0) },
                        }, true, "class_encounters_00054"),
        };
      
    }
}
