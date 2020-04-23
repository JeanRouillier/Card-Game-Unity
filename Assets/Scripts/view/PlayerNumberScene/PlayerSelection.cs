using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{
    private MetaGameManager manager;
    private void Start()
    {
        manager = GameObject.Find("MetaGameManagerGameObject").gameObject.GetComponent<MetaGameManager>();
    }
    public void SelectPlayerNumber(int number)
    {
        Debug.Log(number + " players selected");
        manager.activePlayers = number;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void PickPlayer(string p)
    {
        Debug.Log("Picked :" + p);
        switch (p)
        {
            case "ASSASSIN":
                manager.pickedPlayerd.Add(PlayersAvailable.ASSASSIN);
                break;
            case "HERALD":
                manager.pickedPlayerd.Add(PlayersAvailable.HERALD);
                break;
            case "KNIGHT":
                manager.pickedPlayerd.Add(PlayersAvailable.ASSASSIN);
                break;
            case "WIZARD":
                manager.pickedPlayerd.Add(PlayersAvailable.WIZARD);
                break;

        }
    }

    public void ValidatePlayers()
    {
        Debug.Log("All picked players: " + manager.pickedPlayerd.ToString());
        foreach (PlayersAvailable i in manager.pickedPlayerd)
        {
           Debug.Log(i);
        }
        manager.game.initActivePlayers(manager.pickedPlayerd);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
