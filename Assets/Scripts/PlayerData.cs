using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static PlayerData Instance; // Singleton

    public string PlayerName;

    private void Awake()
    {
        // Singleton Setup
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // bleibt beim Szenenwechsel bestehen
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnNameEntered(string input)
    {
        PlayerData.Instance.PlayerName = input;
    }
}

