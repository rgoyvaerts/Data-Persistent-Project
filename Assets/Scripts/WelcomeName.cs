using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WelcomeName : MonoBehaviour
{
    public TMP_Text welcomeText;
    public string welcomeUsername;

    public TMP_Text highScoreText;
   

    // Start is called before the first frame update
    void Start()
    {
        loadUsernameAndHighScore();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void loadUsernameAndHighScore()
    {
        welcomeUsername = DataManager.Instance.username;
        welcomeText.text = "Welcome " + welcomeUsername;
        highScoreText.text = "Best Score: " + DataManager.Instance.highscore;
    }
}
