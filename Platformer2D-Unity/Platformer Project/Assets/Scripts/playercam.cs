using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercam : MonoBehaviour
{
    //벡터의 연산으로 구현

    Vector3 offset;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        // transform = 카메라, 벡터의 합, 뺴기 ->  a - B :   B
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
