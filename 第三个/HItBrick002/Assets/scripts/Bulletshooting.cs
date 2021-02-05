using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletshooting : MonoBehaviour {
	public Rigidbody Bullet;//方便把Perfab里的sphere预制体拖过来,因此初始化
	//public GameObject ejector;//声明一个发射器好记录位置
	public float speed = 30f;//声明一个子弹速度
	public GameObject bulletPosition;//声明子弹的位置

	

	//public Camera cam;
						   // Use this for initialization
	void Start () {
		
	}
	
						   // Update is called once per frame
	void Update () {
		Rigidbody rb;
		if (Input.GetKeyDown(KeyCode.Space)) {
			rb = Transform.Instantiate(Bullet, bulletPosition.transform.position, bulletPosition.transform.rotation);
			rb.AddForce(new Vector3(0, 0, 1) * speed);
		
		}
		//按下空格发射子弹
		//Ray ray;//初始化一个射线以方便接收cam产生的射线
		//RaycastHit hit;//初始化一个返回射线接受的类
		
		//if (Input.GetMouseButtonDown(0)){
		//	ray = cam.ScreenPointToRay(Input.mousePosition);
					   
		//	if (Physics.Raycast(ray, out hit))
		//	{
		//		GameObject bt = GameObject.Instantiate(Bullet, ejector.transform.position, Quaternion.identity);
		//		Vector3 dis = hit.point - ejector.transform.position;
		//		bt.GetComponent<Rigidbody>().AddForce(dis * speed);
		//	}


		}
		
	}

