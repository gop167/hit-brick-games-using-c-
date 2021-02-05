using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
	private Vector3 distance;
	public GameObject shooter;
	// Use this for initialization
	void Start () {
		distance = shooter.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = shooter.transform.position - distance;
	}
}
