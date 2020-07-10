using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Assets;
using TaskManagement.Models;

namespace TaskManagement
{
    class ThreadManager : IDisposable
    {
        //private DbWriter dbWriter;
        private Functions functions;
        private Thread thread;
        private WSwriter wsWriter;

        public ThreadManager ()
        {
            //dbWriter = new DbWriter();
            wsWriter = new WSwriter();
            functions = new Functions();
            functions.GetMachineData();

            //dbWriter.WriteMachine(functions);
            wsWriter.WsMachine(functions);
            this.thread = new Thread(FunctionTest);
     
        }

        public void Dispose()
        {
            ThreadManagetStop();
            functions = null;
            wsWriter = null;
            thread = null;
        }

        public void ThreadManagerStart()
        {
            if (!this.thread.IsAlive)
            {
                wsWriter = new WSwriter();
                functions = new Functions();
                functions.GetMachineData();
                wsWriter.WsMachine(functions);
                this.thread = new Thread(FunctionTest);
                this.thread.Start();
            }
        }


        public void ThreadManagetStop()
        {

            wsWriter = null;
            functions = null;
        }

        private void FunctionTest()
        {
            while (true)
            {
                if(functions is null)
                {
                    break;
                }
                if (functions.TestFocusedChanged())
                {
                    functions.SaveInHASH();
                    //Write to WebService
                    
                    wsWriter.WsMachineRep(functions);

                    //Write directly to database
                    //dbWriter.WriteMachineReporting(functions);
                    



                }
                // TimeDifference of writing new data

              
                Thread.Sleep(10000);
            }
        }

    }
}
