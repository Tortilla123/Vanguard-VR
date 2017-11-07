using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	public Transform sun;
	public float RotationSpeed;
	public float orbitSpeed;
	void Update () {
		transform.Rotate (Vector3.up, RotationSpeed * Time.deltaTime);
		transform.RotateAround (sun.position, -Vector3.up, orbitSpeed);
	}
}
