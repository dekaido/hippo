using UnityEngine;
using System.Collections;

//Attach to a Sprite with 2DRigidBody and BoxCollider2D

public class volume : MonoBehaviour {

    public bool collided = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        kill(collision);
    }

    void OnGUI()
    {
        if (collided)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 40), "Quit"))
                quit();
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 60, 100, 40), "New Game"))
                newGame();
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 120, 100, 40), "Resume"))
                resumeGame();
        }

    }

    void kill(Collision2D collision)
    {
        Time.timeScale = 0.0f;
        print("You Ded!\n#RIP in pizza");
        collided = true;
        print(collided);

        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        collision.gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0.0f;
    }

    void resumeGame()
    {
        print("Resuming Game");
        Time.timeScale = 1.0f;
        collided = false;
        print(collided);
    }

    void quit()
    {
        Application.Quit();
    }

    void newGame()
    {
        Application.LoadLevel(0);
    }
}
