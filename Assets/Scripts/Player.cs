using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Inventory")]
    public int numberOfFood;
    public int numberOfWater;
    public int numberOfMedicine;

    [Header("Character Data")]
    public int foodLevel;
    public int waterLevel;
    public int medicineLevel;

    public TextMeshProUGUI foodLevelText;
    public TextMeshProUGUI waterLevelText;
    public TextMeshProUGUI medicineLevelText;
    
    [Header("Character Relations")]
    public int sara;
    public int bigBro;
    public int papa;


    private void Update()
    {
        foodLevelText.text = foodLevel + "%";
        waterLevelText.text = waterLevel + "%";
        medicineLevelText.text = medicineLevel + "%";
    }
    public void EatAndDrinkAndTakeMedicine()
    {
        foodLevel += 25;
        waterLevel += 25;
        medicineLevel += 25;
    }
    public void IncreaseRelation(string character)
    {
        if (character == "Sara")
        {
            sara++;
        }
        else if (character == "Big Bro")
        {
            bigBro++;
        }
        else if (character == "Papa")
        {
            papa++;
        }
    }
    public void DecreaseRelation(string character)
    {
        if (character == "Sara")
        {
            sara--;
        }
        else if (character == "Big Bro")
        {
            bigBro--;
        }
        else if (character == "Papa")
        {
            papa--;
        }
    }
}
