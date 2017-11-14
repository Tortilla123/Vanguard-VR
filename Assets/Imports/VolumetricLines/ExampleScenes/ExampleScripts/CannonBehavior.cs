using UnityEngine;
using System.Collections;

public class CannonBehavior : MonoBehaviour {

	
	public Transform m_start;
	public GameObject m_shotPrefab;
	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			GameObject go = GameObject.Instantiate(m_shotPrefab, m_start.position, m_start.rotation) as GameObject;
			GameObject.Destroy(go, 3f);
		}
	}

	
}
