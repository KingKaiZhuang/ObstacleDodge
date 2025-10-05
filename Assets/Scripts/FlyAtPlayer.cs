using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition ;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * moveSpeed);
    }
}
