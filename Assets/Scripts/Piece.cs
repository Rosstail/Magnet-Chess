using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] public List<Vector2> simpleMovements;
    [SerializeField] public List<Vector2> simpleAttacks;
    [SerializeField] public List<Vector2> infiniteMovements;
    [SerializeField] public List<Vector2> infiniteAttacks;
    [SerializeField] public bool canJumpPieces = false;
    [SerializeField] public string team = "lights";


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Taken()
    {
        gameObject.SetActive(false);
    }
}