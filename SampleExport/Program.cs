using SampleExport.Models;

Console.WriteLine("This is a sample project to test our SmartR-Export nuget package");

var productList = new List<Product> {
    new Product { Id = new Guid("0e2b8d5d-b62d-42a6-be15-8b4b7a8e148c"), Price = 250, Quantity = 23 },
    new Product { Id = new Guid("8aab82b9-c7b4-46f0-8b68-3409338faa2c"), Price = 350, Quantity = 5 },
    new Product { Id = new Guid("bd25c77d-1a19-4180-842d-e375f3952afe"), Price = 100, Quantity = 9 },
    new Product { Id = new Guid("84920489-64cf-4de2-b062-4ddeb2331810"), Price = 120, Quantity = 50 },
    new Product { Id = new Guid("3bf8bdc6-2cd5-40bd-9bb0-9823f5fde641"), Price = 149, Quantity = 10 },
    new Product { Id = new Guid("ac1775b6-981e-4524-8708-d70be358714e"), Price = 362, Quantity = 24 },
    new Product { Id = new Guid("2c1d5263-6cec-491c-8b05-e13444478134"), Price = 20, Quantity = 4 },
    new Product { Id = new Guid("e0956dfc-2fb0-4e1b-9595-172562d44e6a"), Price = 15, Quantity = 1 },
    new Product { Id = new Guid("819fac23-2ef8-46d7-9058-ea1df27284ac"), Price = 75, Quantity = 8 },
    new Product { Id = new Guid("ef879d8d-dfa9-455e-b728-4ef7429a155c"), Price = 89, Quantity = 10 },
    new Product { Id = new Guid("d51d3e7a-4547-49e9-b04f-18e811d9b36b"), Price = 94, Quantity = 5 },
    new Product { Id = new Guid("cc0c0b42-bf0c-455f-aeb8-34b53ba00c09"), Price = 250, Quantity = 15 },
    new Product { Id = new Guid("dd9effc2-5fdc-425e-9c1a-78104b06c729"), Price = 130, Quantity = 42 },
    new Product { Id = new Guid("1b69d0a8-5def-47c8-97e3-125375dd394a"), Price = 1120, Quantity = 23 },
    new Product { Id = new Guid("55344c63-0cc8-40fa-8019-7123d782dc8c"), Price = 200, Quantity = 23 },
    new Product { Id = new Guid("ccf3b989-9329-4441-bc31-8f8e3f2b4528"), Price = 133, Quantity = 23 },
    new Product { Id = new Guid("276404c7-41c4-4421-ad24-b3c2196f8d1c"), Price = 250, Quantity = 23 },
    new Product { Id = new Guid("e622880d-45ab-4a4f-aca0-9a7d6a6fc2f3"), Price = 420, Quantity = 23 },
    new Product { Id = new Guid("a0b89572-ea32-457c-91ea-9bc42dc18b8e"), Price = 250, Quantity = 23 },
    new Product { Id = new Guid("278856c6-bf3d-4e09-a73c-dd9a48e04421"), Price = 500, Quantity = 23 },
    new Product { Id = new Guid("11a2552c-f387-4a6a-896e-e33067b064d9"), Price = 360, Quantity = 23 },
    new Product { Id = new Guid("b49a2efa-d820-4a82-8c6a-b7e55757cb31"), Price = 125, Quantity = 23 }
};

try
{
    var fileName = SmartR.DataExport.ConvertToJsonFile(productList, string.Empty, "ProductList");

    Console.WriteLine("Compressing file to gzip");
    SmartR.DataExport.CompressFileToGzip(fileName);

    Console.WriteLine("Generating md5 hash for the file");
    var hash = SmartR.DataExport.CalculateMD5Hash(fileName);

    Console.WriteLine($"MD5 checksum: {hash}");

    Console.WriteLine($"Cleanup");
    File.Delete(fileName);

    Console.WriteLine($"Export is available : {fileName}.gz");
}
catch(Exception exception)
{
    Console.WriteLine($"Export failed: {exception}", exception);
}