using UnityEngine;
public class LoadAndSaveData : MonoBehaviour
{
    public static LoadAndSaveData instance;

    public object CurrentSceneManager { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de LoadAndSaveData dans la scène");
            return;
        }

        instance = this;
    }

    void Start()
    {
    }

    public void SaveData()
    {
    }
}
