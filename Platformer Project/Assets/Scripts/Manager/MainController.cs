using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    public static MainController instance;

    public GameObject GameOverPanel;

    [Header("Score")]
    public TextMeshProUGUI CurrentScore;
    public TextMeshProUGUI BestScore;
    private float score;

    [Header("Level")]
    public TextMeshProUGUI Level;

    public bool isGameStartl; // ������ �����ߴ��� ���ߴ���[3.. 2.. 1..]

    [Header("Start UI")]
    public TextMeshProUGUI StartCountText; // 3.. 2.. 1
    public GameObject StartUIPanel;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        StartCountText.text = "1";
        yield return new WaitForSeconds(1f);
        StartCountText.text = "2";
        yield return new WaitForSeconds(1f);
        StartCountText.text = "3";
        yield return new WaitForSeconds(1f);
        StartCountText.text = "START";
        yield return new WaitForSeconds(1f);
        isGameStartl = true;
        StartCountText.text = "1";
        yield return new WaitForSeconds(0.3f);
        StartUIPanel.SetActive(false);
    }

    private void Update()
    {
        score = GameManager.instance.score;
        UpdateGUIText();
    }

    private void UpdateGUIText()
    {
        CurrentScore.text = $"�������� : {GameManager.instance.score}";
        Level.text = $"���緹�� : {GameManager.instance.ReturnCurrentDifficulty()}";
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);   // ���� ������ ���� ���� UI Ȱ��ȭ
        // ���� ������ �ְ� �������� ���� �� ����
        if (score > PlayerPrefs.GetFloat(GameData.BestScore))
        {
            PlayerPrefs.SetFloat(GameData.BestScore, score);
            BestScore.text = $"�ְ����� : {GameManager.instance.score}";
        }
        else // ���� ������ �ְ� �������� ���� ��, ������ �ְ� ������ �ҷ��´�.
        {
            BestScore.text = $"�ְ����� : {PlayerPrefs.GetFloat(GameData.BestScore)}";
        }

    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameQuit()
    {
        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

}