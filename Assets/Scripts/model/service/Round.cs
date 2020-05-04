using System.Collections.Generic;
using System.Linq;
public class Round {

    public Encounter activeEncounter { get; set; }
    public RoundState state = RoundState.START;

    public bool hasActiveEncounter = false;
    public bool  isEnded = false;

    public int nbEnemiesAttacked = 0;
    
    public bool getHasActiveEncounter(){
        return activeEncounter != null;
    }

    public bool haveAllEnemiesAttacked(List<Enemy> enemiesList){
        if(enemiesList.Count == nbEnemiesAttacked){
            return true;
        }
        return false;
    }
    
}
