﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    bool CursorLockedVar;
    public GameObject pauseMenu;
   
    public bool isPauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        isPauseMenu =false;
    }

    public void Resume(){

        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		CursorLockedVar = (true);

        Time.timeScale =1;
        pauseMenu.SetActive(false);
        isPauseMenu =false;

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){

            if (!isPauseMenu){
                Time.timeScale =0;
                pauseMenu.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
			    Cursor.visible = (true);
			    CursorLockedVar = (false);
                isPauseMenu =true;
            }else{
               Resume();
            }
            
        }

        
    }
    public void ExitGame(){
        Application.Quit();
    }


    public void ToMainMenu(){
        //SceneManager.UnloadScene(SceneManager.GetActiveScene());


        //GameObject.Destroy(GameObject.Find("Inventory_Shooter(Clone)"));
        //GameObject.Destroy(GameObject.Find("vGameController Instance"));
        //GameObject.Destroy(GameObject.Find("Player_Tomek Instance"));
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

    public void Restart(){

        Resume();
    }






}
