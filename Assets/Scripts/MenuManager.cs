using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI jumpCountText;
    public TextMeshProUGUI timerText;    

    void Start()
    {
       
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;                 

        
        jumpCountText.text = "Pulos: " + GameData.jumpCount;
        timerText.text = "Tempo: " + GameData.totalTime.ToString("F2") + " segundos";
    }
}
