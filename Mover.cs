using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed=56.28f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use arrow keys to move your player");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        float zValue = Input.GetAxis("Horizontal")* Time.deltaTime* moveSpeed;
        float xValue = Input.GetAxis("Vertical")* Time.deltaTime* moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
