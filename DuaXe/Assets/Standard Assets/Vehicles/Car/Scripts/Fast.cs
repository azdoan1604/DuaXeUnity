using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Fast : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Car;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Debug.Log("có");
            Car.GetComponent<CarController>().addSpeed();
        }
    }
}
