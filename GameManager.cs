using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private GameObject _finishWindow;
    [SerializeField] private CoinManager _coinManager;

    //мое
    [SerializeField] private AudioSource _soundStartClick;
    [SerializeField] private AudioSource _soundBackgroundMusic;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
        _soundStartClick.Play();
        _soundBackgroundMusic.Play();
    }


    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
        _soundBackgroundMusic.Stop();
    }

    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            _coinManager.SaveToProgress();
            SceneManager.LoadScene(next);
        }

    }
}
