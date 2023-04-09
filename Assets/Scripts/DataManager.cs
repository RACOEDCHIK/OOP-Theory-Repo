using UnityEngine;

public class DataManager : MonoBehaviour
{
    [HideInInspector] public static DataManager _instance { get; private set; }
    private string _playerName;
    public string PlayerName
    {
        set 
        {
            if (value.Length <= 10)
                _playerName = value;
        }
    }
    
    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
