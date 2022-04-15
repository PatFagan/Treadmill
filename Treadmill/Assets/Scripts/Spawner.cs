using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnLoc;
    public GameObject[] obstacles;
    Vector2 spawnLocVector;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocVector = new Vector2(spawnLoc.transform.position.x, spawnLoc.transform.position.y);
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        int rand = Random.Range(0, 3);
        Instantiate(obstacles[rand], spawnLoc.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        StartCoroutine(Spawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
