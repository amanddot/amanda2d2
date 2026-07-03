using UnityEngine;

public class controleMuro1 : MonoBehaviour
{
    // Esta linha TEM de ser "public" para aparecer no Unity!
    public GameObject particulaPrefab; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (particulaPrefab != null)
            {
                Instantiate(particulaPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}