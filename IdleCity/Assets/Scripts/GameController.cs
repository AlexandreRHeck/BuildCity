using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{


    [Header("Gerenciamento Sprites HUD")]

    public Sprite[] icoCoin; // 0 -moeda inativa , 1 - moeada ativa
    public Sprite[] slotBg; // 0 - inativo, 1 - ativo
    public Sprite[] bgUpgradeHud; // 0 - inativo , 1 - ativo, 2 maximizado

    [Header("HUD GAMEPLAY")]
    public GameObject panelFume;
    public Text coinTxt;
    public Text gemsTxt;

    public GameObject panelQuest;
    public Text questTxt;
    public bool isQuest; //Indica quest Ativa
    public int idQuest; //indice da quest atual
    [TextArea]
    public string[] questDescription; //descriçao da quest

    /// variaveis de game play
    private double gold;
    private int gems;

    // Start is called before the first frame update
    void Start()
    {
        panelFume.SetActive(false);
        panelQuest.SetActive(false);

        if (isQuest == true) { panelQuest.SetActive(true); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
