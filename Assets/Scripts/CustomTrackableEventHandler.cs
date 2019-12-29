using UnityEngine;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }
}
