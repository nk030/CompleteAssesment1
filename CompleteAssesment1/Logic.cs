using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssessment1
{
    public class LogicClass
    {
        int Missile = 0;
        int opportunity = 2;

        public void GunShoot()
        {
            //On the off chace that the shot is in the barrel, shoot it at head
            if (Missile == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Missile = Missile + 1;
            }
        }

        public void ShootAway()
        {
            //  on the off chace that i have any opportunities left
            if (opportunity > 0)
            {
                if (Missile == 5)
                {
                    MessageBox.Show("You survived");
                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    Missile = Missile + 1;
                }
            }
            //On the off chace that i don't get any opportunities left
            else
            {
                MessageBox.Show("You are dead!");
            }

            opportunity = opportunity - 1;
        }



    public void button1()
        {
            Random rand = new Random();
            Missile = rand.Next(0, 6);
            MessageBox.Show("Gun spinning");

        }
        public void button2()
        {

            Missile = 0;
            MessageBox.Show("Gun load");

        }
    }

}
