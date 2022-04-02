using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void ReStartGameOver()
    {
        //StartCoroutine(Wait());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // IEnumerator Wait()
    // {
    //     yield return new WaitForSeconds(3); //3second pause
    //     Debug.Log("3 second pause");
    //     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }


}
