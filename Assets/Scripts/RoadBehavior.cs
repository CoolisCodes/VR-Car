using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBehavior : MonoBehaviour
{
    public float roadOffsetY = 0;
    public float speed = 1;

    public Material roadMaterial;

    // Start is called before the first frame update
    void Start()
    {
        roadMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        roadOffsetY += speed * Time.deltaTime;
        roadMaterial.SetTextureOffset("_MainTex", new Vector2(0, -roadOffsetY));
    }
}
