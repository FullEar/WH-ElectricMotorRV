using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PiecesManager : MonoBehaviour
{
    public GameObject[] pieces;
    int npiece;
    public int maxLimitPieces = 10;
    
    public string[] name;
    [TextArea(3, 10)] public string[] description;
    public TextMeshProUGUI displayText;
    public TextMeshProUGUI nameText;

   
    
    // Start is called before the first frame update
    void Awake()
    {
        npiece = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (npiece)
        {
            case 1:
                ActivePiece(0);
                return;
            case 2:
                ActivePiece(1);
                return;
            case 3:
                ActivePiece(2);
                return;
            case 4:
                ActivePiece(3);
                return;
            case 5:
                ActivePiece(4);
                return;
            case 6:
                ActivePiece(5);
                return;
            case 7:
                ActivePiece(6);
                return;
            case 8:
                ActivePiece(7);
                return;
            case 9:
                ActivePiece(8);
                return;
            case 10:
                ActivePiece(9);
                return;
        }
    }

    public void NextPiece()
    {
        npiece++;
        if (npiece > maxLimitPieces) npiece = 1;
    }

    public void BackPiece()
    {
        npiece--;
        if (npiece < 1) npiece = maxLimitPieces ;
       
    }
    
    void ActivePiece(int activePiece)
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i].SetActive(false);
        }
        pieces[activePiece].SetActive(true);

        nameText.text = name[activePiece];
        displayText.text = description[activePiece];

    }
}
