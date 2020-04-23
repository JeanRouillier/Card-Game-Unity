using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class MetaGameManager : MonoBehaviour
{
    public int activePlayers { get; set; }
    public HashSet<PlayersAvailable> pickedPlayerd = new HashSet<PlayersAvailable>();
    public CardGame game = new CardGame();

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
