using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPrefab;
    [SerializeField] private Transform spawnTransform; // check point, save point ���� ��ġ �������ִ� ���

    private PlayerController playerController;         // playerController���� ���� ������Ʈ ���� �߰������ �մϴ�.
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        RespawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            RespawnPlayer();
        }

        // ���� player ������ null�̸� Respawn�ض�.
        //if(player != null)
        //{
        //    RespawnPlayer();
        //}
    }

    public void RespawnPlayer()
    {
        player = Instantiate(PlayerPrefab, spawnTransform.position, Quaternion.identity);

        playerController = player.GetComponent<PlayerController>(); // �ٸ� �ڵ忡 ���� �ϴ� ���.
    }
}
