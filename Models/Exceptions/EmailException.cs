using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Utkina.Models.Exceptions
{
    class EmailException : Exception
    {
        private string _message;

        //Принимает сообщение с описание ошибки
        public EmailException(string message)
              
            {
             
            _message = message;

            }

           
            public string Message {

            get
            {
                return _message;// + "Error in your email adress";
            }
        }


    }
    }
