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
        int Bullet = 0;
        int Chances = 2;

        public void GunShoot()
        {
            //If the bullet is in the barrel, shoot it at head
            if (Bullet == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Bullet = Bullet + 1;
            }
        }

        public void ShootAway()
        {
            //if I have chances
            if (Chances > 0)
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("You survived");
                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    Bullet = Bullet + 1;
                }
            }
            //If I don't have any chances left
            else
            {
                MessageBox.Show("You are dead!");
            }

            Chances = Chances - 1;
        }
    }
}
