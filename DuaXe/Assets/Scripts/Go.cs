using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    void OnTriggerEnter(){
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
