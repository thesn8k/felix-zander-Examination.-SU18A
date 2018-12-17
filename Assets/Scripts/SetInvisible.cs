using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
    // updaterar bara när spelet startar
    void Start()
    {
        //när spelet startar så ska priten stängas av för att den ska bli "osynlig"
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
