using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionsManager : MonoBehaviour
{
    public GameObject[] pieces;
    int npiece =  1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (npiece)
        {
            case 1: PieceAct(0);
                break;
        }
    }

    public void NextPiece()
    {
        npiece++;
        if (npiece > pieces.Length + 1) npiece = 1;
    }
    public void PreviousPiece()
    {
        npiece--;
        if (npiece < 1) npiece = pieces.Length + 1;
    }

    void PieceAct(int piece)
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i].SetActive(false);
        }

        pieces[piece].SetActive(true);
    }
    
}
