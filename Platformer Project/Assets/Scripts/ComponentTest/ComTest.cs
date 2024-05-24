using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class ComTest : MonoBehaviour
{
    // �ڵ��� �帧
    public GameObject TestObject;
    // nullRefence����. ������ �����Ͱ� ��� �߻��ϴ� ������.
    // ����(�ʱ�ȭ) �̺�Ʈ �Լ��� ������ ������ �Ҵ��ϴ� �۾�.
    // Awake -> OnEnavle -> Start


    private void Awake()
    {
        Debug.Log("Awake ����");
        TestObject = new GameObject();
    }


    private void Start()
    {
        Debug.Log("Start ����");
        TestObject.SetActive(false);
    }


    private void OnEnable()
    {
        Debug.Log("OneEnable ����");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixiedUpdate ����");
    }

    private void Update()
    {
        Debug.Log("Update ����");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate ����");
    }
     

}
