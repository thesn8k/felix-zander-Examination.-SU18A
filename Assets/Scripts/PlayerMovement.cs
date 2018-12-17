using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    private Rigidbody2D rbody;
    public GroundCheck groundCheck;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        //om man trycker "space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //om grounded händer
            if (groundCheck.touches > 0)
            {
                //lägg på rörelse vertikalt
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}
