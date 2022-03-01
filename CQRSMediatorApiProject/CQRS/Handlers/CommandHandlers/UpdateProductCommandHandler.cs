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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private AppDbContext context;
        public UpdateProductCommandHandler(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updateProduct = this.context.Products.FirstOrDefault(p => p.Id == request.Id);
            updateProduct.Price = request.Price;
            updateProduct.Quantity = request.Quantity;
            updateProduct.Name = request.Name;
            await this.context.SaveChangesAsync();

            return new UpdateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = updateProduct.Id
            };
        }
    }
}
