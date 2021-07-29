using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private GameObject goalOne;
    [SerializeField] private GameObject goalTwo;
    private bool goalOneCheck;

    // Start is called before the first frame update
    void Start()
    {
        goalOneCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceOne = Vector2.Distance(transform.position, goalOne.transform.position);

        if (goalOneCheck == false && distanceOne >= 0.01)
        {
            Vector2 directionOne = (goalOne.transform.position - transform.position).normalized;

            Vector2 aiPosition = transform.position;
            aiPosition += directionOne * speed * Time.deltaTime;
            transform.position = aiPosition;
        }
        else
        {
            goalOneCheck = true;
        }

        float distanceTwo = Vector2.Distance(transform.position, goalTwo.transform.position);

        if (goalOneCheck == true && distanceTwo >= 0.01)
        {
            Vector2 directionTwo = (goalTwo.transform.position - transform.position).normalized;

            Vector2 aiPosition = transform.position;
            aiPosition += directionTwo * speed * Time.deltaTime;
            transform.position = aiPosition;
        }
    }
}


