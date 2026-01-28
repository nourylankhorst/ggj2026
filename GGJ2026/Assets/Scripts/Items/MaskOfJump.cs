using UnityEngine;

public class MaskOfJump : MonoBehaviour
{
    public bool equipped;
    public int totalJumps = 0;
    public Player player;
    public RaycastHit hit;
    private int maxDistance = 2;
    private Vector3 origin;
    private Vector3 direction;
    public void Update()
    {
        if (Physics.Raycast(origin, direction, out hit, maxDistance))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                equipped = true;
                player.equipped = "MaskOfJump";
            }
        }
    }
    public void Start()
    {
        origin = transform.position;
        direction = transform.forward;
    }
}
