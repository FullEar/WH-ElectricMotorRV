using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAdvance : MonoBehaviour
{

    public GameObject Dialogue_one;
    public GameObject Dialogue_two;
    public GameObject Dialogue_three;
    public GameObject Dialogue_four;
    public GameObject Dialogue_five;
    public GameObject Dialogue_six;
    public GameObject Dialogue_seven;
    // Start is called before the first frame update
    void Start()
    {
        Dialogue_one.SetActive(true);
        Dialogue_two.SetActive(false);
        Dialogue_three.SetActive(false);
        Dialogue_four.SetActive(false);
        Dialogue_five.SetActive(false);
        Dialogue_six.SetActive(false);
        Dialogue_seven.SetActive(false);
        StartCoroutine(DialogueForward());
    }

    IEnumerator DialogueForward()
    {
        yield return new WaitForSeconds(35f);
        Dialogue_one.SetActive(false);
        Dialogue_two.SetActive(true);
        Dialogue_three.SetActive(false);
        Dialogue_four.SetActive(false);
        Dialogue_five.SetActive(false);
        Dialogue_six.SetActive(false);
        Dialogue_seven.SetActive(false);
        StartCoroutine(DialogueForward1());
    }

    IEnumerator DialogueForward1()
    {
        yield return new WaitForSeconds(8f);
        Dialogue_one.SetActive(false);
        Dialogue_two.SetActive(false);
        Dialogue_three.SetActive(true);
        Dialogue_four.SetActive(false);
        Dialogue_five.SetActive(false);
        Dialogue_six.SetActive(false);
        Dialogue_seven.SetActive(false);
        StartCoroutine(DialogueForward2());
    }

    IEnumerator DialogueForward2()
    {
        yield return new WaitForSeconds(40f);
        Dialogue_one.SetActive(false);
        Dialogue_two.SetActive(false);
        Dialogue_three.SetActive(false);
        Dialogue_four.SetActive(true);
        Dialogue_five.SetActive(false);
        Dialogue_six.SetActive(false);
        Dialogue_seven.SetActive(false);
        StartCoroutine(DialogueForward3());
    }

    IEnumerator DialogueForward3()
    {
        yield return new WaitForSeconds(15f);
        Dialogue_one.SetActive(false);
        Dialogue_two.SetActive(false);
        Dialogue_three.SetActive(false);
        Dialogue_four.SetActive(false);
        Dialogue_five.SetActive(true);
        Dialogue_six.SetActive(false);
        Dialogue_seven.SetActive(false);
        StartCoroutine(DialogueForward4());
    }

    IEnumerator DialogueForward4()
    {
        yield return new WaitForSeconds(40f);
        Dialogue_one.SetActive(false);
        Dialogue_two.SetActive(false);
        Dialogue_three.SetActive(false);
        Dialogue_four.SetActive(false);
        Dialogue_five.SetActive(false);
        Dialogue_six.SetActive(true);
        Dialogue_seven.SetActive(false);
        StartCoroutine(DialogueForward5());
    }

    IEnumerator DialogueForward5()
    {
        yield return new WaitForSeconds(20f);
        Dialogue_one.SetActive(false);
        Dialogue_two.SetActive(false);
        Dialogue_three.SetActive(false);
        Dialogue_four.SetActive(false);
        Dialogue_five.SetActive(false);
        Dialogue_six.SetActive(false);
        Dialogue_seven.SetActive(true);
        StartCoroutine(DialogueForward1());
    }
}


