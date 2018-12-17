using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    //string som gör att när levelToLoad händer så ska den starta upp SampleScene
    public string levelToLoad = "SampleScene";

    //uppdaterar när collidern blir nuddad
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om det är player collidern som slår i
        if(collision.tag == "Player")
        {
            //skriv då "yay" och utför levelToLoad
            print("Yay");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
