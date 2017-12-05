using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGame : MonoBehaviour {

    private void Start()
    {
        StartCoroutine(WaitAndLoad(50f, "lastVanguardE"));

    }
    private IEnumerator WaitAndLoad(float value, string scene)
    {
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene(scene,LoadSceneMode.Single);
    }
}
