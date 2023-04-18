using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using BuutonSourse;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Text MoneyIndex;
    [SerializeField] private Text FoodIndex;
    [SerializeField] private Text ElectricityIndex;

    private MoneyButton moneyButton = new MoneyButton();
    private FoodButton foodButton = new FoodButton();
    private ElectricityButton electricityButton = new ElectricityButton();

    private void Update()
    {
        if(moneyButton.Money == 0 ||
            foodButton.Food == 0 ||
            electricityButton.Electricity == 0)
            SceneManager.LoadScene(2);
    }

    public void TapMoney()
    {
        MoneyIndex.text = moneyButton.Add(15).ToString() + '$';
        FoodIndex.text = foodButton.TakeAway(7).ToString();
        ElectricityIndex.text = electricityButton.TakeAway(4).ToString() + '%';
    }

    public void TapFood()
    {
        if (foodButton.Food < 300)
        {
            FoodIndex.text = foodButton.Add(5).ToString();
            ElectricityIndex.text = electricityButton.TakeAway(2).ToString() + '%';
        }
    }

    public void TapElectricity()
    {
        if(electricityButton.Electricity < 100)
        {
            ElectricityIndex.text = electricityButton.Add(100).ToString() + '%';
            MoneyIndex.text = moneyButton.TakeAway(100).ToString() + '$';
        }
    }
}