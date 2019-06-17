using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 100;

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed); // 坐标轴y轴方向 * 每帧的时间 * 速度 = 每帧绕y轴旋转90度
    }

    public void ChangeSpeed(float speed)
    {
        this.speed = speed;
    }
}