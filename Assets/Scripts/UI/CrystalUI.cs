using TMPro;
using UnityEngine;

public class CrystalUI : MonoBehaviour
{
    public TextMeshProUGUI crystalText;

    private void OnEnable()
    {
        GameManager.OnCrystalChanged += UpdateCrystalText;
    }

    private void OnDisable()
    {
        GameManager.OnCrystalChanged -= UpdateCrystalText;
    }

    private void UpdateCrystalText(int amount)
    {
        crystalText.text = "Legacy Crystals: " + amount;
    }
}