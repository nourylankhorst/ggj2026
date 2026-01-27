using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float mouseSensitivity = 400f;
    public Transform playerBody;
    float xRotation = 0f;
    public bool paused = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = !paused ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = paused;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
