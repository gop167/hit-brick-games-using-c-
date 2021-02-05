using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletshooting : MonoBehaviour {
	//public GameObject Bullet;//方便把Perfab里的sphere预制体拖过来,因此初始化
	//public GameObject ejector;
	//public float speed = 300f;//声明一个子弹速度
	
	
	//你的初始化分数为0
	public Camera cam;
	public int i = 0;                      // Use this for initialization
	void Start () {
		OnGUI();
	}
	
						   // Update is called once per frame
	void Update () {
		Ray ray;//初始化一个射线以方便接收cam产生的射线
		RaycastHit hit;//初始化一个返回射线接受的类
	
		if (Input.GetMouseButtonDown(0)){
			ray = cam.ScreenPointToRay(Input.mousePosition);
			
			if (Physics.Raycast(ray, out hit))
			{
				GameObject.Destroy(hit.collider.gameObject);
				i++;
			}

				//if (Physics.Raycast(ray, out hit))
				//{
				//	GameObject bt = GameObject.Instantiate(Bullet, ejector.transform.position, Quaternion.identity);
				//	Vector3 dis = hit.point - ejector.transform.position;
				//	bt.GetComponent<Rigidbody>().AddForce(dis * speed);
				//}


			}//射线检测去消除鼠标点击的物体
		
	}
	void OnGUI()
	{
		GUILayout.TextArea("你目前的分数是：" + i, 600);
	}
}
