using System;
using System.Windows.Forms;
using BddfyVsix;

namespace BddfyForm
{
    
    public class Program
    {
        [STAThread]
        static void Main()
        {
           Application.Run(new HelperForm()); 
        }
    }
}
