using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    private int count;
    public event Action<int> OnAddCoin;
    public event Action<int> OnCountInnit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
        OnCountInnit?.Invoke(count);
    }

    public void AddCoin(int coinToAdd)
    {
        count += coinToAdd;
        OnAddCoin?.Invoke(count);
    }

}
