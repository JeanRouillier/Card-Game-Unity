using System.Collections.Generic;

public class Campaigns
{
    public Bonefirepath wolnirCampaign;
    public Bonefirepath sulyvanCampaign;

    public CampaignPath currentPath;
    public Bonefirepath chosenPath;

    public Campaigns()
    {
        wolnirCampaign = initWolnirCampaign();
        sulyvanCampaign = initSulyvanCampaign();
        //As default
        chosenPath = wolnirCampaign;
    }

    public Bonefirepath initWolnirCampaign()
    {       
        CampaignPath wolnir = new CampaignPath(null, true, "Wolnir boss", null, null);
        CampaignPath abyssWatchers = new CampaignPath(null, true, "Abyss Watchers boss", null, null);

        CampaignPath lowerRightFirst = new CampaignPath(1, false, null, null, null);
        CampaignPath lowerRightSecond = new CampaignPath(1, false, null, lowerRightFirst, wolnir);
        lowerRightFirst.next = lowerRightSecond;

        CampaignPath upperRight = new CampaignPath(2, false, null, null, wolnir);
        
        CampaignPath upperLeft = new CampaignPath(3, false, null, null, abyssWatchers);

        CampaignPath lowerLeft = new CampaignPath(2, false, null, null, abyssWatchers);

        wolnirCampaign = new Bonefirepath(CampaignsId.WOLNIR, upperLeft, upperRight, lowerLeft, lowerRightFirst);
        return wolnirCampaign;
    }
    public Bonefirepath initSulyvanCampaign()
    {
        CampaignPath wordt = new CampaignPath(null, true, "Sulyvan Boss", null, null);
        CampaignPath sulyvan = new CampaignPath(null, true, "Abyss Watchers boss", null, null);

        CampaignPath lowerRightFirst = new CampaignPath(1, false, null, null, null);
        CampaignPath lowerRightSecond = new CampaignPath(2, false, null, lowerRightFirst, wordt);
        lowerRightFirst.next = lowerRightSecond;

        CampaignPath upperRight = new CampaignPath(1, false, null, null, wordt);

        CampaignPath upperLeft = new CampaignPath(3, false, null, null, sulyvan);

        CampaignPath lowerLeft = new CampaignPath(2, false, null, null, sulyvan);

        sulyvanCampaign = new Bonefirepath(CampaignsId.SULYVAN, upperLeft, upperRight, lowerLeft, lowerRightFirst);
        return sulyvanCampaign;
    }
}
