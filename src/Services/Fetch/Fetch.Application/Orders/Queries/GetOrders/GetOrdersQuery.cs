using Ecmanage.eProcessor.BuildingBlocks.BuildingBlocks.Pagination;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Orders.Queries.GetOrders;

public record GetOrdersQuery(PaginationRequest PaginationRequest)
    : IQuery<GetOrdersResult>;

public record GetOrdersResult(PaginatedResult<OrderDto> Orders);