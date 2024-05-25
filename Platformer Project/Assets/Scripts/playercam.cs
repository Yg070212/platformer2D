using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercam : MonoBehaviour
{
    //������ �������� ����

    Vector3 offset;                           // ī�޶�� �÷��̾��� ��ġ ����
    public Transform playerTransform;         // �÷��̾��� ���� ��ġ (�÷��̾ ������ �� ����ǰ�, ī�޶� �ش� ��ġ�� ���̸�ŭ �Ѿư�)
    public float fixedYPosition;              // ī�޶��� Y ��ġ�� ������Ű�� ���� ���ذ�
    [Range(0f, 1f)]                           // �Ʒ� ������ ũ�⸦ �����ϴ� ����. <- C# Attribute
    public float smoothValue;                 // ī�޶��� ���� ����(�ε巯�� �������� ����) �� ��ġ ���̿� ��� ���� percent �̵��� ����..

    // Start is called before the first frame update
    void Start()
    {
        // transform = ī�޶�, ������ ��, ���� ->  a - B :   B
        offset = transform.position - playerTransform.position;

        fixedYPosition = transform.position.y;
    }

    // Lerp. Linear Interpolation ���� ����
    // �� ������ �� ��, �� �� ������ ������ ��ġ�� ���� �ľ��ϱ� ���� ������ ����.
    // �� �� (Point) -(Vector3). ī�޶��� ���� ��ġ. �̵� �ϰ� ���� ��ġ, ī�޶�  -> (point) -> ��ǥ
    
    // �÷��̾��� �������� Update ����� �Ŀ� ī�޶� �ѾƼ� �����̱� ���ؼ�.
    // Vector3.Lerp�Լ� ������ �Ǿ� �ֽ��ϴ�.
    void Update()
    {
        // �÷��̾ ������ �̴ϴ�.
        // offset = transform.position - playerTransform/position;


        Vector3 targetPosition = playerTransform.position + offset;  // ������ �� �������� ī�޶��� ��ġ�� ���Ѵ�.
        targetPosition.y = fixedYPosition;                           // ī�޶��� Y(����)�� ������Ų��.0
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothValue); 
        // ������ ��                                                 // ������ �÷��̾��� x�������θ� ����ٴϰ�, Y�� ������Ų ������ ī�޶��� �̵���Ų��.
        transform.position = smoothPosition;
        
    }
}
