using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goalObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ ��ǥ ������ �����߽��ϴ�.");

            // ȭ�鿡 ������ Ŭ���� �߽��ϴ�. ǥ��. User Interface
            goalObject.SetActive(true);
            TMP_Text goalText = goalObject.GetComponent<TMP_Text>();
            goalText.text = "���� Ŭ����!";

            // ����Ʈ�� ���Ͷ�.

            // ȿ���� ���尡 ���Ͷ�.
        }
    }
}
