using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool start = false;
    public Button btn_start;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        btn_start.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartGame()
    {
        start = true;
        canvas.SetActive(false);
    }

    public void ReStartGameOver()
    {
        StartCoroutine(Wait());
        start = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3); //3second pause
        Debug.Log("3 second pause");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
