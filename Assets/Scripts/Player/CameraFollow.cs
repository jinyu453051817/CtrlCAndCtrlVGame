using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float xMargin = 1.0f;//最大距离
    public float yMargin = 1.0f;
    public float xSmooth = 8.0f;//平滑程度
    public float ySmooth = 8.0f;

    public Vector2 maxXAndY;//摄像机运动范围限制
    public Vector2 minXAndY;

    public Transform player;//主角位置

    // Update is called once per frame
    void FixedUpdate()
    {
        TrackPlayer();
    }

    /// <summary>
    /// 检查相机x距离是否大于最大距离，如果是，返回true，则需要跟随
    /// </summary>
    /// <returns></returns>
    bool CheckXMargin()
    {
        return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
    }

    bool CheckYMargin()
    {
        return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
    }

    /// <summary>
    /// 跟踪目标核心函数
    /// </summary>
    void TrackPlayer()
    {
        //目标位置
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        //如果超过了最大距离，给目标赋值
        if (CheckXMargin())
        {
            targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);
        }
        if (CheckYMargin())
        {
            targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);
        }

        //clamp参数：1.值，2.最小值，3.最大值。如果值带大于最大值则等于最大值，反之同理
        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        //最后的赋值
        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}