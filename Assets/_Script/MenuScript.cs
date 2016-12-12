using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    [Header("UI Objects")]

    public Text InstructionLabel;

    // Use this for initialization
    void Start ()
    {
        this.InstructionLabel.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Instruction()
    {
        if (this.InstructionLabel.gameObject.activeInHierarchy == false)
        {
            this.InstructionLabel.gameObject.SetActive(true);
        }
        else
        {
            this.InstructionLabel.gameObject.SetActive(false);
        }
    }
}
