using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canMove;
    public GameObject Pause;
    PlayerStadistics playerStadistics;
    Rigidbody2D characterController;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        playerStadistics = GetComponent<PlayerStadistics>();
        characterController = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            characterController.velocity = move * playerStadistics.GetSpeed();
        }
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetKey("Escape")){
            canMove = false;
            Pause.SetActive(true);
        }
    }

    public void PlayerCanMove(bool boolMove)
    {
        canMove = boolMove;
    }
}
