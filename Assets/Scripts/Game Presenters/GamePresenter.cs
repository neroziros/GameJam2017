using UnityEngine;
using System.Collections;
using System.Linq;

public class GamePresenter : MonoBehaviour {
    // Singleton
    private static GamePresenter _instance = null;
    public static GamePresenter Instance
    {
        get { return GamePresenter._instance; }
    }

    // Core presenters
    public PlayerPresenter PlayerPresenter { get; private set; }
    public EnvironmentPresenter EnvironmentPresenter { get; private set; }
    public CoreUIPresenter UiPresenter { get; private set; }
    public AudioPresenter AudioPresenter { get; private set; }

    // Match parameters
    public State CurrentMatchState = State.NonStarted;
    public float MatchDuration = 180.0f;
    
    // Match time controls
    public float CurrentMatchDuration = 0.0f;
    private PlayerController winnerPlayer;
    void Awake()
    {
        // Set singleton refere
        GamePresenter._instance = this;
    }

    /// <summary>
    /// Only this player component must use the start and update methods
    /// </summary>
    void Start () {

	    // Get core presenters
        this.PlayerPresenter = this.GetComponentInChildren<PlayerPresenter>();
        this.EnvironmentPresenter = this.GetComponentInChildren<EnvironmentPresenter>();
        this.UiPresenter = this.GetComponentInChildren<CoreUIPresenter>();
        this.AudioPresenter = this.GetComponentInChildren<AudioPresenter>();

        // Initialize core presenters
        this.EnvironmentPresenter.Initialize();
        this.PlayerPresenter.Initialize(this.EnvironmentPresenter);
        this.UiPresenter.Initialize();
        //this.AudioPresenter.Initialize(true);

        // Display connected gamepad
        this.PrintGamepad();

        // Start game
        this.CurrentMatchState = State.Running;

    }
	
	// Update is called once per frame
	private  void Update ()
	{
        if (this.CurrentMatchState != GamePresenter.State.Running)
            return;

        this.UpdateMatchTimer();

	    CheckPlayers();
	}

    private void CheckPlayers()
    {
        int currentAlivePlayers = PlayerPresenter.Players.Count(player => player.IsAlive);

        // Check if there is only one winner
        if (currentAlivePlayers == 1)
        {
            for (int index = 0; index < PlayerPresenter.Players.Length; index++)
            {
                var player = PlayerPresenter.Players[index];
                if (player.IsAlive)
                {
                    winnerPlayer = player;
                    UiPresenter.RequestWinScreen(index);
                    EndMatch();
                    return;
                }
            }
        }
    }

    // Ends the match
    public void EndMatch()
    {
        // Set end game state
        this.CurrentMatchState = State.Ended;
    }


    // Update match timer
    private void UpdateMatchTimer()
    {
        this.CurrentMatchDuration += Time.deltaTime;
        if (this.CurrentMatchDuration >= this.MatchDuration && this.MatchDuration > 0)
            this.EndMatch();
    }

    #region Debug
    void PrintGamepad()
    {
        if (Input.GetJoystickNames().Length <= 0) return;

        int i = 0;
        while (i < Input.GetJoystickNames().Length)
        {
            Debug.Log(Input.GetJoystickNames()[i]);
            i++;
        }
    }
    #endregion

    public enum State
    {
        NonStarted,
        Running,
        Ended
    }

    public enum EndGameMessage
    {
        Winner,
        Defeated,
        Draw
    }
}
