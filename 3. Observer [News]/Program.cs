Youtuber calango = new();


for (int i=0; i<10; i++)
{
    var sub = new CommonSubscriber();
    calango.eventManager.AddSubscriber(sub);
    Console.WriteLine(i);
    // Console.WriteLine(calango.eventManager.Subscribers);
}

calango.PostVideo();