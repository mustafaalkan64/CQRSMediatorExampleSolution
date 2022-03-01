using CQRSMediatorApiProject;
using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        private AppDbContext context;
        public DeleteProductCommandHandler(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == request.Id);
            this.context.Products.Remove(product);
            await context.SaveChangesAsync();

            return new DeleteProductCommandResponse
            {
                IsSuccess = true,
                ProductId = product.Id
            };
        }
    }
}
