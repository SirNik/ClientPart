using RiskManagementLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АВПЗ
{
   
    public class ControlForms
    {
        private FormPotentialRiskEvents formPRE;
        private Thread thread1;
        private FormSources formSources;
        private FormAnalis formAnalis;

        private void FormInThread(object formInThread)
        {
            Application.Run(formInThread as Form);
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        internal void ActivateFormPotentionalRiskEvents(RiskManagementLib rs)
        {
            if (Application.OpenForms["FormPotentialRiskEvents"] == null)
            {
                formPRE = new FormPotentialRiskEvents(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(formPRE);
            }
            else
            {
                SetForegroundWindow(rs.FormPotentialRiskEventsProcess);
            }
        }

        internal void ActivateFormSources(RiskManagementLib rs)
        {
            if (Application.OpenForms["FormSources"] == null)
            {
                formSources = new FormSources(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(formSources);
            }
            else
            {
                SetForegroundWindow(rs.FormSourcesProcess);
            }
        }

        internal void ActivateFormAnalis(RiskManagementLib rs)
        {
            if (Application.OpenForms["FormAnalis"] == null)
            {
                formAnalis = new FormAnalis(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(formAnalis);
            }
            else
            {
                SetForegroundWindow(rs.FormAnalisProcess);
            }
        }
    }

}
