using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject PressAnyWave; //�I�����N�B�r
    public GameObject MenuButtons; //�D�����s
    public GameObject HowPlayUI; //�C���覡����
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PressAnyWave.SetActive(true);
        MenuButtons.SetActive(false);
        HowPlayUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (PressAnyWave.activeInHierarchy && Input.anyKeyDown)
        {
            PressAnyWave.SetActive(false);
            MenuButtons.SetActive(true);
        }
    }
    public void GameStart(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void HowPlay()
    {
        HowPlayUI.SetActive(true);
    }
    public void BackMenu()
    {
        HowPlayUI.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
