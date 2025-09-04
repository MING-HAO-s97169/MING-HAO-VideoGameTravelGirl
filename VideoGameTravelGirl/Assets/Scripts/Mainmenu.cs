using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject PressAnyWave; //點擊任意處字
    public GameObject MenuButtons; //主選單按鈕
    public GameObject HowPlayUI; //遊玩方式介面
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
