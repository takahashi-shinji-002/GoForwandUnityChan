﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    // ゲームオーバテキスト
    private GameObject gameOverText;

    // 走行距離テキスト
    private GameObject runLengthText;

    // 走った距離
    private float len = 0;

    // 走る速度
    private float speed = 0.03f;

    // ゲームオーバの判定
    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            // 走った距離を更新する
            this.len += this.speed;

            // 走った距離を表示する
            this.runLengthText.GetComponent<Text>().text = "Distance: " + len.ToString("F2") + "m";
        }
    }

    public void GameOver()
    {
        // ゲームオーバーになったときに、画面上にゲームオーバーを表示する
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
