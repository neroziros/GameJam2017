using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnvironmentPresenter : MonoBehaviour
{
    [SerializeField]
    private Transform[] _possibleSpawnPoints = new Transform[4];
    
    [SerializeField]
    private WallSetPresenter[] _possibleStages = new WallSetPresenter[4];

    private int currentStage = 0;

    public float InitialDelay = 15.0f;

    public float StageChangeInterval = 30.0f;

    // Use this for initialization
    public void Initialize()
    {
        StartCoroutine("PossibleStagesProcess");
    }

    IEnumerator PossibleStagesProcess()
    {
        yield return new WaitForSeconds(InitialDelay);

        while (GamePresenter.Instance.CurrentMatchState != GamePresenter.State.Ended)
        {
            if (GamePresenter.Instance.CurrentMatchState == GamePresenter.State.Running)
            {
                _possibleStages[currentStage].Display();
                
                yield return new WaitForSeconds(StageChangeInterval);

                _possibleStages[currentStage].Hide();
                currentStage = (currentStage+1)% _possibleStages.Length;
            }

        }
    }

    public Transform[] GetPossibleSpawnPoints()
    {
        return _possibleSpawnPoints;
    }

    // Returns a random spawn location in a random room
    public Transform GetValidPlayerSpawnTransform()
    {
        // todo: execute proper spawn checks
        return _possibleSpawnPoints[0];
    }

    // Shuffle lists
    Transform[] Reshuffle(Transform[] texts)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < texts.Length; t++)
        {
            Transform tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }

        return texts;
    }
}
