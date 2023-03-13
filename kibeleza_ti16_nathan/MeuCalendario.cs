using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public class MeuCalendario : MonthCalendar
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]

        static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(Handle, string.Empty, string.Empty);
            base.OnHandleCreated(e);
        }
    }
}
