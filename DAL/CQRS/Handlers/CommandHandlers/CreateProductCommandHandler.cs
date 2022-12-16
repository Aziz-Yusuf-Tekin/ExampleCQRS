using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                ProductId = id,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductCategory = request.ProductCategory
            });
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProtuctId = id
            };
        }
    } 
}
