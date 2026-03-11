using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int playerMoney;
    public int currentLevel;
    public int fishIndex;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        playerMoney = 0;
        currentLevel = 1;
        fishIndex = 0;
    }

    public void AddMoney(int amount)
    {
        playerMoney += amount;
    }

    public void LevelUp()
    {
        currentLevel++;
    }

    public void SetFishIndex(int index)
    {
        fishIndex = index;
    }
}