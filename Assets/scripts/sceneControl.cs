using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneControl : MonoBehaviour
{
    // game phase will be used to keep track of what scene is next, everything conctrolled through elevator
    // phase 0: in present. will transition to teacher game
    // phase 1: teacher game. pushed in elevator. Press elevator button 1 to go to past
    // phase 2: in the past. got o game after fight. elevator back to present game
    // phase 3: in present. transitions to teacher game
    // phase 4: teacher game. pushed in elevator. go to future game
    // phase 5: in future, play game, go to mona lisa room. go back to present from elevator room
    // phase 6: present. play game, go to door, go through door
    // phase 7: punch teacher in the face
    public static int gamePhase; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScenePhase()
    {

        if(gamePhase == 0)
        {
            gamePhase++;
            SceneManager.LoadScene("Pixel HB");
        }
        else if(gamePhase == 1)
        {
            gamePhase++;
            SceneManager.LoadScene("midieval castle");
        }
        else if(gamePhase == 2)
        {
            gamePhase++;
            SceneManager.LoadScene("SonyaScene");
        }
        else if(gamePhase == 3)
        {
            gamePhase++;
            SceneManager.LoadScene("Pixel HB");
        }
        else if(gamePhase == 4)
        {
            gamePhase++;
            SceneManager.LoadScene("robot room");
        }
        else if(gamePhase == 5)
        {
            gamePhase++;
            SceneManager.LoadScene("SonyaScene");
        }
        else if(gamePhase == 6)
        {
            gamePhase++;
            SceneManager.LoadScene("Pixel HB");
        }

    }

    public void changeScene(string sceneName)
    {
         SceneManager.LoadScene(sceneName);
    }
    

    public void goToElevator(string name)
    {
        SceneManager.LoadScene("elevator");
    }
}
