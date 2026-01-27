using UnityEngine;

public class customCursor : MonoBehaviour
{
    RectTransform rectTransform;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        rectTransform.position = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
            rectTransform.localScale = Vector3.one * 0.9f;

        if (Input.GetMouseButtonUp(0))
            rectTransform.localScale = Vector3.one;
    }
}
