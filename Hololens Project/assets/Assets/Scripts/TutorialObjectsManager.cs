using UnityEngine;
using System.Collections;

public class TutorialObjectsManager : MonoBehaviour {

    public static TutorialObjectsManager Instance { get; private set; }


    public GameObject ThisGameObject { get; private set; }
    public GameObject player { get; private set; }
    public GameObject gunEffect { get; private set; }
    public GameObject enemy { get; private set; }

    void Start () {
        Instance = this;

        ThisGameObject = gameObject;
        player = gameObject.transform.Find("Player").gameObject;
        gunEffect = player.transform.Find("GunParticles").gameObject;
        enemy = gameObject.transform.Find("Enemy").gameObject;
    }
	
}
