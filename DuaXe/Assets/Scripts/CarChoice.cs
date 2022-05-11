using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject RedBody;
    public GameObject BlackBody;

    public int CarImport;

    // Start is called before the first frame update
    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1){
            BlackBody.SetActive(true);
        }

        if (CarImport == 2){
            RedBody.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
