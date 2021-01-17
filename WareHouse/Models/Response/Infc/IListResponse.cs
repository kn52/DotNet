using System.Collections.Generic;

namespace WareHouse.Models.Response.Infc
{
    public interface IListResponse<TModel> : IResponse
    {
        IEnumerable<TModel> Model { get; set; }
    }
}
