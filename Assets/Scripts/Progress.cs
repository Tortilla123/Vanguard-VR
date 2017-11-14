using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Progress : MonoBehaviour {
    public Text progress;
    private int asteroid;
    int remaining;                  //Variable for the progress bar
    public GameObject prefab;

    // Use this for initialization
    void Start () {
        //asteroid = GetComponent<AsteroidSpawn>().AsteroidCount;
        //remaining = GetComponent<AsteroidSpawn>().AsteroidsLeft;

    }

    // Update is called once per frame
    void Update () {
        UpdateAsteroids();
	}

    public void UpdateAsteroids()
    {
        //progress.text = asteroid.ToString();
        //if ()
        {

        }
        
    }
}
