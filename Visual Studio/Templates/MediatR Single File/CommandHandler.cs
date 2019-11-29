using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace $rootnamespace$
{
    public class $fileinputname$Command : IRequest
    {
        
    }

    public class $fileinputname$CommandHandler : IRequestHandler<$fileinputname$Command>
    {
        public Task<Unit> Handle($fileinputname$Command request, CancellationToken cancellationToken)
        {
            return Unit.Task;
        }
    }
}
