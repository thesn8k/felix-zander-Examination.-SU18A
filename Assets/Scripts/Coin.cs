using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //score är värt 1
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om kollition händer med "player"
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    //lägger till 1 till score
                    tracker.totalScore += score;
                }
                else
                {
                    //skriver "ScoreTracker saknas på GameController"
                    Debug.LogError("ScoreTracker saknas på GameController.");
                }
            }
            else
            {
                //skriver "GameController finns inte"
                Debug.LogError("GameContoller finns inte.");
            }
            //tar bort "coin" från existensen
            Destroy(gameObject);
        }
    }
}
