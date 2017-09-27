/*
 * Created by Ranorex
 * User: MOLLAHM
 * Date: 04.09.2017
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace close
{
    class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            // Uncomment the following 2 lines if you want to automate Windows apps
            // by starting the test executable directly
            //if (Util.IsRestartRequiredForWinAppAccess)
            //    return Util.RestartWithUiAccess();

            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error = 0;
            
            int run_id = 1412;
            int not_executed =0;
            
            
            try
            {
                error = TestSuiteRunner.Run(typeof(Program), Environment.CommandLine);
                
                JArray get_tests = (JArray) client.SendGet("get_tests/"+run_id);
                
                int count_tests = get_test.Count;
                
                for(int i =0 ; i<count_tests; i++){
                	
                	if(get_tests[i]["status_id"].ToString()==4){
                	not_executed++;
                	}
                }
                
                
                
                        

                
                
                
            }
            catch (Exception e)
            {
                Report.Error("Unexpected exception occurred: " + e.ToString());
                error = -1;
            }
            return error;
        }
    }
}
