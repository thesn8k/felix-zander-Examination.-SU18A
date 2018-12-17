using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //int
    public int touches;
    //om kollition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //rör vid marken
        touches++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //rör inte vid marken
        touches--;
    }
}
