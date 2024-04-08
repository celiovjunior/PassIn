using PassIn.Communication.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassIn.Application.UseCases.Events.Register
{
    public class RegisterEventsUseCase
    {
        public void Execute(RequestEventJson request)
        {
            Validate(request);
        }

        private void Validate(RequestEventJson request)
        {
            if (request.MaximumAttendees <= 0)
            {
                throw new ArgumentException("Number is invalid");
            }

            if (string.IsNullOrWhiteSpace(request.Title))
            {
                throw new ArgumentException("The title is invalid");
            }

            if (string.IsNullOrWhiteSpace(request.Details))
            {
                throw new ArgumentException("The details are invalid");
            }
        }
    }
}
