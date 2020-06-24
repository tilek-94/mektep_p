using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mectep.All_class
{
    class Camera_class
    {
        string str = "";
        int kolNumber { get; set; } = 0;
        string[] numberMass=new string[50];
        public Camera_class(int number)
        {
            kolNumber = number;
            MassivNul();



        }
        public void MassivNul()
        {
            str = "";
            for (int i = 1; i <= kolNumber; i++)
            {
                numberMass[i] = "0";
            }
        }
       
        public string cameraVK(int number)
        {
            str = "";
            for (int i=1;i<= kolNumber; i++)
            {

                if (i == number)
                {
                    str += '1';
                }
                else
                {
                    str += '0';
                }
                
            }
            return str;
        }

        public string cameraVK2(int number,bool flag)
        {
            if (flag == true)
            {
                str = "";
                for (int i = 1; i <=kolNumber; i++)
                {

                    if (i == number)
                    {
                        numberMass[i] = "1";
                    }

                    str += numberMass[i];
                }
            }
            else
            {
                str = "";
                for (int i = 1; i <=kolNumber; i++)
                {

                    if (i == number)
                    {
                        numberMass[i] = "0";
                    }

                    str += numberMass[i];
                }
            }
                return str;
        }


    }
}
