using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //move speed är 2
    public float moveSpeed = 2f;
    // spriten pekar vänster är sant
    public bool isLeft = true;
    //fysik på ett game object
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //
        rbody = GetComponent<Rigidbody2D>();
        //fienden har rörelse avstängd
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //om man trycker på H
        if (Input.GetKeyDown(KeyCode.H))
        {
            //rör sig fienden
            Move(true);
        }
    }
    //fiende flip
    void Move(bool flip)
    {
        //om flip är sant
        if (flip == true)
        {
            //blir fienden motsatsen till vänster
            isLeft = !isLeft;
        }
        // om fienden är vänster
        if (isLeft == true)
        {
            //rör sig fienden mot vänster
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        // annars
        else
        {
            //rör sig fienden åt höger
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    //någonting ska hända om fienden kolliderar med något
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om kollition händer med "invisibleWall"
        if (collision.tag == "InvisibleWall")
        {
            //rör sig fienden
            Move(true);
        }
    }
}
