using BlazingCoffee.Server.IO;
using BlazingCoffee.Shared.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Xunit;

namespace CsvImportTest
{
    public class TestCsvImport
    {
        [Fact]
        public void Test1()
        {
            
            using var reader = new StreamReader(@"./imports/finserv.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<SalesImportDTO>();
            IEnumerable<Sale> import = records.Select(dto => new Sale
            {
                Amount = dto.Amount,
                Code = dto.Code,
                Country = dto.Country,
                CustomerInfo = dto.CustomerInfo,
                PromotionId = dto.PromotionId,
                PaymentType = dto.PaymentType,
                Sku = dto.Product,
                ProductGroup = dto.ProductGroup,
                Region = dto.Region,
                StoreId = dto.StoreId,
                TransactionId = dto.TransactionId,
                TransactionDate = DateTime.Parse($"{dto.TransactionDate} {dto.TransactionHour}")
            });

            Assert.NotEmpty(import);
        }
    }
}
