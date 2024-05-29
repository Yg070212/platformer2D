using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap_Saw : Trap
{
    private Animator anim;
    public Transform[] movePositions;       // 톱니바퀴가 이동할 위치를 저장할 변수
    public float speed = 5f;
    public int moveIndex = 0;
    public bool OnGoingForward = true;

    private void Start()
    {
        anim = GetComponent<Animator>();

        isWorking = true;
    }

    private void Update() // 컴퓨터 성능 영향을 받는다.
    {
        anim.SetBool("isWorking", isWorking);

        MoveTrap();
    }

    private void MoveTrap()
    {
        // 평균으로 0.0016값
        transform.position = Vector3.MoveTowards(transform.position, movePositions[moveIndex].position, speed * Time.deltaTime);

        // 조건문 _ 함정이 목표한 지점까지 도착했는지?
        if(Vector3.Distance(transform.position, movePositions[moveIndex].position) <= 0.1f)
        {
            //moveIndex = moveIndex + 1;
            moveIndex = moveIndex + 1;
        }
        // 다음 목표 지점이 없으면.. move Index = 0.
        if(movePositions.Length <= moveIndex)
        {
            moveIndex = 0;
        }
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }
}
