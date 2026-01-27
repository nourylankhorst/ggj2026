using UnityEngine;

public class MaskOfJump : MonoBehaviour
{
    public bool equipped;
    public int totalJumps = 0;
    private Player player;
    public void Update()
    {
        if (player.equipped == "MaskOfJump")
        {
            equipped = !equipped;
            if (player.isGrounded == false && Input.GetKeyDown(KeyCode.Space) && totalJumps > 0)
            {
                totalJumps--;
                player.rb.AddForce(Vector3.up * player.jumpHeight, ForceMode.Impulse);
            }
            else
            {
                totalJumps = 1;
            }
        }
        else
        {
            equipped = false;
        }
    }
}
