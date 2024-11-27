using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI jumpCountText; // Texto para exibir o n�mero de pulos
    public TextMeshProUGUI timerText;     // Texto para exibir o tempo decorrido

    void Start()
    {
        // Exibe os dados armazenados em GameData
        jumpCountText.text = "Pulos: " + GameData.jumpCount;
        timerText.text = "Tempo: " + GameData.totalTime.ToString("F2") + " segundos";
    }
}
