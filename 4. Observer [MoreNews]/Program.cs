Agency choquei = new();



for(int i=0; i<2; i++)
{
    var sub = new Subscriber();
    choquei.eventManager.AddSubscriber(sub, "murder");
}

for(int i=0; i<4; i++)
{
    var sub = new Subscriber();
    choquei.eventManager.AddSubscriber(sub, "gossip");
}

for(int i=0; i<3; i++)
{
    var sub = new Subscriber();
    choquei.eventManager.AddSubscriber(sub, "entreteinment");
}

choquei.postNews("murder");

choquei.postNews("gossip");

choquei.postNews("entreteinment");