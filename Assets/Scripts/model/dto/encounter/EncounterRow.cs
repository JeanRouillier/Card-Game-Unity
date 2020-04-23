
public class EncounterRow {
    public EncounterRow(int treasureNumber, int levelOneNumber, int levelTwoNumber, int levelThreeNumber)
    {
        this.treasureNumber = treasureNumber;
        this.levelOneNumber = levelOneNumber;
        this.levelTwoNumber = levelTwoNumber;
        this.levelThreeNumber = levelThreeNumber;
    }

    public int treasureNumber { get; set; }
    public int levelOneNumber { get; set; }
    public int levelTwoNumber { get; set; }
    public int levelThreeNumber { get; set; }
}
