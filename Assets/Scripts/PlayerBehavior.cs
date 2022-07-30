using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private float moveSpeed = 40f;
    private float distanceMargin = 1f;
    private float fieldLimit = 9f;

    public Transform movePoint;

    void Start()
    {
        movePoint.parent = null;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= distanceMargin)
        {
            if (Input.GetKeyDown(KeyCode.W) && movePoint.position.z + 4f < fieldLimit)
            {
                movePoint.position += new Vector3(0f, 0f, 4f);
            }
            else if (Input.GetKeyDown(KeyCode.A) && movePoint.position.x - 4f > -fieldLimit)
            {
                movePoint.position += new Vector3(-4f, 0f, 0f);
            }
            else if (Input.GetKeyDown(KeyCode.S) && movePoint.position.z - 4f > -fieldLimit)
            {
                movePoint.position += new Vector3(0f, 0f, -4f);
            }
            else if (Input.GetKeyDown(KeyCode.D) && movePoint.position.x + 4f < fieldLimit)
            {
                movePoint.position += new Vector3(4f, 0f, 0f);
            }
        }
    }
}
