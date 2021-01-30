using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScrollMenu : MonoBehaviour
{

    bool CursorLockedVar;
    public GameObject ScrollCanves;
    public bool isCanvesMenu;
    // Start is called before the first frame update
    void Start()
    {
        isCanvesMenu =false;
    }

    public void Resume(){

        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		CursorLockedVar = (true);

        Time.timeScale =1;
        ScrollCanves.SetActive(false);
      

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)){

            if (!isCanvesMenu){
                Time.timeScale =0;
                ScrollCanves.SetActive(true);
                isCanvesMenu =true;
                Cursor.lockState = CursorLockMode.None;
			    Cursor.visible = (true);
			    CursorLockedVar = (false);
            }else{
               Resume();
               isCanvesMenu =false;
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
