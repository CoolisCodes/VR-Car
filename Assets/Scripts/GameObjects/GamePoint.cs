using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePoint : MonoBehaviour
{
    public MovementBehaviour movementBehaviour;

    private void Awake()
    {
        movementBehaviour = new MovementBehaviour(transform, Vector3.forward, 2 * 5);//game speed

    }

    // Update is called once per frame
    void Update()
    {
        movementBehaviour.Move();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.GetComponent<CarMovement>() != null)
        {
            Debug.Log("You Got a point");
        }

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}

