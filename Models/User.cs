﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AonFreelancing.Interfaces;

namespace AonFreelancing.Models
{
    public class User : IUserAuthOperations, IUserPrintOperations
    {
        [StringLength(512)]
        public string Name { get; set; }
        [StringLength(256)]
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        [Key]
        public int Id { get; set; }

        public Freelancer? Freelancer { get; set; }
        public Client? Client { get; set; }
        public SystemUser? SystemUser { get; set; }
        public void DisplayProfile(){}
        public void Login()
        {

        }
        public  void Logout()
        {

        }
    }
}
