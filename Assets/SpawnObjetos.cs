using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour {
	public GameObject obj;


	public static bool gameOver=false;
	public static int cantidadCajas=0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//tiempo+=Time.deltaTime;

		//print("cajas "+);
		if(gameOver==false){
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			

			cantidadCajas+=1;
			print("cantidad cajas "+cantidadCajas);
			Instantiate(obj,transform.position,transform.rotation);

		}
		}else{

		}
			

	}
}
