using TMPro;
using UnityEngine;

public class UI_StatisticPanel : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;
    public PlayerCoin playerCoin;
    public TextMeshProUGUI coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerHealth.OnAddHealth += PlayerHealth_OnAddHealth;
        playerHealth.OnHealthInnit += PlayerHealth_OnHealthInnit;
        playerCoin.OnAddCoin += PlayerCoin_OnAddCoin;
        playerCoin.OnCountInnit += PlayerCoin_OnCountInnit;
    }

    private void PlayerCoin_OnCountInnit(int count)
    {
        ModifyCoinText(count);
    }
    private void PlayerCoin_OnAddCoin(int count)
    {
        ModifyCoinText(count);
    }

    private void ModifyCoinText(int count)
    {
        coinText.text = "Coins " + count.ToString();
    }


    private void PlayerHealth_OnHealthInnit(int health)
    {
        ModifyHealthText(health);
    }

    private void PlayerHealth_OnAddHealth(int health)
    {
        ModifyHealthText(health);
    }

    private void ModifyHealthText(int health)
    {
        healthText.text = "Health " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
