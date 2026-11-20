using UnityEngine;


public class resumeButton : MonoBehaviour

{
    public GameObject Container;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Container.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeButton()
    {
        Container.SetActive(false);
        Time.timeScale = 0;
    }
}
