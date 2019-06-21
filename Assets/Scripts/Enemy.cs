using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private float speed = 4f;
	private Transform tr;

    private float direcao = 1;

	void Start () {
		tr = GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update()
    {
        Vector2 posicao = new Vector2(direcao *speed * UnityEngine.Time.deltaTime, 0);
        tr.Translate(posicao);

        tr.localScale = new Vector3(direcao,1,1);

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "parede"){
            direcao = direcao * -1;
        }

    }
}
