using UnityEngine;

public class start : MonoBehaviour
{
    // every script requires one public (class name) (<==);
    public bool paused = false;
    public Player player;
    public PlayerCam playerCam;
    public GameObject startUI;
    public GameObject pauseUI;

    public void Start()
    {
        player.enabled = false;
        playerCam.enabled = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            Time.timeScale = paused ? 0f : 1f;
            player.enabled = false;
            playerCam.enabled = false;
            pauseUI.SetActive(true);
        }
    }
    public void StartGame()
    {
        player.enabled = true;
        playerCam.enabled = true;
        pauseUI.SetActive(false);
        startUI.SetActive(false);
    }
}
