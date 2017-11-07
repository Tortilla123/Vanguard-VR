// script to render explosion
using UnityEngine;
using System.Collections;

public class GraphicExplosion : MonoBehaviour {

    public AudioSource blowUp;
    public float loopduration;
    private float ramptime=0;
    private float alphatime=1;	

	void Update ()
    {
        Invoke("destroy", 2.6f);
    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
