public class Card{

    public string textureName;
    public bool isStarter = true;

    public Card(string t){
        textureName = t;
    }
    
    public Card(string t, bool starterCard){
        textureName = t;
        isStarter = starterCard;
    }
}