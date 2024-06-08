using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownOff : MonoBehaviour
{
    public Transform[] movePositions;
    public float speed = 5f;
    public int moveindex = 0;
    public Transform playerTransform;
    private bool isFollow = false;

    public bool isStayOn = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePositions[moveindex].position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePositions[moveindex].position) <= 0.1f)
        {
            moveindex = moveindex + 1;
        }

        if (movePositions.Length <= moveindex)
        {
            moveindex = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isStayOn)
        {
            isFollow = true;
            transform.SetParent(collision.gameObject.transform);
            Debug.Log($"플레이어가 발판위에 올라탄 상태 : {isFollow}");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isStayOn)
        {
            isFollow = false;
            Debug.Log($"플레이어가 발판위에 올라탄 상태 : {isFollow}");
        }
    }

}
