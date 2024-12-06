using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class FinalTrigger : MonoBehaviour
{
    public PlayableDirector GreenLightsTimeline;
    public PlayableDirector BlueLightsTimeline;
    public PlayableDirector FinalBlueGhost;
    public PlayableDirector FinalGreenGhosts;

    private void OnTriggerEnter(Collider other)
    {
        GreenLightsTimeline.Play();
        BlueLightsTimeline.Play();
        FinalGreenGhosts.Play();
        FinalBlueGhost.Play();

    }
}
