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

    public TextMeshProUGUI numberOfFoodText;
    public TextMeshProUGUI numberOfWaterText;
    public TextMeshProUGUI numberOfMedicineText;

    [Header("Character Relations")]
    public int sara;
    public int bigBro;
    public int papa;

    private void Awake()
    {
        int numberOfPlayerOBJ = FindObjectsByType<Player>(FindObjectsSortMode.None).Length;

        if (numberOfPlayerOBJ > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        foodLevelText.text = foodLevel + "%";
        waterLevelText.text = waterLevel + "%";
        medicineLevelText.text = medicineLevel + "%";

        numberOfFoodText.text = "Food: " + numberOfFood;
        numberOfWaterText.text = "Water: " + numberOfWater;
        numberOfMedicineText.text = "Medicine: " + numberOfMedicine;
    }
    public void EatAndDrinkAndTakeMedicine()
    {
        foodLevel += 25;
        waterLevel += 25;
        medicineLevel += 25;
    }
    public void DontEatAndDrinkAndTakeMedicine()
    {
        foodLevel -= 25;
        waterLevel -= 25;
        medicineLevel -= 25;
    }
    public void IncreaseSupply()
    {
        numberOfFood++;
        numberOfWater++;
        numberOfMedicine++;
    }
    public void DecreaseSupply()
    {
        numberOfFood--;
        numberOfWater--;
        numberOfMedicine--;
    }

    public void LoseEverything()
    {
        numberOfFood = 0;
        numberOfWater = 0;
        numberOfMedicine = 0;
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
