using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    [Header("Scene Selection")]
    public string selectionScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Scene Transitions 
    #region Scene Methods
    public void TransitionToSelection(){
        SceneManager.LoadScene(selectionScreen);
    }

    #endregion
}
