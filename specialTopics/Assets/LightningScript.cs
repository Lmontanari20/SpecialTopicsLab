using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningScript : MonoBehaviour
{
    public GameObject ps;
    public float sec;


    void Start()
    {
        StartCoroutine(ActivateCoroutine());
    }

    private IEnumerator ActivateCoroutine()
    {
        yield return new WaitForSeconds(sec);
        Debug.Log("should be setting active rn");
        ps.SetActive(true);

        yield return new WaitForSeconds(5);

        ps.SetActive(false);
        StartCoroutine(ActivateCoroutine());
    }


}
