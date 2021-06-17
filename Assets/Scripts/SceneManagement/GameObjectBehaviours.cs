using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviours : MonoBehaviour
{
    public float gameSpeed;

    public CarMovement car;
    public RoadBehavior roadBehavior;


    private void Awake()
    {
        roadBehavior.roadSpeed = gameSpeed;
        car.roadXScale = roadBehavior.transform.localScale.z - 3.8f;
    }
}
