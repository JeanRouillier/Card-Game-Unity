using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{
    private MetaGameManager manager;
    public GameObject managerObject;

    public Color selectedColor;
    public Color defaultColor;
    public GameObject assassinObject;
    public GameObject heraldObject;
    public GameObject wizardObject;
    public GameObject knightObject;

    private void Start()
    {
        manager = MetaGameManager._instance;
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
                if (!assassinObject.GetComponent<Toggle>().isOn)
                {
                    assassinObject.GetComponent<Image>().color = defaultColor;
                    manager.pickedPlayerd.Remove(PlayersAvailable.ASSASSIN);
                }
                else
                {
                    assassinObject.GetComponent<Image>().color = selectedColor;
                    manager.pickedPlayerd.Add(PlayersAvailable.ASSASSIN);
                }
                break;
            case "HERALD":
                if (!heraldObject.GetComponent<Toggle>().isOn)
                {
                    heraldObject.GetComponent<Image>().color = defaultColor;
                    manager.pickedPlayerd.Remove(PlayersAvailable.HERALD);
                }
                else
                {
                    heraldObject.GetComponent<Image>().color = selectedColor;
                    manager.pickedPlayerd.Add(PlayersAvailable.HERALD);
                }
                break;
            case "KNIGHT":
                if (!knightObject.GetComponent<Toggle>().isOn)
                {
                    knightObject.GetComponent<Image>().color = defaultColor;
                    manager.pickedPlayerd.Remove(PlayersAvailable.KNIGHT);
                }
                else
                {
                    knightObject.GetComponent<Image>().color = selectedColor;
                    manager.pickedPlayerd.Add(PlayersAvailable.KNIGHT);
                }
                break;
            case "WIZARD":
                if (!wizardObject.GetComponent<Toggle>().isOn)
                {
                    wizardObject.GetComponent<Image>().color = defaultColor;
                    manager.pickedPlayerd.Remove(PlayersAvailable.WIZARD);
                }
                else
                {
                    wizardObject.GetComponent<Image>().color = selectedColor;
                    manager.pickedPlayerd.Add(PlayersAvailable.WIZARD);
                }
                break;

        }
    }

    public void ValidatePlayers()
    {
        Debug.Log("All picked players: " + manager.pickedPlayerd.ToString());
        foreach (PlayersAvailable i in manager.pickedPlayerd)
        {
           Debug.Log(i.ToString());
        }
        manager.initActivePlayers(manager.pickedPlayerd);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
