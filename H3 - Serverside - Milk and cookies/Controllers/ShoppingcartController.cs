using H3___Serverside___Milk_and_cookies.Controllers.Helper;
using H3___Serverside___Milk_and_cookies.Data;
using Microsoft.AspNetCore.Mvc;

namespace H3___Serverside___Milk_and_cookies.Controllers
{
    [Produces("application/json")]
    [Route("api/Shoppingcart")]
    public class ShoppingcartController : Controller
    {
        // GET: api/Shoppingcart
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get(string productName, int price)
        {
            var myComplexObject = HttpContext.Session.GetObjectFromJson<Product>("Test");

            if (myComplexObject == null)
            {
                var myList = new List<Product>
                {
                    new Product
                    { ProductName = productName,
                      Price = price
                    }
                };

                HttpContext.Session.SetObjectAsJson("Test", myList);
                return Ok(myList);
            }
            else
            {
                return Ok(myComplexObject);
            }
        }
    }
}
