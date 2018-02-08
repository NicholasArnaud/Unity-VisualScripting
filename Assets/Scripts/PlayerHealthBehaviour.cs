using UnityEngine;

public class PlayerHealthBehaviour : MonoBehaviour
{

    public FloatVariable health;

    void Start()
    {
        health.Value = 100;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health.Value -= 5;
        }
    }
}
