/// <summary>
/// Behaviors for a button that will click upon a timed gaze.
/// Button is clicked after user gazes for a particular duration.
/// Ref: https://www.youtube.com/watch?v=M6sL0ffosds
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ButtonHandler : MonoBehaviour
{

    public Text changingText;
    public Button NextButton;
    public int counter = 0;

   /* // GameObject in charge of scene-level admin.
    private GameObject sceneController;*/

    // Whether the Google Cardboard user is gazing at this button.
    private bool isLookedAt = false;

    // How long the user can gaze at this before the button is clicked.
    public float timerDuration = 3f;

    // Count time the player has been gazing at the button.
    private float lookTimer = 0f;

    // Graphical progress indicator.
    private GameObject gazeTimer;

    // Use this for initialization
    void Start()
    {
        //sceneController = GameObject.Find("SceneController");
        gazeTimer = GameObject.Find("GazeTimer");
    }

    // Update is called once per frame
    void Update()
    {

        // While player is looking at this button.
        if (isLookedAt)
        {

            // Increment the gaze timer.
            lookTimer += Time.deltaTime;

            // Modify graphic progress indicator to show remaining time. E.g. set the alpha layer value
            // cutoff on a PNG so the part showing is proportional to remaining time.
            gazeTimer.GetComponent<Renderer>().material.SetFloat("_Cutoff", lookTimer / timerDuration);

            // Gaze time exceeded limit - button is considered clicked.
            if (lookTimer > timerDuration)
            {
                lookTimer = 0f;

                Debug.Log("Button selected!");
                GetComponent<Button>().onClick.Invoke();
            }
        }

        // Not gazing at this anymore, reset everything.
        else
        {
            lookTimer = 0f;
            // Reset progress indicator.
            gazeTimer.GetComponent<Renderer>().material.SetFloat("_Cutoff", 0f);
        }
    }

    // Record whether Google Cardboard user is gazing at the button.
    // gazedAt: Set it to the value passed from event trigger.
    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
    }

    public void changeText()
    {
        counter++;
        if (counter == 1)
        {
            changingText.text = "STEP 1:" + System.Environment.NewLine + "Put the circle-like component on plane." + System.Environment.NewLine + "Click 'Next' to continue.";
        }
        else if (counter == 2)
        {
            changingText.text = "STEP 2:" + System.Environment.NewLine + "Screw the circle-like component to the plane with screws provided." + System.Environment.NewLine + "Click 'Next' to continue.";
        }

        else
        {
            changingText.text = "Step 3: " + System.Environment.NewLine + "Put Adils at the centre of circle-like component and rotate it. " + System.Environment.NewLine + " Step completed";
            NextButton.interactable = false;
        }
    }
}
