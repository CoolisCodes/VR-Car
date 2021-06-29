using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameObjectManager : MonoBehaviour
{
    public float gameSpeed;

    [Range(-1, -0.005f)]
    public float carTurningSpeed = -0.15f;

    public CarMovement car;
    public RoadBehavior roadBehavior;

    public GameObstacle gameObstaclePrefab;
    public GamePoint gamePointPrefab;

    public List<GameObject> activeObjects = new List<GameObject>();

    private void Awake()
    {
        roadBehavior.roadSpeed = gameSpeed;
        car.roadXScale = roadBehavior.transform.localScale.z - 3.8f;
        car.turnSpeed = carTurningSpeed;


        StartCoroutine(SpawnObjectsRoutine());
    }

    public void SpawnObject(GameObject prefab)
    {
        prefab.transform.position = GetRandomPosition();

        if (XUnique(prefab.transform.position.x) == true)
        {
            GameObject created = Instantiate(prefab);

            activeObjects.Add(created);
        }
    }

    public Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(-2.5f, 2.5f);

        return new Vector3(randomX, 0.5f, 100);
    }

    public bool XUnique(float x)
    {
        foreach (GameObject active in activeObjects)
        {
            if (Mathf.Abs(active.transform.position.x) - Mathf.Abs(x) < 0.5)
            {
                Debug.Log("too close!");

                return false;
            }
        }

        return true;
    }

    public IEnumerator SpawnObjectsRoutine()
    {
        while (true)
        {
            Debug.Log("Spawn");
            SpawnObject(gameObstaclePrefab.gameObject);

            //SpawnObject(gamePointPrefab.gameObject);
            yield return new WaitForSeconds(0.5f);
        }
    }

}
