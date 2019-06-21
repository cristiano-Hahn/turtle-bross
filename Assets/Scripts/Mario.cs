using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mario : MonoBehaviour {

	private float speedh = 7f;
	private float speedv = 12f;
	private bool morreu = false;
	private Transform tr;
	private Collider2D collider;
	private Rigidbody2D rigidBody;
	private bool noChao = true;
	private int contagemDoPulo = 0;

	void Start () {
		tr = GetComponent<Transform>();
		rigidBody = GetComponent<Rigidbody2D>();
		collider = GetComponentInChildren<Collider2D>();
	}


	void Update() {
		  float hor = Input.GetAxis("Horizontal");

			Vector2 posicao = new Vector2(hor * speedh * UnityEngine.Time.deltaTime, 0);		  
			tr.Translate(posicao);

			if(Input.GetKey(KeyCode.Space) && noChao && contagemDoPulo > 30){
				noChao = false;
				contagemDoPulo = 0;
				rigidBody.AddForce(new Vector3(0,15,0), ForceMode2D.Impulse);
			}
			contagemDoPulo++;
	}

	void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "enemy" && morreu == false){        
      matarMario();
		}

		 if(other.tag == "venceu"){        
      venceu();
		}

		noChao = other.tag == "chao" ;
  }
	
		void matarMario(){
			morreu = true;
			collider.isTrigger = true;
			Vector2 posicao = new Vector2(0, 2); ;		  
			tr.Translate(posicao);
			tr.localScale = new Vector3(1,-1,1);
			Destroy(this, 1f);
		}

		void venceu(){
			Vector2 posicao = new Vector2(0, 4); ;		  
			tr.Translate(posicao);
			Destroy(this, 1f);
		}

    private void OnDestroy() {
			if(morreu){
				SceneManager.LoadScene("mariomorreu");
			}else{
				SceneManager.LoadScene("mariovenceu");
			}
			
		}

	}

