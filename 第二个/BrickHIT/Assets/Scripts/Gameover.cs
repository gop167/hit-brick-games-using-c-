using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject yzt = GameObject.FindGameObjectWithTag("Player");
		if (yzt.transform.position.y < 0)
		{
			Debug.Log("GameOver");
		}//如果小方块掉下去了则在控制台输出Gameover
	}
	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			GameObject.Destroy(coll.gameObject);
			
		}//球碰到cube则消灭cube
	}
	
}
