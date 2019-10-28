using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Keyboard : MonoBehaviour
{

    public InputField TextField;
    public InputField JoinRoom;
    public InputField PlayerName;

    public SteamVR_LaserPointer laserPointer;
    string alphabet;

    public bool Room;
    public bool Join;
    public bool PlayerNameCheck;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "A")
        {
            Debug.Log("A was clicked");
            A();
        }
        else if (e.target.name == "B")
        {
            Debug.Log("B was clicked");
            B();
        }
        else if (e.target.name == "C")
        {
            Debug.Log("C was clicked");
            C();
        }
        else if (e.target.name == "D")
        {
            Debug.Log("D was clicked");
            D();
        }
        else if (e.target.name == "E")
        {
            Debug.Log("E was clicked");
            E();
        }
        else if (e.target.name == "F")
        {
            Debug.Log("F was clicked");
            F();
        }
        else if (e.target.name == "G")
        {
            Debug.Log("G was clicked");
            G();
        }
        else if (e.target.name == "H")
        {
            Debug.Log("H was clicked");
            H();
        }
        else if (e.target.name == "I")
        {
            Debug.Log("I was clicked");
            I();
        }
        else if (e.target.name == "J")
        {
            Debug.Log("J was clicked");
            J();
        }
        else if (e.target.name == "K")
        {
            Debug.Log("K was clicked");
            K();
        }
        else if (e.target.name == "L")
        {
            Debug.Log("L was clicked");
            L();
        }
        else if (e.target.name == "M")
        {
            Debug.Log("M was clicked");
            M();
        }
        else if (e.target.name == "N")
        {
            Debug.Log("N was clicked");
            N();
        }
        else if (e.target.name == "O")
        {
            Debug.Log("O was clicked");
            O();
        }
        else if (e.target.name == "P")
        {
            Debug.Log("P was clicked");
            P();
        }
        else if (e.target.name == "Q")
        {
            Debug.Log("Q was clicked");
            Q();
        }
        else if (e.target.name == "R")
        {
            Debug.Log("R was clicked");
            R();
        }
        else if (e.target.name == "S")
        {
            Debug.Log("S was clicked");
            S();
        }
        else if (e.target.name == "T")
        {
            Debug.Log("T was clicked");
            T();
        }
        else if (e.target.name == "U")
        {
            Debug.Log("U was clicked");
            U();
        }
        else if (e.target.name == "V")
        {
            Debug.Log("V was clicked");
            V();
        }
        else if (e.target.name == "W")
        {
            Debug.Log("W was clicked");
            W();
        }
        else if (e.target.name == "X")
        {
            Debug.Log("X was clicked");
            X();
        }
        else if (e.target.name == "Y")
        {
            Debug.Log("Y was clicked");
            Y();
        }
        else if (e.target.name == "Z")
        {
            Debug.Log("Z was clicked");
            Z();
        }
        else if (e.target.name == "Coma")
        {
            Debug.Log("Coma was clicked");
            Coma();
        }
        else if (e.target.name == "FullStop")
        {
            Debug.Log("FullStop was clicked");
            FullStop();
        }
        else if (e.target.name == "BackSpace")
        {
            Debug.Log("BackSpace was clicked");
            BackSpace();
        }
        else if (e.target.name == "Space")
        {
            Debug.Log("Space was clicked");
            Space();
        }
        else if (e.target.name == "1")
        {
            Debug.Log("1 was clicked");
            One();
        }
        else if (e.target.name == "2")
        {
            Debug.Log("2 was clicked");
            Two();
        }
        else if (e.target.name == "3")
        {
            Debug.Log("3 was clicked");
            Three();
        }
        else if (e.target.name == "4")
        {
            Debug.Log("4 was clicked");
            Four();
        }
        else if (e.target.name == "5")
        {
            Debug.Log("5 was clicked");
            Five();
        }
        else if (e.target.name == "6")
        {
            Debug.Log("6 was clicked");
            Six();
        }
        else if (e.target.name == "7")
        {
            Debug.Log("7 was clicked");
            Seven();
        }
        else if (e.target.name == "8")
        {
            Debug.Log("8 was clicked");
            Eight();
        }
        else if (e.target.name == "9")
        {
            Debug.Log("9 was clicked");
            Nine();
        }
        else if (e.target.name == "0")
        {
            Debug.Log("0 was clicked");
            Zero();
        }

        if (e.target.name == "RoomNameInput")
        {
            TextField.ActivateInputField();
            JoinRoom.DeactivateInputField();

            if (TextField.isActiveAndEnabled == true)
            {
                Debug.Log("Join Room is deactive  " + JoinRoom.isActiveAndEnabled);
                Debug.Log("Room Name Input Activated" + TextField.isActiveAndEnabled);
                Debug.Log("Room Name is enable" + (TextField.enabled == true));
                Room = true;
                Join = false;
            }
        }
        else if (e.target.name == "JoinRoomInput")
        {
            JoinRoom.ActivateInputField();
            TextField.DeactivateInputField();

            if (JoinRoom.isActiveAndEnabled == true)
            {
                Debug.Log("Room Name is deactive = " + TextField.isActiveAndEnabled);
                Debug.Log("Join Room Input Activated" + JoinRoom.isActiveAndEnabled);

                Room = false;
                Join = true;
            }
        }
        else if (e.target.name == "PlayerName")
        {
            PlayerName.ActivateInputField();

            if (PlayerName.isActiveAndEnabled == true)
            {
                Debug.Log("Player Name Activated!");

                PlayerNameCheck = true;
                Room = false;
                Join = false;
            }
        }
    }


    public void A()
    {

        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "A";
            TextField.caretPosition = (TextField.text.Length) + 2;

        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "A";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "A";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void B()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "B";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "B";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "B";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void C()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "C";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "C";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "C";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void D()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "D";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "D";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "D";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void E()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "E";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "E";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "E";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void F()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "F";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "F";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "F";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void G()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "G";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "G";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "G";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void H()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "H";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "H";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "H";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void I()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "I";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "I";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "I";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void J()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "J";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "J";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "J";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void K()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "K";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "K";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "K";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void L()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "L";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "L";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "L";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void M()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "M";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "M";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "M";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void N()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "N";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "N";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "N";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void O()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "O";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "O";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "O";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void P()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "P";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "P";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "P";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void Q()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "Q";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "Q";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "Q";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void R()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "R";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "R";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "R";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void S()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "S";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "S";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "S";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void T()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "T";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "T";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "T";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void U()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "U";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "U";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "U";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void V()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "V";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "V";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "V";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void W()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "W";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "W";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "W";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void X()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "X";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "X";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "X";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void Y()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "Y";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "Y";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "Y";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void Z()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "Z";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "Z";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "Z";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void FullStop()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + ".";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + ".";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + ".";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void Coma()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + ",";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + ",";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + ",";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void BackSpace()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            if (TextField.text.Length > 0) TextField.text = TextField.text.Remove(TextField.text.Length - 1, 1);
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            if (JoinRoom.text.Length > 0) JoinRoom.text = JoinRoom.text.Remove(JoinRoom.text.Length - 1, 1);
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            if (PlayerName.text.Length > 0) PlayerName.text = PlayerName.text.Remove(PlayerName.text.Length - 1, 1);

        }
    }

    public void Space()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + " ";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + " ";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + " ";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void One()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "1";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "1";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "1";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void Two()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "2";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "2";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "2";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

    public void Three()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "3";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "3";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "3";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }
    public void Four()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "4";
            TextField.caretPosition = (TextField.text.Length) + 2;

        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "4";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "4";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }
    public void Five()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "5";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "5";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "5";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }
    public void Six()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "6";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "6";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "6";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }

    }
    public void Seven()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "7";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "7";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "7";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }
    public void Eight()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "8";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "8";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "8";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }
    public void Nine()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "9";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "9";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "9";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }
    public void Zero()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "0";
            TextField.caretPosition = (TextField.text.Length) + 2;
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "0";
            JoinRoom.caretPosition = (JoinRoom.text.Length) + 2;
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "0";
            PlayerName.caretPosition = (PlayerName.text.Length) + 2;
        }
    }

}