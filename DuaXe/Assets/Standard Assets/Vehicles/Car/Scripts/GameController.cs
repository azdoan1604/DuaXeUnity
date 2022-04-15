using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
}
