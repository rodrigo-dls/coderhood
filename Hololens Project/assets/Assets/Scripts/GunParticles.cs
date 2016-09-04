using UnityEngine;
using System.Collections;

public class GunParticles : MonoBehaviour {

    public void Hide()
    {
        StartCoroutine(WaitForDisable());
    }

    private IEnumerator WaitForDisable()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
