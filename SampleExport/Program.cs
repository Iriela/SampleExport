using SampleExport.Models;

Console.WriteLine("This is a sample project to test our SmartR-Export nuget package");

var productList = new List<Product> {
    new Product(new Guid("0e2b8d5d-b62d-42a6-be15-8b4b7a8e148c"),"Product 1", 250, 23 ),
    new Product(new Guid("8aab82b9-c7b4-46f0-8b68-3409338faa2c"),"Product 2", 350, 5 ),
    new Product(new Guid("bd25c77d-1a19-4180-842d-e375f3952afe"),"Product 3", 100, 9 ),
    new Product(new Guid("84920489-64cf-4de2-b062-4ddeb2331810"),"Product 4", 120, 50 ),
    new Product(new Guid("3bf8bdc6-2cd5-40bd-9bb0-9823f5fde641"),"Product 5", 149, 10 ),
    new Product(new Guid("ac1775b6-981e-4524-8708-d70be358714e"),"Product 6", 362, 24 ),
    new Product(new Guid("2c1d5263-6cec-491c-8b05-e13444478134"),"Product 7", 20, 4 ),
    new Product(new Guid("e0956dfc-2fb0-4e1b-9595-172562d44e6a"),"Product 8", 15, 1 ),
    new Product(new Guid("819fac23-2ef8-46d7-9058-ea1df27284ac"),"Product 9", 75, 8 ),
    new Product(new Guid("ef879d8d-dfa9-455e-b728-4ef7429a155c"),"Product 10", 89, 10 ),
    new Product(new Guid("d51d3e7a-4547-49e9-b04f-18e811d9b36b"),"Product 11", 94, 5 ),
    new Product(new Guid("cc0c0b42-bf0c-455f-aeb8-34b53ba00c09"),"Product 12", 250, 15 ),
    new Product(new Guid("dd9effc2-5fdc-425e-9c1a-78104b06c729"),"Product 13", 130, 42 ),
    new Product(new Guid("1b69d0a8-5def-47c8-97e3-125375dd394a"),"Product 14", 1120, 23 ),
    new Product(new Guid("55344c63-0cc8-40fa-8019-7123d782dc8c"),"Product 15", 200, 23 ),
    new Product(new Guid("ccf3b989-9329-4441-bc31-8f8e3f2b4528"),"Product 16", 133, 23 ),
    new Product(new Guid("276404c7-41c4-4421-ad24-b3c2196f8d1c"),"Product 17", 250, 23 ),
    new Product(new Guid("e622880d-45ab-4a4f-aca0-9a7d6a6fc2f3"),"Product 18", 420, 23 ),
    new Product(new Guid("a0b89572-ea32-457c-91ea-9bc42dc18b8e"),"Product 19", 250, 23 ),
    new Product(new Guid("278856c6-bf3d-4e09-a73c-dd9a48e04421"),"Product 20", 500, 23 ),
    new Product(new Guid("11a2552c-f387-4a6a-896e-e33067b064d9"),"Product 21", 360, 23 ),
    new Product(new Guid("b49a2efa-d820-4a82-8c6a-b7e55757cb31"),"Product 22", 125, 23 )
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
catch (Exception exception)
{
    Console.WriteLine($"Export failed: {exception}", exception);
}