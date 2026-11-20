using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerCoin count))
        {
            count.AddCoin(+value);
            Destroy(gameObject);
        }
    }
}
