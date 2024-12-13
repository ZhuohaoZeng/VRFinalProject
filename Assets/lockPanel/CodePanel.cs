using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CodePanel : MonoBehaviour
{
    public GameObject[] codeSquares;
    public GameObject redSquare; 
    public GameObject keyPrefab; 
    private int[] currentCode = new int[4];
    private int[] incorrectCode = {0,0,0,0};
    private int[] correctCode = {7,6,1,6};
    public bool floor1 = true;
    public DamageAddition health;

    void Start()
    {
        for (int i = 0; i < currentCode.Length; i++)
        {
            currentCode[i] = 0;
        }
    }

    public bool HandleSquareHit(GameObject square)
    {
        if (IsCodeSquare(square, out int index))
        {
            IncrementSquare(index);
            return false;
        }
        else if (square == redSquare)
        {
            return CheckCode();
        }
        return false;
    }

    private bool IsCodeSquare(GameObject obj, out int index)
    {
        index = System.Array.IndexOf(codeSquares, obj);
        return index >= 0;
    }

    private void IncrementSquare(int index)
    {
        currentCode[index] = (currentCode[index] + 1) % 10;
        TextMeshPro textMesh = codeSquares[index].GetComponent<TextMeshPro>();
        if (textMesh != null)
        {
            textMesh.text = currentCode[index].ToString();
        }
    }

    private bool CheckCode()
    {
        for (int i = 0; i < currentCode.Length; i++)
        {
            if (currentCode[i] != correctCode[i])
            {
                health.dealDamage(2.0f);
                return false;
            }
        }
        return true;


    }
}
