using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudioManager : MonoBehaviour
{
    // ������ҽ� ������Ʈ�� �߰����ּ���.
    public AudioSource[] sfx;
    public AudioSource[] bgm;

    // ���� �����ϰ� �ִ� BGMIndex
    // �̺�Ʈ �Լ� Start, Update ���ǹ�

    
    private void Start()
    {
        
    }

    private void Update()
    {

    }
    
    public void PlayBGM(int bgmIndex)
    {
        bgm[bgmIndex].Play();
    }

}
