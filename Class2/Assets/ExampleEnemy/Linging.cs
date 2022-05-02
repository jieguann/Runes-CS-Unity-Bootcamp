using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linging : MonoBehaviour
{
    //public Hero heroTest;

    public List<float> m_floats = new List<float>();

    public float x = 0;
    private bool m_available => x < 0; //if x > 0, it is true

    private void Update()
    {
        Debug.Log(m_available);
    }


    private void Start()
    {
        float totalFloats = m_floats.Sum();

        float sumOfFloatGreaterThan5 = m_floats.Where(t => t > 5).Sum();

        var myList = m_floats.Where(t => t > 5);
    }

    public List<Hero> m_heros = new List<Hero>();

    private void Awake()
    {
        bool checkName = m_heros.Any(t => t.Name == "Jean");
        bool checkNameAndHealth = m_heros.Any(t => t.Name == "Emiliano" && t.Health > 0);

        //float avgDamage = m_heros.Average(t => t.Damage);

        var allWizard = m_heros.Where(t => t.Class == HeroType.Wizard);

        List<Hero> myUniqueHeros = m_heros.Distinct().ToList();

        var herosGrouped = m_heros.GroupBy(t => t.Class);

        foreach(var heroes in herosGrouped)
        {
            Debug.Log(heroes.Key);
            foreach(var hero in heroes)
            {
                Debug.Log(hero);
            }
        }
    }
}

public class Hero
{
    public string Name;
    public float Health;
    public float Damage;
    public HeroType Class;
}

public enum HeroType
{
    Wizard, Knight, Archer
}
