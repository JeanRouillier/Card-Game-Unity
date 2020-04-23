using UnityEngine;
using System.Collections;

public class CampaignPath
{

    public int? encounterLevel;
    public bool isBossEncounter=false;
    public string bossName;
    public CampaignPath previous;
    public CampaignPath next;

    public CampaignPath(int? encounterLevel, bool isBossEncounter, string bossName, CampaignPath previous, CampaignPath next)
    {
        this.encounterLevel = encounterLevel;
        this.isBossEncounter = isBossEncounter;
        this.bossName = bossName;
        this.previous = previous;
        this.next = next;
    }
}
