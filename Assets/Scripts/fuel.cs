using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuel : MonoBehaviour
{
    public GameObject gold;
    public Transform objects;
    float _nextSpawnTime = -2f;
    public float _spawnDelay = 5f;
    int count = 16;
    float height = 0.5f;
    void Start()
    {

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= _nextSpawnTime && count!=0)
        {
            Vector3 edgeOfScreen = new Vector3(_nextSpawnTime * 1f, height, 8.0f);
            Vector3 placeToSpawn = Camera.main.ViewportToWorldPoint(edgeOfScreen);
            Quaternion directionToFace = Quaternion.identity;
            Instantiate(gold, placeToSpawn, directionToFace);
            _nextSpawnTime = Time.time + _spawnDelay;
            count--;
            Debug.Log(objects.position.y);
        }
    }
}
