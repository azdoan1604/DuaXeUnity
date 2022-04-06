using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Rigidbody rb;
   

    public GameObject scoretext;
    public int score = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome Mutimedia!");
        // tìm component Rigidbody bên trong Sphere Object để liên kết nếu có
        rb = GetComponent<Rigidbody>();
        scoretext.GetComponent<TextMesh>().text = 0 + " score! ";
    }

    // Update is called once per frame

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            scoretext.GetComponent<TextMesh>().text = score.ToString() + " score! ";
            score = score + 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            this.enabled = false;
            FindObjectOfType<Restart>().ReStartGameOver();
        }
    }

}
