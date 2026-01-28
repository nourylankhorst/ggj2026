using UnityEngine;

public class uIManager : MonoBehaviour
{
    // every script requires one public (class name) (<==);
    public bool paused = false;
    public Player player;
    public PlayerCam playerCam;
    public GameObject startUI;
    public GameObject pauseUI;
    public GameObject quitUI;

    public void Start()
    {
        player.enabled = false;
        playerCam.enabled = false;
        pauseUI.SetActive(false);
        quitUI.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void StartGame()
    {
        player.enabled = true;
        playerCam.enabled = true;
        startUI.SetActive(false);
    }
    public void Pause()
    {
        paused = !paused;
        Time.timeScale = paused ? 0f : 1f;
        pauseUI.SetActive(paused);
        playerCam.paused = !playerCam.paused;
    }
    public void GameQuit(float quit)
    {
        if (quit == 0)
        {
            pauseUI.SetActive(false);
            pauseUI.SetActive(false);
            quitUI.SetActive(true);
            quitUI.SetActive(true);
        }
        if (quit == 1)
        {
            Quit();
        }
        if (quit == 2)
        {
            quitUI.SetActive(false);
            quitUI.SetActive(false);
            Pause();
        }
    }
    private void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }
}
