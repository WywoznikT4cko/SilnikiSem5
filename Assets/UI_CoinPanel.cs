using System.Threading;
using TMPro;
using UnityEngine;

public class UI_CoinPanel : MonoBehaviour
{
    public PlayerCoin playerCoin;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        playerCoin.OnAddCoin += PlayerCoin_OnAddCoin;
        playerCoin.OnCountInnit += PlayerCoin_OnCountInnit;
    }

    private void PlayerCoin_OnCountInnit(int count)
    {
        coinText.text = count.ToString();
    }

    private void PlayerCoin_OnAddCoin(int count)
    {
        coinText.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
