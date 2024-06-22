using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

/// <summary>
/// UI - Slider ������Ʈ�� �ִ� ������Ʈ�� �� Ŭ���� ����(Add)�ؾ��Ѵ�.
/// </summary>
public class VolumeController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    public string mixerParameterName; // BGM, SFX �ۼ����ִ� ����.
    public float sliderMultipliers = 25;   //    ~1,0������ Slider Value�� �� ũ�� ���̱� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(SliderValue);
        slider.minValue = 0.0001f;
    }

    public void SliderValue(float value)
    {
        audioMixer.SetFloat(mixerParameterName, Mathf.Log10(value) * sliderMultipliers);
        Debug.Log(Mathf.Log10(value));
    }
}
