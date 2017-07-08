using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Infrastructure.Services
{
    public class Path
    {
       public static string ProductImages(){
           return ConfigurationManager.AppSettings["ImgProductsPath"]; 
       }
    }
}
