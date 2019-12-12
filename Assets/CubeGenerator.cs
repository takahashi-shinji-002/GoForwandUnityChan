﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

	// cubeのPrefab
	public GameObject cubePrefab;
    // 時間計測用の変数
    private float delta = 0;
	// cubeの生成間隔
	private float span = 1.0f;
	// cubeの生成位置: x座標
	private float genPosX = 12;
	// cubeの生成位置: offset
	private float offsetY = 0.3f;
	// cubeの縦方向の間隔
	private float spaceY = 6.9f;
	// cubeの生成位置: offset
	private float offsetX = 0.5f;
	// cubeの横方向の間隔
	private float spaceX = 0.4f;
	// cubeの生成個数の上限
	private int maxBlockNum = 4;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		this.delta += Time.deltaTime;

        // span秒以上の時間が経過したかを調べる
        if(this.delta > this.span)
		{
			this.delta = 0;
			// 生成するcube数をRandomに決める
			int n = Random.Range(1, maxBlockNum + 1);

			// 指定した数だけcubeを生成する
			for (int i = 0; i < n; i++)
			{
				// cubeの生成
				GameObject go = Instantiate(cubePrefab) as GameObject;
				go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
			}
			// nextcubeまでの生成時間を決める
			this.span = this.offsetX + this.spaceX * n;
		}
	}
}
