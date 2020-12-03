using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Image _imageLoad;
    private float _timeScale;
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
        _timeScale = 1f;
        Time.timeScale = 1f;
        DontDestroyOnLoad(_imageLoad);
    }
}
