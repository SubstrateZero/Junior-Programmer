using UnityEngine;

public class Cat : Animal
{
    public float catMultiplier = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Name = "Bali";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void MakeNoise()
    {
        Debug.Log(Name + " sagt: Miau!");
    }
    public override void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * catMultiplier);
    }

    public override void Jump()
    {
        transform.Translate(Vector3.up * speed * catMultiplier);
    }
}
