using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string Name;
    public string Password;
    public string Email;
    private string Gender;
    public int Age;
    private int TotalScore;
    private GlassBall ball;
    private Water water;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }


    public Player(string Name, string Password, string Email)
    {
        this.Name = Name;
        this.Password = Password;
        this.Email = Email;
    }


    public void SignUp(string Name, string Password, string Email , int Age)
    {
        this.Name = Name;
        this.Password = Password;
        this.Email = Email;
        this.Age = Age;

    }

    public void Login(string Name, string Password)
    {
        
            this.Name = Name;
            this.Password = Password;
        

    }

    /* public void Logout()
     {

     }
    */

    public void ForgetPassword(string Password)
    {
        this.Password = Password;
    }

    public void UpdateProfile(string Name, string Email, string Password)
    {
        this.Name = Name;
        this.Email = Email;
        this.Password = Password;
    }
    public void UpdateName(string Name)
    {
        this.Name = Name;
    }
    public void UpdateEmail(string Email)
    {
        this.Email = Email;
    }

    public void UpdatePassword(string Password)
    {
        this.Password = Password;
    }

    public void ViewProfile(string Email)
    {
        this.Email = Email;
    }

    public void FinalScore(int TotalScore)
    {
        this.TotalScore = TotalScore;
    }

   /* public void EncryptedPassword()
    {

    }
    public void DecryptionPassword()
    {

    }
   */
}
