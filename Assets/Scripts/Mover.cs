using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game. Use WASD or arrow keys to move the player");
        Debug.Log("Move using arrow keys or WASD");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
