using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this, 3f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDestroy() {
			SceneManager.LoadScene("fase1");
	}
}
