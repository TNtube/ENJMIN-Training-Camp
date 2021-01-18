using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tutorialScript : MonoBehaviour
{

    public GameObject textObject;
    public Text tutorialText;

    public GameObject rock;
    public GameObject button;

    public int state;
    public bool one;
    public bool two;
    public bool done1;
    public bool three;
    public bool four;
    public bool done2;
    public bool five;
    public bool six;
    public bool done3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tutorial1());
    }

    public IEnumerator Tutorial1()
    {
        switch (state)
        {
            case 0:
                textObject.SetActive(true);
                tutorialText.text = "Press right click and move the mouse to move the camera around the platform.";
                two = true;
                break;

            case 1:
                yield return new WaitForSeconds(2f);
                textObject.SetActive(true);
                Instantiate(rock);
                tutorialText.text = "Select the rock by left clicking it; hold left click and move mouse to move it around.";
                four = true;
                break;

            case 2:
                textObject.SetActive(true);
                tutorialText.text = "Release left click to let the rock fall.";
                yield return new WaitForSeconds(2f);
                five = true;
                break;

            case 3:
                textObject.SetActive(true);
                tutorialText.text = "Objects all have a certain weight. Make sure to drop them in a way that won't make the platform flip!";
                break;

        }

    }


    public void Update()
    {
        if (Input.GetMouseButton(1))
        {
            one = true;
        }

        if (one == true && two == true && done1 == false)
        {
            state = 1;
            done1 = true;
            StartCoroutine(Tutorial1());
        }

        if (three == true && four == true && done2 == false)
        {
            state = 2;
            done2 = true;
            StartCoroutine(Tutorial1());
        }

        if (five == true && six == true && done3 == false)
        {
            state = 3;
            done3 = true;
            StartCoroutine(Tutorial1());
        }

    }
}
