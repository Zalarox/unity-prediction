using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    int curScene = 0;
    public GameObject playButton;
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadNext()
    {
        curScene++;
        SceneManager.LoadScene(curScene, LoadSceneMode.Single);
        if (curScene == 1)
        {
            playButton.SetActive(false);
            DontDestroyOnLoad(GameObject.Find("Canvas"));
        }
    }
    
    public void LoadCurrent()
    {
        SceneManager.LoadScene(curScene, LoadSceneMode.Single);
    }
}
