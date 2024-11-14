using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject[] hearts;
    private int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(hearts[i]);
        i++;
        if (i >= 3)
        {
            Debug.Log("Game Over!");
            Application.Quit();
            i = 0;
        }
    }
}
