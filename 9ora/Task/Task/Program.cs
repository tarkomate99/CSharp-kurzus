using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {

        public static async Task<long> Sum(int meddig, CancellationToken token)
        {
            long sum = 0;
            for (int i=0; i< meddig; i++)
            {
                //token.ThrowIfCancellationRequested();
                if (token.IsCancellationRequested)
                {
                    break;
                }
                sum += 1;
                await System.Threading.Tasks.Task.Delay(1000, token);
            }
            return sum;
        }

        private static CancellationTokenSource _tokenSource;

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            try
            {
                _tokenSource = new CancellationTokenSource();

                Console.CancelKeyPress += OnCancelKey;

                long result = await Sum(1000000, _tokenSource.Token);
                Console.Write(result);
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine("Türelmetlen voltál");
            }
            finally
            {
                _tokenSource.Dispose();
            }
        }

        private static void OnCancelKey(object sender, ConsoleCancelEventArgs e)
        {
            _tokenSource.Cancel();
            e.Cancel = true; //amugy nem lépünk ki
        }
    }
}
