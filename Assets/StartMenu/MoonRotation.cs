using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation : MonoBehaviour {
	public Transform Earth;
	public float RotationSpeed;
	public float orbitSpeed;
	void Update () {
		transform.Rotate (Vector3.up, RotationSpeed * Time.deltaTime);
		transform.RotateAround (Earth.position, -Vector3.up, orbitSpeed);
	}
}
