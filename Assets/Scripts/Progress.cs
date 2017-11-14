using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Progress : MonoBehaviour {
    public Text progress;
    Teleport teleport;
    int asteroidsLeft;
    AsteroidSpawn spawns;
    int count;

    // Use this for initialization
    void Start () {
        asteroidsLeft = teleport.counter;
        count = spawns.AsteroidCount;
        asteroidsLeft = count;

    }

    // Update is called once per frame
    void Update () {
        UpdateAsteroids();
	}

    public void UpdateAsteroids()
    {
        
            if (asteroidsLeft <= count)
            {
                progress.text = asteroidsLeft.ToString();
            }
        
    }
}
