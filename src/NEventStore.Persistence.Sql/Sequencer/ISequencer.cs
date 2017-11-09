using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NEventStore.Persistence.Sql.Sequencer
{
    public interface ISequencer
    {
        Task Start();
    }

    public class Sequencer : ISequencer, IDisposable
    {
        private readonly CancellationTokenSource _stopRequested = new CancellationTokenSource();

        public void Dispose()
        {
            _stopRequested.Cancel();
        }

        public Task Start()
        {
            throw new NotImplementedException();
        }

        private void SequencePage()
        {
            if (_stopRequested.IsCancellationRequested)
            {
                Dispose();
            }
        }
    }
}
