using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animal[] tiere;

    void Start()
    {
        foreach (Animal tier in tiere)
        {
            tier.MakeNoise(); // Katze -> "Miau!", Hund -> "Wuff!"
            tier.Jump();
            Debug.Log("Spieler heiﬂt: " + PlayerData.Instance.PlayerName);

        }
    }

    private void Update()
    {
        foreach(Animal tier in tiere)
        {
            tier.Move();
        }
    }
}
