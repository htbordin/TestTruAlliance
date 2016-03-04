using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var prods = new List<Product>
           {
           new Product{Name="Shoes 01",Slug="shoes-01",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="http://www.vegetarian-shoes.co.uk/Portals/42/product/images/prd06da61c8-f8a9-402a-8590-fbec98bfbf1a.jpg"},
           new Product{Name="Shoes 02",Slug="shoes-02",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="http://www.theshoemen.com/images/big-shoes-03.png"},
           new Product{Name="Shoes 03",Slug="shoes-03",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="http://hitwallpaper.com/wp-content/uploads/2013/11/reebok-classics-2013-shaq-attaq-11.jpg"},
           new Product{Name="Shoes 04",Slug="shoes-04",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="http://www.thepricelist.in/wp-content/uploads/2014/12/Reebok-shoes-brand-price-list-in-india.jpg"},
           new Product{Name="Tshirt 01",Slug="tshirt-01",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="https://d2fzf9bbqh0om5.cloudfront.net/images/65427/main/stars_and_restraints_t_shirt_tees_2.jpg?1376441585"},
           new Product{Name="Tshirt 02",Slug="tshirt-02",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="https://d1s82l1atzspzx.cloudfront.net/threadless-media/artist_shops/parlortattooprints/7268/shirt_guys_01.jpg?w=584&h=550&q=96"},
           new Product{Name="Tshirt 03",Slug="tshirt-03",Description="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Price=10,ImageUrl="https://tshirtlogoprinting.files.wordpress.com/2014/11/hair-saloon-t-shirts-at-low-price-99with-pritning.jpg"},           
           };

            prods.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

        }
    }
}
