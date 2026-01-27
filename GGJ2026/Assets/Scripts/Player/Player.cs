using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Movement")]
    public float movementSpeed = 4;
    public float jumpHeight = 7;
    public bool isGrounded = false;
    public Rigidbody rb;
    private Vector3 moveDir;
    private float hor;
    private float vert;

    [Header("Extra Stuff")]
    public string equipped;
    public MaskOfJump maskOfJump;

    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        moveDir.x = hor;
        moveDir.z = vert;
        transform.Translate(moveDir * Time.deltaTime * movementSpeed);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = 10;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 5;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
            maskOfJump.totalJumps = 1;
        }
    }
}
