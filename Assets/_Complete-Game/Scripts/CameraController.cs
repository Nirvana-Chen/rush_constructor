using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform target; //角色的Transform
    public Vector3 Offset = new Vector3(5.5f, 3.5f, -10f);  //摄像机与角色的相对位置偏移
    private float smoothing = 3; //移动平滑度
                                 // Use this for initialization
    void Start()
    {
        //得到角色和偏移
        target = GameObject.FindWithTag("Player").transform;
    }

    /// <summary>
    /// 这里使用LateUpdate可以减少镜头晃动
    /// </summary>
    void LateUpdate()
    {
        if (target.position.x <= 13)
        {
            //target.TransformDirection(Offset) 将偏移从局部坐标变为世界坐标,达到摄像机永远在角色背后的目的
            transform.position = new Vector3(Vector3.Lerp(transform.position, target.position + target.TransformDirection(Offset), Time.deltaTime * smoothing).x, 3.5f, -10f);
        }
    }
}
