using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public float numBoxes = 0;
    public TextMeshProUGUI text;
    public GameObject textObj;
    public Rigidbody player;
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
        if(other.gameObject.tag == "Box")
        {
            numBoxes++;
        }
        if(other.gameObject.tag == "Player")
        {
            WinScreen();
        }
    }

    void WinScreen()
    {
        text.text = "Congratulations, you delivered " + numBoxes.ToString() + " packages!";
        textObj.SetActive(true);
        player.constraints = RigidbodyConstraints.FreezePosition;
    }
}
