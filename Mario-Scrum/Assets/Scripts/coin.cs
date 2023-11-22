using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinValue = 1;
    public int antalcoin=0;

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
        CoinManager.instance.ChangeScore(antalcoin);
        Destroy(gameObject);

    }

  }
}
