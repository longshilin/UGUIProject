using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //开始游戏触发按钮事件
    public void OnStartGame(int sceneIndex)
    {
        Application.LoadLevel(sceneIndex);
    }
}