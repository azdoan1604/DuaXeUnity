using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Time_BestTimeComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject MinuteDisPlay;
    public GameObject SecondDisPlay;
    public GameObject MiliDisPlay;
    public GameObject LapTimeBox;
    void OnTriggerEnter(){
        if (Time_BestTime.SecondCount<=9){
            SecondDisPlay.GetComponent<Text>().text="0"+Time_BestTime.SecondCount+".";
        }else{
            SecondDisPlay.GetComponent<Text>().text=""+Time_BestTime.SecondCount+".";
        }
        if (Time_BestTime.MinuteCount<=9){
            MinuteDisPlay.GetComponent<Text>().text="0"+Time_BestTime.MinuteCount+".";
        }else{
            MinuteDisPlay.GetComponent<Text>().text=""+Time_BestTime.MinuteCount+".";
        }
        MiliDisPlay.GetComponent<Text>().text=""+Time_BestTime.MiliCount;
        Time_BestTime.MinuteCount=0;
        Time_BestTime.SecondCount=0;
        Time_BestTime.MiliCount=0;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}
