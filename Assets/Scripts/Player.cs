using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int numberOfFood;
    public int numberOfWater;
    public int numberOfMedicine;

    public int foodLevel;
    public int waterLevel;
    public int medicineLevel;

    public TextMeshProUGUI foodLevelText;
    public TextMeshProUGUI waterLevelText;
    public TextMeshProUGUI medicineLevelText;

    private void Update()
    {
        foodLevelText.text = foodLevel + "%";
        waterLevelText.text = waterLevel + "%";
        medicineLevelText.text = medicineLevel + "%";
    }
}
