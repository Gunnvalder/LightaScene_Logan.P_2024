using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TriggerTimeLine : MonoBehaviour
{

    public PlayableDirector JunkPileTimeLine;

    private void OnTriggerEnter(Collider other)
    {
        JunkPileTimeLine.Play();
        Debug.Log("TimeLine Active");
    }
}
