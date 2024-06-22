using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    // ������ҽ� ������Ʈ�� �߰����ּ���.
    public AudioSource[] sfx;
    public AudioSource[] bgm;

    // ���� �����ϰ� �ִ� BGMIndex
    public int bgmIndex = 0;
    // �̺�Ʈ �Լ� Start, Update ���ǹ�
    public int sfxIndex = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Start()
    {
        //PlayBGM(bgmIndex);
        //PlayRandomBGM();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayRandomBGM();
        }
    }

    public void PlayBGM(int bgmIndex)
    {
        bgm[bgmIndex].Play();
    }

    public void PlaySFX(int sfxIndex)
    {
        if(sfxIndex < sfx.Length) // sfx.Length ū ���� ������ �迭�ʰ� ������ �߻��Ѵ�.
        {
            sfx[sfxIndex].pitch = Random.Range(0.85f, 1.15f);
            sfx[sfxIndex].Play();
            Debug.Log($"{sfx[sfxIndex].name} ��µ�");
        }
    }

    private void StopBGM()
    {
        //for(int i =0; i < bgm.Length; i++)
        //{
            //bgm[1].Stop();
        //}

        foreach(var sound in bgm)
        {
            sound.Stop();
        }
    }

    private void StopSFX()
    {
        foreach (var sound in sfx)
        {
            sound.Stop();
        }
    }
    public void PlayRandomBGM()
    {
        Debug.Log("BGM�� �����.");
        // ������ ������ BGM�� �����.

        // bgmIndex�� ������ ���� ������, �� ���� �����ϸ�ȴ�.
        int randomIndex = Random.Range(0, bgm.Length);
        PlayBGM(randomIndex);
    }

    public void PlayRandomSFX()
    {
        Debug.Log("ȿ������ �����.");
        int randomIndex = Random.Range(0, sfx.Length);
        PlaySFX(randomIndex);
    }
}
