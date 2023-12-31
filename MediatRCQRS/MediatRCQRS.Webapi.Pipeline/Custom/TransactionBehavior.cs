﻿using MediatR;

namespace MediatRCQRS.Webapi.Pipeline.Custom
{
    /// <summary>
    /// http://huafangyun.com/technology/detail/1329031948185632769 
    /// 在Program里面注册服务
    /// builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(DBTransactionBehavior<,>));
    /// </summary>
    /// <typeparam name="TDBContext"></typeparam>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public class TransactionBehavior<TDBContext, TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse> where TDBContext : WyyDbContext
    {
        //ILogger _logger;
        //WyyDbContext _dbContext;

        //public TransactionBehavior(ILogger logger, WyyDbContext dbContext)
        //{
        //    _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        //    _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        //}

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var response = default(TResponse);
            try
            {
                //Console.WriteLine("执行前逻辑++++++++++++++++++++++++++++++++++");
                //Console.WriteLine();
                //if (request != null)
                //    return await next();

                //Console.WriteLine("逻辑不对处理++++++++++++++++++++++++++++++++");
                //Console.WriteLine();
                //var strategy = _dbContext.Database.CreateExecutionStrategy();

                //await strategy.ExecuteAsync(async () =>
                //{
                //    Guid transactionId;
                //    using (var transaction = await _dbContext.Database.BeginTransactionAsync())
                //    using (_logger.BeginScope("TransactionContext:{TransactionId}", transaction.TransactionId))
                //    {
                //        _logger.LogInformation("----- 开始事务 {TransactionId} 请求{request}", transaction.TransactionId, request);

                //        response = await next();

                //        _logger.LogInformation("----- 提交事务 {TransactionId}}", transaction.TransactionId);

                //        await _dbContext.CommitTransactionAsync(transaction);

                //        transactionId = transaction.TransactionId;
                //    }
                //});

                return response;

            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "处理事务出错{@Command}", request);

                throw;
            }
        }
    }

    public class WyyDbContext
    {
    }
}