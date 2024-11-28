using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI jumpCountText; // Texto para exibir o número de pulos
    public TextMeshProUGUI timerText;     // Texto para exibir o tempo decorrido

    void Start()
    {
        // Ativa o cursor ao carregar a cena do menu
        Cursor.lockState = CursorLockMode.None; // Libera o cursor
        Cursor.visible = true;                 // Torna o cursor visível

        // Exibe os dados armazenados em GameData
        jumpCountText.text = "Pulos: " + GameData.jumpCount;
        timerText.text = "Tempo: " + GameData.totalTime.ToString("F2") + " segundos";
    }
}
