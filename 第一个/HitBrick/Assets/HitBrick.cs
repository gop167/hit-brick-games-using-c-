using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBrick : MonoBehaviour {
	public GameObject Brick;
	public GameObject bullet;
	private Ray ray;
	public float speed = 30f;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			Vector3 ve = new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(-8, 8));
			GameObject.Instantiate(Brick, ve, Quaternion.identity);
		}
		//在平面内随机生成10个刚体brick
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);//如果按下鼠标左键先把主摄像机屏幕点转化为射线
			if (Physics.Raycast(ray,out hit)) {
			GameObject bt =	GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
				Vector3 dis = hit.point - transform.position;
				bt.GetComponent<Rigidbody>().AddForce(dis * speed);
			}//然后再射线检测，接收返回的射线属性并在摄像机位置实例化子弹，子弹的方向就是碰撞点和摄像机之间的向量，
			//最后给刚体球添加一个力就完成了最核心的打砖块的逻辑了
		}
	}
}
