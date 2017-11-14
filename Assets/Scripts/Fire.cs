using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public GameObject m_shotPrefab;
    public Transform m_start;
    
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject go = GameObject.Instantiate(m_shotPrefab, m_start.position, m_start.rotation) as GameObject;
            GameObject.Destroy(go, 2f);


        }
    }
}
