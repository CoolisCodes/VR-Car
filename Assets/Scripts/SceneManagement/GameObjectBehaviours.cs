using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviours : MonoBehaviour
{
    public float gameSpeed;

    [Range(-1, -0.005f)]
    public float carTurningSpeed = -0.15f;

    public CarMovement car;
    public RoadBehavior roadBehavior;


    private void Awake()
    {
        roadBehavior.roadSpeed = gameSpeed;
        car.roadXScale = roadBehavior.transform.localScale.z - 3.8f;
        car.turnSpeed = carTurningSpeed;
    }
}
