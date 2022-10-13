using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objectsTospawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;
    
    public float minSpawnTime = 2.5f;
    public float maxSpawnTime = 3.0f;

    bool gameOver;
    void Start()
    {
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    
    
    void Update()
    {
        if (!(gameOver))
        {
            timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

            if (timeSinceLastSpawn > timeToNextSpawn)
            {

                int selection = Random.Range(0, objectsTospawn.Length);


                Instantiate(objectsTospawn[selection], transform.position, Quaternion.identity);

                timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
                timeSinceLastSpawn = 0.0f;

            }
        }
    }

    public void GameOver()
    {
        gameOver = true;
    }
}
