using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject gold;
    public Transform objects;
    float _nextSpawnTime = -2f;
    public float _spawnDelay = 3.0f;
    double x = 0;
    double x2 = 0;
    void Start()
    {
        
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        x2 = objects.position.x;
        if (Time.time >= _nextSpawnTime && x2 > x)
        {
            Vector3 edgeOfScreen = new Vector3(1.0f, 0.5f, 8.0f);
            Vector3 placeToSpawn = Camera.main.ViewportToWorldPoint(edgeOfScreen);
            Quaternion directionToFace = Quaternion.identity;
            Instantiate(gold, placeToSpawn, directionToFace);
            _nextSpawnTime = Time.time + _spawnDelay;
            x = x2;
        }
    }
}
