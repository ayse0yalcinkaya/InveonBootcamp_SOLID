namespace InveonBootcamp2.App.DIP
{ //business katmnaı
    //business logic katmanı
    internal class ProductService
    {
        IProductRepository ProductRepository = new ProductRepository();
        public List<Product> GetAll()
        {
            var productRepository = new ProductRepository();
            var productList = productRepository.GetAll();
            foreach (var product in productList) 
            {
                product.Price = product.Price * 1.2m;
            }
            return productList;

        }
    }
}
