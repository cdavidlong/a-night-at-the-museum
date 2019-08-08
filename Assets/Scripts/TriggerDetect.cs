using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetect : MonoBehaviour {

    public GameObject stationVideo;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has Entered trigger");    
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is within trigger");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player Exited trigger");
    }
    
}
