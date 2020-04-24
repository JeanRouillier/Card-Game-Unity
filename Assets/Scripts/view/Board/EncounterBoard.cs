﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using System.Linq;

public class EncounterBoard :MonoBehaviour
{
    private MetaGameManager manager;

    public GameObject self;

    public GameObject lowerLeftpath;
    public GameObject upperRightpath;
    public GameObject lowerRightOnepath;
    public GameObject lowerRightTwoPath;
    public GameObject upperLeftpath;

    public SpriteAtlas classEncounterAtlas;

    private void Start()
    {
        manager = MetaGameManager._instance;

    }

    public void Update()
    {
        CampaignPath cp = manager.getCurrentPath();
        if(cp != null && cp.encounter != null)
        {
            string texture = cp.encounter.textureName;
            CampaignPathEnum position = cp.position;
            Debug.Log("Texture to display "+texture);
            GameObject toUpdate = null;
            switch (position)
            {
                case CampaignPathEnum.LOWER_LEFT:
                    toUpdate = lowerLeftpath;
                    break;
                case CampaignPathEnum.UPPER_RIGHT:
                    toUpdate = upperRightpath;
                    break;
                case CampaignPathEnum.LOWER_RIGHT_ONE:
                    toUpdate = lowerRightOnepath;
                    break;
                case CampaignPathEnum.LOWER_RIGHT_TWO:
                    toUpdate = lowerRightTwoPath;
                    break;
                case CampaignPathEnum.UPPER_LEFT:
                    toUpdate = upperRightpath;
                    break;
            }
            string textureName = manager.getCurrentPath().encounter.textureName;
            if(toUpdate != null)
            {
                Sprite[] toto = new Sprite[classEncounterAtlas.spriteCount];
                classEncounterAtlas.GetSprites(toto);
                Sprite [] wantedSprite = toto.Where( e => e.name == textureName).ToArray();
                toUpdate.GetComponent<SpriteRenderer>().sprite = wantedSprite[0];
            }

        }
    }

}