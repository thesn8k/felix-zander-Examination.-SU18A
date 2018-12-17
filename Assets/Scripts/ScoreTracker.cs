using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro; //<- "namespace"

public class ScoreTracker : MonoBehaviour
{
    //
    public TextMeshProUGUI scoreText;
    //räknar vad din totalScore är
    public int totalScore;

    //updaterar varje frame
    private void Update()
    {
        //score texten ska skriva "Score: {vad du nu har för score}
        scoreText.text = string.Format("Score: {0}", totalScore);
    }
}
