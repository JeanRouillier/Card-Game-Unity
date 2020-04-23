﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChosePath : MonoBehaviour
{
    private MetaGameManager manager;
    public GameObject managerObject;

    public Color selectedColor;
    public Color defaultColor;

    public GameObject wolnirPathObject;
    public GameObject sulivanPathObject;

    protected int pickedPath;

    void Start()
    {
        manager = managerObject.GetComponent<MetaGameManager>();
    }

    public void validatePath()
    {
        manager.initPickedCampaign(pickedPath);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void setActivepath(int pathId)
    {
        pickedPath = pathId;
        if(pickedPath == 0)
        {
            wolnirPathObject.GetComponent<Image>().color = selectedColor;
            sulivanPathObject.GetComponent<Image>().color = defaultColor;
        }
        else if (pickedPath == 1)
        {
            wolnirPathObject.GetComponent<Image>().color = defaultColor;
            sulivanPathObject.GetComponent<Image>().color = selectedColor;
        }
    }
}
