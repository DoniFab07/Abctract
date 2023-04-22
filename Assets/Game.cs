using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Weappon pistol = new Pistol();
    private Weappon rifle = new rifle();
    private Weappon[] massiWeappons;
    void Start()
    {
        massiWeappons = new[] {pistol, rifle};
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
