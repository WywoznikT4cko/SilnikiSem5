using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    private int count;
    public int coinForHealthThreashold = 10;
    public event Action<int> OnAddCoin;
    public event Action<int> OnCountInnit;
    private PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
        OnCountInnit?.Invoke(count);
    }

    public void AddCoin(int coinToAdd)
    {
        count += coinToAdd;
        CheckForHeal();
        OnAddCoin?.Invoke(count);
    }

    private void CheckForHeal()
    {
        if (count >= coinForHealthThreashold)
        {
            count = count - coinForHealthThreashold;
            Debug.Log("10!");
            if (playerHealth != null)
            {
                HealPlayerForCoins();
            }
            else if (TryGetComponent<PlayerHealth>(out PlayerHealth healthComponent))
            {
                playerHealth = healthComponent;
                HealPlayerForCoins();
            }
            else
            {
                Debug.LogError("Health Component in not in the same game object as Player Coin");
            }

        }
    }

    private void HealPlayerForCoins()
    {
        playerHealth.AddHealth(playerHealth.maxHealth);
    }
}
