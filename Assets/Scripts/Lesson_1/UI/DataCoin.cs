using UnityEngine;

public class DataCoin
{
    public int Coin { get; private set; }

    /// <summary>
    /// Конструктор для инициализации денег
    /// </summary>
    /// <param name="coin">Начальное количество денег</param>
    public DataCoin(int coin = 0)
    {
        Coin = coin == 0 ? PlayerPrefs.GetInt("Coin", 100) : coin;
    }

    /// <summary>
    /// Добавляем деньги
    /// </summary>
    /// <param name="amount">Количество для добавления</param>
    public void AddCoins(int amount)
    {
        Coin += amount;
        Save();
    }

    /// <summary>
    /// Сохраняем деньги
    /// </summary>
    private void Save()
    {
        PlayerPrefs.SetInt("Coin", Coin);
        PlayerPrefs.Save();
    }
}