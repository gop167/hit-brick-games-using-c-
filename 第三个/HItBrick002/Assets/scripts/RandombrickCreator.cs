using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandombrickCreator : MonoBehaviour {
	public GameObject Brick;//初始化Brick对象方便到时候把Perfab里的cube拖进来
							// Use this for initialization

	

	void Start () {
		InitiateBrick();//在区域随机位置生成10块方块
		InvokeRepeating("Copybrick", 4, 2);//在4s之后，每隔2s在上方区域随机位置生成3块方块
		
	}//都是写作start方法里面

	// Update is called once per frame
	void Update () {
		
	}
	void InitiateBrick() {
		for (int i = 0; i < 10; i++)
		{
			Vector3 ve = new Vector3(Random.Range(-13, 13), 1.0f, Random.Range(0, 13));//每次随机生成一个三维向量
			Transform.Instantiate(Brick, ve, Quaternion.identity);//利用该随机生成的向量随机位置生成一个方块，10次生成10个方块
		} }
		void Copybrick()
		{
			for (int i = 0; i < 3; i++)
			{
				Vector3 ve = new Vector3(Random.Range(-13, 13), 1.0f, Random.Range(0, 13));//每次随机生成一个三维向量
			Transform.Instantiate(Brick, ve, Quaternion.identity);
			//利用该随机生成的向量随机位置生成一个方块，重复3次生成3块方块
			
		}
		}
	}

