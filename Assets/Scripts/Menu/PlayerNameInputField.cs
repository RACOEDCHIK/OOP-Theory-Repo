using TMPro;
using UnityEngine;

public class PlayerNameInputField : MonoBehaviour
{
    [SerializeField] private TMP_InputField _playerNameInputField;

    public void RecordPlayerName()
    {
        if (_playerNameInputField != null)
            DataManager._instance.PlayerName = _playerNameInputField.text;
        else
            Debug.LogError("Missing InputField!");
    }
}
