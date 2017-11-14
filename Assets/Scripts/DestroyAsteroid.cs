using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour {
    public int counter;
    //public int asteroid;
    private void Start()
    {
        //asteroid = GetComponent<AsteroidSpawn>().AsteroidCount;
        //counter = asteroid;
    }

    private void Update()
    {
    
    }

    void OnMouseDown()
    {
        
        DestroyObject(gameObject);
        counter -= 1;

    }
    
    
  
}
