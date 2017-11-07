using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour {
	public float RotationSpeed = 5f;
	void Update () {
		transform.Rotate (-Vector3.up, RotationSpeed * Time.deltaTime);
	}
}
