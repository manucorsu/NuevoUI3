/*CONSIGNA:
 * Cuando el usuario presione el BtnAceptar,
 * debe escribirse un mensaje en la consola
 * si el texto del InputPassword coincide
 * con una contraseña predefinida por mi,
 * escribir en la consola "ACCESS GRANTED",
 * si no escribir "ACCESS DENIED"*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField inputPassword;
    string password = "2705";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckPwd()
    {
        if(inputPassword.text == password)
        {
            Debug.Log("ACCESS GRANTED");
        }
        else
        {
            Debug.Log("ACCESS DENIED");
        }
    }
}
