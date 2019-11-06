using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Keyboard_MainMenu : MonoBehaviour
{
    public InputField Username;
    public InputField Password;
    
    public SteamVR_LaserPointer laserPointer;
    string alphabet;

    public UnityEngine.UI.InputField passwordInput = null;

    public bool UserNameCheck;
    public bool PasswordCheck;
    
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

        if (e.target.name == "UsernameTF")
        {
            Username.ActivateInputField();
            Password.DeactivateInputField();

            if (Username.isActiveAndEnabled == true)
            {
                
                Debug.Log("Password is deactive  " + Password.isActiveAndEnabled);
                Debug.Log("Username Input Activated" + Username.isActiveAndEnabled);
                Debug.Log("Username is enable" + (Username.enabled == true));
                UserNameCheck = true;
                PasswordCheck = false;
            }
        }
        else if (e.target.name == "PasswordTF")
        {
            Password.ActivateInputField();
            Username.DeactivateInputField();

            if (Password.isActiveAndEnabled == true)
            {
                Debug.Log("Username is deactive = " + Username.isActiveAndEnabled);
                Debug.Log("Password Input Activated" + Password.isActiveAndEnabled);

                UserNameCheck = false;
                PasswordCheck = true;
            }
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Toogle Check!");
            ToogleInputType();
        }
    }

    public void ToogleInputType()
    {      
        if (this.passwordInput != null)
        {            
            if (this.passwordInput.contentType == InputField.ContentType.Password)
            {

                this.passwordInput.contentType = InputField.ContentType.Standard;
            }
            else
            {
                this.passwordInput.contentType = InputField.ContentType.Password;
            }

            this.passwordInput.ForceLabelUpdate();
        }
    }


    public void A()
    {
        if (UserNameCheck == true && PasswordCheck == false )
        {
            Username.text = Username.text + "A";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false )
        {
            Password.text = Password.text + "A";
            Password.caretPosition = (Password.text.Length) + 2;
        }        
    }

    public void B()
    {
        if (UserNameCheck == true && PasswordCheck == false )
        {
            Username.text = Username.text + "B";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false )
        {
            Password.text = Password.text + "B";
            Password.caretPosition = (Password.text.Length) + 2;
        }        
    }

    public void C()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "C";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "C";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void D()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "D";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "D";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void E()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "E";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "E";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void F()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "F";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "F";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void G()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "G";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "G";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void H()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "H";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "H";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void I()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "I";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "I";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void J()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "J";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "J";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void K()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "K";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "K";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void L()
    {
        if(UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "L";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "L";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void M()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "M";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "M";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void N()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "N";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "N";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void O()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "O";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "O";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void P()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "P";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "P";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void Q()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "Q";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "Q";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void R()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "R";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "R";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void S()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "S";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "s";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void T()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "T";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "T";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void U()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "U";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "U";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void V()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "V";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "V";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void W()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "W";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "W";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void X()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "X";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "X";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void Y()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "Y";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "Y";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void Z()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "Z";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "Z";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void FullStop()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + ".";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + ".";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void Coma()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + ",";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + ",";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void BackSpace()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            if (Username.text.Length > 0) Username.text = Username.text.Remove(Username.text.Length - 1, 1);
        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            if (Password.text.Length > 0) Password.text = Password.text.Remove(Password.text.Length - 1, 1);
        }
        
    }

    public void Space()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + " ";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + " ";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void One()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "1";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "1";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void Two()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "2";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "2";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }

    public void Three()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "3";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "3";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
    public void Four()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "4";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "4";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
    public void Five()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "5";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "5";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
    public void Six()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "6";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "6";
            Password.caretPosition = (Password.text.Length) + 2;
        }

    }
    public void Seven()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "7";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "7";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
    public void Eight()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "8";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "8";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
    public void Nine()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "9";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "9";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
    public void Zero()
    {
        if (UserNameCheck == true && PasswordCheck == false)
        {
            Username.text = Username.text + "0";
            Username.caretPosition = (Username.text.Length) + 2;

        }
        else if (PasswordCheck == true && UserNameCheck == false)
        {
            Password.text = Password.text + "0";
            Password.caretPosition = (Password.text.Length) + 2;
        }
    }
 }