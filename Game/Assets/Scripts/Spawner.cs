using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject trashcan;
    public float spawnRate;
    private float timer = 0;
    public float widthoffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
    }
    void spawn()
    {
        float leftmostPoint = transform.position.x - widthoffset;
        float rightmostPoint = transform.position.x + widthoffset;
        Instantiate(trashcan, new Vector3(Random.Range(leftmostPoint,rightmostPoint), 0), transform.rotation);
    }
}
