using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class ComTest : MonoBehaviour
{
    // 코드의 흐름
    public GameObject TestObject;
    // nullRefence에러. 변수에 데이터가 없어서 발생하는 에러다.
    // 생성(초기화) 이벤트 함수에 데이터 변수를 할당하는 작업.
    // Awake -> OnEnavle -> Start


    private void Awake()
    {
        Debug.Log("Awake 실행");
        TestObject = new GameObject();
    }


    private void Start()
    {
        Debug.Log("Start 실행");
        TestObject.SetActive(false);
    }


    private void OnEnable()
    {
        Debug.Log("OneEnable 실행");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixiedUpdate 실행");
    }

    private void Update()
    {
        Debug.Log("Update 실행");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate 실행");
    }
     

}
