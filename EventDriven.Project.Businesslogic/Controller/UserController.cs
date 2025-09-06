using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class UserController
    {
        private UserRepository userRepo;
        

        public UserController()
        {
            userRepo = new UserRepository();
        }

        public List<UserModel> GetUserList()
        {
            return new List<UserModel> { new UserModel() };
        }

        public UserModel ValidateUser( string Username, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
                {
                    throw new Exception("Password/Username cannot be empty.");
                }
                else
                {
                    Console.WriteLine("Login Succesfull");
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userRepo.ValidateUser(Username,Password);
        }
    }
}
