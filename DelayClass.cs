using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class DelayClass
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();

        public async Task PauseTaskDelay()
        {
            try
            {
                await Task.Delay(5000, tokenSource.Token);
            }
            catch(TaskCanceledExeption ex)
            {
            }
            catch (Exception ex)
            {
            }

        }
    }
}
