using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNovoClick : MonoBehaviour
{
    public void OnClick(){
	    Debug.Log("Clicou");
        SceneManager.LoadScene("fase1");
        
    }
}
