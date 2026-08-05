using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static STockDto ToStockDto(this Stocks stockModel)
        {
            return new STockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                Myproperty = stockModel.Myproperty

            };
        }

        public static Stocks ToStockFromCreateStockDto(this CreateStockRequestDto stockDto)
        {
            return new Stocks
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv= stockDto.LastDiv,
                Industry = stockDto.Industry,
                Myproperty = stockDto.Myproperty

            };
        }
    }
}