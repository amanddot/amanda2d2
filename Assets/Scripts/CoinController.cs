using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour

{
    public GameObject coinParticle;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pontuacao pontuacao = other.GetComponent<Pontuacao>();
            pontuacao.AddPoints();
            Instantiate(coinParticle, this.transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(this.gameObject);
        }
    }
}
