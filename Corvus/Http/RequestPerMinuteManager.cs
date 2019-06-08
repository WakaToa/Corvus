using System;
using System.Threading;
using System.Threading.Tasks;

namespace Corvus.Http
{
    public class RequestPerMinuteManager
    {
        private DateTime _lastRequest = DateTime.Now;

        private object _lockObject = new object();

        private Random _random = new Random();

        private int _calculatedTime = -1;

        private int _rpmMin;
        private int _rpmMax;

        public async Task WaitForNextRequest()
        {
            await Task.Run(() =>
            {
                WaitForNextRequestInternal();
            }).ConfigureAwait(false);
        }

        public bool IsNextRequestPossible()
        {
            if (_calculatedTime < 0)
            {
                var timeMin = 0;
                var timeMax = 0;
                timeMin = 60000 / _rpmMin;
                timeMax = 60000 / _rpmMax;

                _calculatedTime = _random.Next(timeMax, timeMin);
            }

            var result = (_lastRequest.AddMilliseconds(_calculatedTime) <= DateTime.Now);
            return result;
        }

        public RequestPerMinuteManager(int rpmMin = 12, int rpmMax = 12)
        {
            _rpmMin = rpmMin;
            _rpmMax = rpmMax;
        }

        private void WaitForNextRequestInternal()
        {
            lock (_lockObject)
            {
                while (!IsNextRequestPossible())
                {
                    Thread.Sleep(10);
                }
                _lastRequest = DateTime.Now;
                _calculatedTime = -1;
            }
        }
    }
}
