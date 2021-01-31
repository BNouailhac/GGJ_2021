using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XP_system : MonoBehaviour
{
    public int XP;
    public int level;
    public int next_level;
    public int Point_bonus;
    public int objectiv;

    // Start is called before the first frame update
    void Start()
    {
        XP = 0;
        objectiv = 3;
        level = 1;
        next_level = 10;
        GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = "You still need " + objectiv.ToString() + " key";
    }

    // Update is called once per frame
    void Update()
    {
        if (XP >= next_level)
        {
            next_level += 10;
            XP = 0;
            Point_bonus += 5;
            level += 1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            XP += 1;
        }
        if (other.tag == "key")
        {
            objectiv -= 1;
            if (objectiv != 0)
                GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = "You still need " + objectiv.ToString() + " key";
            if (objectiv == 0)
                GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = "You must find the exit door !";
            other.gameObject.SetActive(false);
        }
        if (other.tag == "Finish")
        {
            if (objectiv == 0)
                GameObject.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = "END";
        }
    }
}
