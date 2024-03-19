using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainComponent : MonoBehaviour
{
    public GameObject startGamePanel;
    public GameObject gameMapPanel;

    bool isGameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        if(!isGameStarted)
        {
            startGamePanel.SetActive(false);
            isGameStarted = true;
            gameMapPanel.SetActive(true);
        }
    }
}
