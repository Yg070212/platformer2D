using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] ParticleSystem movementPaticle;
    [SerializeField] ParticleSystem jumpParticle;
    [SerializeField] ParticleSystem myParticle;

    // �÷��̾��� �ӵ��� ���� ��ƼŬ�� �����ϴ� ���� ����
    [SerializeField] int occurAfterVelocity;
    // ������ ���� �ֱ�
    [Range(0, 0.3f)]
    [SerializeField] float dustFormationTime;

    [SerializeField] Rigidbody2D playerRb;
    float counter;   // ������ ���� �ֱ⸦ üũ�ϱ� ���� �ð� ����
    public bool isGround;   // �÷��̾��� ���� ���¸� üũ�ϱ� ���� ����

    private void Update()
    {
        CheckAfterVelocity();
    }

    public void PlayParticle()
    {
        myParticle.Play();
    }

    private void CheckAfterVelocity()
    {
        counter += Time.deltaTime;
        if (isGround && Mathf.Abs(playerRb.velocity.x) > occurAfterVelocity)
        {
            CheckDustFomationTime();
        }
    }

    private void CheckDustFomationTime()
    {
        if (counter > dustFormationTime)
        {
            movementPaticle.Play();
            counter = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            jumpParticle.Play();
            isGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}



