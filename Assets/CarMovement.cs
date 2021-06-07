using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform camera;
    public Transform carTransform;

    public string test;
    public int test1;

    private void OnEnable()
    {
        Debug.Log("Hello!");
    }

    private void Awake()
    {
        carTransform = transform;
    }

    void Start()
    {

    }

    void Update()
    {

        carTransform.eulerAngles = new Vector3(0, camera.eulerAngles.z * -1, 0);
    }

    private void FixedUpdate()
    {

    }

    private void OnDisable()
    {
        Debug.Log("Hello?");
    }
}
