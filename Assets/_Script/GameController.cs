using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES ++++++++++++++++++
    private int _livesValue;
    private int _scoreValue;
    private AudioSource _endGameSound;
    private int BigShipNum;


    // PUBLIC INSTANCE VARIABLES (TESTING) +++++++++


    [Header("UI Objects")]
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text FinalScoreLabel;
    public Text VictoryLabel;


    [Header("Sound")]
    public AudioSource GameOver;

    // PUBLIC PROPERTIES +++++++++++++++++++++++++++
    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }

    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }


    public void IncreaseScore(int increase)
    {
        _scoreValue += increase;
        this.ScoreLabel.text = "Score: " + this._scoreValue;
    }

    // Use this for initialization
    void Start()
    {
        this.LivesValue = 3;
        this.ScoreValue = 0;

        this.GameOverLabel.gameObject.SetActive(false);
        this.FinalScoreLabel.gameObject.SetActive(false);
        this.VictoryLabel.gameObject.SetActive(false);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);


        this._endGameSound = this.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    private void _endGame()
    {
        this.GameOverLabel.gameObject.SetActive(true);
        this.FinalScoreLabel.text = "Final Score: " + this.ScoreValue;
        this.FinalScoreLabel.gameObject.SetActive(true);
        this.ScoreLabel.gameObject.SetActive(false);
        this.LivesLabel.gameObject.SetActive(false);
        this.GameOver.Play();
    }

    // PUBLIC METHODS ++++++++++++++++++++++++++++++
    public void Victory()
    {
        this.VictoryLabel.gameObject.SetActive(true);
        this.FinalScoreLabel.text = "Final Score: " + this.ScoreValue;
        this.FinalScoreLabel.gameObject.SetActive(true);
        this.ScoreLabel.gameObject.SetActive(false);
        this.LivesLabel.gameObject.SetActive(false);
    }
}
