using UnityEngine;

public class Dog : Animal
{
    public float dogMultiplier = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Name = "Minatestetdielangedesnamensmkay";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void MakeNoise()
    {
        Debug.Log(Name + " sagt: Wuff!");
    }
    public override void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * dogMultiplier);
    }

    public override void Jump()
    {
        transform.Translate(Vector3.up * speed * dogMultiplier);
    }
}
