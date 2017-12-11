using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AsteroidSpawn2 : MonoBehaviour {
    // Spawning asteroids
    public GameObject Asteroid1;
    public GameObject PowerUp;
    //Teleport teleport;
    //int asteroidsleft;
    public int AsteroidCount;
    public float AsteroidTime;
    public float PowerTime;
    public float firstAsteroid;
    public float firstPower;
    public int Time;
    public Vector3 size;
    public Vector3 center;
    public GameObject AsteroidPrefab;
    public GameObject PowerUpContainer;
    // Use this for initialization
    public Text progress;

    void Start()
    {
        StartCoroutine(SpawnAsteroid1());
        StartCoroutine(SpawnPowerup());
        Time = 0;

        //AsteroidsLeft = AsteroidCount;  //setting the amount of asteroids left to destroy to the amount it originally started with
        //asteroidsleft = teleport.counter;
        
    } 
	
	// Update is called once per frame
	void Update () {
        //AsteroidsCounter();    
        Time = Time + 1;
        if (Time % 60 == 0)
            AsteroidTime = AsteroidTime - 0.01f;

	}

    public void AsteroidUpdate()
    {
        AsteroidCount = AsteroidCount + 1;
        Debug.Log(AsteroidCount);
        Debug.Log(AsteroidTime);
    }
    IEnumerator SpawnAsteroid1()
     {
        yield return new WaitForSeconds(firstAsteroid);

        for (int i = 1; i <= AsteroidCount; i++)
        {
           Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
           Quaternion spawnRotation = Quaternion.identity;
           Instantiate(AsteroidPrefab, pos, spawnRotation);
           yield return new WaitForSeconds(AsteroidTime);
           if (AsteroidCount < 50)
                AsteroidUpdate();
        }
    }
    IEnumerator SpawnPowerup()
    {
        yield return new WaitForSeconds(firstPower);

        for (int i = 1; i <= 3; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(PowerUpContainer, pos, spawnRotation);
            yield return new WaitForSeconds(PowerTime);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center,size);
    }


/*public void AsteroidsCounter()
    {
        if (asteroidsleft <= AsteroidCount)
        {
            progress.text = asteroidsleft.ToString();
        }
    }*/
    
}
