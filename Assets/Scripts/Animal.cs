using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed = 5.0f;
    private string _name;
    private int _alter;

    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length > 15)
            {
                Debug.LogWarning("Name ist zu lang! Kürze ihn auf max. 15 Zeichen.");
                _name = value.Substring(0, 15);
            }
            else
            {
                _name = value;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public virtual void MakeNoise()
    {
        Debug.Log("Das Tier macht ein Geräusch.");
    }
    public virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public virtual void Jump()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
