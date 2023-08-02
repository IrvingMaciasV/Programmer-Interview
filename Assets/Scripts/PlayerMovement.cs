using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canMove=true;
    public GameObject Pause;
    public GameObject PlayerGraphics;
    PlayerStadistics playerStadistics;
    Rigidbody2D characterController;
    Animator animator;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        playerStadistics = GetComponent<PlayerStadistics>();
        characterController = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (canMove && move.x!=0)
        {
            characterController.velocity = move * playerStadistics.GetSpeed();
            animator.SetTrigger("Walk");

            if (move.x > 0)
            {
                PlayerGraphics.transform.localScale = new Vector3(1,1,1);
            }
            else if (move.x < 0)
            {
                PlayerGraphics.transform.localScale = new Vector3(-1,1,1);
            }
        }

        if (move.x == 0)
        {
            animator.SetTrigger("Idle");
        }
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.Escape)){
            canMove = false;
            Pause.SetActive(true);
        }
    }

    public void PlayerCanMove(bool boolMove)
    {
        canMove = boolMove;
    }
}
