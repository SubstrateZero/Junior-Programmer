using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class TitleScreenManager : MonoBehaviour
{
    public TMP_InputField inputField; // im Inspector zuweisen

    // Wird vom InputField aufgerufen, wenn der Spieler Enter drückt oder das Feld verlässt
    public void OnNameEntered(string input)
    {

    }

    // Wird vom Start-Button aufgerufen
    public void OnStartGame()
    {
        PlayerData.Instance.PlayerName = inputField.text;
        Debug.Log("Spielername gespeichert: " + PlayerData.Instance.PlayerName);
        SceneManager.LoadScene(1); // Name deiner Main-Szene
    }
}
