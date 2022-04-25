using System;
using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject gameControl;
        public GameObject PoliceCar;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            if (!gameControl.GetComponent<GameController>().start) return;
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }

        private void OnCollisionEnter(Collision collision){
            if(collision.gameObject.tag == "hangrao"){
                this.gameControl.GetComponent<GameController>().ReStartGameOver();
            }
            

        }

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "PoliceCar")
            {
                Debug.Log("lol");
                PoliceCar.GetComponent<PoliceCar>().CollisionCar(true);
                collision.gameObject.SetActive(false);
                StartCoroutine(Wait(collision.gameObject));
            }
        }

        IEnumerator Wait(GameObject PoliceCar)
        {
            yield return new WaitForSeconds(3); //3second pause
                                                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
            PoliceCar.SetActive(true);
        }
    }
}
