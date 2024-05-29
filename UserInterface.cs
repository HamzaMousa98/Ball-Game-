using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceInstraction : MonoBehaviour
{
    public Player player;
    public GameObject StartPage;
    public GameObject RegisterPage;
    public GameObject LoginPage;
    public GameObject HomePage;
    public GameObject ForgetPage;
    private void Start()
    {
       

    }
    public void RegisterVerification()
    {
        
        InputField UserName = GameObject.Find("EnterUserName").GetComponent<InputField>();
        InputField Password = GameObject.Find("EnterPassword").GetComponent<InputField>();
        InputField ConfirmPassword = GameObject.Find("EnterConfirmPassword").GetComponent<InputField>();
        InputField Age = GameObject.Find("EnterAge").GetComponent<InputField>();
        InputField Email = GameObject.Find("EnterEmail").GetComponent<InputField>();
        Text ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
        Text EmailError = GameObject.Find("EmailError").GetComponent<Text>();
        Text PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
        Text ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
        Text AgeError = GameObject.Find("AgeError").GetComponent<Text>();
        //--------------------------------------------------------------------
        if (CorrectUserName(UserName.text) == 0)
        {
            
            ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
            ErrorUserName.text = "Empty";
        }
        else if (CorrectUserName(UserName.text) == 1)
        {
            
            ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
            ErrorUserName.text = "UserName must start with a capital letter ";
        }
        else if(CorrectUserName(UserName.text) == 2)
        {
            ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
            ErrorUserName.text = "UserName must be between 6 and 10 characters";
        }
        else if (CorrectUserName(UserName.text) == 3)
        {
            ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
            ErrorUserName.text = "";
            
        }
        //--------------------------------------------------------------------
        if (!CorrectEmail(Email.text))
        {
            EmailError = GameObject.Find("EmailError").GetComponent<Text>();
            EmailError.text = "Email is not correct";
        }
        else
        {
            EmailError = GameObject.Find("EmailError").GetComponent<Text>();
            EmailError.text = "";
        }
        //--------------------------------------------------------------------
        if (CorrectPassword(Password.text, ConfirmPassword.text) == 0)
        {
            PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
            ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
            PasswordError.text = "Empty";
            ConfirmPasswordError.text = "Empty";
        }
        else if (CorrectPassword(Password.text, ConfirmPassword.text) == 1)
        {
            PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
            ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
            PasswordError.text = "The two passwords are not the same";
            ConfirmPasswordError.text = "The two passwords are not the same";
        }
        else if (CorrectPassword(Password.text, ConfirmPassword.text) == 2)
        {
            PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
            ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
            PasswordError.text = "Password must be between 6 and 10 characters";
            ConfirmPasswordError.text = "Password must be between 6 and 10 characters";
        }
        else if (CorrectPassword(Password.text, ConfirmPassword.text) == 3)
        {
            PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
            ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
            PasswordError.text = "The password must contain an uppercase and lowercase letters and a number";
            ConfirmPasswordError.text = "The password must contain an uppercase and lowercase letters and a number";
        }
        else
        {
            PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
            ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
            PasswordError.text = "";
            ConfirmPasswordError.text = "";
        }
        //--------------------------------------------------------------------
        if (!CorrectAge(Age.text))
        {
            AgeError = GameObject.Find("AgeError").GetComponent<Text>();
            AgeError.text = "Age must be between 12 and 65 Years";
        }
        else
        {
            AgeError = GameObject.Find("AgeError").GetComponent<Text>();
            AgeError.text = "";
        }

        //--------------------------------------------------------------------
        if(AgeError.text.Equals("")&& PasswordError.text.Equals("")&& ConfirmPasswordError.text.Equals("")&& EmailError.text.Equals("")&& ErrorUserName.text.Equals(""))
        {
            StartPage.active = true;
            Text CreatedEmail = GameObject.Find("CreatedEmail").GetComponent<Text>();
            CreatedEmail.text = "Your email has been created";

            /*
             هون بدك تعمل حفظ بالداتا بيز للمعلومات تبعت الاعب 
             */

           // player.SignUp(UserName.text,Password.text,Email.text,Int32.Parse(Age.text));

            UserName.text = "";
            Password.text = "";
            Email.text = "";
            Age.text = "";
            ConfirmPassword.text = "";

            RegisterPage.active = false;

        }
        //---------------------------------------------------------------------

        // InputField GendarDropDwon = GameObject.Find("GendarDropDwon").GetComponent<InputField>();
    }
    
    public void LoginVerification()
    {
        bool find = false; 
        InputField UserName = GameObject.Find("EnterUsername").GetComponent<InputField>();
        InputField Password = GameObject.Find("EnterPassword").GetComponent<InputField>();

        /*
         هون بدك تجيب كل الحسابات وتشوف اذا فيه حساب منهن بطابق اليوزر وكلمة السر الي اتدخلن 
         اذا اه بتخلي متغير الفايند ترو واذا لا بتعمل فولس وبتوخذ كل القيم للاعب وبتحطهن بمتغيرات 
         */
        // الكود الي تحت هاض عشان اتأكد انه الامور شغاله بس 
        // بس تشبك الداتا شيله
        if (UserName.text.Equals("Morad2001") && Password.text.Equals("123123mM"))
        {
            find = true;
        }
        //-------------------------
        if (find)
        {
            // هون بتدخل المتغيرات جوا كلاس البلاير
            // player.SignUp(UserName.text, Password.text, Email.text, Int32.Parse(Age.text));
            LoginPage.active = false;
            HomePage.active = true;
        }
        else
        {
            Text error = GameObject.Find("Error").GetComponent<Text>();
            error.text = "The password or username is incorrect";
        }
    }

    public void ForgetPasswordVerification()
    {
        bool find = false;
        InputField UserName = GameObject.Find("EnterUserName").GetComponent<InputField>();
        InputField Password = GameObject.Find("EnterPassword").GetComponent<InputField>();
        InputField ConfirmPassword = GameObject.Find("EnterConfirmPassword").GetComponent<InputField>();
        InputField Email = GameObject.Find("EnterEmail").GetComponent<InputField>();
        Text ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
        Text EmailError = GameObject.Find("EmailError").GetComponent<Text>();
        Text PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
        Text ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
        // الكود الي تحت هاض عشان اتأكد انه الامور شغاله بس 
        // بس تشبك الداتا شيله
        if(UserName.text.Equals("Morad2001") && Email.text.Equals("morad.2001.memo@gmail.com"))
        {
            find = true;
        }
        //-------------------------
        /*
         * هون بدك تدور اذا اليوزر نيم والباسوورد هضول موجودات بالداتا بيز واذا موجودات بدك تغير كلمة السر 
         * بعد التأكد انه كلمه السر اصلا صحيحه
         */

        if (find)
        {
            ErrorUserName.text = "";
            EmailError.text = "";
            //--------------------------------------------------------------------
            if (CorrectPassword(Password.text, ConfirmPassword.text) == 0)
            {
                PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
                ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
                PasswordError.text = "Empty";
                ConfirmPasswordError.text = "Empty";
            }
            else if (CorrectPassword(Password.text, ConfirmPassword.text) == 1)
            {
                PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
                ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
                PasswordError.text = "The two passwords are not the same";
                ConfirmPasswordError.text = "The two passwords are not the same";
            }
            else if (CorrectPassword(Password.text, ConfirmPassword.text) == 2)
            {
                PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
                ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
                PasswordError.text = "Password must be between 6 and 10 characters";
                ConfirmPasswordError.text = "Password must be between 6 and 10 characters";
            }
            else if (CorrectPassword(Password.text, ConfirmPassword.text) == 3)
            {
                PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
                ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
                PasswordError.text = "The password must contain an uppercase and lowercase letters and a number";
                ConfirmPasswordError.text = "The password must contain an uppercase and lowercase letters and a number";
            }
            else
            {
                UserName = GameObject.Find("EnterUserName").GetComponent<InputField>();
                Password = GameObject.Find("EnterPassword").GetComponent<InputField>();
                ConfirmPassword = GameObject.Find("EnterConfirmPassword").GetComponent<InputField>();
                Email = GameObject.Find("EnterEmail").GetComponent<InputField>();
                ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
                EmailError = GameObject.Find("EmailError").GetComponent<Text>();
                PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
                ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
                /*هون بتكون اتأكدت انك لقيت الحساب وبنفس الوقت الباسوورد مليحه 
                 وهون بتروح بتعمل update
                بالداتا بيز على كلمة السر*/


                UserName.text = "";
                Password.text = "";
                Email.text = "";
                ConfirmPassword.text = "";
                EmailError.text = "";
                PasswordError.text = "";
                ConfirmPasswordError.text = "";
                ErrorUserName.text = "";

                LoginPage.active = true;
                Text Error = GameObject.Find("Error").GetComponent<Text>();
                Error.text = "Your password has changed";
                ForgetPage.active = false;
            }
            //--------------------------------------------------------------------
        }
        else
        {
            ErrorUserName.text = "Username or email is uncorrect";
            EmailError.text = "Username or email is uncorrect";
        }
    }

    public void BackLoginPagefromForget()
    {
        InputField UserName = GameObject.Find("EnterUserName").GetComponent<InputField>();
        InputField Password = GameObject.Find("EnterPassword").GetComponent<InputField>();
        InputField ConfirmPassword = GameObject.Find("EnterConfirmPassword").GetComponent<InputField>();
        InputField Email = GameObject.Find("EnterEmail").GetComponent<InputField>();
        Text ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
        Text EmailError = GameObject.Find("EmailError").GetComponent<Text>();
        Text PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
        Text ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
        UserName.text = "";
        Password.text = "";
        Email.text = "";
        ConfirmPassword.text = "";
        EmailError.text = "";
        PasswordError.text = "";
        ConfirmPasswordError.text = "";
        ErrorUserName.text = "";

        LoginPage.active = true;
        Text Error = GameObject.Find("Error").GetComponent<Text>();
        Error.text = "";
        ForgetPage.active = false;

    }






    public void BackStartPagefromLogin()
    {
        InputField UserName = GameObject.Find("EnterUsername").GetComponent<InputField>();
        InputField Password = GameObject.Find("EnterPassword").GetComponent<InputField>();
        
        Text Error = GameObject.Find("Error").GetComponent<Text>();
        Error.text = "";
        UserName.text = "";
        Password.text = "";

        StartPage.active = true;
        LoginPage.active = false;

    }
    public void BackStartPagefromRegister()
    {
        InputField UserName = GameObject.Find("EnterUserName").GetComponent<InputField>();
        InputField Password = GameObject.Find("EnterPassword").GetComponent<InputField>();
        InputField ConfirmPassword = GameObject.Find("EnterConfirmPassword").GetComponent<InputField>();
        InputField Age = GameObject.Find("EnterAge").GetComponent<InputField>();
        InputField Email = GameObject.Find("EnterEmail").GetComponent<InputField>();
        Text EmailError = GameObject.Find("EmailError").GetComponent<Text>();
        Text PasswordError = GameObject.Find("PasswordError").GetComponent<Text>();
        Text ConfirmPasswordError = GameObject.Find("ConfirmPasswordError").GetComponent<Text>();
        Text AgeError = GameObject.Find("AgeError").GetComponent<Text>();
        Text ErrorUserName = GameObject.Find("UsernameError").GetComponent<Text>();
        StartPage.active = true;
        Text CreatedEmail = GameObject.Find("CreatedEmail").GetComponent<Text>();
        CreatedEmail.text = "";
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        UserName.text = "";
        Password.text = "";
        Email.text = "";
        Age.text = "";
        ConfirmPassword.text = "";
        EmailError.text = "";
        PasswordError.text = "";
        ConfirmPasswordError.text = "";
        AgeError.text = "";
        ErrorUserName.text = "";
        RegisterPage.active = false;

    }
    public int CorrectUserName(string UserName)
    {
        if (UserName.Equals(""))
        {
            return 0;
        }
        if (!Char.IsUpper(UserName[0]))
        {
            return 1;
        }
        else if (!(UserName.Length >= 6 && UserName.Length <= 10))
        {
            return 2;
        }
        else return 3;
    }
    public bool CorrectEmail(string Email)
    {
        if (Email.Equals(""))
        {
            return false;
        }
        else if (!(Email[Email.Length - 1].Equals('m') && Email[Email.Length - 2].Equals('o') && Email[Email.Length - 3].Equals('c') && Email[Email.Length - 4].Equals('.')))
        {
            return false;
        }
        else if (Email.IndexOf('@') < 0)
        {
            return false;
        }
        else if (!(Email.IndexOf('@') >= 5 && Email.IndexOf('@') <= 15))
        {
            return false;
        }
        else if (!(Email.Length - Email.IndexOf('@') >= 8))
        {
            return false;
        }
        else return true;
    }
    public int CorrectPassword(String Password , String ConfirmPassword)
    {
        bool findDigit = false;
        bool findUchar  = false;
        bool findLchar = false;
        for (int i = 0; i < Password.Length; i++)
        {
            if (Char.IsDigit(Password[i])) { findDigit = true; }
            else if (Char.IsLower(Password[i])) { findLchar = true; }
            else if (Char.IsUpper(Password[i])) { findUchar = true; }
        }
        if (Password.Equals("") && ConfirmPassword.Equals(""))
        {
            return 0;
        }
        else if (!Password.Equals(ConfirmPassword))
        {
            return 1;
        }
        else if(!(Password.Length >= 8 && Password.Length <= 16))
        {
            return 2;
        }
        else if (!findDigit || !findUchar || !findLchar)
        {
            return 3;
        }
        return 4;
    }
    public bool CorrectAge(String Age)
    {
        if (Age.Equals(""))
        {
            return false;
        }
        int AgeN = Int32.Parse(Age);
        if (!(AgeN >= 12 && AgeN <= 65))
        {
            return false;
        }
        return true;
    }

}
