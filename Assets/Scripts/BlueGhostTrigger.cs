using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BlueGhostTrigger : MonoBehaviour
{
    public PlayableDirector BlueGhostTimeLine;

    private void OnTriggerEnter(Collider other)
    {
        BlueGhostTimeLine.Play();
        Debug.Log("Blue Ghost moving");
    }
}
