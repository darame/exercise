using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using static UnityEngine.Rendering.DebugUI;

public class MenuUI : MonoBehaviour
{
    public static string playerName;
    [SerializeField] GameObject inputField;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        playerName = inputField.GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
      
    }
}
