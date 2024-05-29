using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap_Saw : Trap
{
    private Animator anim;
    public Transform[] movePositions;       // ��Ϲ����� �̵��� ��ġ�� ������ ����
    public float speed = 5f;
    public int moveIndex = 0;
    public bool OnGoingForward = true;

    private void Start()
    {
        anim = GetComponent<Animator>();

        isWorking = true;
    }

    private void Update() // ��ǻ�� ���� ������ �޴´�.
    {
        anim.SetBool("isWorking", isWorking);

        MoveTrap();
    }

    private void MoveTrap()
    {
        // ������� 0.0016��
        transform.position = Vector3.MoveTowards(transform.position, movePositions[moveIndex].position, speed * Time.deltaTime);

        // ���ǹ� _ ������ ��ǥ�� �������� �����ߴ���?
        if(Vector3.Distance(transform.position, movePositions[moveIndex].position) <= 0.1f)
        {
            //moveIndex = moveIndex + 1;
            moveIndex = moveIndex + 1;
        }
        // ���� ��ǥ ������ ������.. move Index = 0.
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