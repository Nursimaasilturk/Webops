using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainComponent : MonoBehaviour
{
    public GameObject startGamePanel;
    public GameObject gameMapPanel;
    public GameObject dailyBonusPopup;


    bool isGameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToMapsFrame()
    {
        if(!isGameStarted)
        {
            startGamePanel.SetActive(false);
            isGameStarted = true;
            gameMapPanel.SetActive(true);
        }
    }
    public void startGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void openDailyBonusPopup()
    {
        dailyBonusPopup.SetActive(true);

    }

    public void closeDailyBonusPopup()
    {
        dailyBonusPopup.SetActive(false);
    }
   
}
