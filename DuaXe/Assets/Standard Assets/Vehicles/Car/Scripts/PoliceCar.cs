using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoliceCar : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    public float translateSpeed;
    private float defauleSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject gameControl;
    private Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
        defauleSpeed = translateSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameControl.GetComponent<GameController>().start)
        {
            vector3 = transform.position;
            HandleTranslation();
            HandleRotation();
        }
    }

    private void HandleTranslation()
    {
        var targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(vector3, targetPosition, translateSpeed * Time.deltaTime);
    }

    private void HandleRotation()
    {
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Car")
        {
            this.gameControl.GetComponent<GameController>().ReStartGameOver();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10); //3second pause
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        CollisionCar(false);
    }

    public void CollisionCar(bool value)
    {
        if (value)
        {
            translateSpeed += 4;
            Debug.Log(translateSpeed);
            StartCoroutine(Wait());
        }
        else
        {
            translateSpeed = defauleSpeed;
        }
    }
}
