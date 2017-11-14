using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {
    // Spawning asteroids
    public GameObject Asteroid1;
    //public int AsteroidsLeft;
    public int AsteroidCount;
    public float AsteroidTime;
    public float firstAsteroid;
    public Vector3 size;
    public Vector3 center;
    public GameObject AsteroidPrefab;
    // Use this for initialization
    

    void Start () {
        StartCoroutine(SpawnAsteroid1());
        
        //AsteroidsLeft = AsteroidCount;  //setting the amount of asteroids left to destroy to the amount it originally started with
        //AsteroidsLeft = GetComponent<DestroyAsteroid>().counter;
    }
	
	// Update is called once per frame
	void Update () {
        //asteroidsCounter();
        
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
      }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center,size);
    }


/*public void asteroidsCounter()
    {
        if (AsteroidsLeft <= AsteroidCount)
        {
            progress.text = AsteroidsLeft.ToString();
        }
    }*/
    
}
