using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern03 : MonoBehaviour
{
    // 원을 방사할 위치
    public Transform startPos;
    public int bulletCount;
    public float bulletspeed;
    public GameObject bulletPrefab;

    private int MaxBulletCount;

    private void Awake()
    {
        MaxBulletCount = bulletCount;
    }

    private void OnEnable()
    {
        StartCoroutine(SpawnEnemy());
    }


    private void OnDisable()
    {
        StopCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        int count = 0;

        yield return new WaitForSeconds(1f);

        while(count <MaxBulletCount)
        {
            CircleEmit();
            count++;
            yield return new WaitForSeconds(1f);
        }
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CircleEmit()
    {
        float angle = 360 / (float)bulletCount;

        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab,
                startPos.position, Quaternion.identity);


            float bulletAngle = angle * i; // 12도, 24도, 36도 ....
            float x = Mathf.Cos(bulletAngle * Mathf.PI / 180);
            float y = Mathf.Sin(bulletAngle * Mathf.PI / 180);

            bullet.GetComponent<MovementTransform2D>().MoveSpeed(bulletspeed);
            bullet.GetComponent<MovementTransform2D>().MoveTo(new Vector3(x, y));
        }
    }
}
