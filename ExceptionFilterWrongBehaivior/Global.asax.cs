using System;
using System.Threading;

namespace ExceptionFilterWrongBehaivior
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            int i = 3;
            do
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception) when (--i < 0)
                {
                    throw;
                }
                catch (Exception)
                {
                    Thread.Sleep(10);
                }
            } while (true);
        }
    }
}