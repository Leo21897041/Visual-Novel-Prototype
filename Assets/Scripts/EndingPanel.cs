using UnityEngine;
using TMPro;

public class EndingPanel : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI foodText;
    public TextMeshProUGUI waterText;
    public TextMeshProUGUI medicineText;

    private void Start()
    {
        player = FindFirstObjectByType<Player>();
    }

    private void Update()
    {
        foodText.text = "Food: " + player.numberOfFood;
        waterText.text = "Water: " + player.numberOfWater;
        medicineText.text = "Medicine: " + player.numberOfMedicine;
    }
}
