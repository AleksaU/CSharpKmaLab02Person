using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Utkina.Models
{
    class Person
    {
        private string _name;
        private string _surName;
        private string _email;
        private DateTime _birthDate;

        private readonly bool _isAdult;
        private readonly string _sunSign;
        private readonly string _chineseSign;
        private readonly bool _isBirthday;


        public Person(string name, string surName, string email, DateTime birthDate)
        {
            _name = name;
            _surName = surName;
            _email = email;
            _birthDate = birthDate;

            //  _isAdult = CheckAdult();
            //   _sunSign = CalcSunSign();
            //   _chineseSign = CalcChineseSign();
            //   _isBirthday = CheckBirthday();
        }

      //  Когда приходится работать с перегружаемыми конструкторами, то иногда очень полезно предоставить возможность одному конструктору вызывать другой.В C# это дается с помощью ключевого слова this. 
        public Person(string name, string surName, string email):this(name,surName, email, DateTime.MaxValue) { }

        public Person(string name, string surName,DateTime birthDate): this(name,surName,"noemail", birthDate) { }




        }




    }

