using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class NavigationControl
    {
        List<System.Windows.Forms.UserControl> userControlList = new List<System.Windows.Forms.UserControl>();
        Panel panel;

        public NavigationControl(List<System.Windows.Forms.UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void Display(int index)
        {
            userControlList[index].BringToFront();
        }


    }
}
