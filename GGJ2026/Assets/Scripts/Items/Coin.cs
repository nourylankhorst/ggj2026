using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Coin : MonoBehaviour
{
    public string Score;
    public float score;
    public float scoreGain;
    public GameObject coin;
    public GameObject scoreUI;

    private void Start()
    {
        
    }
    private void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            score += scoreGain;
        }
    }
}
