using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public Transform asteroid;
    public Transform target;
    public float speed;
    

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float constant = speed * Time.deltaTime;
        asteroid.position = Vector3.MoveTowards(asteroid.position, target.position, constant);
	}

    private void OnTriggerEnter(Collider other)
    {
        //if (CompareTag("Player"){
            
        //}
    }

}

