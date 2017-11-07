using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {
	public Transform Sun;
	public float RotationSpeed;
	public float orbitSpeed;
	void Update () {
		transform.Rotate (Vector3.up, RotationSpeed * Time.deltaTime);
		transform.RotateAround (Sun.position, -Vector3.up, orbitSpeed);
	}
}
