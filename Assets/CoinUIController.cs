using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinText;
    [SerializeField] private Button _addCoinButton;
    private DataCoin _dataCoin;

    private void Start()
    {
        _dataCoin = new DataCoin();
        UpdateUI();
        
        _addCoinButton.onClick.AddListener(OnAddCoinButtonClicked);
    }

    /// <summary>
    /// Обновляем текст на UI
    /// </summary>
    private void UpdateUI()
    {
        _coinText.text = $"Coins: {_dataCoin.Coin}";
    }

    /// <summary>
    /// Логика для кнопки добавления денег
    /// </summary>
    private void OnAddCoinButtonClicked()
    {
        _dataCoin.AddCoins(10); // Добавляем 10 монет
        UpdateUI(); // Обновляем UI
    }
}
