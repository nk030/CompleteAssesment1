using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateAssessment1;

namespace CompleteAssesment1
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class mainform : Form

    {
        LogicClass Logic = new LogicClass();
        public mainform()
        {
            InitializeComponent();
        }

        private void GunShoot_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(CompleteAssesment1.Properties.Resources.Gun_Shot);
            sound.Play();
            {
                {
                    Logic.GunShoot();
                }
            }
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            {
                Logic.ShootAway();
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.button1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logic.button2();
        }
    }
}