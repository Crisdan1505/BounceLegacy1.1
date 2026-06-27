using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int legacyCrystals = 0;

    public static event Action<int> OnCrystalChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        OnCrystalChanged?.Invoke(legacyCrystals);
    }

    public void AddCrystal(int amount)
    {
        legacyCrystals += amount;

        OnCrystalChanged?.Invoke(legacyCrystals);

        Debug.Log("Legacy Crystals: " + legacyCrystals);
    }
}