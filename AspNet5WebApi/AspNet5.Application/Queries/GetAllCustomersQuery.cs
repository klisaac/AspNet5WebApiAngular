using System.Collections.Generic;
using MediatR;
using AspNet5.Application.Responses;

namespace AspNet5.Application.Queries
{
    public class GetAllCustomersQuery: IRequest<IEnumerable<CustomerResponse>>
    {
    }
}
