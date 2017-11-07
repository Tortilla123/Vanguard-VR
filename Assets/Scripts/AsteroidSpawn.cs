using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {
    // Spawning asteroids
    public GameObject Asteroid1;
    //public GameObject Asteroid2;
    //public GameObject Asteroid3;
    //public GameObject Asteroid4;
    //public Vector3 Asteroid1Val;
    //public Vector3 Asteroid2Val;
    //public Vector3 Asteroid3Val;
    //public Vector3 Asteroid4Val;

    public int AsteroidCount;
    public float AsteroidTime;
    public float firstAsteroid;
    public Vector3 size;
    public Vector3 center;
    public GameObject AsteroidPrefab;
    // Use this for initialization
    void Start () {
           StartCoroutine(SpawnAsteroid1());
    }
	
	// Update is called once per frame
	void Update () {

	}

   // public void SpawnAsteroid()
  //  {
        //Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
       // Instantiate(AsteroidPrefab, pos, Quaternion.identity);
  //  }

    IEnumerator SpawnAsteroid1()
     {
        yield return new WaitForSeconds(firstAsteroid);

        for (int i = 1; i <= AsteroidCount; i++)
        {
           Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
           Quaternion spawnRotation = Quaternion.identity;
           Instantiate(AsteroidPrefab, pos, spawnRotation);
           yield return new WaitForSeconds(AsteroidTime);
      }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center,size);
    }

}
