using UnityEngine;

public class start : MonoBehaviour
{
    // every script requires one public (class name) (<==);
    public Player player;
    public PlayerCam playerCam;

    public void StartGame()
    {
        player.enabled = false;
    }
}
