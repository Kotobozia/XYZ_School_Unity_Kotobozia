using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private HeroScript _hero;
    
    private void Awake()
    {
        _hero = GetComponent<HeroScript>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        _hero.SetDirection(horizontal);

        if (Input.GetButtonUp("Fire1"))
        {
            _hero.SaySomething();
        }
    }
}
