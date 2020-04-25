public class Round {

    public Encounter activeEncounter { get; set; }
    public RoundState state = RoundState.START;

    public bool hasActiveEncounter = false;
    public bool  isEnded = false;

    
    public bool getHasActiveEncounter(){
        return activeEncounter != null;
    }
    
}
