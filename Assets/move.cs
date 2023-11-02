using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private float speed = 0.1f; //floatは小数点

    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))//→キーを押したら
        {
            pos.x += speed;//右に移動
        }
        else if (Input.GetKey(KeyCode.LeftArrow))//←キーを押したら
        {
            pos.x -= speed;//左に移動
        }
        else if (Input.GetKey(KeyCode.UpArrow))//↑キーを押したら
        {
            pos.y += speed;//上に移動
        }
        else if (Input.GetKey(KeyCode.DownArrow))//↓キーを押したら
        {
            pos.y -= speed;//下に移動
        }

        transform.position = pos;
    }
}
