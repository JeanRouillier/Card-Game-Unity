using UnityEngine;
using System.Collections;

public class Bonefirepath
{

    public CampaignPath upperLeft { get; set; }
    public CampaignPath upperRight { get; set; }
    public CampaignPath lowerLeft { get; set; }
    public CampaignPath lowerRight { get; set; }

    public Bonefirepath() { }
    public Bonefirepath(CampaignPath upperLeft, CampaignPath upperRight, CampaignPath lowerLeft, CampaignPath lowerRight)
    {
        this.upperLeft = upperLeft;
        this.upperRight = upperRight;
        this.lowerLeft = lowerLeft;
        this.lowerRight = lowerRight;
    }
}
