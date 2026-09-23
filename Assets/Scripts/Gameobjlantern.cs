using UnityEngine;

public class LanternPickup : MonoBehaviour
{
    public GameObject playerLantern;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        playerLantern.SetActive(true);
        Destroy(gameObject);
    }
}